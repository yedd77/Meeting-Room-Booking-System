Imports System.Data.OleDb
Module Module1
	Public con As New OleDbConnection

	Sub Main()
		con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zarit\source\repos\Project2\MeetingDb.mdb"
		Dim Form1 As New Form1
		Form1.ShowDialog()
	End Sub
End Module
