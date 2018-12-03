Public Class frnlab1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim Name As String
        Dim Salary, TotalSalary As Integer

        Name = txtName.Text
        Salary = Val(txtSalary.Text)

        TotalSalary = Salary * 12

        lblName.Text = Name
        lblSalary.Text = Salary
        lblTotalsalary.Text = TotalSalary

    End Sub
End Class