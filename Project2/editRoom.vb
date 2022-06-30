'import packages
Imports System.Data.OleDb
Imports Module1

Public Class editRoom
	'declaration
	Dim ad As New OleDbDataAdapter
	Dim ds As New DataSet
	Dim n As Integer
	Dim provider As String
	Dim connString As String
	Public RoomPin As String

	Private Sub editRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'get data from previous form
		RoomPin = validID.meetPin

		'initialize connection
		con.Open()
		Dim cm As New OleDbCommand
		cm.Connection = con
		cm.CommandText = "SELECT * FROM meetingDetails"
		ad.SelectCommand = cm
		ad.Fill(ds, "meeting")
		n = ds.Tables("meeting").Rows.Count - 1
		con.Close()

		'retrieve data from db
		Try
			provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zarit\source\repos\Project2\MeetingDb.mdb"
			connString = provider
			con.ConnectionString = connString
			con.Open()
			Dim str As String
			str = "Select * From meetingDetails Where (MeetingPIN = '" & RoomPin & "')"
			Dim cmd As OleDbCommand = New OleDbCommand(str, con)
			Dim data As OleDbDataReader = cmd.ExecuteReader()

			If data.Read Then
				meetingTitleTF.Text = data("MeetingTitle").ToString
				DaysTF.Text = data("MeetingDate").ToString.Substring(0, 2)
				MonthsTF.Text = data("MeetingDate").ToString.Substring(3, 2)
				yearTF.Text = data("MeetingDate").ToString.Substring(6, 4)
				CBmeetTime.Text = data("MeetingTime").ToString
				CBmeetRoom.Text = data("MeetingLocation").ToString()
			Else

				MsgBox("Invalid Request Please try again", MsgBoxStyle.Critical)
			End If
			con.Close()
			data.Close()
		Catch ex As Exception
			MessageBox.Show("Something went wrong, please try again")
		End Try
	End Sub



	Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
		Dim cm As New OleDbCommandBuilder
		cm.DataAdapter = ad

		Dim days = DaysTF.Text
		Dim month = MonthsTF.Text
		Dim Year = yearTF.Text
		Dim dateMeet = days & "/" & month & "/" & Year

		If meetingTitleTF.Text = "" Then
			MessageBox.Show("Please Insert the Meeting Title to edit your data")
		Else
			'update  the data from access
			Dim tb As DataTable
			Dim dcPrimaryKey(0) As DataColumn
			tb = ds.Tables("meeting")
			dcPrimaryKey(0) = tb.Columns("MeetingPIN")
			tb.PrimaryKey = dcPrimaryKey
			Dim dr As DataRow = tb.Rows.Find(RoomPin)
			With dr
				.Item("MeetingTitle") = meetingTitleTF.Text
				.Item("MeetingDate") = dateMeet
				.Item("MeetingTime") = CBmeetTime.Text
				.Item("MeetingLocation") = CBmeetRoom.Text
			End With

			ad.UpdateCommand = cm.GetUpdateCommand
			MessageBox.Show("Your data have been updated....")
		End If

		update()
		Me.Close()
	End Sub

	Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
		provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zarit\source\repos\Project2\MeetingDb.mdb"
		connString = provider
		con.ConnectionString = connString
		con.Open()
		'delete data in access
		Dim str As String
		str = "Delete from meetingDetails Where (MeetingPIN = '" & RoomPin & "')"
		Dim cmd As OleDbCommand = New OleDbCommand(str, con)

		Try
			cmd.ExecuteNonQuery()
			cmd.Dispose()
			con.Close()
			meetingTitleTF.Text = ""
			DaysTF.Text = ""
			MonthsTF.Text = ""
			yearTF.Text = ""
			CBmeetTime.SelectedIndex = 0
			CBmeetRoom.SelectedIndex = 0
			MsgBox("Your booking has been deleted")
		Catch ex As Exception
			MsgBox("Something went wrong")
		End Try
	End Sub

	Sub update()
		con.Open()
		Try
			ad.Update(ds, "meeting")

		Catch ex As Exception
			MessageBox.Show("Something is wrong with the system!")
		End Try
		con.Close()
	End Sub

End Class