Public Class Start
    Dim startmusic As New System.Media.SoundPlayer()
    Dim stream1 As System.IO.Stream = My.Resources.start 'start音樂

    Dim clickmusic As New System.Media.SoundPlayer()
    Dim stream2 As System.IO.Stream = My.Resources.paper '翻頁音樂

    Dim mainmusic As New System.Media.SoundPlayer()
    Dim stream3 As System.IO.Stream = My.Resources.maingame '主遊戲音效

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startmusic.Stream = stream1
        startmusic.Play()
    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        startmusic.Stop()
        StartScreen.Visible = False
        clickmusic.Stream = stream2
        clickmusic.PlaySync()
        gameguides.Visible = True
        mainmusic.Stream = stream3
        mainmusic.PlayLooping()
    End Sub

    Private Sub gobtn_Click(sender As Object, e As EventArgs) Handles gobtn.Click
        startmusic.Stop()
        mainmusic.Stop()
        MainGame.Show()
        Hide()
        'Me.Dispose() 'bug
    End Sub
End Class
