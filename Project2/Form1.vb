'import necessary packages
Imports Module1
Imports System.Data.OleDb

Public Class Form1
	'initialize connection
	Dim ad As New OleDbDataAdapter
	Dim ds As New DataSet
	Dim n As Integer
	Private timer As Integer = 0

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Time_Timer.Start()
		TimeLabel.Parent = PictureBox1
		DateLabel.Parent = PictureBox1

		con.Open()
		Dim cm As New OleDbCommand
		cm.Connection = con
		cm.CommandText = "SELECT * FROM meetingDetails"
		ad.SelectCommand = cm
		ad.Fill(ds, "meeting")
		n = ds.Tables("meeting").Rows.Count - 1
		con.Close()
		Display()
	End Sub

	Private Sub Time_Timer_Tick(sender As Object, e As EventArgs) Handles Time_Timer.Tick
		'update timer for every 1 second
		timer = timer + 1
		TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss")
		DateLabel.Text = DateTime.Now.ToString("dd, MMM yyyy")
	End Sub

	Sub Display()
		'declaration for datarow access
		Dim dr As DataRow
		If n >= 0 Then
			dr = ds.Tables("meeting").Rows(0)
			With dr
				meetingSideTittle1.Text = .Item("MeetingTitle")
				MeetingSideLoc1.Text = .Item("MeetingLocation")
				MeetingSideTime1.Text = .Item("MeetingTime")
			End With
			dr = ds.Tables("meeting").Rows(1)
			With dr
				meetingSideTittle2.Text = .Item("MeetingTitle")
				MeetingSideLoc2.Text = .Item("MeetingLocation")
				MeetingSideTime2.Text = .Item("MeetingTime")
			End With
			dr = ds.Tables("meeting").Rows(2)
			With dr
				meetingSideTittle3.Text = .Item("MeetingTitle")
				MeetingSideLoc3.Text = .Item("MeetingLocation")
				MeetingSideTime3.Text = .Item("MeetingTime")
			End With

		Else
			meetingSideTittle1.Text = "All room available for booking"
		End If
	End Sub

	Private Sub BookBtn_Click(sender As Object, e As EventArgs) Handles BookBtn.Click
		roomBook.Show() 'show form roomBook
	End Sub

	Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
		validID.Show() 'show form validID
	End Sub

	Private Sub DisplayBtn_Click(sender As Object, e As EventArgs) Handles DisplayBtn.Click
		meeting.Show() 'show form meeting
	End Sub
End Class
