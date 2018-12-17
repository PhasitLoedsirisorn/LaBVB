Public Class frmLab3
    Dim Num As Integer
    Private Sub lblFRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFRed.Click
        txtNumber.ForeColor = Color.Red
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Num = txtNumber.Text
        Num = Num + 2
        txtNumber.Text = Num

    End Sub


    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Num = txtNumber.Text
        Num = Num - 2
        txtNumber.Text = Num
    End Sub

    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged
        Dim size As Integer = Val(cboSize.Text)
        txtNumber.Font = New Font(txtNumber.Font.Name, size, FontStyle.Regular)
        txtNumber.Text = FormatNumber(txtNumber.Text, 2)
    End Sub

    Private Sub lblBGRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGRed.Click
        txtNumber.BackColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlue.Click
        txtNumber.ForeColor = Color.Blue
    End Sub

    Private Sub lblFGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFGreen.Click
        txtNumber.ForeColor = Color.Green
    End Sub

    Private Sub lblFViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFViolet.Click
        txtNumber.ForeColor = Color.Violet
    End Sub

    Private Sub lblFBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlack.Click
        txtNumber.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFOrange.Click
        txtNumber.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFYellow.Click
        txtNumber.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBrown.Click
        txtNumber.ForeColor = Color.Brown
    End Sub

    Private Sub lblFWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFWrite.Click
        txtNumber.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFSky.Click
        txtNumber.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBGBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGBlue.Click
        txtNumber.BackColor = Color.Blue
    End Sub

    Private Sub lblBGGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGGreen.Click
        txtNumber.BackColor = Color.Green
    End Sub

    Private Sub lblBGPink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGPink.Click
        txtNumber.BackColor = Color.Violet
    End Sub

    Private Sub lblBGBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGBlack.Click
        txtNumber.BackColor = Color.Black
    End Sub

    Private Sub lblBGOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGOrange.Click
        txtNumber.BackColor = Color.Orange
    End Sub

    Private Sub lblBGYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGYellow.Click
        txtNumber.BackColor = Color.Yellow
    End Sub

    Private Sub lblBGBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGBrown.Click
        txtNumber.BackColor = Color.Brown
    End Sub

    Private Sub lblBGWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGWrite.Click
        txtNumber.BackColor = Color.White
    End Sub

    Private Sub lblBGSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGSky.Click
        txtNumber.BackColor = Color.SkyBlue
    End Sub
End Class