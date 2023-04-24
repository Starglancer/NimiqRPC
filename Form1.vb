﻿Imports System.Configuration
Imports System.Windows.Forms.DataVisualization.Charting
Imports Nimiq

Public Class Form1

    'Global Variables
    Dim Cfg As Config
    Dim Client As NimiqClient
    Dim Running As Boolean
    Dim ForceClose As Boolean
    Dim DataArray(,) As Integer
    Dim DataPointer As Integer
    Dim MaxDataPointer As Integer
    Dim TrendDurationMinutes As Integer
    Dim UpdateIntervalSeconds As Integer
    Dim UserUpdate As Boolean
    Dim PoolList As String
    Dim BlockNumber As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load Persistent Variables
        txtPoolList.Text = My.Settings.PoolList
        txtScheme.Text = My.Settings.Scheme
        txtHost.Text = My.Settings.Host
        txtPort.Text = My.Settings.Port
        txtUser.Text = My.Settings.User
        txtPassword.Text = My.Settings.Password

        'Populate default peer list dropdown options
        cmbType.Text = "--all--"
        cmbConnection.Text = "established"
        cmbColumn.Text = "bytes recieved"
        cmbDirection.Text = "descending"

        'Populate pool dropdown
        Populate_Pool_Dropdown()

        'Set constants
        TrendDurationMinutes = 60
        UpdateIntervalSeconds = 10

        'Initialise Data Capture
        DataPointer = 0
        MaxDataPointer = Convert.ToInt16(TrendDurationMinutes * 60 / UpdateIntervalSeconds)
        ReDim DataArray(MaxDataPointer + 1, 3)

        'Configure client
        Configure_Client()

        'Set logging level
        cmbLoggingLevel.Text = My.Settings.LoggingLevel
        If cmbLoggingLevel.Text = "" Then cmbLoggingLevel.Text = "info"

        'Set thread parameters
        tbrThreads.Minimum = 1
        tbrThreads.Maximum = Environment.ProcessorCount

        'Configure Block Number Chart
        Configure_Block_Number_Chart()

        'Configure Peer Count Chart
        Configure_Peer_Count_Chart()

        'Configure hashrate chart
        Configure_Hashrate_Chart()

        'Initial data update
        Update_Data()

        'Initiate data timer
        timUpdateData.Interval = UpdateIntervalSeconds * 1000
        timUpdateData.Enabled = True

        'Centre Form on screen
        Me.CenterToScreen()

        'Set default force close to false
        ForceClose = False

    End Sub

    Private Sub Configure_Client()

        'If required fields are blank, set to default
        If txtScheme.Text = "" Then txtScheme.Text = "http"
        If txtHost.Text = "" Then txtHost.Text = "localhost"
        If txtPort.Text = "" Then txtPort.Text = "8648"

        'Set configuration
        Cfg = New Config With {
            .Scheme = txtScheme.Text,
            .Host = txtHost.Text,
            .Port = Convert.ToInt16(txtPort.Text),
            .User = txtUser.Text,
            .Password = txtPassword.Text
        }

        'Create client
        Client = New NimiqClient(Cfg)

    End Sub

    Private Sub Configure_Block_Number_Chart()

        With chtBlocknumber.ChartAreas(0)
            .AxisX.Title = "Time (minutes)"
            .AxisX.MajorGrid.LineColor = Color.Gainsboro
            .AxisX.Minimum = 0
            .AxisY.Title = "Block Number"
            .AxisY.MajorGrid.LineColor = Color.Gainsboro
            .AxisY.IsStartedFromZero = False
            .BackColor = Color.White
            .BorderColor = Color.Black
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 1
        End With

    End Sub

    Private Sub Configure_Peer_Count_Chart()

        With chtPeerCount.ChartAreas(0)
            .AxisX.Title = "Time (minutes)"
            .AxisX.MajorGrid.LineColor = Color.Gainsboro
            .AxisX.Minimum = 0
            .AxisY.Title = "Peer Count"
            .AxisY.MajorGrid.LineColor = Color.Gainsboro
            .AxisY.IsStartedFromZero = False
            .BackColor = Color.White
            .BorderColor = Color.Black
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 1
        End With

    End Sub

    Private Sub Configure_Hashrate_Chart()

        With chtHashRate.ChartAreas(0)
            .AxisX.Title = "Time (minutes)"
            .AxisX.MajorGrid.LineColor = Color.Gainsboro
            .AxisX.Minimum = 0
            .AxisY.Title = "Hash Rate"
            .AxisY.MajorGrid.LineColor = Color.Gainsboro
            .AxisY.IsStartedFromZero = False
            .BackColor = Color.White
            .BorderColor = Color.Black
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 1
        End With

    End Sub

    Private Sub Populate_Pool_Dropdown()

        Dim Pools() As String

        Pools = txtPoolList.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        cmbPool.Items.Clear()
        For N As Integer = 0 To Pools.Length - 1
            cmbPool.Items.Add(Pools(N))
        Next

    End Sub

    Private Sub timUpdateData_Tick(sender As Object, e As EventArgs) Handles timUpdateData.Tick

        'Update all the data fields according to the timer
        Update_Data()

    End Sub

    Private Sub Update_Data()

        Update_Status()

        'Only update the rest if the client is running
        If Running = True Then

            'Update individual tabs
            Update_Block_Number()
            Update_Block_List()
            Update_Peer_Count()
            Update_Peer_List()
            Update_Mining()

            'Increment pointer
            DataPointer += 1

            'Shift array contents once we reach maximum duration
            If DataPointer > MaxDataPointer Then
                DataPointer = MaxDataPointer
                For N As Integer = 0 To MaxDataPointer - 1
                    DataArray(N, 0) = DataArray(N + 1, 0)
                Next
            End If

        End If

    End Sub

    Private Sub Update_Status()

        Dim Consensus As String = ""

        'Update the status fields
        Try
            Consensus = Client.Consensus()
            Running = True
            txtStatus.Text = "running"
            txtConsensus.Text = Consensus
        Catch
            Running = False
            txtStatus.Text = "stopped"
            txtConsensus.Text = ""
        End Try

        'Update the image colour, icon colour and icon text
        If Running = False Then
            pbxStatus.Image = My.Resources.Red
            NotifyIcon.Icon = My.Resources.Red1
            NotifyIcon.Text = "Nimiq Stopped"
        ElseIf Consensus = "established" Then
            pbxStatus.Image = My.Resources.Green
            NotifyIcon.Icon = My.Resources.Green1
            NotifyIcon.Text = "Nimiq Running"
        Else
            pbxStatus.Image = My.Resources.Amber
            NotifyIcon.Icon = My.Resources.Nimiq
            NotifyIcon.Text = "Nimiq Establishing Concensus"
        End If

    End Sub

    Private Sub Update_Block_Number()

        'Get current block number
        BlockNumber = Client.BlockNumber

        'Display current blocknumber
        txtBlocknumber.Text = BlockNumber

        'Store current blocknumber
        DataArray(DataPointer, 0) = BlockNumber

        'Display Graph
        chtBlocknumber.Series.Clear()
        chtBlocknumber.Series.Add("Block Number")

        With chtBlocknumber.Series(0)
            .IsVisibleInLegend = False
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .BorderWidth = 3
            .Color = Color.DarkGray
            .BorderDashStyle = ChartDashStyle.Solid

            For N As Integer = 0 To DataPointer
                .Points.AddXY(N * UpdateIntervalSeconds / 60, DataArray(N, 0))
            Next

        End With

    End Sub

    Private Sub Update_Block_List()

        Dim Block As Models.Block
        Dim Row As Integer

        grdBlocks.Rows.Clear()

        Row = 0

        For N As Integer = BlockNumber To BlockNumber - 50 Step -1

            Block = Client.GetBlockByNumber(N)

            'Add block data to grid
            grdBlocks.Rows.Add()
            grdBlocks.Rows(Row).Cells(0).Value = N
            grdBlocks.Rows(Row).Cells(1).Value = Block.Confirmations
            grdBlocks.Rows(Row).Cells(2).Value = Block.Size
            grdBlocks.Rows(Row).Cells(3).Value = DateTimeOffset.FromUnixTimeSeconds(Block.Timestamp).LocalDateTime
            grdBlocks.Rows(Row).Cells(4).Value = Block.MinerAddress

            Row += 1
        Next

    End Sub

    Private Sub Update_Peer_Count()

        Dim PeerCount As Integer

        'Get current peer count
        PeerCount = Client.PeerCount

        'Display current peer count
        txtTotalPeers.Text = PeerCount

        'Store current peer count
        DataArray(DataPointer, 1) = PeerCount

        'Display Graph
        chtPeerCount.Series.Clear()
        chtPeerCount.Series.Add("Peer Count")

        With chtPeerCount.Series(0)
            .IsVisibleInLegend = False
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .BorderWidth = 3
            .Color = Color.DarkGray
            .BorderDashStyle = ChartDashStyle.Solid

            For N As Integer = 0 To DataPointer
                .Points.AddXY(N * UpdateIntervalSeconds / 60, DataArray(N, 1))
            Next

        End With

    End Sub

    Private Sub Update_Peer_List()

        Dim Peers() As Models.Peer
        Dim Address() As String
        Dim Include As Boolean
        Dim Row As Integer

        Peers = Client.PeerList()

        grdPeers.Rows.Clear()
        Row = 0

        For N As Integer = 0 To Peers.Count - 1
            'Get Type
            Address = Peers(N).Address.Split(New Char() {":"c})

            'Filter
            Include = True
            If cmbType.Text <> "--all--" And cmbType.Text <> Address(0) Then Include = False
            If cmbConnection.Text <> "--all--" And cmbConnection.Text <> Peers(N).AddressState.ToString Then Include = False

            'Add Peer data to grid
            If Include = True Then
                grdPeers.Rows.Add()
                grdPeers.Rows(Row).Cells(0).Value = Peers(N).Address
                grdPeers.Rows(Row).Cells(1).Value = Address(0)
                grdPeers.Rows(Row).Cells(2).Value = Peers(N).AddressState.ToString
                grdPeers.Rows(Row).Cells(3).Value = Peers(N).Rx
                grdPeers.Rows(Row).Cells(4).Value = Peers(N).Tx
                grdPeers.Rows(Row).Cells(5).Value = Peers(N).Latency

                Row += 1

            End If

        Next

        'Sort Grid
        Select Case cmbColumn.Text
            Case "bytes recieved"
                If cmbDirection.Text = "ascending" Then
                    grdPeers.Sort(grdPeers.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
                Else
                    grdPeers.Sort(grdPeers.Columns(3), System.ComponentModel.ListSortDirection.Descending)
                End If
            Case "bytes sent"
                If cmbDirection.Text = "ascending" Then
                    grdPeers.Sort(grdPeers.Columns(4), System.ComponentModel.ListSortDirection.Ascending)
                Else
                    grdPeers.Sort(grdPeers.Columns(4), System.ComponentModel.ListSortDirection.Descending)
                End If
            Case "latency"
                If cmbDirection.Text = "ascending" Then
                    grdPeers.Sort(grdPeers.Columns(5), System.ComponentModel.ListSortDirection.Ascending)
                Else
                    grdPeers.Sort(grdPeers.Columns(5), System.ComponentModel.ListSortDirection.Descending)
                End If
        End Select

        'Display row count
        lblRowCount.Text = Row.ToString + " Peers Listed"

    End Sub

    Private Sub Update_Mining()

        Dim Hashrate As Integer
        Dim PoolBalance As Double
        Dim Threads As Integer

        'Display mining enabled
        UserUpdate = False
        chkMiner.Checked = Client.IsMining
        UserUpdate = True

        'Display threads
        Threads = Client.MinerThreads
        UserUpdate = False
        txtThreads.Text = Threads
        tbrThreads.Value = Threads
        UserUpdate = True

        'Display mining address
        UserUpdate = False
        txtMiningAddress.Text = Client.MinerAddress.ToString
        UserUpdate = True

        'Display Pool
        UserUpdate = False
        cmbPool.Text = Client.Pool.ToString
        UserUpdate = True

        'Populate pool dropdown
        Populate_Pool_Dropdown()

        'Display pool connection
        txtPoolConnection.Text = Client.PoolConnectionState.ToString

        'Display pool balance
        PoolBalance = Client.PoolConfirmedBalance / 100000
        txtPoolBalance.Text = PoolBalance.ToString

        'Get current hash rate
        Hashrate = Client.Hashrate

        'Display current hash rate
        txtHashRate.Text = Hashrate

        'Store current hash rate
        DataArray(DataPointer, 2) = Hashrate

        'Display Graph
        chtHashRate.Series.Clear()
        chtHashRate.Series.Add("Hashrate (H/s)")

        With chtHashRate.Series(0)
            .IsVisibleInLegend = False
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .BorderWidth = 3
            .Color = Color.DarkGray
            .BorderDashStyle = ChartDashStyle.Solid

            For N As Integer = 0 To DataPointer
                .Points.AddXY(N * UpdateIntervalSeconds / 60, DataArray(N, 2))
            Next

        End With

    End Sub

    Private Sub NotifyIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseClick

        'Only handle left mouse click
        If e.Button = MouseButtons.Left Then
            Display_Form()
        End If

    End Sub

    Private Sub Display_Form()

        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            Me.TopMost = True
        Else
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If ForceClose = False And e.CloseReason = CloseReason.UserClosing Then
            Me.WindowState = FormWindowState.Minimized
            e.Cancel = True
        End If

        'Set Force close flag to false
        ForceClose = False

    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        'Save persistent variables
        My.Settings.PoolList = txtPoolList.Text
        My.Settings.Scheme = txtScheme.Text
        My.Settings.Host = txtHost.Text
        My.Settings.Port = txtPort.Text
        My.Settings.User = txtUser.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.LoggingLevel = cmbLoggingLevel.Text

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        ForceClose = True
        Me.Close()

    End Sub

    Private Sub chkMiner_CheckStateChanged(sender As Object, e As EventArgs) Handles chkMiner.CheckStateChanged

        'Ignore system update of checkbox
        If UserUpdate = True Then
            If chkMiner.Checked = True Then
                Client.SetMining(True)
            Else
                Client.SetMining(False)
            End If
        End If

    End Sub

    Private Sub tbrThreads_ValueChanged(sender As Object, e As EventArgs) Handles tbrThreads.ValueChanged

        'Keep textbox in sync
        txtThreads.Text = tbrThreads.Value

        'Ignore system update of slider
        If UserUpdate = True Then
            Client.SetMinerThreads(tbrThreads.Value)
        End If

    End Sub

    Private Sub cmbPool_TextChanged(sender As Object, e As EventArgs) Handles cmbPool.TextChanged

        'Ignore system update of value
        If UserUpdate = True Then
            Client.SetPool(cmbPool.Text)
        End If

    End Sub

    Private Sub btnSaveLogin_Click(sender As Object, e As EventArgs) Handles btnSaveLogin.Click

        'Reconfigure client
        Configure_Client()

        'Clear trend data as no longer relevant
        Array.Clear(DataArray, 0, DataArray.Length)
        DataPointer = 0

    End Sub

    Private Sub cmbLoggingLevel_TextChanged(sender As Object, e As EventArgs) Handles cmbLoggingLevel.TextChanged

        Dim LogLevel As Models.LogLevel = New Models.LogLevel

        Select Case cmbLoggingLevel.Text
            Case "trace"
                LogLevel = Models.LogLevel.Trace
            Case "verbose"
                LogLevel = Models.LogLevel.Verbose
            Case "debug"
                LogLevel = Models.LogLevel.Debug
            Case "info"
                LogLevel = Models.LogLevel.Info
            Case "warning"
                LogLevel = Models.LogLevel.Warn
            Case "error"
                LogLevel = Models.LogLevel.Error
            Case "assert"
                LogLevel = Models.LogLevel.Assert
        End Select

        Client.SetLog("*", LogLevel)

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Minimized Then Me.Hide()

    End Sub

End Class
