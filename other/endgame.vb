Public Class endgame
    Private Sub endgame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainGame.score = 3 And MazeGame.check = True Then
            PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("結算成功_三星"), Image)
            Button1.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("結算成功_按鍵"), Image)
        ElseIf MainGame.score = 2 And MazeGame.check = True Then
            PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("結算成功_二星"), Image)
            Button1.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("結算成功_按鍵"), Image)
        ElseIf MainGame.score = 1 And MazeGame.check = True Then
            PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("結算成功_一星"), Image)
            Button1.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("結算成功_按鍵"), Image)
        Else
            Me.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("結算失敗畫面"), Image)
            Button1.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("結算失敗畫面_按鍵"), Image)
            Label1.Visible = False
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Start.Close()
        MainGame.Close()
        Setting.Close()
        Me.Close()

    End Sub
End Class