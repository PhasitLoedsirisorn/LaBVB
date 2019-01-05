<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab8
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
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOldTotalScore = New System.Windows.Forms.Label()
        Me.lblOldTotalCredit = New System.Windows.Forms.Label()
        Me.lblNewGPA = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOldGPA = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวฯเกรดเฉลี่ยนสะสม"
        '
        'lstSubject
        '
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.Location = New System.Drawing.Point(32, 107)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(120, 121)
        Me.lstSubject.TabIndex = 1
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.Location = New System.Drawing.Point(158, 107)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(120, 121)
        Me.lstScore.TabIndex = 1
        '
        'lstCredit
        '
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.Location = New System.Drawing.Point(284, 107)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(120, 121)
        Me.lstCredit.TabIndex = 1
        '
        'lstGrade
        '
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.Location = New System.Drawing.Point(410, 107)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(120, 121)
        Me.lstGrade.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "วิชา"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "คะแนนสอบ"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = " หน่วยกิต"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(411, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 31)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = " เกรด"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(33, 240)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(118, 20)
        Me.txtSubject.TabIndex = 3
        Me.txtSubject.Text = " "
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(159, 240)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(118, 20)
        Me.txtScore.TabIndex = 3
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(286, 240)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(118, 20)
        Me.txtCredit.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(411, 236)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(55, 27)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = " เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(475, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(55, 27)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblOldTotalScore
        '
        Me.lblOldTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldTotalScore.Location = New System.Drawing.Point(159, 273)
        Me.lblOldTotalScore.Name = "lblOldTotalScore"
        Me.lblOldTotalScore.Size = New System.Drawing.Size(64, 27)
        Me.lblOldTotalScore.TabIndex = 2
        '
        'lblOldTotalCredit
        '
        Me.lblOldTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldTotalCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldTotalCredit.Location = New System.Drawing.Point(314, 273)
        Me.lblOldTotalCredit.Name = "lblOldTotalCredit"
        Me.lblOldTotalCredit.Size = New System.Drawing.Size(64, 27)
        Me.lblOldTotalCredit.TabIndex = 2
        '
        'lblNewGPA
        '
        Me.lblNewGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNewGPA.Location = New System.Drawing.Point(248, 340)
        Me.lblNewGPA.Name = "lblNewGPA"
        Me.lblNewGPA.Size = New System.Drawing.Size(64, 27)
        Me.lblNewGPA.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = " คะแนนสะสมก่อนหน้า"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = " หน่วยกิตสะสม"
        '
        'lblOldGPA
        '
        Me.lblOldGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldGPA.Location = New System.Drawing.Point(472, 273)
        Me.lblOldGPA.Name = "lblOldGPA"
        Me.lblOldGPA.Size = New System.Drawing.Size(64, 27)
        Me.lblOldGPA.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(381, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = " เกรดเฉลี่่ยสะสม"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(93, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = " เกรดเฉลี่่ยสะสมภาคปัจจุบัน"
        '
        'frmLab8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 424)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNewGPA)
        Me.Controls.Add(Me.lblOldGPA)
        Me.Controls.Add(Me.lblOldTotalCredit)
        Me.Controls.Add(Me.lblOldTotalScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab8"
        Me.Text = "frmLab8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstSubject As System.Windows.Forms.ListBox
    Friend WithEvents lstScore As System.Windows.Forms.ListBox
    Friend WithEvents lstCredit As System.Windows.Forms.ListBox
    Friend WithEvents lstGrade As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblOldTotalScore As System.Windows.Forms.Label
    Friend WithEvents lblOldTotalCredit As System.Windows.Forms.Label
    Friend WithEvents lblNewGPA As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblOldGPA As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
