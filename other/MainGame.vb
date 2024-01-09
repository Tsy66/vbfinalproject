Public Class MainGame
    Dim jumpLimit As Boolean = True
    Dim jumping As Boolean = True
    Dim force As Integer = 1
    Dim x As Integer = 0

    Dim mainmusic As New System.Media.SoundPlayer()
    Dim stream3 As System.IO.Stream = My.Resources.maingame '主遊戲音樂

    Dim goLeft, goRight As Boolean

    Public score As Integer = 0 '得到魚的數量
    Dim pstime As Integer = 0 '碰到毒液的次數

    Dim playerSpeed = 10
    Dim jumpspeed As Integer = 7
    Dim backgroundSpeed = 10

    Dim mpfdirection As Integer 'movepf2
    Dim mpfspeed As Integer
    Dim mpfdistance As Integer

    Dim vkLastX As Integer
    Dim vkLastY As Integer

    '上下移動平台
    Private Sub MainGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mainmusic.Stream = stream3
        mainmusic.PlayLooping()
        ' movepf2移動方向
        mpfdirection = 1
        ' movepf2移動速度
        mpfspeed = 5
        ' movepf2移動距離
        mpfdistance = 10
        conch.Visible = False
    End Sub

    Private Sub MainGame_Move(sender As Object, e As EventArgs) Handles Me.Move
        vkLastX = vk.Left
        vkLastY = vk.Top
    End Sub

    '控制左右跳
    Private Sub KeyIsDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Setting.Show()
        End If


        If e.KeyCode = Keys.Left Then
            goLeft = True
        End If

        If e.KeyCode = Keys.Right Then
            goRight = True
        End If

        If e.KeyCode = Keys.Space Then
            check()
        End If
    End Sub
    Private Sub check()
        If jumpLimit = True Then
            jump.Start()
            jumpLimit = False
        End If
    End Sub

    Private Sub jump_Tick(sender As Object, e As EventArgs) Handles jump.Tick
        vk.Top -= 10
        x += 1
        If x = 10 Then
            jump.Stop()
            x = 0
            jumpdown.Start()
        End If
    End Sub

    Private Sub jumpdown_Tick(sender As Object, e As EventArgs) Handles jumpdown.Tick
        vk.Top += 10
        For Each y As PictureBox In Me.Controls.OfType(Of PictureBox)()
            If y.Tag = "pf" Then
                If vk.Bounds.IntersectsWith(y.Bounds) Then
                    jumpdown.Stop()
                    jumpLimit = True
                    jumping = True
                End If
            End If
            background.SendToBack()
            barrel.BringToFront()
            vk.BringToFront()
            ps1.BringToFront() '讓毒液能顯示於地板之上而不被覆蓋
            ps2.BringToFront()
            ps3.BringToFront()
        Next
    End Sub
    Private Sub KeyIsUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Left Then
            goLeft = False
        End If

        If e.KeyCode = Keys.Right Then
            goRight = False
        End If
    End Sub
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        If (goLeft = True) And (vk.Left > 125) Then '設移動邊界
            vk.Left -= playerSpeed
        End If

        If (goRight = True) And vk.Left + (vk.Width + 125) < Me.ClientSize.Width Then
            vk.Left += playerSpeed
        End If

        If goLeft = True And background.Left < 0 Then
            background.Left += backgroundSpeed
            MoveGameElements("forward")
        End If

        If goRight = True And background.Left > -1420 Then
            background.Left -= backgroundSpeed
            MoveGameElements("back")
        End If

        vk.Top += jumpspeed

        If jumping = True Then
            force -= 1
        Else
            jumpspeed = 7 '當jumping = Flase 返回原本速度
        End If

        If jumping = True And force < 0 Then
            jumping = False
        End If

        For Each x As PictureBox In Me.Controls.OfType(Of PictureBox)()
            If x.Tag = "pf" Then
                If vk.Bounds.IntersectsWith(x.Bounds) And jumping = False Then
                    force = 1
                    vk.Top = x.Top - vk.Height
                    jumpspeed = 0
                End If
            End If
        Next

        For Each x As PictureBox In Me.Controls.OfType(Of PictureBox)()
            If x.Tag = "fish" Then
                If vk.Bounds.IntersectsWith(x.Bounds) And x.Visible = True Then
                    score += 1
                    x.Visible = False
                End If
            End If

            If x.Tag = "ps" Then
                If vk.Bounds.IntersectsWith(x.Bounds) Then
                    pstime += 1
                    ' 將維京人返回上一個位置，但不能毒液的範圍內
                    If vkLastX < x.Left Or vkLastX > x.Right Or vkLastY < x.Top Or vkLastY > x.Bottom Then
                        vk.Location = New Point(vkLastX, vkLastY)
                    Else
                        ' 在毒液的範圍，將維京人移開
                        If vk.Left < vk.Left Then
                            vk.Left = x.Right
                        ElseIf vk.Right > x.Right Then
                            vk.Left = x.Left - vk.Width
                        ElseIf vk.Top < x.Top Then
                            vk.Top = x.Bottom
                        ElseIf vk.Bottom > x.Bottom Then
                            vk.Top = x.Top - vk.Height
                        End If
                    End If
                End If
            End If
        Next

        If vk.Bounds.IntersectsWith(key.Bounds) And key.Visible = True Then '碰到鑰匙
            Label2.Visible = False
            clbl.Visible = True
            key1.Visible = True
            key.Visible = False
            cage.Visible = False
            conch.Visible = True
        End If

        If score = 1 Then '依獲得魚數量顯示左上圖片
            f1.Image = CType(My.Resources.ResourceManager.GetObject("魚1"), Image)
            f1.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf score = 2 Then
            f1.Image = CType(My.Resources.ResourceManager.GetObject("魚2"), Image)
            f1.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf score = 3 Then
            f1.Image = CType(My.Resources.ResourceManager.GetObject("魚3"), Image)
            f1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        If pstime = 1 Then '依碰觸毒液次數顯示右上圖片
            sk1.Image = CType(My.Resources.ResourceManager.GetObject("skull"), Image)
            sk1.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf pstime = 2 Then
            sk1.Image = CType(My.Resources.ResourceManager.GetObject("skull2"), Image)
            sk1.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf pstime = 3 Then
            sk1.Image = CType(My.Resources.ResourceManager.GetObject("skull3"), Image)
            sk1.SizeMode = PictureBoxSizeMode.StretchImage
            endgame.Show()
            'Start.Close()
            'MazeGame.Close()
            'Setting.Close()
            Me.Close()
        End If

        If vk.Bounds.IntersectsWith(conch.Bounds) And key1.Visible = True Then
            Hide()
            mainmusic.Stop()
            MazeGame.Show()
        End If
    End Sub

    Private moveRight As Boolean = True
    Private Sub pfTimer1_Tick(sender As Object, e As EventArgs) Handles pfTimer1.Tick
        If moveRight Then
            ' 向右移動
            movepf1.Left += 6
            ' 檢查是否已經到達右側邊界
            If movepf1.Left + movepf1.Width > pf5.Left Then
                moveRight = False
            End If
        Else
            ' 向左移動
            movepf1.Left -= 6
            ' 檢查是否已經到達左側邊界
            If movepf1.Left < pf4.Left + pf4.Width Then
                moveRight = True
            End If
        End If
    End Sub

    '上下移動平台
    Private Sub pfTimer2_Tick(sender As Object, e As EventArgs) Handles pfTimer2.Tick
        movepf2.Top += mpfdirection * mpfspeed
        If movepf2.Top <= 55 Then '到達頂部
            mpfdirection = 1
        ElseIf movepf2.Top >= (Me.Height - movepf2.Height) - 50 Then '到達底部
            mpfdirection = -1
        End If
    End Sub

    Private Sub vkgif_Tick(sender As Object, e As EventArgs)
        vk.Location = New Point(vk.Location.X = 1, vk.Location.Y = 1)
    End Sub


    Private Sub MoveGameElements(direction As String) '背景物移動
        For Each x As PictureBox In Me.Controls.OfType(Of PictureBox)()
            If (x.Tag = "fish" Or x.Tag = "pf" Or x.Tag = "t" Or x.Tag = "ps") Then
                If direction = "back" Then
                    x.Left -= backgroundSpeed
                End If

                If direction = "forward" Then
                    x.Left += backgroundSpeed
                End If
            End If
        Next
        For Each y As Label In Me.Controls.OfType(Of Label)() '文字提示
            If (y.Tag = "lbl") Then
                If direction = "back" Then
                    y.Left -= backgroundSpeed
                End If

                If direction = "forward" Then
                    y.Left += backgroundSpeed
                End If
            End If
        Next
    End Sub
End Class