Imports System.Data.OleDb

Public Class roomBook
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
	End Sub

	Private Sub BookBtn_Click(sender As Object, e As EventArgs) Handles BookBtn.Click
		Dim empIDTF = EmployeeIDTF.Text
		Dim meetTittle = meetingTittle.Text
		Dim meetDate = DatePicker.Value.Date.ToString
		Dim meetTime = cmbxmeetinTime.Text
		Dim meetRoom = cmbxmeetRoom.Text

		Dim cmb As New OleDbCommandBuilder
		cmb.DataAdapter = ad

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

	Sub clearControl()
		EmployeeIDTF.Text = ""
		meetingTittle.Text = ""
		cmbxmeetinTime.SelectedIndex = 0
		cmbxmeetRoom.SelectedIndex = 0
		DatePicker.Value = Now
	End Sub

End Class