'import package
Imports System.Data.OleDb

Public Class validID
	'declaration
	Dim ad As New OleDbDataAdapter
	Dim ds As New DataSet
	Dim n As Integer
	Dim provider As String
	Dim connString As String
	Public meetPin As String

	Private Sub validID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		con.Open()
		Dim cm As New OleDbCommand
		cm.Connection = con
		cm.CommandText = "SELECT * FROM meetingDetails"
		ad.SelectCommand = cm
		ad.Fill(ds, "meeting")
		n = ds.Tables("meeting").Rows.Count - 1
		con.Close()
	End Sub

	Private Sub BookBtn_Click(sender As Object, e As EventArgs) Handles BookBtn.Click
		Try
			provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zarit\source\repos\Project2\MeetingDb.mdb"
			connString = provider
			con.ConnectionString = connString
			con.Open()
			Dim str As String
			str = "Select * From meetingDetails Where (MeetingPIN = '" & MeetingPIN.Text & "')"
			Dim cmd As OleDbCommand = New OleDbCommand(str, con)
			Dim data As OleDbDataReader = cmd.ExecuteReader()

			'if pin correct, form editRoom will show
			If data.Read Then
				meetPin = MeetingPIN.Text
				con.Close()
				editRoom.Show()
			Else
				MsgBox("Invalid Room PIN", MsgBoxStyle.Critical)
			End If
			Me.Close()
			con.Close()
			data.Close()
		Catch ex As Exception
			MessageBox.Show("Something went wrong, please try again")
		End Try
	End Sub


End Class