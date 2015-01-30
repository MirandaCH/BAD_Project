Public Class frmShifts

    Private Sub btnFirstShift_Click(sender As Object, e As EventArgs) Handles btnFirstShift.Click
        frmFirstShift.ShowDialog()

    End Sub

    Private Sub btnSecondShift_Click(sender As Object, e As EventArgs) Handles btnSecondShift.Click
        frmSecondShift.ShowDialog()
    End Sub

    Private Sub btnThirdShift_Click(sender As Object, e As EventArgs) Handles btnThirdShift.Click
        frmThirdShift.ShowDialog()
    End Sub

    Private Sub frmShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class