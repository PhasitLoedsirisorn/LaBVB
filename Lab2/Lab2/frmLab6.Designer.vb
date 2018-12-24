<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab6
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
        Me.chkcarforme = New System.Windows.Forms.CheckBox()
        Me.lblStartPrice = New System.Windows.Forms.Label()
        Me.gpb1 = New System.Windows.Forms.GroupBox()
        Me.gpb2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkitemadd1 = New System.Windows.Forms.CheckBox()
        Me.chkitemadd2 = New System.Windows.Forms.CheckBox()
        Me.chkitemadd3 = New System.Windows.Forms.CheckBox()
        Me.chkitemadd4 = New System.Windows.Forms.CheckBox()
        Me.chkfree1 = New System.Windows.Forms.CheckBox()
        Me.chkfree2 = New System.Windows.Forms.CheckBox()
        Me.chkfree3 = New System.Windows.Forms.CheckBox()
        Me.lblitemprice1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPaidPrice = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gpb1.SuspendLayout()
        Me.gpb2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณราคารถยนต์"
        '
        'chkcarforme
        '
        Me.chkcarforme.AutoSize = True
        Me.chkcarforme.Location = New System.Drawing.Point(63, 119)
        Me.chkcarforme.Name = "chkcarforme"
        Me.chkcarforme.Size = New System.Drawing.Size(92, 17)
        Me.chkcarforme.TabIndex = 1
        Me.chkcarforme.Text = "ISUZU MU7X"
        Me.chkcarforme.UseVisualStyleBackColor = True
        '
        'lblStartPrice
        '
        Me.lblStartPrice.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblStartPrice.Location = New System.Drawing.Point(418, 119)
        Me.lblStartPrice.Name = "lblStartPrice"
        Me.lblStartPrice.Size = New System.Drawing.Size(64, 17)
        Me.lblStartPrice.TabIndex = 2
        Me.lblStartPrice.Text = "1250000"
        '
        'gpb1
        '
        Me.gpb1.Controls.Add(Me.Label9)
        Me.gpb1.Controls.Add(Me.Label8)
        Me.gpb1.Controls.Add(Me.Label7)
        Me.gpb1.Controls.Add(Me.lblitemprice1)
        Me.gpb1.Controls.Add(Me.Label3)
        Me.gpb1.Controls.Add(Me.Label2)
        Me.gpb1.Controls.Add(Me.chkitemadd4)
        Me.gpb1.Controls.Add(Me.chkitemadd3)
        Me.gpb1.Controls.Add(Me.chkitemadd2)
        Me.gpb1.Controls.Add(Me.chkitemadd1)
        Me.gpb1.Location = New System.Drawing.Point(63, 167)
        Me.gpb1.Name = "gpb1"
        Me.gpb1.Size = New System.Drawing.Size(171, 159)
        Me.gpb1.TabIndex = 3
        Me.gpb1.TabStop = False
        Me.gpb1.Text = "อุปกรณ์เสริม"
        '
        'gpb2
        '
        Me.gpb2.Controls.Add(Me.Label5)
        Me.gpb2.Controls.Add(Me.Label4)
        Me.gpb2.Controls.Add(Me.chkfree3)
        Me.gpb2.Controls.Add(Me.Label12)
        Me.gpb2.Controls.Add(Me.Label11)
        Me.gpb2.Controls.Add(Me.Label10)
        Me.gpb2.Controls.Add(Me.chkfree2)
        Me.gpb2.Controls.Add(Me.chkfree1)
        Me.gpb2.Location = New System.Drawing.Point(272, 167)
        Me.gpb2.Name = "gpb2"
        Me.gpb2.Size = New System.Drawing.Size(210, 159)
        Me.gpb2.TabIndex = 3
        Me.gpb2.TabStop = False
        Me.gpb2.Text = "อุปกรณ์เสริม"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รายการ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ราคา"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "รายการ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ราคา"
        '
        'chkitemadd1
        '
        Me.chkitemadd1.AutoSize = True
        Me.chkitemadd1.Location = New System.Drawing.Point(20, 32)
        Me.chkitemadd1.Name = "chkitemadd1"
        Me.chkitemadd1.Size = New System.Drawing.Size(76, 17)
        Me.chkitemadd1.TabIndex = 1
        Me.chkitemadd1.Text = "กันชนหน้า"
        Me.chkitemadd1.UseVisualStyleBackColor = True
        '
        'chkitemadd2
        '
        Me.chkitemadd2.AutoSize = True
        Me.chkitemadd2.Location = New System.Drawing.Point(20, 55)
        Me.chkitemadd2.Name = "chkitemadd2"
        Me.chkitemadd2.Size = New System.Drawing.Size(80, 17)
        Me.chkitemadd2.TabIndex = 1
        Me.chkitemadd2.Text = "ชุดเสริมข้าง"
        Me.chkitemadd2.UseVisualStyleBackColor = True
        '
        'chkitemadd3
        '
        Me.chkitemadd3.AutoSize = True
        Me.chkitemadd3.Location = New System.Drawing.Point(19, 78)
        Me.chkitemadd3.Name = "chkitemadd3"
        Me.chkitemadd3.Size = New System.Drawing.Size(77, 17)
        Me.chkitemadd3.TabIndex = 1
        Me.chkitemadd3.Text = "แล็คหลังคา"
        Me.chkitemadd3.UseVisualStyleBackColor = True
        '
        'chkitemadd4
        '
        Me.chkitemadd4.AutoSize = True
        Me.chkitemadd4.Location = New System.Drawing.Point(20, 101)
        Me.chkitemadd4.Name = "chkitemadd4"
        Me.chkitemadd4.Size = New System.Drawing.Size(60, 17)
        Me.chkitemadd4.TabIndex = 1
        Me.chkitemadd4.Text = "ล้อแม็ก"
        Me.chkitemadd4.UseVisualStyleBackColor = True
        '
        'chkfree1
        '
        Me.chkfree1.AutoSize = True
        Me.chkfree1.Location = New System.Drawing.Point(31, 32)
        Me.chkfree1.Name = "chkfree1"
        Me.chkfree1.Size = New System.Drawing.Size(108, 17)
        Me.chkfree1.TabIndex = 1
        Me.chkfree1.Text = "ประกันภัยชั้นหนึ่ง"
        Me.chkfree1.UseVisualStyleBackColor = True
        '
        'chkfree2
        '
        Me.chkfree2.AutoSize = True
        Me.chkfree2.Location = New System.Drawing.Point(31, 55)
        Me.chkfree2.Name = "chkfree2"
        Me.chkfree2.Size = New System.Drawing.Size(65, 17)
        Me.chkfree2.TabIndex = 1
        Me.chkfree2.Text = "ทำ พรบ."
        Me.chkfree2.UseVisualStyleBackColor = True
        '
        'chkfree3
        '
        Me.chkfree3.AutoSize = True
        Me.chkfree3.Location = New System.Drawing.Point(31, 78)
        Me.chkfree3.Name = "chkfree3"
        Me.chkfree3.Size = New System.Drawing.Size(78, 17)
        Me.chkfree3.TabIndex = 1
        Me.chkfree3.Text = "จดทะเบียน"
        Me.chkfree3.UseVisualStyleBackColor = True
        '
        'lblitemprice1
        '
        Me.lblitemprice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblitemprice1.Location = New System.Drawing.Point(104, 32)
        Me.lblitemprice1.Name = "lblitemprice1"
        Me.lblitemprice1.Size = New System.Drawing.Size(44, 17)
        Me.lblitemprice1.TabIndex = 2
        Me.lblitemprice1.Text = "40000"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(104, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = " 50000"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(103, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = " 20000"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(104, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = " 30000 "
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(159, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = " 25000"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(159, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = " 15000"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(159, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = " 35000"
        '
        'lblPaidPrice
        '
        Me.lblPaidPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPaidPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPaidPrice.Location = New System.Drawing.Point(277, 343)
        Me.lblPaidPrice.Name = "lblPaidPrice"
        Me.lblPaidPrice.Size = New System.Drawing.Size(205, 34)
        Me.lblPaidPrice.TabIndex = 4
        Me.lblPaidPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(197, 356)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 21)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "ราคาสุทธิ"
        '
        'frmLab6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 454)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblPaidPrice)
        Me.Controls.Add(Me.gpb2)
        Me.Controls.Add(Me.gpb1)
        Me.Controls.Add(Me.lblStartPrice)
        Me.Controls.Add(Me.chkcarforme)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab6"
        Me.Text = "frmLab6"
        Me.gpb1.ResumeLayout(False)
        Me.gpb1.PerformLayout()
        Me.gpb2.ResumeLayout(False)
        Me.gpb2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkcarforme As System.Windows.Forms.CheckBox
    Friend WithEvents lblStartPrice As System.Windows.Forms.Label
    Friend WithEvents gpb1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblitemprice1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkitemadd4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkitemadd3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkitemadd2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkitemadd1 As System.Windows.Forms.CheckBox
    Friend WithEvents gpb2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkfree3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkfree2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkfree1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblPaidPrice As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
