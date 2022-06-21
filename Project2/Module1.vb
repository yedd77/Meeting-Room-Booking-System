Imports System.Data.OleDb
Module Module1
	Public con As New OleDbConnection

	Sub Main()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nurud\Desktop\Project 2_ VB\MeetingDB.mdb"
        Dim Form1 As New Form1
		Form1.ShowDialog()
	End Sub
End Module
