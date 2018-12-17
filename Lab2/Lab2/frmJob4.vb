Public Class frmJob4

 
    Dim datetoday As Date = Date.Now

   
    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Dim salary, YearSalary, Bonus, Allowance, tax, Allincome, sale As Double
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07
       

        salary = Val(txtSalary.Text)
        txtSalary.Text = FormatNumber(txtSalary.Text, 2)
        sale = Val(txtSale.Text)
        txtSale.Text = FormatNumber(txtSale.Text, 2)

        YearSalary = salary * 12

        Bonus = sale * decR_BONUS

        Allincome = YearSalary + Bonus

        Allowance = Allincome * decR_ALLOW

        tax = (Allincome - Allowance) * decR_TAX

        lblAllIncome.Text = Allincome
        lblAllIncome.Text = FormatNumber(lblAllIncome.Text, 2)

        lblAllowance.Text = Allowance
        lblAllowance.Text = FormatNumber(lblAllowance.Text, 2)

        lblBonus.Text = Bonus
        lblBonus.Text = FormatNumber(lblBonus.Text, 2)

        lblTax.Text = tax
        lblTax.Text = FormatNumber(lblTax.Text, 2)

        lblYearSalary.Text = YearSalary
        lblYearSalary.Text = FormatNumber(lblYearSalary.Text, 2)


    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        txtToday.Text = FormatDateTime(datetoday, DateFormat.ShortDate)
    End Sub

    Private Sub radGeneralDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGeneralDate.CheckedChanged
        txtToday.Text = FormatDateTime(datetoday, DateFormat.GeneralDate)
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        txtToday.Text = FormatDateTime(datetoday, DateFormat.LongDate)
    End Sub

    Private Sub frmJob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtToday.Text = FormatDateTime(datetoday, DateFormat.GeneralDate)
    End Sub
End Class