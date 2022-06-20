<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomBook
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(roomBook))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.EmployeeIDTF = New System.Windows.Forms.TextBox()
		Me.meetingTittle = New System.Windows.Forms.TextBox()
		Me.DatePicker = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.cmbxmeetRoom = New System.Windows.Forms.ComboBox()
		Me.BookBtn = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.cmbxmeetinTime = New System.Windows.Forms.ComboBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(32, 463)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(59, 0)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(32, 463)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 1
		Me.PictureBox2.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
		Me.PictureBox3.Location = New System.Drawing.Point(121, 0)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(32, 463)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox3.TabIndex = 2
		Me.PictureBox3.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(159, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(269, 31)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Book a meeting room"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(171, 88)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(100, 20)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Employee ID"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(171, 153)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(104, 20)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Meeting Tittle"
		'
		'EmployeeIDTF
		'
		Me.EmployeeIDTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EmployeeIDTF.Location = New System.Drawing.Point(175, 111)
		Me.EmployeeIDTF.Name = "EmployeeIDTF"
		Me.EmployeeIDTF.Size = New System.Drawing.Size(208, 26)
		Me.EmployeeIDTF.TabIndex = 6
		'
		'meetingTittle
		'
		Me.meetingTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.meetingTittle.Location = New System.Drawing.Point(175, 176)
		Me.meetingTittle.Name = "meetingTittle"
		Me.meetingTittle.Size = New System.Drawing.Size(208, 26)
		Me.meetingTittle.TabIndex = 7
		'
		'DatePicker
		'
		Me.DatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DatePicker.Location = New System.Drawing.Point(175, 245)
		Me.DatePicker.MinDate = New Date(2022, 6, 19, 0, 0, 0, 0)
		Me.DatePicker.Name = "DatePicker"
		Me.DatePicker.Size = New System.Drawing.Size(208, 26)
		Me.DatePicker.TabIndex = 8
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(171, 222)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(105, 20)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Meeting Date"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(171, 360)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(113, 20)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Meeting Room"
		'
		'cmbxmeetRoom
		'
		Me.cmbxmeetRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbxmeetRoom.FormattingEnabled = True
		Me.cmbxmeetRoom.Items.AddRange(New Object() {"Yellow Room", "Red Room", "Green Room", "Meeting Room 1", "Meeting Room 2", "Meeting Room 3", "MeetBox 1", "MeetBox 2", "MeetBox 3"})
		Me.cmbxmeetRoom.Location = New System.Drawing.Point(175, 383)
		Me.cmbxmeetRoom.Name = "cmbxmeetRoom"
		Me.cmbxmeetRoom.Size = New System.Drawing.Size(208, 28)
		Me.cmbxmeetRoom.TabIndex = 11
		'
		'BookBtn
		'
		Me.BookBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BookBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BookBtn.Location = New System.Drawing.Point(506, 407)
		Me.BookBtn.Name = "BookBtn"
		Me.BookBtn.Size = New System.Drawing.Size(119, 44)
		Me.BookBtn.TabIndex = 12
		Me.BookBtn.Text = "Book a Room"
		Me.BookBtn.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(171, 286)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(104, 20)
		Me.Label6.TabIndex = 14
		Me.Label6.Text = "Meeting Time"
		'
		'cmbxmeetinTime
		'
		Me.cmbxmeetinTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbxmeetinTime.FormattingEnabled = True
		Me.cmbxmeetinTime.Items.AddRange(New Object() {"0900", "0930", "1000", "1030", "1100", "1130", "1200", "1230", "1300", "1330", "1400", "1430", "1500", "1530", "1600", "1630", "1700"})
		Me.cmbxmeetinTime.Location = New System.Drawing.Point(175, 309)
		Me.cmbxmeetinTime.Name = "cmbxmeetinTime"
		Me.cmbxmeetinTime.Size = New System.Drawing.Size(208, 28)
		Me.cmbxmeetinTime.TabIndex = 15
		'
		'roomBook
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(637, 463)
		Me.Controls.Add(Me.cmbxmeetinTime)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.BookBtn)
		Me.Controls.Add(Me.cmbxmeetRoom)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.DatePicker)
		Me.Controls.Add(Me.meetingTittle)
		Me.Controls.Add(Me.EmployeeIDTF)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Name = "roomBook"
		Me.Text = "roomBook"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents EmployeeIDTF As TextBox
	Friend WithEvents meetingTittle As TextBox
	Friend WithEvents DatePicker As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents cmbxmeetRoom As ComboBox
	Friend WithEvents BookBtn As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents cmbxmeetinTime As ComboBox
End Class
