<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.ForeColor = New System.Windows.Forms.GroupBox()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFWrite = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.BgColor = New System.Windows.Forms.GroupBox()
        Me.lblBGBlack = New System.Windows.Forms.Label()
        Me.lblBGPink = New System.Windows.Forms.Label()
        Me.lblBGGreen = New System.Windows.Forms.Label()
        Me.lblBGBlue = New System.Windows.Forms.Label()
        Me.lblBGSky = New System.Windows.Forms.Label()
        Me.lblBGWrite = New System.Windows.Forms.Label()
        Me.lblBGBrown = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblBGYellow = New System.Windows.Forms.Label()
        Me.lblBGOrange = New System.Windows.Forms.Label()
        Me.lblBGRed = New System.Windows.Forms.Label()
        Me.ForeColor.SuspendLayout()
        Me.BgColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "กำหนดตัวเลข"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(265, 66)
        Me.txtNumber.Multiline = True
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(304, 102)
        Me.txtNumber.TabIndex = 1
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(575, 66)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(56, 49)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(575, 121)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(56, 47)
        Me.btnDown.TabIndex = 3
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 66)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ขนาดฟอนต์"
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"16", "18", "20", "22", "24", "26", "28", "30", "32"})
        Me.cboSize.Location = New System.Drawing.Point(453, 181)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(116, 21)
        Me.cboSize.TabIndex = 5
        '
        'ForeColor
        '
        Me.ForeColor.Controls.Add(Me.lblFBlack)
        Me.ForeColor.Controls.Add(Me.lblFViolet)
        Me.ForeColor.Controls.Add(Me.lblFGreen)
        Me.ForeColor.Controls.Add(Me.lblFBlue)
        Me.ForeColor.Controls.Add(Me.lblFSky)
        Me.ForeColor.Controls.Add(Me.lblFWrite)
        Me.ForeColor.Controls.Add(Me.lblFBrown)
        Me.ForeColor.Controls.Add(Me.Label3)
        Me.ForeColor.Controls.Add(Me.lblFYellow)
        Me.ForeColor.Controls.Add(Me.lblFOrange)
        Me.ForeColor.Controls.Add(Me.lblFRed)
        Me.ForeColor.Location = New System.Drawing.Point(112, 231)
        Me.ForeColor.Name = "ForeColor"
        Me.ForeColor.Size = New System.Drawing.Size(240, 114)
        Me.ForeColor.TabIndex = 6
        Me.ForeColor.TabStop = False
        Me.ForeColor.Text = "ForeColor"
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(180, 16)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(37, 34)
        Me.lblFBlack.TabIndex = 0
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Violet
        Me.lblFViolet.Location = New System.Drawing.Point(137, 16)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(37, 34)
        Me.lblFViolet.TabIndex = 0
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Green
        Me.lblFGreen.Location = New System.Drawing.Point(93, 16)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(37, 34)
        Me.lblFGreen.TabIndex = 0
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(50, 16)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(37, 34)
        Me.lblFBlue.TabIndex = 0
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblFSky.Location = New System.Drawing.Point(180, 61)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(37, 34)
        Me.lblFSky.TabIndex = 0
        '
        'lblFWrite
        '
        Me.lblFWrite.BackColor = System.Drawing.Color.White
        Me.lblFWrite.Location = New System.Drawing.Point(137, 61)
        Me.lblFWrite.Name = "lblFWrite"
        Me.lblFWrite.Size = New System.Drawing.Size(37, 34)
        Me.lblFWrite.TabIndex = 0
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblFBrown.Location = New System.Drawing.Point(93, 61)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(37, 34)
        Me.lblFBrown.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(93, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 34)
        Me.Label3.TabIndex = 0
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(49, 61)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(37, 34)
        Me.lblFYellow.TabIndex = 0
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.Orange
        Me.lblFOrange.Location = New System.Drawing.Point(6, 61)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(37, 34)
        Me.lblFOrange.TabIndex = 0
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(6, 16)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(37, 34)
        Me.lblFRed.TabIndex = 0
        '
        'BgColor
        '
        Me.BgColor.Controls.Add(Me.lblBGBlack)
        Me.BgColor.Controls.Add(Me.lblBGPink)
        Me.BgColor.Controls.Add(Me.lblBGGreen)
        Me.BgColor.Controls.Add(Me.lblBGBlue)
        Me.BgColor.Controls.Add(Me.lblBGSky)
        Me.BgColor.Controls.Add(Me.lblBGWrite)
        Me.BgColor.Controls.Add(Me.lblBGBrown)
        Me.BgColor.Controls.Add(Me.Label11)
        Me.BgColor.Controls.Add(Me.lblBGYellow)
        Me.BgColor.Controls.Add(Me.lblBGOrange)
        Me.BgColor.Controls.Add(Me.lblBGRed)
        Me.BgColor.Location = New System.Drawing.Point(391, 231)
        Me.BgColor.Name = "BgColor"
        Me.BgColor.Size = New System.Drawing.Size(240, 114)
        Me.BgColor.TabIndex = 7
        Me.BgColor.TabStop = False
        Me.BgColor.Text = "BgColor"
        '
        'lblBGBlack
        '
        Me.lblBGBlack.BackColor = System.Drawing.Color.Black
        Me.lblBGBlack.Location = New System.Drawing.Point(180, 16)
        Me.lblBGBlack.Name = "lblBGBlack"
        Me.lblBGBlack.Size = New System.Drawing.Size(37, 34)
        Me.lblBGBlack.TabIndex = 0
        '
        'lblBGPink
        '
        Me.lblBGPink.BackColor = System.Drawing.Color.Violet
        Me.lblBGPink.Location = New System.Drawing.Point(137, 16)
        Me.lblBGPink.Name = "lblBGPink"
        Me.lblBGPink.Size = New System.Drawing.Size(37, 34)
        Me.lblBGPink.TabIndex = 0
        '
        'lblBGGreen
        '
        Me.lblBGGreen.BackColor = System.Drawing.Color.Green
        Me.lblBGGreen.Location = New System.Drawing.Point(93, 16)
        Me.lblBGGreen.Name = "lblBGGreen"
        Me.lblBGGreen.Size = New System.Drawing.Size(37, 34)
        Me.lblBGGreen.TabIndex = 0
        '
        'lblBGBlue
        '
        Me.lblBGBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBGBlue.Location = New System.Drawing.Point(50, 16)
        Me.lblBGBlue.Name = "lblBGBlue"
        Me.lblBGBlue.Size = New System.Drawing.Size(37, 34)
        Me.lblBGBlue.TabIndex = 0
        '
        'lblBGSky
        '
        Me.lblBGSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblBGSky.Location = New System.Drawing.Point(180, 61)
        Me.lblBGSky.Name = "lblBGSky"
        Me.lblBGSky.Size = New System.Drawing.Size(37, 34)
        Me.lblBGSky.TabIndex = 0
        '
        'lblBGWrite
        '
        Me.lblBGWrite.BackColor = System.Drawing.Color.White
        Me.lblBGWrite.Location = New System.Drawing.Point(137, 61)
        Me.lblBGWrite.Name = "lblBGWrite"
        Me.lblBGWrite.Size = New System.Drawing.Size(37, 34)
        Me.lblBGWrite.TabIndex = 0
        '
        'lblBGBrown
        '
        Me.lblBGBrown.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblBGBrown.Location = New System.Drawing.Point(93, 61)
        Me.lblBGBrown.Name = "lblBGBrown"
        Me.lblBGBrown.Size = New System.Drawing.Size(37, 34)
        Me.lblBGBrown.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(93, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 34)
        Me.Label11.TabIndex = 0
        '
        'lblBGYellow
        '
        Me.lblBGYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBGYellow.Location = New System.Drawing.Point(49, 61)
        Me.lblBGYellow.Name = "lblBGYellow"
        Me.lblBGYellow.Size = New System.Drawing.Size(37, 34)
        Me.lblBGYellow.TabIndex = 0
        '
        'lblBGOrange
        '
        Me.lblBGOrange.BackColor = System.Drawing.Color.Orange
        Me.lblBGOrange.Location = New System.Drawing.Point(6, 61)
        Me.lblBGOrange.Name = "lblBGOrange"
        Me.lblBGOrange.Size = New System.Drawing.Size(37, 34)
        Me.lblBGOrange.TabIndex = 0
        '
        'lblBGRed
        '
        Me.lblBGRed.BackColor = System.Drawing.Color.Red
        Me.lblBGRed.Location = New System.Drawing.Point(6, 16)
        Me.lblBGRed.Name = "lblBGRed"
        Me.lblBGRed.Size = New System.Drawing.Size(37, 34)
        Me.lblBGRed.TabIndex = 0
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 517)
        Me.Controls.Add(Me.BgColor)
        Me.Controls.Add(Me.ForeColor)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab3"
        Me.Text = "frmLab3"
        Me.ForeColor.ResumeLayout(False)
        Me.BgColor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents ForeColor As System.Windows.Forms.GroupBox
    Friend WithEvents lblFBlack As System.Windows.Forms.Label
    Friend WithEvents lblFViolet As System.Windows.Forms.Label
    Friend WithEvents lblFGreen As System.Windows.Forms.Label
    Friend WithEvents lblFBlue As System.Windows.Forms.Label
    Friend WithEvents lblFSky As System.Windows.Forms.Label
    Friend WithEvents lblFWrite As System.Windows.Forms.Label
    Friend WithEvents lblFBrown As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFYellow As System.Windows.Forms.Label
    Friend WithEvents lblFOrange As System.Windows.Forms.Label
    Friend WithEvents lblFRed As System.Windows.Forms.Label
    Friend WithEvents BgColor As System.Windows.Forms.GroupBox
    Friend WithEvents lblBGBlack As System.Windows.Forms.Label
    Friend WithEvents lblBGPink As System.Windows.Forms.Label
    Friend WithEvents lblBGGreen As System.Windows.Forms.Label
    Friend WithEvents lblBGBlue As System.Windows.Forms.Label
    Friend WithEvents lblBGSky As System.Windows.Forms.Label
    Friend WithEvents lblBGWrite As System.Windows.Forms.Label
    Friend WithEvents lblBGBrown As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblBGYellow As System.Windows.Forms.Label
    Friend WithEvents lblBGOrange As System.Windows.Forms.Label
    Friend WithEvents lblBGRed As System.Windows.Forms.Label
End Class
