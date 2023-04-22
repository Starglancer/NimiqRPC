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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set constants
        TrendDurationMinutes = 60
        UpdateIntervalSeconds = 10

        'Initialise Data Capture
        DataPointer = 0
        MaxDataPointer = Convert.ToInt16(TrendDurationMinutes * 60 / UpdateIntervalSeconds)
        ReDim DataArray(MaxDataPointer + 1, 1)

        'Configure client
        Cfg = New Config()
        Cfg.Scheme = "http"
        Cfg.Host = "localhost"
        Cfg.Port = 8648

        'Create client
        Client = New NimiqClient(Cfg)

        'Configure Blockchain Chart
        Configure_Blockchain_Chart()

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

    Private Sub Configure_Blockchain_Chart()

        With chtBlocknumber.ChartAreas(0)
            .AxisX.Title = "Time (minutes)"
            .AxisX.MajorGrid.LineColor = Color.Gainsboro
            .AxisX.Minimum = 0
            .AxisY.Title = "Block Number"
            .AxisY.MajorGrid.LineColor = Color.Gainsboro
            .BackColor = Color.White
            .BorderColor = Color.Black
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 1
        End With

    End Sub

    Private Sub timUpdateData_Tick(sender As Object, e As EventArgs) Handles timUpdateData.Tick

        'Update all the data fields according to the timer
        Update_Data()

        'Increment pointer
        DataPointer += 1

        'Shift array contents once we reach maximum duration
        If DataPointer > MaxDataPointer Then
            DataPointer = MaxDataPointer
            For N As Integer = 0 To MaxDataPointer - 1
                DataArray(N, 0) = DataArray(N + 1, 0)
            Next
        End If

    End Sub

    Private Sub Update_Data()

        Update_Status()

        'Only update the rest if the client is running
        If Running = True Then

            Update_Blockchain()

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

    Private Sub Update_Blockchain()

        'Display current blocknumber
        txtBlocknumber.Text = Client.BlockNumber()

        'Store current blocknumber
        DataArray(DataPointer, 0) = Client.BlockNumber.ToString

        'Display Graph
        chtBlocknumber.ChartAreas(0).AxisY.Minimum = DataArray(0, 0) - 5
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

    Private Sub NotifyIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseClick

        'Only handle left mouse click
        If e.Button = MouseButtons.Left Then
            Display_Form()
        End If

    End Sub

    Private Sub Display_Form()

        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
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

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        ForceClose = True
        Me.Close()

    End Sub

End Class
