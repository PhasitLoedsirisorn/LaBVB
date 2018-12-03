Public Class frmLab2

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim Vista, Frista, Sale As Integer
        Dim VistaCom, FristaCom, TotalCom As Long
        Vista = Val(txtVista.Text)
        Frista = Val(txtFrista.Text)

        Sale = Vista + Frista

        VistaCom = Vista * 5 / 100
        FristaCom = Frista * 10 / 100

        TotalCom = VistaCom + FristaCom

        lblSale.Text = Sale
        lblCom.Text = TotalCom






    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
