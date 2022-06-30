'import packages
Imports System.Data.OleDb
Imports Module1

Public Class meeting
	'declaration 
	Dim provider As String
	Dim connString As String

	Public meetPin As String

	Private Sub meeting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'connection access
		Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zarit\source\repos\Project2\MeetingDb.mdb"
		Dim Myconnection As OleDbConnection
		Dim dbda As OleDbDataAdapter
		Dim dbds As DataSet
		Dim tables As DataTableCollection
		Dim source As New BindingSource
		Myconnection = New OleDbConnection
		Myconnection.ConnectionString = connString
		dbds = New DataSet
		tables = dbds.Tables
		dbda = New OleDbDataAdapter("Select MeetingTitle, MeetingDate, MeetingTime, MeetingLocation from meetingDetails", Myconnection) 'select a few data to show at datagrid
		dbda.Fill(dbds, "meetingDetails")
		Dim view As New DataView(tables(0))
		source.DataSource = view
		DataGridView1.DataSource = view
	End Sub
End Class