Public Class frmLab7
    Dim i As Integer

    Private Sub frmLab7vb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If Not txtAdd.Text = ("") Then
            btnAdd.Enabled = True
        ElseIf txtAdd.Text = ("") Then
            btnAdd.Enabled = False
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        lstAdd.Items.Add(txtAdd.Text)
        lstAdd.SelectedIndex = i
        i += 1
        txtAdd.Text = ("")

    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        cboOutput.Items.Add(lstAdd.SelectedItem)
        cboOutput.SelectedIndex = 0
        lstAdd.Items.Remove(lstAdd.SelectedItem)
        lstAdd.SelectedIndex = i

    End Sub

    Private Sub btnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        cboOutput.Items.Add(lstAdd.Items)

        lstAdd.Items.Clear()
    End Sub
End Class