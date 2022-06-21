Imports System.Data.OleDb

Public Class editRoom
    Dim con As New OleDbConnection

    Private Sub editRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MeetingDb.mdb"
    End Sub

    Private Sub meetingPIN_TextChanged(sender As Object, e As EventArgs) Handles meetingPIN.TextChanged


    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select * from meetingDetails where MeetingPin like '%" & meetingPIN.Text & "%'", con)
        da.Fill(dt)

        meetingDate.DataBindings.Add("Text", dt, "MeetingDate")
        CBmeetTime.DataBindings.Add("Text", dt, "MeetingTime")
        CBmeetRoom.DataBindings.Add("Text", dt, "MeetingLocation")
        con.Close()
    End Sub
End Class