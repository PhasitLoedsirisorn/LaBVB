<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab7
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
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lstAdd = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(238, 126)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(52, 41)
        Me.btnMove.TabIndex = 0
        Me.btnMove.Text = " >"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnMoveAll
        '
        Me.btnMoveAll.Location = New System.Drawing.Point(238, 173)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(52, 41)
        Me.btnMoveAll.TabIndex = 0
        Me.btnMoveAll.Text = " >>"
        Me.btnMoveAll.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(238, 220)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(52, 41)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = " <"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBackAll
        '
        Me.btnBackAll.Location = New System.Drawing.Point(238, 267)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(52, 41)
        Me.btnBackAll.TabIndex = 0
        Me.btnBackAll.Text = "<<"
        Me.btnBackAll.UseVisualStyleBackColor = True
        '
        'cboOutput
        '
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(322, 53)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(124, 21)
        Me.cboOutput.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(86, 335)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(139, 30)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = " เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(322, 335)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 30)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = " เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(86, 384)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(138, 20)
        Me.txtAdd.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.Location = New System.Drawing.Point(327, 384)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(134, 29)
        Me.lblOutput.TabIndex = 4
        '
        'lstAdd
        '
        Me.lstAdd.FormattingEnabled = True
        Me.lstAdd.Location = New System.Drawing.Point(56, 44)
        Me.lstAdd.Name = "lstAdd"
        Me.lstAdd.Size = New System.Drawing.Size(155, 251)
        Me.lstAdd.TabIndex = 5
        '
        'frmLab7vb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 474)
        Me.Controls.Add(Me.lstAdd)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboOutput)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Name = "frmLab7vb"
        Me.Text = "frmLab7vb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnMoveAll As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBackAll As System.Windows.Forms.Button
    Friend WithEvents cboOutput As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lstAdd As System.Windows.Forms.ListBox
End Class
