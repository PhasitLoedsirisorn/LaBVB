Public Class frmLab6
    Dim total, car, g1, g2, g3, g4, g21, g22, g23 As Integer

    Private Sub frmLab6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gpb1.Enabled = False
        gpb2.Enabled = False
    End Sub

    Private Sub chkcarforme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcarforme.CheckedChanged
       
    End Sub

    Private Sub chkitemadd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkitemadd1.CheckedChanged

        If chkitemadd1.Checked = False Then

            total = total - 40000
            lblPaidPrice.Text = FormatNumber(total, 2)
        Else

            total = total + 40000
            lblPaidPrice.Text = FormatNumber(total, 2)

        End If
    End Sub

    Private Sub chkitemadd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkitemadd2.CheckedChanged

        If chkitemadd2.Checked = False Then
            total = total - 50000
            lblPaidPrice.Text = FormatNumber(total, 2)
        Else
            total = total + 50000
            lblPaidPrice.Text = FormatNumber(total, 2)
        End If
    End Sub

    Private Sub chkitemadd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkitemadd3.CheckedChanged
        If chkitemadd3.Checked = False Then
            total = total - 20000
            lblPaidPrice.Text = FormatNumber(total, 2)
        Else
            total = total + 20000
            lblPaidPrice.Text = FormatNumber(total, 2)
        End If
    End Sub

    Private Sub chkitemadd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkitemadd4.CheckedChanged
        If chkitemadd4.Checked = False Then
            total = total - 30000
            lblPaidPrice.Text = FormatNumber(total, 2)
        Else
            total = total + 30000
            lblPaidPrice.Text = FormatNumber(total, 2)
        End If
    End Sub

    Private Sub chkfree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfree1.CheckedChanged
        If chkfree1.Checked = True Then
            total = total - 25000
            lblPaidPrice.Text = FormatNumber(total, 2)
        Else
            total = total + 25000
            lblPaidPrice.Text = FormatNumber(total, 2)
        End If
    End Sub

    Private Sub chkfree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfree2.CheckedChanged
        If chkfree2.Checked = True Then
            total = total - 15000
            lblPaidPrice.Text = FormatNumber(total, 2)
        Else
            total = total + 15000
            lblPaidPrice.Text = FormatNumber(total, 2)
        End If
    End Sub

    Private Sub chkfree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfree3.CheckedChanged
        If chkfree3.Checked = True Then
            total = total - 35000
            lblPaidPrice.Text = FormatNumber(total, 2)
        Else
            total = total + 35000
            lblPaidPrice.Text = FormatNumber(total, 2)
        End If
    End Sub

    Private Sub chkcarforme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkcarforme.Click
        gpb1.Enabled = True
        gpb2.Enabled = True



        car = 1250000
        g1 = 40000
        g2 = 50000
        g3 = 20000
        g4 = 30000
        g21 = 25000
        g22 = 15000
        g23 = 35000

        If chkcarforme.Checked = True Then
            total = car + g21 + g22 + g23
            lblPaidPrice.Text = FormatNumber(total, 2)
        End If
        If (chkcarforme.Checked = False) Then
            If MessageBox.Show("ต้องการยกเลิกการซื้อรถหรือไม่", "หัวหน้าต่าง", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                gpb1.Enabled = False
                gpb2.Enabled = False
                chkitemadd1.Checked = False
                chkitemadd2.Checked = False
                chkitemadd3.Checked = False
                chkitemadd4.Checked = False
                chkfree1.Checked = False
                chkfree2.Checked = False
                chkfree3.Checked = False
                lblPaidPrice.Text = ""
            Else
                chkcarforme.Checked = True

            End If


        End If
    End Sub
End Class