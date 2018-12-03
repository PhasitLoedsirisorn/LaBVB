<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Me.txtGluta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(373, 316)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(74, 33)
        Me.btnCalculate.TabIndex = 0
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
        Me.Button1.Location = New System.Drawing.Point(488, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Closes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtVista
        '
        Me.txtVista.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVista.Location = New System.Drawing.Point(361, 92)
        Me.txtVista.Name = "txtVista"
        Me.txtVista.Size = New System.Drawing.Size(201, 40)
        Me.txtVista.TabIndex = 2
        '
        'txtGluta
        '
        Me.txtGluta.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtGluta.Location = New System.Drawing.Point(361, 165)
        Me.txtGluta.Name = "txtGluta"
        Me.txtGluta.Size = New System.Drawing.Size(201, 40)
        Me.txtGluta.TabIndex = 2
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
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 390)
        Me.Controls.Add(Me.txtGluta)
        Me.Controls.Add(Me.txtVista)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frm1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtVista As System.Windows.Forms.TextBox
    Friend WithEvents txtGluta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
