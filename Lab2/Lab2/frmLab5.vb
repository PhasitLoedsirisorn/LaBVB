Public Class frmLab5
    Dim price, ea, total, discount, paid As Integer
    Private Sub frmLab5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbltotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotal.Click
   

    End Sub

    Private Sub txtunit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunit.TextChanged
        price = Val(txtprice.Text)
        ea = Val(txtunit.Text)
        total = price * ea

        lbltotal.Text = total

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



    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        If (total < 1000) Then
            discount = total * 0 / 100
        ElseIf (total < 5000) Then
            discount = total * 5 / 100
            lblDiscount.Text = discount
        ElseIf (total < 10000) Then
            discount = total * 10 / 100
        ElseIf (total >= 10000) Then
            discount = total * 15 / 100
        End If

        lblDiscount.Text = discount
        paid = total - discount

        lblPaid.Text = paid



    End Sub
End Class