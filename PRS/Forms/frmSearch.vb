Imports System.Data.SqlClient
Public Class frmSearch

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim con As New SqlConnection
        con.ConnectionString = DatabaseConnection.ConnectionString

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "Select Firstname, Lastname, Phone, Email, Username FROM Employees WHERE Firstname LIKE @Firstname"
        cmd.Parameters.Add(New SqlParameter("@FirstName", "%" + txtSearch.Text + "%"))

        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds)

        grdEmployees.DataSource = ds.Tables(0)

    End Sub

    
End Class