Public Class frmLab5
    Dim price, ea, paid As Integer
    Private Sub txtunit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunit.TextChanged
        price = Val(txtprice.Text)
        ea = Val(txtunit.Text)
        decTotal = price * ea

        lbltotal.Text = decTotal

    End Sub

    Private Sub radmember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radmember.CheckedChanged
        gpbpaid.Enabled = True
        radpaid.Enabled = True
        radcredit.Enabled = True

        lblDiscount.Text = ""
        lblcredit.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub radother_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radother.CheckedChanged
        radpaid.Checked = True
        gpbpaid.Enabled = False


        lblDiscount.Text = ""
        lblcredit.Text = ""
        lblPaid.Text = ""

    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        If (decTotal < 1000) Then
            decDiscount = 0
        ElseIf (decTotal < 5000) Then
            decDiscount = decTotal * 5 / 100
        ElseIf (decTotal < 10000) Then
            decDiscount = decTotal * 10 / 100
        ElseIf (decTotal >= 10000) Then
            decDiscount = decTotal * 15 / 100
        End If





        If (price = 0) Then
            MessageBox.Show("ป้อนข้อความไม่สมบูรณ์")
        ElseIf (ea = 0) Then
            MessageBox.Show("ป้อนข้อความไม่สมบูรณ์")
     
        End If


        If radmember.Checked = True Then
            If (radcredit.Checked = True) Then
                decDiscount = 0
                lblDiscount.Text = 0
                decNet = decTotal - decDiscount
                lblcredit.Text = decNet

            End If

            If radpaid.Checked = True Then
                lblDiscount.Text = decDiscount
                decNet = decTotal - decDiscount
                lblcredit.Text = 0
            End If

        End If
        If radother.Checked = True Then
            decDiscount = 0
            lblDiscount.Text = 0
            decNet = decTotal - decDiscount
            lblcredit.Text = 0
        End If
        lblPaid.Text = decNet
    End Sub

    Private Sub radpaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radpaid.CheckedChanged

        lblDiscount.Text = ""
        lblcredit.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub radcredit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radcredit.CheckedChanged

        lblDiscount.Text = ""
        lblcredit.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub lblDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDiscount.Click

    End Sub
End Class