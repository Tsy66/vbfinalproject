<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainGame
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainGame))
        Me.background = New System.Windows.Forms.PictureBox()
        Me.vk = New System.Windows.Forms.PictureBox()
        Me.f1 = New System.Windows.Forms.PictureBox()
        Me.key1 = New System.Windows.Forms.PictureBox()
        Me.sk1 = New System.Windows.Forms.PictureBox()
        Me.pf = New System.Windows.Forms.PictureBox()
        Me.pf1 = New System.Windows.Forms.PictureBox()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pfTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pfTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.jump = New System.Windows.Forms.Timer(Me.components)
        Me.jumpdown = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pf2 = New System.Windows.Forms.PictureBox()
        Me.pf3 = New System.Windows.Forms.PictureBox()
        Me.fish1 = New System.Windows.Forms.PictureBox()
        Me.fish2 = New System.Windows.Forms.PictureBox()
        Me.fish3 = New System.Windows.Forms.PictureBox()
        Me.ps2 = New System.Windows.Forms.PictureBox()
        Me.ps1 = New System.Windows.Forms.PictureBox()
        Me.ps3 = New System.Windows.Forms.PictureBox()
        Me.pf4 = New System.Windows.Forms.PictureBox()
        Me.movepf1 = New System.Windows.Forms.PictureBox()
        Me.pf5 = New System.Windows.Forms.PictureBox()
        Me.barrel = New System.Windows.Forms.PictureBox()
        Me.key = New System.Windows.Forms.PictureBox()
        Me.pf6 = New System.Windows.Forms.PictureBox()
        Me.conch = New System.Windows.Forms.PictureBox()
        Me.cage = New System.Windows.Forms.PictureBox()
        Me.ps5 = New System.Windows.Forms.PictureBox()
        Me.movepf2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clbl = New System.Windows.Forms.Label()
        CType(Me.background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.key1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pf1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pf2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pf3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fish1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fish2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fish3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pf4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movepf1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pf5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pf6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.conch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movepf2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'background
        '
        Me.background.Image = Global.KRAKEN.My.Resources.Resources._3主遊戲畫面
        Me.background.Location = New System.Drawing.Point(0, 1)
        Me.background.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.background.Name = "background"
        Me.background.Size = New System.Drawing.Size(2698, 465)
        Me.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.background.TabIndex = 0
        Me.background.TabStop = False
        '
        'vk
        '
        Me.vk.BackColor = System.Drawing.Color.Transparent
        Me.vk.Image = Global.KRAKEN.My.Resources.Resources.vk
        Me.vk.Location = New System.Drawing.Point(51, 302)
        Me.vk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vk.Name = "vk"
        Me.vk.Size = New System.Drawing.Size(73, 83)
        Me.vk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.vk.TabIndex = 1
        Me.vk.TabStop = False
        '
        'f1
        '
        Me.f1.BackColor = System.Drawing.Color.Transparent
        Me.f1.Location = New System.Drawing.Point(11, 1)
        Me.f1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.f1.Name = "f1"
        Me.f1.Size = New System.Drawing.Size(191, 53)
        Me.f1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.f1.TabIndex = 2
        Me.f1.TabStop = False
        '
        'key1
        '
        Me.key1.BackColor = System.Drawing.Color.Transparent
        Me.key1.Image = Global.KRAKEN.My.Resources.Resources.開海螺的鑰匙
        Me.key1.Location = New System.Drawing.Point(208, 2)
        Me.key1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.key1.Name = "key1"
        Me.key1.Size = New System.Drawing.Size(60, 53)
        Me.key1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.key1.TabIndex = 5
        Me.key1.TabStop = False
        Me.key1.Visible = False
        '
        'sk1
        '
        Me.sk1.BackColor = System.Drawing.Color.Transparent
        Me.sk1.Location = New System.Drawing.Point(797, 0)
        Me.sk1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sk1.Name = "sk1"
        Me.sk1.Size = New System.Drawing.Size(191, 54)
        Me.sk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sk1.TabIndex = 6
        Me.sk1.TabStop = False
        '
        'pf
        '
        Me.pf.Image = Global.KRAKEN.My.Resources.Resources.地板
        Me.pf.Location = New System.Drawing.Point(0, 386)
        Me.pf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pf.Name = "pf"
        Me.pf.Size = New System.Drawing.Size(2698, 80)
        Me.pf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pf.TabIndex = 9
        Me.pf.TabStop = False
        Me.pf.Tag = "pf"
        '
        'pf1
        '
        Me.pf1.BackColor = System.Drawing.Color.Transparent
        Me.pf1.Image = Global.KRAKEN.My.Resources.Resources.平台_長
        Me.pf1.Location = New System.Drawing.Point(273, 299)
        Me.pf1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pf1.Name = "pf1"
        Me.pf1.Size = New System.Drawing.Size(270, 31)
        Me.pf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pf1.TabIndex = 10
        Me.pf1.TabStop = False
        Me.pf1.Tag = "pf"
        '
        'GameTimer
        '
        Me.GameTimer.Enabled = True
        '
        'pfTimer1
        '
        Me.pfTimer1.Enabled = True
        Me.pfTimer1.Interval = 130
        '
        'pfTimer2
        '
        Me.pfTimer2.Enabled = True
        '
        'jump
        '
        Me.jump.Enabled = True
        Me.jump.Interval = 20
        '
        'jumpdown
        '
        Me.jumpdown.Enabled = True
        Me.jumpdown.Interval = 20
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(212, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Tag = "lbl"
        Me.Label1.Text = "小心 腳下的毒液..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pf2
        '
        Me.pf2.BackColor = System.Drawing.Color.Transparent
        Me.pf2.Image = Global.KRAKEN.My.Resources.Resources.平台_短
        Me.pf2.Location = New System.Drawing.Point(590, 210)
        Me.pf2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pf2.Name = "pf2"
        Me.pf2.Size = New System.Drawing.Size(144, 28)
        Me.pf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pf2.TabIndex = 12
        Me.pf2.TabStop = False
        Me.pf2.Tag = "pf"
        '
        'pf3
        '
        Me.pf3.BackColor = System.Drawing.Color.Transparent
        Me.pf3.Image = Global.KRAKEN.My.Resources.Resources.平台_短
        Me.pf3.Location = New System.Drawing.Point(780, 123)
        Me.pf3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pf3.Name = "pf3"
        Me.pf3.Size = New System.Drawing.Size(157, 31)
        Me.pf3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pf3.TabIndex = 13
        Me.pf3.TabStop = False
        Me.pf3.Tag = "pf"
        '
        'fish1
        '
        Me.fish1.BackColor = System.Drawing.Color.Transparent
        Me.fish1.Image = Global.KRAKEN.My.Resources.Resources.魚
        Me.fish1.Location = New System.Drawing.Point(836, 59)
        Me.fish1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fish1.Name = "fish1"
        Me.fish1.Size = New System.Drawing.Size(60, 53)
        Me.fish1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fish1.TabIndex = 14
        Me.fish1.TabStop = False
        Me.fish1.Tag = "fish"
        '
        'fish2
        '
        Me.fish2.BackColor = System.Drawing.Color.Transparent
        Me.fish2.Image = Global.KRAKEN.My.Resources.Resources.魚
        Me.fish2.Location = New System.Drawing.Point(1559, 171)
        Me.fish2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fish2.Name = "fish2"
        Me.fish2.Size = New System.Drawing.Size(60, 53)
        Me.fish2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fish2.TabIndex = 15
        Me.fish2.TabStop = False
        Me.fish2.Tag = "fish"
        '
        'fish3
        '
        Me.fish3.BackColor = System.Drawing.Color.Transparent
        Me.fish3.Image = Global.KRAKEN.My.Resources.Resources.魚
        Me.fish3.Location = New System.Drawing.Point(2034, 315)
        Me.fish3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fish3.Name = "fish3"
        Me.fish3.Size = New System.Drawing.Size(60, 53)
        Me.fish3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fish3.TabIndex = 16
        Me.fish3.TabStop = False
        Me.fish3.Tag = "fish"
        '
        'ps2
        '
        Me.ps2.BackColor = System.Drawing.Color.Transparent
        Me.ps2.Image = Global.KRAKEN.My.Resources.Resources.毒液_上_有底
        Me.ps2.Location = New System.Drawing.Point(1157, 257)
        Me.ps2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ps2.Name = "ps2"
        Me.ps2.Size = New System.Drawing.Size(65, 20)
        Me.ps2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ps2.TabIndex = 17
        Me.ps2.TabStop = False
        Me.ps2.Tag = "ps"
        '
        'ps1
        '
        Me.ps1.BackColor = System.Drawing.Color.Transparent
        Me.ps1.Image = Global.KRAKEN.My.Resources.Resources.毒液_2a
        Me.ps1.Location = New System.Drawing.Point(216, 377)
        Me.ps1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ps1.Name = "ps1"
        Me.ps1.Size = New System.Drawing.Size(80, 38)
        Me.ps1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ps1.TabIndex = 18
        Me.ps1.TabStop = False
        Me.ps1.Tag = "ps"
        '
        'ps3
        '
        Me.ps3.BackColor = System.Drawing.Color.Transparent
        Me.ps3.Image = Global.KRAKEN.My.Resources.Resources.毒液_地板_長
        Me.ps3.Location = New System.Drawing.Point(1228, 383)
        Me.ps3.Name = "ps3"
        Me.ps3.Size = New System.Drawing.Size(702, 85)
        Me.ps3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ps3.TabIndex = 19
        Me.ps3.TabStop = False
        Me.ps3.Tag = "ps"
        '
        'pf4
        '
        Me.pf4.BackColor = System.Drawing.Color.Transparent
        Me.pf4.Image = Global.KRAKEN.My.Resources.Resources.平台_長
        Me.pf4.Location = New System.Drawing.Point(972, 246)
        Me.pf4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pf4.Name = "pf4"
        Me.pf4.Size = New System.Drawing.Size(277, 31)
        Me.pf4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pf4.TabIndex = 20
        Me.pf4.TabStop = False
        Me.pf4.Tag = "pf"
        '
        'movepf1
        '
        Me.movepf1.BackColor = System.Drawing.Color.Transparent
        Me.movepf1.Image = Global.KRAKEN.My.Resources.Resources.移動平台_2
        Me.movepf1.Location = New System.Drawing.Point(1255, 246)
        Me.movepf1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.movepf1.Name = "movepf1"
        Me.movepf1.Size = New System.Drawing.Size(146, 40)
        Me.movepf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.movepf1.TabIndex = 21
        Me.movepf1.TabStop = False
        Me.movepf1.Tag = "pf"
        '
        'pf5
        '
        Me.pf5.BackColor = System.Drawing.Color.Transparent
        Me.pf5.Image = Global.KRAKEN.My.Resources.Resources.平台_長
        Me.pf5.Location = New System.Drawing.Point(1920, 246)
        Me.pf5.Name = "pf5"
        Me.pf5.Size = New System.Drawing.Size(280, 34)
        Me.pf5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pf5.TabIndex = 22
        Me.pf5.TabStop = False
        Me.pf5.Tag = "pf"
        '
        'barrel
        '
        Me.barrel.BackColor = System.Drawing.Color.Transparent
        Me.barrel.Image = Global.KRAKEN.My.Resources.Resources.木桶
        Me.barrel.Location = New System.Drawing.Point(2601, 287)
        Me.barrel.Name = "barrel"
        Me.barrel.Size = New System.Drawing.Size(97, 104)
        Me.barrel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.barrel.TabIndex = 23
        Me.barrel.TabStop = False
        Me.barrel.Tag = "t"
        '
        'key
        '
        Me.key.BackColor = System.Drawing.Color.Transparent
        Me.key.Image = Global.KRAKEN.My.Resources.Resources.開海螺的鑰匙
        Me.key.Location = New System.Drawing.Point(2626, 315)
        Me.key.Name = "key"
        Me.key.Size = New System.Drawing.Size(51, 48)
        Me.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.key.TabIndex = 24
        Me.key.TabStop = False
        Me.key.Tag = "t"
        '
        'pf6
        '
        Me.pf6.BackColor = System.Drawing.Color.Transparent
        Me.pf6.Image = Global.KRAKEN.My.Resources.Resources.平台_短
        Me.pf6.Location = New System.Drawing.Point(2573, 129)
        Me.pf6.Name = "pf6"
        Me.pf6.Size = New System.Drawing.Size(150, 34)
        Me.pf6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pf6.TabIndex = 25
        Me.pf6.TabStop = False
        Me.pf6.Tag = "pf"
        '
        'conch
        '
        Me.conch.BackColor = System.Drawing.Color.Transparent
        Me.conch.Image = Global.KRAKEN.My.Resources.Resources.海螺
        Me.conch.Location = New System.Drawing.Point(2621, 75)
        Me.conch.Name = "conch"
        Me.conch.Size = New System.Drawing.Size(51, 48)
        Me.conch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.conch.TabIndex = 27
        Me.conch.TabStop = False
        Me.conch.Tag = "t"
        '
        'cage
        '
        Me.cage.BackColor = System.Drawing.Color.Transparent
        Me.cage.Image = Global.KRAKEN.My.Resources.Resources.困住的海螺_籠子
        Me.cage.Location = New System.Drawing.Point(2608, 39)
        Me.cage.Name = "cage"
        Me.cage.Size = New System.Drawing.Size(77, 95)
        Me.cage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cage.TabIndex = 28
        Me.cage.TabStop = False
        Me.cage.Tag = "t"
        '
        'ps5
        '
        Me.ps5.BackColor = System.Drawing.Color.Transparent
        Me.ps5.Image = Global.KRAKEN.My.Resources.Resources.毒液_上_有底
        Me.ps5.Location = New System.Drawing.Point(2646, 140)
        Me.ps5.Name = "ps5"
        Me.ps5.Size = New System.Drawing.Size(68, 23)
        Me.ps5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ps5.TabIndex = 30
        Me.ps5.TabStop = False
        Me.ps5.Tag = "ps"
        '
        'movepf2
        '
        Me.movepf2.BackColor = System.Drawing.Color.Transparent
        Me.movepf2.Image = Global.KRAKEN.My.Resources.Resources.移動平台_2
        Me.movepf2.Location = New System.Drawing.Point(2435, 315)
        Me.movepf2.Name = "movepf2"
        Me.movepf2.Size = New System.Drawing.Size(118, 42)
        Me.movepf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.movepf2.TabIndex = 31
        Me.movepf2.TabStop = False
        Me.movepf2.Tag = "pf"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2237, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Tag = "lbl"
        Me.Label2.Text = "木桶後方似乎藏有什麼..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'clbl
        '
        Me.clbl.BackColor = System.Drawing.Color.Transparent
        Me.clbl.Font = New System.Drawing.Font("微軟正黑體", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.clbl.ForeColor = System.Drawing.Color.Gold
        Me.clbl.Location = New System.Drawing.Point(2462, 234)
        Me.clbl.Name = "clbl"
        Me.clbl.Size = New System.Drawing.Size(223, 46)
        Me.clbl.TabIndex = 33
        Me.clbl.Tag = "lbl"
        Me.clbl.Text = "恭喜 你找到了秘密鑰匙" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "解開了被禁錮的黃金海螺" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.clbl.Visible = False
        '
        'MainGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.KRAKEN.My.Resources.Resources.主遊戲背景
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 466)
        Me.Controls.Add(Me.clbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.movepf2)
        Me.Controls.Add(Me.ps5)
        Me.Controls.Add(Me.cage)
        Me.Controls.Add(Me.conch)
        Me.Controls.Add(Me.pf6)
        Me.Controls.Add(Me.key)
        Me.Controls.Add(Me.barrel)
        Me.Controls.Add(Me.pf5)
        Me.Controls.Add(Me.movepf1)
        Me.Controls.Add(Me.ps2)
        Me.Controls.Add(Me.pf4)
        Me.Controls.Add(Me.ps3)
        Me.Controls.Add(Me.ps1)
        Me.Controls.Add(Me.fish3)
        Me.Controls.Add(Me.fish2)
        Me.Controls.Add(Me.fish1)
        Me.Controls.Add(Me.pf3)
        Me.Controls.Add(Me.pf2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pf1)
        Me.Controls.Add(Me.pf)
        Me.Controls.Add(Me.sk1)
        Me.Controls.Add(Me.key1)
        Me.Controls.Add(Me.f1)
        Me.Controls.Add(Me.vk)
        Me.Controls.Add(Me.background)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KRAKEN"
        CType(Me.background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.key1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pf1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pf2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pf3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fish1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fish2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fish3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pf4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movepf1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pf5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pf6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.conch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movepf2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents background As PictureBox
    Friend WithEvents vk As PictureBox
    Friend WithEvents f1 As PictureBox
    Friend WithEvents key1 As PictureBox
    Friend WithEvents sk1 As PictureBox
    Friend WithEvents pf As PictureBox
    Friend WithEvents pf1 As PictureBox
    Friend WithEvents GameTimer As Timer
    Friend WithEvents pfTimer1 As Timer
    Friend WithEvents pfTimer2 As Timer
    Friend WithEvents jump As Timer
    Friend WithEvents jumpdown As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents pf2 As PictureBox
    Friend WithEvents pf3 As PictureBox
    Friend WithEvents fish1 As PictureBox
    Friend WithEvents fish2 As PictureBox
    Friend WithEvents fish3 As PictureBox
    Friend WithEvents ps2 As PictureBox
    Friend WithEvents ps1 As PictureBox
    Friend WithEvents ps3 As PictureBox
    Friend WithEvents pf4 As PictureBox
    Friend WithEvents movepf1 As PictureBox
    Friend WithEvents pf5 As PictureBox
    Friend WithEvents barrel As PictureBox
    Friend WithEvents key As PictureBox
    Friend WithEvents pf6 As PictureBox
    Friend WithEvents conch As PictureBox
    Friend WithEvents cage As PictureBox
    Friend WithEvents ps5 As PictureBox
    Friend WithEvents movepf2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents clbl As Label
End Class
