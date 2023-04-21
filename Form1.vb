Imports Nimiq

Public Class Form1

    'Global Variables
    Dim Cfg As Config
    Dim Client As NimiqClient
    Dim Running As Boolean

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
        timUpdateData.Interval = 10000 'Every 10 seconds
        timUpdateData.Enabled = True

    End Sub

    Private Sub timUpdateData_Tick(sender As Object, e As EventArgs) Handles timUpdateData.Tick

        'Update all the data fields according to the timer
        Update_Data()

    End Sub

    Private Sub Update_Data()

        Update_Status()

        'Only update the rest if the client is running
        If Running = True Then


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

        'Update the image colour
        If Running = False Then
            pbxStatus.Image = My.Resources.Red
        ElseIf Consensus = "established" Then
            pbxStatus.Image = My.Resources.Green
        Else
            pbxStatus.Image = My.Resources.Amber
        End If

    End Sub

End Class
