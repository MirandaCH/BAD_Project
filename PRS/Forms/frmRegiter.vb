﻿Imports System.Data.SqlClient

Public Class frmRegiter
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        con.ConnectionString = DatabaseConnection.ConnectionString
        cmd.Connection = con


        If txtFirstname.Text.Trim() = "" Then
            MessageBox.Show("First name cannot be empty!")
            txtFirstname.Focus()
            Return
        End If
        cmd.CommandText = "Insert INTO Employees(Firstname, Lastname, Email, Phone, Username, Password) VALUES (@Firstname, @Lastname, @Email, @Phone, @Username, @Password)"

        cmd.Parameters.Add(New SqlParameter("@Firstname", txtFirstname.Text))
        cmd.Parameters.Add(New SqlParameter("@Lastname", txtLastname.Text))
        cmd.Parameters.Add(New SqlParameter("@Email", txtEmail.Text))
        cmd.Parameters.Add(New SqlParameter("@Phone", txtPhone.Text))
        cmd.Parameters.Add(New SqlParameter("@Username", txtUsername.Text))
        cmd.Parameters.Add(New SqlParameter("@Password", txtPassword.Text))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("You were successfully registered!")
            con.Close()


        Catch ex As Exception
            MessageBox.Show("An error has ocured! Message!" + ex.Message)
            con.Close()


        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class

