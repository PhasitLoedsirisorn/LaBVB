Public Class frmJob4

 
    Dim datetoday As Date = Date.Now

   
    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Dim salary, YearSalary, Bonus, Allowance, tax, Allincome, sale As Double
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07
       

        salary = Val(txtSalary.Text)
        sale = Val(txtSale.Text)

        YearSalary = salary * 12
        Bonus = sale * decR_BONUS
        Allincome = YearSalary + Bonus
        Allowance = Allincome * decR_ALLOW
        tax = (Allincome - Allowance) * decR_TAX

        lblAllIncome.Text = FormatNumber(Allincome, 2)
        lblAllowance.Text = FormatNumber(Allowance, 2)
        lblBonus.Text = FormatNumber(Bonus, 2)
        lblTax.Text = FormatNumber(tax, 2)
        lblYearSalary.Text = FormatNumber(YearSalary, 2)

        txtSale.Text = FormatNumber(txtSale.Text, 2)
        txtSalary.Text = FormatNumber(txtSalary.Text, 2)
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