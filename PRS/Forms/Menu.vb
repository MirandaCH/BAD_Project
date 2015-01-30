Public Class Menu

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        frmRegiter.ShowDialog()

    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        frmLogin.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit application!?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
