<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab2
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtVista = New System.Windows.Forms.TextBox()
        Me.txtFrista = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSale = New System.Windows.Forms.Label()
        Me.lblCom = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(361, 345)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(97, 33)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ยอดขาย  Vistra Gluta"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ยอดขาย Frista Gluta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Closes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtVista
        '
        Me.txtVista.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVista.Location = New System.Drawing.Point(361, 92)
        Me.txtVista.Name = "txtVista"
        Me.txtVista.Size = New System.Drawing.Size(201, 40)
        Me.txtVista.TabIndex = 0
        Me.txtVista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFrista
        '
        Me.txtFrista.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFrista.Location = New System.Drawing.Point(361, 165)
        Me.txtFrista.Name = "txtFrista"
        Me.txtFrista.Size = New System.Drawing.Size(201, 40)
        Me.txtFrista.TabIndex = 1
        Me.txtFrista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 40)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ยอดขาย รวม"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 40)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ยอดขาย ค่าคอมมิชชั่นรวม"
        '
        'lblSale
        '
        Me.lblSale.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSale.Location = New System.Drawing.Point(362, 228)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(200, 40)
        Me.lblSale.TabIndex = 3
        Me.lblSale.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCom
        '
        Me.lblCom.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCom.Location = New System.Drawing.Point(362, 288)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(200, 40)
        Me.lblCom.TabIndex = 3
        Me.lblCom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Cyan
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(480, 40)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "โปรแกรมคำนวณยอดขายและค่าคอมมิชชั่น"
        '
        'frmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(735, 390)
        Me.Controls.Add(Me.lblCom)
        Me.Controls.Add(Me.lblSale)
        Me.Controls.Add(Me.txtFrista)
        Me.Controls.Add(Me.txtVista)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmLab2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtVista As System.Windows.Forms.TextBox
    Friend WithEvents txtFrista As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSale As System.Windows.Forms.Label
    Friend WithEvents lblCom As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
