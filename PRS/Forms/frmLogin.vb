Imports System.Data.SqlClient

Public Class frmLogin
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        con.ConnectionString = DatabaseConnection.ConnectionString
        cmd.Connection = con

        cmd.CommandText = "SELECT Username, Password FROM Employees WHERE Username=@Username AND Password=@Password"
        cmd.Parameters.Add(New SqlParameter("@Username", txtUsername.Text))
        cmd.Parameters.Add(New SqlParameter("@Password", txtPassword.Text))

        Try
            con.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader


            If dr.HasRows = False Then
                MessageBox.Show("Wrong username or password!")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("Error connecting! Message!" + ex.Message)
            con.Close()

        End Try

        frmShifts.ShowDialog()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class