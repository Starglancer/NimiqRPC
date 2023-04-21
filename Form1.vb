Imports Nimiq

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cfg As Config = New Config()

        Cfg.Scheme = "http"
        Cfg.Host = "localhost"
        Cfg.Port = 8648

        Dim Client As NimiqClient = New NimiqClient(Cfg)

        Dim blocknumber As Integer = Client.BlockNumber

        Label1.Text = blocknumber

    End Sub

End Class
