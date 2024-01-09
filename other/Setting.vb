Public Class Setting
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_return.Visible = False
    End Sub

    Private Sub Panel_Resume_MouseClick(sender As Object, e As MouseEventArgs) Handles Button_resume.MouseClick
        Me.Close()
    End Sub


    Private Sub Label_Exit_Click(sender As Object, e As EventArgs) Handles Button_exit.MouseClick
        MainGame.Close()
        MazeGame.Close()
        Start.Close()
        Me.Close()
    End Sub

    Private Sub Label_Ourteam_Click(sender As Object, e As EventArgs) Handles Button_team.MouseClick

        Button_set.Visible = False
        Button_resume.Visible = False
        Button_team.Visible = False
        Button_exit.Visible = False
        Button_return.Visible = True

        Me.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("TEAM"), Image)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_return.Click
        Button_set.Visible = True
        Button_resume.Visible = True
        Button_team.Visible = True
        Button_exit.Visible = True
        Button_return.Visible = False

        Me.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("迷宮遊戲_框_背景"), Image)
    End Sub
End Class