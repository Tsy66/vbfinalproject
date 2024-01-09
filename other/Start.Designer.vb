<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.StartScreen = New System.Windows.Forms.Panel()
        Me.startbtn = New System.Windows.Forms.Panel()
        Me.gameguides = New System.Windows.Forms.Panel()
        Me.gobtn = New System.Windows.Forms.Panel()
        Me.StartScreen.SuspendLayout()
        Me.gameguides.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartScreen
        '
        Me.StartScreen.BackColor = System.Drawing.Color.Transparent
        Me.StartScreen.BackgroundImage = Global.KRAKEN.My.Resources.Resources.START畫面_3
        Me.StartScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartScreen.Controls.Add(Me.startbtn)
        Me.StartScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartScreen.Location = New System.Drawing.Point(0, 0)
        Me.StartScreen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartScreen.MaximumSize = New System.Drawing.Size(902, 512)
        Me.StartScreen.Name = "StartScreen"
        Me.StartScreen.Size = New System.Drawing.Size(902, 512)
        Me.StartScreen.TabIndex = 0
        '
        'startbtn
        '
        Me.startbtn.BackgroundImage = Global.KRAKEN.My.Resources.Resources.start_button
        Me.startbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.startbtn.Location = New System.Drawing.Point(383, 326)
        Me.startbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(138, 79)
        Me.startbtn.TabIndex = 0
        '
        'gameguides
        '
        Me.gameguides.BackgroundImage = Global.KRAKEN.My.Resources.Resources.公主說明
        Me.gameguides.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gameguides.Controls.Add(Me.gobtn)
        Me.gameguides.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gameguides.Location = New System.Drawing.Point(0, 0)
        Me.gameguides.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gameguides.MaximumSize = New System.Drawing.Size(902, 512)
        Me.gameguides.Name = "gameguides"
        Me.gameguides.Size = New System.Drawing.Size(902, 512)
        Me.gameguides.TabIndex = 1
        '
        'gobtn
        '
        Me.gobtn.BackColor = System.Drawing.Color.Transparent
        Me.gobtn.BackgroundImage = Global.KRAKEN.My.Resources.Resources.公主說明_傳送鍵
        Me.gobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.gobtn.Location = New System.Drawing.Point(706, 354)
        Me.gobtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gobtn.Name = "gobtn"
        Me.gobtn.Size = New System.Drawing.Size(104, 90)
        Me.gobtn.TabIndex = 0
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 512)
        Me.Controls.Add(Me.StartScreen)
        Me.Controls.Add(Me.gameguides)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(902, 512)
        Me.MinimumSize = New System.Drawing.Size(902, 512)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KRAKEN"
        Me.StartScreen.ResumeLayout(False)
        Me.gameguides.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartScreen As Panel
    Friend WithEvents startbtn As Panel
    Friend WithEvents gameguides As Panel
    Friend WithEvents gobtn As Panel
End Class
