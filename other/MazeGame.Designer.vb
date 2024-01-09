<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MazeGame
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MazeGame))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.ScoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.vk = New System.Windows.Forms.PictureBox()
        Me.final = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.PictureBox27 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.final, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_下
        Me.PictureBox1.Location = New System.Drawing.Point(12, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(726, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "wall"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_上
        Me.PictureBox2.Location = New System.Drawing.Point(12, 719)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(717, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "wall"
        '
        'lblscore
        '
        Me.lblscore.BackColor = System.Drawing.Color.Transparent
        Me.lblscore.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.ForeColor = System.Drawing.Color.White
        Me.lblscore.Location = New System.Drawing.Point(600, 33)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(116, 56)
        Me.lblscore.TabIndex = 2
        Me.lblscore.Text = "600"
        '
        'ScoreTimer
        '
        Me.ScoreTimer.Enabled = True
        Me.ScoreTimer.Interval = 1000
        '
        'vk
        '
        Me.vk.BackColor = System.Drawing.Color.Transparent
        Me.vk.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_維京人
        Me.vk.Location = New System.Drawing.Point(46, 126)
        Me.vk.Name = "vk"
        Me.vk.Size = New System.Drawing.Size(62, 62)
        Me.vk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.vk.TabIndex = 3
        Me.vk.TabStop = False
        '
        'final
        '
        Me.final.BackColor = System.Drawing.Color.Transparent
        Me.final.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_終點
        Me.final.Location = New System.Drawing.Point(610, 616)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(106, 106)
        Me.final.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.final.TabIndex = 4
        Me.final.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox3.Location = New System.Drawing.Point(12, 111)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 636)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "wall"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_左
        Me.PictureBox4.Location = New System.Drawing.Point(709, 92)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 646)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "wall"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_牆
        Me.PictureBox5.Location = New System.Drawing.Point(21, 196)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(122, 28)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "wall"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_牆
        Me.PictureBox6.Location = New System.Drawing.Point(16, 412)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(122, 28)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "wall"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_牆
        Me.PictureBox7.Location = New System.Drawing.Point(115, 475)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(134, 28)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "wall"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_上
        Me.PictureBox8.Location = New System.Drawing.Point(221, 182)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(122, 28)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "wall"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_牆
        Me.PictureBox9.Location = New System.Drawing.Point(221, 283)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(122, 28)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "wall"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_上
        Me.PictureBox10.Location = New System.Drawing.Point(16, 625)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(368, 28)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 12
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "wall"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_上
        Me.PictureBox11.Location = New System.Drawing.Point(430, 182)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(307, 28)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 13
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "wall"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox12.Location = New System.Drawing.Point(115, 196)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(28, 140)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 14
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "wall"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox13.Location = New System.Drawing.Point(115, 412)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(28, 91)
        Me.PictureBox13.TabIndex = 15
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "wall"
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox14.Location = New System.Drawing.Point(119, 596)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(28, 57)
        Me.PictureBox14.TabIndex = 16
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "wall"
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox15.Location = New System.Drawing.Point(221, 92)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(28, 118)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 17
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "wall"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox16.Location = New System.Drawing.Point(221, 283)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(28, 266)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 18
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Tag = "wall"
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox17.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox17.Location = New System.Drawing.Point(320, 389)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(28, 127)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 19
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Tag = "wall"
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox18.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_上
        Me.PictureBox18.Location = New System.Drawing.Point(320, 389)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(308, 28)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 20
        Me.PictureBox18.TabStop = False
        Me.PictureBox18.Tag = "wall"
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox19.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_左
        Me.PictureBox19.Location = New System.Drawing.Point(430, 265)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(28, 127)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox19.TabIndex = 21
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Tag = "wall"
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox20.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox20.Location = New System.Drawing.Point(531, 182)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(28, 129)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox20.TabIndex = 22
        Me.PictureBox20.TabStop = False
        Me.PictureBox20.Tag = "wall"
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox21.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_牆
        Me.PictureBox21.Location = New System.Drawing.Point(533, 283)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(95, 28)
        Me.PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox21.TabIndex = 23
        Me.PictureBox21.TabStop = False
        Me.PictureBox21.Tag = "wall"
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox22.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_左
        Me.PictureBox22.Location = New System.Drawing.Point(600, 283)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(28, 134)
        Me.PictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox22.TabIndex = 24
        Me.PictureBox22.TabStop = False
        Me.PictureBox22.Tag = "wall"
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox23.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox23.Location = New System.Drawing.Point(472, 561)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(28, 161)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 25
        Me.PictureBox23.TabStop = False
        Me.PictureBox23.Tag = "wall"
        '
        'PictureBox24
        '
        Me.PictureBox24.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox24.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_牆
        Me.PictureBox24.Location = New System.Drawing.Point(417, 561)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(83, 28)
        Me.PictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox24.TabIndex = 26
        Me.PictureBox24.TabStop = False
        Me.PictureBox24.Tag = "wall"
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox25.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_牆
        Me.PictureBox25.Location = New System.Drawing.Point(584, 596)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(154, 28)
        Me.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox25.TabIndex = 27
        Me.PictureBox25.TabStop = False
        Me.PictureBox25.Tag = "wall"
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox26.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_a單邊_右
        Me.PictureBox26.Location = New System.Drawing.Point(417, 488)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(28, 101)
        Me.PictureBox26.TabIndex = 28
        Me.PictureBox26.TabStop = False
        Me.PictureBox26.Tag = "wall"
        '
        'PictureBox27
        '
        Me.PictureBox27.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox27.Image = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_牆
        Me.PictureBox27.Location = New System.Drawing.Point(417, 488)
        Me.PictureBox27.Name = "PictureBox27"
        Me.PictureBox27.Size = New System.Drawing.Size(223, 28)
        Me.PictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox27.TabIndex = 29
        Me.PictureBox27.TabStop = False
        Me.PictureBox27.Tag = "wall"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 56)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "限時60秒，以上下左右鍵控制角色，若碰到牆壁則扣2.5秒並返回起始點。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MazeGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KRAKEN.My.Resources.Resources.迷宮遊戲_框_背景
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 750)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox22)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox26)
        Me.Controls.Add(Me.PictureBox27)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.final)
        Me.Controls.Add(Me.vk)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.PictureBox24)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MazeGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KRAKEN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.final, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblscore As Label
    Friend WithEvents ScoreTimer As Timer
    Friend WithEvents vk As PictureBox
    Friend WithEvents final As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents PictureBox27 As PictureBox
    Friend WithEvents Label1 As Label
End Class
