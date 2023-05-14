Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting
Imports Nimiq
Imports Nimiq.Models

Public Class Form1

    'Global Variables
    Dim Cfg As Config
    Dim Client As NimiqClient
    Dim Running As Boolean
    Dim ForceClose As Boolean
    Dim DataArray(,) As Integer
    Dim DataPointer As Integer
    Dim MaxDataPointer As Integer
    Dim UserUpdate As Boolean
    Dim PoolList As String
    Dim BlockNumber As Integer
    Dim PeerCount As Integer
    Dim Peers() As Models.Peer
    Dim Threads As Integer
    Dim PoolBalance As Double
    Dim Hashrate As Integer
    Dim Mempool As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Load Persistent Variables
            txtPoolList.Text = My.Settings.PoolList
            txtScheme.Text = My.Settings.Scheme
            txtHost.Text = My.Settings.Host
            txtPort.Text = My.Settings.Port
            txtUser.Text = My.Settings.User
            txtPassword.Text = My.Settings.Password
            txtTrendDuration.Text = My.Settings.TrendDurationMinutes
            txtUpdateInterval.Text = My.Settings.UpdateIntervalSeconds

            'Populate default peer list dropdown options
            cmbType.Text = "--all--"
            cmbConnection.Text = "established"
            cmbColumn.Text = "bytes recieved"
            cmbDirection.Text = "descending"

            'Populate pool dropdown
            Populate_Pool_Dropdown()

            'Set constants if persistent values not set
            If txtTrendDuration.Text = 0 Then txtTrendDuration.Text = 60
            If txtUpdateInterval.Text = 0 Then txtUpdateInterval.Text = 10

            'Set slider positions
            UserUpdate = False
            tbrUpdateInterval.Value = 100 * Math.Log10(txtUpdateInterval.Text)
            tbrTrendDuration.Value = txtTrendDuration.Text
            UserUpdate = True

            'Initialise Data Capture
            Initialise_Data_Capture()

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

            'Configure filter for save CSV dialog box
            SaveCSVDialog.Filter = "CSV File|*.csv|Text File|*.txt"

            'Initial data update
            Update_Data()

            'Initiate data timer
            timUpdateData.Interval = txtUpdateInterval.Text * 1000
            timUpdateData.Enabled = True

            'Centre Form on screen
            Me.CenterToScreen()

            'Set default force close to false
            ForceClose = False

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Configure_Client()

        Try
            'If required fields are blank, set to default
            If txtScheme.Text = "" Then txtScheme.Text = "http"
            If txtHost.Text = "" Then txtHost.Text = "localhost"
            If txtPort.Text = "" Then txtPort.Text = "8648"

            'Set configuration
            Cfg = New Config With {
                .Scheme = txtScheme.Text,
                .Host = txtHost.Text,
                .Port = Convert.ToInt32(txtPort.Text),
                .User = txtUser.Text,
                .Password = txtPassword.Text
            }

            'Create client
            Client = New NimiqClient(Cfg)

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Initialise_Data_Capture()

        Try
            DataPointer = 0
            MaxDataPointer = Convert.ToInt32(txtTrendDuration.Text * 60 / txtUpdateInterval.Text)
            ReDim DataArray(MaxDataPointer + 1, 3)

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Configure_Block_Number_Chart()

        Try
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

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Configure_Peer_Count_Chart()

        Try
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

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Configure_Hashrate_Chart()

        Try
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

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Populate_Pool_Dropdown()

        Try
            Dim Pools() As String

            Pools = txtPoolList.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            cmbPool.Items.Clear()
            For N As Integer = 0 To Pools.Length - 1
                cmbPool.Items.Add(Pools(N))
            Next

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub timUpdateData_Tick(sender As Object, e As EventArgs) Handles timUpdateData.Tick

        'Update all the data fields according to the timer
        Update_Data()

    End Sub

    Private Sub Update_Data()

        Try
            Update_Status()

            'Only update the rest if the client is running
            If Running = True Then

                'Update individual tabs
                Update_Mempool()
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
                        DataArray(N, 1) = DataArray(N + 1, 1)
                        DataArray(N, 2) = DataArray(N + 1, 2)
                    Next
                End If

            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Update_Status()

        Try
            Dim Consensus As String = ""

            'Update the status fields
            Try
                Consensus = Client.Consensus()
                Running = True
                txtStatus.Text = "running"
                txtStatus.BackColor = Color.PaleGreen
                txtConsensus.Text = Consensus
                If Consensus = "established" Then
                    txtConsensus.BackColor = Color.PaleGreen
                Else
                    txtConsensus.BackColor = Color.Khaki
                End If
            Catch
                Running = False
                txtStatus.Text = "stopped"
                txtStatus.BackColor = Color.LightSalmon
                txtConsensus.Text = ""
                txtConsensus.BackColor = Color.LightSalmon
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

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Update_Mempool()

        Try
            Try
                Mempool = Client.Mempool.Total.ToString
            Catch
                'If fails just ignore and use last value obtained as stored in global variable
            End Try

            txtMempool.Text = Mempool

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Update_Block_Number()

        Try
            'Get current block number
            Try
                BlockNumber = Client.BlockNumber
            Catch
                'Do nothing. Block number stays the same as last check
            End Try

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
                    .Points.AddXY(N * txtUpdateInterval.Text / 60, DataArray(N, 0))
                Next

            End With

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Update_Block_List()

        Try
            Dim Block As Models.Block
            Dim Row As Integer

            grdBlocks.Rows.Clear()

            Row = 0

            For N As Integer = BlockNumber To BlockNumber - 50 Step -1

                Try
                    Block = Client.GetBlockByNumber(N)

                    'Add block data to grid
                    grdBlocks.Rows.Add()
                    grdBlocks.Rows(Row).Cells(0).Value = N
                    Try
                        grdBlocks.Rows(Row).Cells(1).Value = Client.GetBlockTransactionCountByNumber(N)
                    Catch
                        grdBlocks.Rows(Row).Cells(1).Value = ""
                    End Try
                    grdBlocks.Rows(Row).Cells(2).Value = Block.Size
                    grdBlocks.Rows(Row).Cells(3).Value = DateTimeOffset.FromUnixTimeSeconds(Block.Timestamp).LocalDateTime
                    grdBlocks.Rows(Row).Cells(4).Value = Block.MinerAddress

                    Row += 1

                Catch
                    'If a call fails, just skip that line from the block list until the next update
                End Try

            Next

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Update_Peer_Count()

        Try
            'Get current peer count
            Try
                PeerCount = Client.PeerCount
            Catch
                'Do nothing. Peer count stays the same as the last check
            End Try

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
                    .Points.AddXY(N * txtUpdateInterval.Text / 60, DataArray(N, 1))
                Next

            End With

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Update_Peer_List()

        Try
            Dim Address() As String
            Dim Include As Boolean
            Dim Row As Integer

            Try
                Peers = Client.PeerList()
            Catch
                'Do nothing. If call fails, the peers list remains the same as the last successful call
            End Try

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

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Update_Mining()

        Try
            'Display mining enabled
            UserUpdate = False
            Try
                chkMiner.Checked = Client.IsMining
            Catch
            End Try
            UserUpdate = True

            'Display threads
            Try
                Threads = Client.MinerThreads
            Catch
                'Do nothing. If call fails, the threads remains the same as the last successful call
            End Try
            UserUpdate = False
            txtThreads.Text = Threads
            tbrThreads.Value = Threads
            UserUpdate = True

            'Display mining address
            UserUpdate = False
            Try
                txtMiningAddress.Text = Client.MinerAddress.ToString
            Catch
            End Try
            UserUpdate = True

            'Display Pool
            UserUpdate = False
            Try
                cmbPool.Text = Client.Pool.ToString
            Catch
            End Try
            UserUpdate = True

            'Populate pool dropdown
            Populate_Pool_Dropdown()

            'Display pool connection
            Try
                txtPoolConnection.Text = Client.PoolConnectionState.ToString
            Catch
            End Try

            'Display pool balance
            Try
                PoolBalance = Client.PoolConfirmedBalance / 100000
            Catch
                'Do nothing. If it fails use last poolbalance
            End Try
            txtPoolBalance.Text = PoolBalance.ToString

            'Get current hash rate
            Try
                Hashrate = Client.Hashrate
            Catch
                'Do nothing. If it fails use last hashrate
            End Try

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
                    .Points.AddXY(N * txtUpdateInterval.Text / 60, DataArray(N, 2))
                Next

            End With

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub NotifyIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseClick

        Try
            'Only handle left mouse click
            If e.Button = MouseButtons.Left Then
                Display_Form()
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Display_Form()

        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Show()
                Me.WindowState = FormWindowState.Normal
            Else
                Me.WindowState = FormWindowState.Minimized
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try
            If ForceClose = False And e.CloseReason = CloseReason.UserClosing Then
                Me.WindowState = FormWindowState.Minimized
                e.Cancel = True
            End If

            'Set Force close flag to false
            ForceClose = False

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Try
            'Save persistent variables
            My.Settings.PoolList = txtPoolList.Text
            My.Settings.Scheme = txtScheme.Text
            My.Settings.Host = txtHost.Text
            My.Settings.Port = txtPort.Text
            My.Settings.User = txtUser.Text
            My.Settings.Password = txtPassword.Text
            My.Settings.LoggingLevel = cmbLoggingLevel.Text
            My.Settings.TrendDurationMinutes = txtTrendDuration.Text
            My.Settings.UpdateIntervalSeconds = txtUpdateInterval.Text

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Try
            ForceClose = True
            Me.Close()

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub chkMiner_CheckStateChanged(sender As Object, e As EventArgs) Handles chkMiner.CheckStateChanged

        Try
            'Ignore system update of checkbox
            If UserUpdate = True Then
                If chkMiner.Checked = True Then
                    Client.SetMining(True)
                Else
                    Client.SetMining(False)
                End If
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub tbrThreads_ValueChanged(sender As Object, e As EventArgs) Handles tbrThreads.ValueChanged

        Try
            'Keep textbox in sync
            txtThreads.Text = tbrThreads.Value

            'Ignore system update of slider
            If UserUpdate = True Then
                Client.SetMinerThreads(tbrThreads.Value)
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub cmbPool_TextChanged(sender As Object, e As EventArgs) Handles cmbPool.TextChanged

        Try
            'Ignore system update of value
            If UserUpdate = True Then
                Client.SetPool(cmbPool.Text)
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub btnSaveLogin_Click(sender As Object, e As EventArgs) Handles btnSaveLogin.Click

        Try
            'Reconfigure client
            Configure_Client()

            'Clear trend data as no longer relevant
            Array.Clear(DataArray, 0, DataArray.Length)
            DataPointer = 0

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub cmbLoggingLevel_TextChanged(sender As Object, e As EventArgs) Handles cmbLoggingLevel.TextChanged

        Try
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

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Try
            If Me.WindowState = FormWindowState.Minimized Then Me.Hide()

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub btnBlockSearch_Click(sender As Object, e As EventArgs) Handles btnBlockSearch.Click

        Block_Search()

    End Sub

    Private Sub Block_Search()

        Try
            Dim Block As Models.Block

            'Clear all search results
            txtBlockDetailsNumber.Text = ""
            txtBlockDetailsHash.Text = ""
            txtBlockDetailsParentHash.Text = ""
            txtBlockDetailsMiner.Text = ""
            txtBlockDetailsMinerAddress.Text = ""
            txtBlockDetailsExtraData.Text = ""
            txtBlockDetailsNonce.Text = ""
            txtBlockDetailsAccountsHash.Text = ""
            txtBlockDetailsBodyHash.Text = ""
            txtBlockDetailsConfirmations.Text = ""
            txtBlockDetailsDifficulty.Text = ""
            txtBlockDetailsPow.Text = ""
            txtBlockDetailsSize.Text = ""
            txtBlockDetailsTimestamp.Text = ""
            txtBlockDetailsTransactions.Text = ""

            'Check for valid search parameters and do search
            If Validate_BlockNumber(txtBlock_Number.Text) Then

                'Valid number supplied, so use that
                Try
                    Block = Client.GetBlockByNumber(txtBlock_Number.Text)
                Catch
                    Block = Nothing
                End Try

            ElseIf Validate_BlockHash(txtBlock_Hash.Text) Then

                'No number supplied but valid hash is, so use that
                Try
                    Block = Client.GetBlockByHash(txtBlock_Hash.Text)
                Catch
                    Block = Nothing
                End Try
            Else
                Block = Nothing
            End If

            'Only do the following if Block has been found
            If Not Block Is Nothing Then

                txtBlockDetailsNumber.Text = Block.Number
                txtBlockDetailsHash.Text = Block.Hash
                txtBlockDetailsParentHash.Text = Block.ParentHash
                txtBlockDetailsMiner.Text = Block.Miner
                txtBlockDetailsMinerAddress.Text = Block.MinerAddress
                txtBlockDetailsExtraData.Text = Block.ExtraData
                txtBlockDetailsNonce.Text = Block.Nonce
                txtBlockDetailsAccountsHash.Text = Block.AccountsHash
                txtBlockDetailsBodyHash.Text = Block.BodyHash
                txtBlockDetailsConfirmations.Text = Block.Confirmations
                txtBlockDetailsDifficulty.Text = Block.Difficulty
                txtBlockDetailsPow.Text = Block.Pow
                txtBlockDetailsSize.Text = Block.Size
                txtBlockDetailsTimestamp.Text = DateTimeOffset.FromUnixTimeSeconds(Block.Timestamp).UtcDateTime
                Try
                    txtBlockDetailsTransactions.Text = Client.GetBlockTransactionCountByNumber(Block.Number)
                Catch
                    txtBlockDetailsTransactions.Text = ""
                End Try

            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub btnTransactionSearch_Click(sender As Object, e As EventArgs) Handles btnTransactionSearch.Click

        Transaction_Search()

    End Sub

    Private Sub Transaction_Search()

        Try
            Dim Account As Models.Account
            Dim TransactionCount As Integer
            Dim Transactions() As Models.Transaction
            Dim Transaction As Models.Transaction

            'Clear all previous search results
            txtAccountID.Text = ""
            txtAccountType.Text = ""
            txtBalance.Text = ""
            grdTransactions.Rows.Clear()

            'Check for valid search parameters and do search
            If Validate_BlockNumber(txtBlockNumberSearch.Text) Then

                'Valid number supplied, so use that to populate the transaction table
                Try
                    TransactionCount = Client.GetBlockTransactionCountByNumber(txtBlockNumberSearch.Text)
                Catch
                    Exit Sub
                End Try

                For N As Integer = 0 To TransactionCount - 1
                    Try
                        Transaction = Client.GetTransactionByBlockNumberAndIndex(txtBlockNumberSearch.Text, N)
                    Catch
                        Exit Sub
                    End Try

                    grdTransactions.Rows.Add()
                    grdTransactions.Rows(N).Cells(0).Value = DateTimeOffset.FromUnixTimeSeconds(Transaction.Timestamp).UtcDateTime
                    grdTransactions.Rows(N).Cells(1).Value = Transaction.FromAddress
                    grdTransactions.Rows(N).Cells(2).Value = Transaction.ToAddress
                    grdTransactions.Rows(N).Cells(3).Value = Transaction.Value / 100000
                    grdTransactions.Rows(N).Cells(4).Value = Transaction.Fee / 100000
                    grdTransactions.Rows(N).Cells(5).Value = Transaction.Confirmations
                    grdTransactions.Rows(N).Cells(6).Value = Transaction.BlockNumber
                Next

            ElseIf Validate_Address(txtAccountAddress.Text) Then

                'No number supplied but valid address is, so use that

                'Get account details
                Try
                    Account = Client.GetAccount(txtAccountAddress.Text)
                    txtAccountID.Text = Account.Id
                    txtAccountType.Text = Account.Type.ToString
                    txtBalance.Text = Account.Balance / 100000
                Catch
                End Try

                'Get Transaction details
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Transactions = Client.GetTransactionsByAddress(txtAccountAddress.Text, 100) 'This can be a very slow process
                    Me.Cursor = Cursors.Default
                Catch
                    Exit Sub
                End Try
                TransactionCount = Transactions.Count

                For N As Integer = 0 To TransactionCount - 1
                    grdTransactions.Rows.Add()
                    grdTransactions.Rows(N).Cells(0).Value = DateTimeOffset.FromUnixTimeSeconds(Transactions(N).Timestamp).UtcDateTime
                    grdTransactions.Rows(N).Cells(1).Value = Transactions(N).FromAddress
                    grdTransactions.Rows(N).Cells(2).Value = Transactions(N).ToAddress
                    grdTransactions.Rows(N).Cells(3).Value = Transactions(N).Value / 100000
                    grdTransactions.Rows(N).Cells(4).Value = Transactions(N).Fee / 100000
                    grdTransactions.Rows(N).Cells(5).Value = Transactions(N).Confirmations
                    grdTransactions.Rows(N).Cells(6).Value = Transactions(N).BlockNumber
                Next
            Else
                'Do nothing as no valid search parameters
            End If

            'Display transaction count
            If TransactionCount = 100 Then
                lblTransactionCount.Text = "Most recent " + TransactionCount.ToString + " transactions"
            Else
                lblTransactionCount.Text = TransactionCount.ToString + " transactions"
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Function Validate_BlockNumber(Input As String) As Boolean

        Dim Valid As Boolean

        Try
            If Input = "" Then
                'its an empty string
                Valid = False
            ElseIf Not Regex.IsMatch(Input, "^[1-9]\d*$") Then
                'Its not numeric
                Valid = False
            ElseIf Input > BlockNumber Then
                'Its larger than the current block number
                Valid = False
            Else
                Valid = True
            End If

        Catch ex As Exception
            Log_Error(ex)
            Valid = False
        End Try

        Return Valid

    End Function

    Private Function Validate_BlockHash(Input As String) As Boolean

        Dim Valid As Boolean

        Try
            If Input = "" Then
                'Its an empty string
                Valid = False
            ElseIf Not Regex.IsMatch(Input, "[A-Fa-f0-9]{64}") Then
                'Its not a valid sha256 hash
                Valid = False
            Else
                Valid = True
            End If

        Catch ex As Exception
            Log_Error(ex)
            Valid = False
        End Try

        Return Valid

    End Function

    Private Function Validate_Address(Input As String) As Boolean

        Dim Valid As Boolean

        Try
            If Input = "" Then
                'Its an empty string
                Valid = False
            ElseIf Not Regex.IsMatch(Input, "N{1}Q{1}\d{2}(\s[A-Z0-9]{4}){8}") Then
                'Its not a valid wallet address
                Valid = False
            Else
                Valid = True
            End If

        Catch ex As Exception
            Log_Error(ex)
            Valid = False
        End Try

        Return Valid

    End Function

    Private Sub btnDownloadNimiqCore_Click(sender As Object, e As EventArgs) Handles btnDownloadNimiqCore.Click

        Try
            Process.Start(My.Settings.DownloadCore)

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub txtMiningAddress_MouseClick(sender As Object, e As MouseEventArgs) Handles txtMiningAddress.MouseClick

        Try
            txtAccountAddress.Text = txtMiningAddress.Text
            txtBlockNumberSearch.Text = ""
            Transaction_Search()
            TabControl.SelectedTab = tabTransactionList

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub grdBlocks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdBlocks.CellClick

        Try
            If e.ColumnIndex = 0 Then 'Block Number
                txtBlock_Number.Text = grdBlocks.Rows(e.RowIndex).Cells(0).Value
                txtBlock_Hash.Text = ""
                Block_Search()
                TabControl.SelectedTab = tabBlockDetail
            ElseIf e.ColumnIndex = 1 Then 'Transactions
                txtBlockNumberSearch.Text = grdBlocks.Rows(e.RowIndex).Cells(0).Value
                txtAccountAddress.Text = ""
                Transaction_Search()
                TabControl.SelectedTab = tabTransactionList
            ElseIf e.ColumnIndex = 4 Then 'Miner Address
                txtBlockNumberSearch.Text = ""
                txtAccountAddress.Text = grdBlocks.Rows(e.RowIndex).Cells(4).Value
                Transaction_Search()
                TabControl.SelectedTab = tabTransactionList
            Else
                'Do nothing
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub txtBlocknumber_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBlocknumber.MouseClick

        Try
            txtBlock_Number.Text = txtBlocknumber.Text
            txtBlock_Hash.Text = ""
            Block_Search()
            TabControl.SelectedTab = tabBlockDetail

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub txtBlockDetailsTransactions_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBlockDetailsTransactions.MouseClick

        Try
            txtBlockNumberSearch.Text = txtBlockDetailsNumber.Text
            txtAccountAddress.Text = ""
            Transaction_Search()
            TabControl.SelectedTab = tabTransactionList

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub txtBlockDetailsMinerAddress_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBlockDetailsMinerAddress.MouseClick

        Try
            txtBlockNumberSearch.Text = ""
            txtAccountAddress.Text = txtBlockDetailsMinerAddress.Text
            Transaction_Search()
            TabControl.SelectedTab = tabTransactionList

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub grdTransactions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdTransactions.CellClick

        Try
            If e.ColumnIndex = 1 Then 'From address
                txtBlockNumberSearch.Text = ""
                txtAccountAddress.Text = grdTransactions.Rows(e.RowIndex).Cells(1).Value
                Transaction_Search()
                TabControl.SelectedTab = tabTransactionList
            ElseIf e.ColumnIndex = 2 Then 'To Address
                txtBlockNumberSearch.Text = ""
                txtAccountAddress.Text = grdTransactions.Rows(e.RowIndex).Cells(2).Value
                Transaction_Search()
                TabControl.SelectedTab = tabTransactionList
            ElseIf e.ColumnIndex = 6 Then 'Block number
                txtBlock_Number.Text = grdTransactions.Rows(e.RowIndex).Cells(6).Value
                txtBlock_Hash.Text = ""
                Block_Search()
                TabControl.SelectedTab = tabBlockDetail
            Else
                'Do nothing
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub Log_Error(ex As Exception)

        Dim LogEntry As String

        'Construct Log Entry
        LogEntry = "----------------------------------------------"
        LogEntry += Environment.NewLine
        LogEntry += Date.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")
        LogEntry += Environment.NewLine
        LogEntry += "----------------------------------------------"
        LogEntry += Environment.NewLine
        LogEntry += "Exception Message: " + ex.Message
        LogEntry += Environment.NewLine
        LogEntry += "StackTrace: " + ex.StackTrace
        LogEntry += Environment.NewLine
        LogEntry += "Source: " + ex.Source
        LogEntry += Environment.NewLine
        LogEntry += "TargetSite: " + ex.TargetSite.ToString
        LogEntry += Environment.NewLine

        'Write entry to log
        txtErrorLog.AppendText(LogEntry)

    End Sub

    Private Sub btnClearLog_Click(sender As Object, e As EventArgs)

        Try
            txtErrorLog.Text = ""

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub mnuExportCSV_Click(sender As Object, e As EventArgs) Handles mnuExportCSV.Click

        Try
            Dim Path As String = ""
            Dim csv As String = ""
            Dim Minute As String = ""

            If TabControl.SelectedTab Is tabBlockList Then

                'Add the Header row for CSV file.
                For Each column As DataGridViewColumn In grdBlocks.Columns
                    csv += column.HeaderText & ","c
                Next

                'Add new line.
                csv += Environment.NewLine

                'Adding the Rows
                For Each row As DataGridViewRow In grdBlocks.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        'Add the Data rows.
                        csv += cell.Value.ToString().Replace(",", ";") & ","c
                    Next

                    'Add new line.
                    csv += Environment.NewLine
                Next

            End If

            If TabControl.SelectedTab Is tabPeerList Then

                'Add the Header row for CSV file.
                For Each column As DataGridViewColumn In grdPeers.Columns
                    csv += column.HeaderText & ","c
                Next

                'Add new line.
                csv += Environment.NewLine

                'Adding the Rows
                For Each row As DataGridViewRow In grdPeers.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        'Add the Data rows.
                        csv += cell.Value.ToString().Replace(",", ";") & ","c
                    Next

                    'Add new line.
                    csv += Environment.NewLine
                Next

            End If

            If TabControl.SelectedTab Is tabTransactionList Then

                'Add the Header row for CSV file.
                For Each column As DataGridViewColumn In grdTransactions.Columns
                    csv += column.HeaderText & ","c
                Next

                'Add new line.
                csv += Environment.NewLine

                'Adding the Rows
                For Each row As DataGridViewRow In grdTransactions.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        'Add the Data rows.
                        csv += cell.Value.ToString().Replace(",", ";") & ","c
                    Next

                    'Add new line.
                    csv += Environment.NewLine
                Next

            End If

            If TabControl.SelectedTab Is tabBlockNumber Or TabControl.SelectedTab Is tabPeerCount Or TabControl.SelectedTab Is tabMining Then

                'Output the underlying data array that feeds all the graphs

                'Add the Header row for CSV file.
                csv += "Minute,Block Number,Peer Count,Hash Rate"

                'Add new line.
                csv += Environment.NewLine

                'Adding the Rows
                For N As Integer = 0 To DataPointer - 1
                    'Add the data rows
                    Minute = (N * txtUpdateInterval.Text / 60).ToString
                    If Minute.Length > 4 Then Minute = Minute.Substring(0, 4)
                    csv += Minute + "," + DataArray(N, 0).ToString + "," + DataArray(N, 1).ToString + "," + DataArray(N, 2).ToString

                    'Add new line.
                    csv += Environment.NewLine
                Next

            End If

            If TabControl.SelectedTab Is tabBlockDetail Then

                'output all the information from the individual texboxes
                csv += "Number:" + vbTab + vbTab + txtBlockDetailsNumber.Text + Environment.NewLine
                csv += "Hash:" + vbTab + vbTab + txtBlockDetailsHash.Text + Environment.NewLine
                csv += "Parent Hash:" + vbTab + txtBlockDetailsParentHash.Text + Environment.NewLine
                csv += "Miner:" + vbTab + vbTab + txtBlockDetailsMiner.Text + Environment.NewLine
                csv += "Miner Address:" + vbTab + txtBlockDetailsMinerAddress.Text + Environment.NewLine
                csv += "Exra Data:" + vbTab + txtBlockDetailsExtraData.Text + Environment.NewLine
                csv += "Nonce:" + vbTab + vbTab + txtBlockDetailsNonce.Text + Environment.NewLine
                csv += "Accounts Hash:" + vbTab + txtBlockDetailsAccountsHash.Text + Environment.NewLine
                csv += "Body Hash:" + vbTab + txtBlockDetailsBodyHash.Text + Environment.NewLine
                csv += "Confirmations:" + vbTab + txtBlockDetailsConfirmations.Text + Environment.NewLine
                csv += "Difficulty:" + vbTab + txtBlockDetailsDifficulty.Text + Environment.NewLine
                csv += "Pow:" + vbTab + vbTab + txtBlockDetailsPow.Text + Environment.NewLine
                csv += "Size:" + vbTab + vbTab + txtBlockDetailsSize.Text + Environment.NewLine
                csv += "Timestamp:" + vbTab + txtBlockDetailsTimestamp.Text + Environment.NewLine
                csv += "Transactions:" + vbTab + txtBlockDetailsTransactions.Text + Environment.NewLine

            End If

            'Get filename and location from user
            SaveCSVDialog.ShowDialog()
            Path = SaveCSVDialog.FileName

            'Save file if selected
            If Path <> "" Then
                IO.File.WriteAllText(Path, csv)
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub tbrTrendDuration_ValueChanged(sender As Object, e As EventArgs) Handles tbrTrendDuration.ValueChanged

        Try
            'Only action if its a user initiated change
            If UserUpdate = True Then
                txtTrendDuration.Text = tbrTrendDuration.Value
                'Reset data capture
                Initialise_Data_Capture()
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

    Private Sub tbrUpdateInterval_ValueChanged(sender As Object, e As EventArgs) Handles tbrUpdateInterval.ValueChanged

        Try
            'Only action if its a user initiated change
            If UserUpdate = True Then
                txtUpdateInterval.Text = Convert.ToInt32(Math.Pow(10, tbrUpdateInterval.Value / 100))
                'Reset data capture
                Initialise_Data_Capture()
            End If

        Catch ex As Exception
            Log_Error(ex)
        End Try

    End Sub

End Class
