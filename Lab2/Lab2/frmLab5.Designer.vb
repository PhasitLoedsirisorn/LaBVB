<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab5
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radother = New System.Windows.Forms.RadioButton()
        Me.radmember = New System.Windows.Forms.RadioButton()
        Me.txtproduct = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblcredit = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.gpbpaid = New System.Windows.Forms.GroupBox()
        Me.radcredit = New System.Windows.Forms.RadioButton()
        Me.radpaid = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gpbpaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รายการขาย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "จำนวนซื้อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เป็นเงิน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ส่วนลด"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "จำนวนเงินต้องชำระ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ยอดค้างชำระ"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radother)
        Me.GroupBox1.Controls.Add(Me.radmember)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 52)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทลูกค้า"
        '
        'radother
        '
        Me.radother.AutoSize = True
        Me.radother.Location = New System.Drawing.Point(69, 19)
        Me.radother.Name = "radother"
        Me.radother.Size = New System.Drawing.Size(76, 17)
        Me.radother.TabIndex = 6
        Me.radother.TabStop = True
        Me.radother.Text = "ลูกค้าทั่วไป"
        Me.radother.UseVisualStyleBackColor = True
        '
        'radmember
        '
        Me.radmember.AutoSize = True
        Me.radmember.Location = New System.Drawing.Point(6, 19)
        Me.radmember.Name = "radmember"
        Me.radmember.Size = New System.Drawing.Size(57, 17)
        Me.radmember.TabIndex = 5
        Me.radmember.TabStop = True
        Me.radmember.Text = "สมาชิก"
        Me.radmember.UseVisualStyleBackColor = True
        '
        'txtproduct
        '
        Me.txtproduct.Location = New System.Drawing.Point(184, 68)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.Size = New System.Drawing.Size(163, 20)
        Me.txtproduct.TabIndex = 0
        Me.txtproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(184, 100)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(163, 20)
        Me.txtprice.TabIndex = 1
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(184, 134)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(163, 20)
        Me.txtunit.TabIndex = 2
        Me.txtunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(184, 168)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(163, 18)
        Me.lbltotal.TabIndex = 3
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(184, 273)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(163, 18)
        Me.lblDiscount.TabIndex = 10
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaid
        '
        Me.lblPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaid.Location = New System.Drawing.Point(184, 301)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(163, 18)
        Me.lblPaid.TabIndex = 11
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcredit
        '
        Me.lblcredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcredit.Location = New System.Drawing.Point(184, 329)
        Me.lblcredit.Name = "lblcredit"
        Me.lblcredit.Size = New System.Drawing.Size(163, 18)
        Me.lblcredit.TabIndex = 12
        Me.lblcredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(185, 368)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(161, 27)
        Me.btncalculate.TabIndex = 13
        Me.btncalculate.Text = "คำนวณ"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'gpbpaid
        '
        Me.gpbpaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpbpaid.Controls.Add(Me.radcredit)
        Me.gpbpaid.Controls.Add(Me.radpaid)
        Me.gpbpaid.Location = New System.Drawing.Point(274, 210)
        Me.gpbpaid.Name = "gpbpaid"
        Me.gpbpaid.Size = New System.Drawing.Size(170, 52)
        Me.gpbpaid.TabIndex = 7
        Me.gpbpaid.TabStop = False
        Me.gpbpaid.Text = "การชำระเงิน"
        '
        'radcredit
        '
        Me.radcredit.AutoSize = True
        Me.radcredit.Location = New System.Drawing.Point(69, 19)
        Me.radcredit.Name = "radcredit"
        Me.radcredit.Size = New System.Drawing.Size(43, 17)
        Me.radcredit.TabIndex = 9
        Me.radcredit.TabStop = True
        Me.radcredit.Text = "เชื่อ"
        Me.radcredit.UseVisualStyleBackColor = True
        '
        'radpaid
        '
        Me.radpaid.AutoSize = True
        Me.radpaid.Location = New System.Drawing.Point(6, 19)
        Me.radpaid.Name = "radpaid"
        Me.radpaid.Size = New System.Drawing.Size(38, 17)
        Me.radpaid.TabIndex = 8
        Me.radpaid.Text = "สด"
        Me.radpaid.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(174, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(211, 28)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "โปรแกรมคำนวณการขาย"
        '
        'frmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 463)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.lblcredit)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.gpbpaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab5"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbpaid.ResumeLayout(False)
        Me.gpbpaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radother As System.Windows.Forms.RadioButton
    Friend WithEvents radmember As System.Windows.Forms.RadioButton
    Friend WithEvents txtproduct As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblcredit As System.Windows.Forms.Label
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents gpbpaid As System.Windows.Forms.GroupBox
    Friend WithEvents radcredit As System.Windows.Forms.RadioButton
    Friend WithEvents radpaid As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
