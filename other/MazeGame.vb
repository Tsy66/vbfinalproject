Public Class MazeGame
    Dim mazemusic As New System.Media.SoundPlayer()
    Dim stream4 As System.IO.Stream = My.Resources.maze  '迷宮背景音樂
    Dim score As Integer = 600
    Public check As Boolean = False
    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles Me.Load
        mazemusic.Stream = stream4
        mazemusic.PlayLooping()
        ScoreTimer.Start()
    End Sub

    Private Sub Game2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '角色移動 上下左右
        If e.KeyCode = Keys.Up Then
            vk.Top -= 5
        End If
        If e.KeyCode = Keys.Left Then
            vk.Left -= 5
        End If

        If e.KeyCode = Keys.Down Then
            vk.Top += 5
        End If

        If e.KeyCode = Keys.Right Then
            vk.Left += 5
        End If

        For Each x As PictureBox In Me.Controls.OfType(Of PictureBox)()
            If x.Tag = "wall" Then
                If vk.Bounds.IntersectsWith(x.Bounds) Then
                    score -= 25
                    vk.Top = 100
                    vk.Left = 46
                End If
            End If
        Next

        If vk.Bounds.IntersectsWith(final.Bounds) Then
            check = True
            ScoreTimer.Stop()
            mazemusic.Stop()
            'MsgBox("Congrats!")
            'Start.Close()
            'MainGame.Close()
            'Setting.Close()
            endgame.Show()
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Setting.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ScoreTimer.Tick
        score -= 10

        lblscore.Text = CStr(score)

        If score = 0 Then
            ScoreTimer.Stop()

            'MsgBox("Mission Failed")
            'Start.Close()
            'mazemusic.Stop()
            'MainGame.Close()
            'Setting.Close()
            endgame.Show()
            Me.Close()

        ElseIf score < 0 Then
            ScoreTimer.Stop()

            '("Mission Failed")
            'Start.Close()
            mazemusic.Stop()
            'MainGame.Close()
            'Setting.Close()
            endgame.Show()
            Me.Close()
        End If


    End Sub

End Class