Imports System.Data.SqlClient

Public Class frmFirstShift

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub frmFirstShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = DatabaseConnection.ConnectionString
        cmd.Connection = con

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
     
    Private Sub ShowTotals()
        cmd.Parameters.Clear()
        cmd.CommandText = "SELECT TicketType, SUM(Total) as total FROM Tickets where userid=@userid GROUP BY TicketType"
        cmd.Parameters.Add(New SqlParameter("userid", Session.UserID))

        con.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        While dr.Read
            If (dr("TicketType").ToString() = "1") Then
                txtTc.Text = dr("total")
            ElseIf dr("TicketType").ToString() = "2" Then
                txtTb.Text = dr("total")
            Else
                txtTt.Text = dr("total")
            End If
        End While
        con.Close()


        txtTotal.Text = Convert.ToDecimal(txtTb.Text) + Convert.ToDecimal(txtTc.Text) + Convert.ToDecimal(txtTt.Text)
    End Sub

    Private Sub btnBpaid_Click(sender As Object, e As EventArgs)
        cmd.Parameters.Clear()
        cmd.CommandText = "INSERT INTO Tickets (RegistrationDate, TicketType, Total, UserID) VALUES (@RD, 2, 100, @UID)"
        cmd.Parameters.Add(New SqlParameter("@RD", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@UID", Session.UserID))

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        ShowTotals()
    End Sub

    Private Sub btnTpaid_Click(sender As Object, e As EventArgs)
        cmd.Parameters.Clear()
        cmd.CommandText = "INSERT INTO Tickets (RegistrationDate, TicketType, Total, UserID) VALUES (@RD, 3, 110, @UID)"
        cmd.Parameters.Add(New SqlParameter("@RD", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@UID", Session.UserID))

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        ShowTotals()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    Private Sub btnCpaid_Click(sender As Object, e As EventArgs) Handles btnCpaid.Click
        cmd.Parameters.Clear()
        cmd.CommandText = "INSERT INTO Tickets (RegistrationDate, TicketType, Total, UserID) VALUES (@RD, 1, 50, @UID)"
        cmd.Parameters.Add(New SqlParameter("@RD", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@UID", Session.UserID))

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        ShowTotals()
    End Sub
End Class