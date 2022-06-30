'import package
Imports System.Data.OleDb

Public Class roomBook
	'declaration
	Dim ad As New OleDbDataAdapter
	Dim ds As New DataSet
	Dim n As Integer

	Private Sub roomBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		con.Open()
		Dim cm As New OleDbCommand
		cm.Connection = con
		cm.CommandText = "SELECT * FROM meetingDetails"
		ad.SelectCommand = cm
		ad.Fill(ds, "meeting")
		n = ds.Tables("meeting").Rows.Count - 1
		con.Close()
		DayTf.Text = DateTime.Now.ToString("dd")
		MonthTF.Text = DateTime.Now.ToString("MM")
		YearTF.Text = DateTime.Now.ToString("yyyy")

	End Sub

	Private Sub BookBtn_Click(sender As Object, e As EventArgs) Handles BookBtn.Click
		'declaration
		Dim empIDTF = EmployeeIDTF.Text
		Dim meetTittle = meetingTittle.Text
		Dim day = DayTf.Text
		Dim months = MonthTF.Text
		Dim year = YearTF.Text
		Dim meetDate = day & "/" & months & "/" & year
		Dim meetTime = cmbxmeetinTime.Text
		Dim meetRoom = cmbxmeetRoom.Text

		Dim cmb As New OleDbCommandBuilder
		cmb.DataAdapter = ad

		'if the field input is empty, appear msgbox
		If empIDTF = "" Then
			MessageBox.Show("Please insert your employee Id to book")
		ElseIf meetTittle = "" Then
			MessageBox.Show("Please insert meeting title to book")
		ElseIf meetDate = "" Then
			MessageBox.Show("Please set meeting date to book")
		ElseIf meetTime = "" Then
			MessageBox.Show("Please set meeting time to book")
		ElseIf meetRoom = "" Then
			MessageBox.Show("Please select meeting room to book")
		Else
			'insert data into access
			Dim roompin = DateTime.Now.ToString("ddHHmmss")
			Dim dr As DataRow
			dr = ds.Tables("meeting").NewRow
			With dr
				.Item("EmployeeID") = empIDTF
				.Item("MeetingTitle") = meetTittle
				.Item("MeetingDate") = meetDate
				.Item("MeetingTime") = meetTime
				.Item("MeetingPin") = roompin
				.Item("MeetingLocation") = meetRoom
			End With
			ds.Tables("meeting").Rows.Add(dr)
			ad.InsertCommand = cmb.GetInsertCommand
			n = n + 1
			MessageBox.Show("Your selected room has been reserved" + vbCrLf + "Your room pin is " + roompin)
		End If
		con.Open()
		Try
			ad.Update(ds, "meeting")
			clearControl()
			Me.Close()
		Catch ex As Exception
			MessageBox.Show("Something went wrong, please try again")
		End Try
		con.Close()
	End Sub

	Sub clearControl() 'function clear all the field input
		EmployeeIDTF.Text = ""
		meetingTittle.Text = ""
		cmbxmeetinTime.SelectedIndex = 0
		cmbxmeetRoom.SelectedIndex = 0
		DayTf.Text = ""
		MonthTF.Text = ""
		YearTF.Text = ""
	End Sub

End Class