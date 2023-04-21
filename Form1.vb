Imports System.ComponentModel
Imports System.Security.Cryptography
Imports Nimiq

Public Class Form1

    'Global Variables
    Dim Cfg As Config
    Dim Client As NimiqClient
    Dim Running As Boolean
    Dim ForceClose As Boolean
    Dim DataArray(500, 1) As String
    Dim DataPointer As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configure client
        Cfg = New Config()
        Cfg.Scheme = "http"
        Cfg.Host = "localhost"
        Cfg.Port = 8648

        'Create client
        Client = New NimiqClient(Cfg)

        'Initial data update
        Update_Data()

        'Initiate data timer
        timUpdateData.Interval = 10000 'Every 10 second
        timUpdateData.Enabled = True

        'Centre Form on screen
        Me.CenterToScreen()

        'Set default force close to false
        ForceClose = False

        'Initialise Data Capture
        DataPointer = 0


    End Sub

    Private Sub timUpdateData_Tick(sender As Object, e As EventArgs) Handles timUpdateData.Tick

        'Increment pointer
        DataPointer += 1

        'Add timestamp
        DataArray(DataPointer, 0) = Date.Now.ToString

        'Update all the data fields according to the timer
        Update_Data()

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
        DataArray(DataPointer, 1) = Client.BlockNumber.ToString

        'Display Graph


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
