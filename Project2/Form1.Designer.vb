<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.TimeLabel = New System.Windows.Forms.Label()
		Me.DateLabel = New System.Windows.Forms.Label()
		Me.PageTittle = New System.Windows.Forms.Label()
		Me.meetingTittle1 = New System.Windows.Forms.Label()
		Me.RoomName1 = New System.Windows.Forms.Label()
		Me.TimeLeft1 = New System.Windows.Forms.Label()
		Me.meetingTittle2 = New System.Windows.Forms.Label()
		Me.RoomName2 = New System.Windows.Forms.Label()
		Me.TimeLeft2 = New System.Windows.Forms.Label()
		Me.BookBtn = New System.Windows.Forms.Button()
		Me.EditBtn = New System.Windows.Forms.Button()
		Me.DisplayBtn = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.meetingSideTittle1 = New System.Windows.Forms.Label()
		Me.MeetingSideLoc1 = New System.Windows.Forms.Label()
		Me.MeetingSideTime1 = New System.Windows.Forms.Label()
		Me.meetingSideTittle2 = New System.Windows.Forms.Label()
		Me.MeetingSideLoc2 = New System.Windows.Forms.Label()
		Me.MeetingSideTime2 = New System.Windows.Forms.Label()
		Me.meetingSideTittle3 = New System.Windows.Forms.Label()
		Me.MeetingSideLoc3 = New System.Windows.Forms.Label()
		Me.MeetingSideTime3 = New System.Windows.Forms.Label()
		Me.Time_Timer = New System.Windows.Forms.Timer(Me.components)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(1191, 547)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'TimeLabel
		'
		Me.TimeLabel.AutoSize = True
		Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
		Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TimeLabel.ForeColor = System.Drawing.Color.White
		Me.TimeLabel.Location = New System.Drawing.Point(12, 9)
		Me.TimeLabel.Name = "TimeLabel"
		Me.TimeLabel.Size = New System.Drawing.Size(140, 54)
		Me.TimeLabel.TabIndex = 1
		Me.TimeLabel.Text = "00:00"
		'
		'DateLabel
		'
		Me.DateLabel.AutoSize = True
		Me.DateLabel.BackColor = System.Drawing.Color.Transparent
		Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateLabel.ForeColor = System.Drawing.Color.White
		Me.DateLabel.Location = New System.Drawing.Point(16, 52)
		Me.DateLabel.Name = "DateLabel"
		Me.DateLabel.Size = New System.Drawing.Size(126, 39)
		Me.DateLabel.TabIndex = 2
		Me.DateLabel.Text = "00, Apr"
		'
		'PageTittle
		'
		Me.PageTittle.AutoSize = True
		Me.PageTittle.BackColor = System.Drawing.Color.Transparent
		Me.PageTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PageTittle.ForeColor = System.Drawing.Color.Transparent
		Me.PageTittle.Location = New System.Drawing.Point(16, 117)
		Me.PageTittle.Name = "PageTittle"
		Me.PageTittle.Size = New System.Drawing.Size(285, 42)
		Me.PageTittle.TabIndex = 3
		Me.PageTittle.Text = "Current Meeting"
		'
		'meetingTittle1
		'
		Me.meetingTittle1.AutoSize = True
		Me.meetingTittle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(116, Byte), Integer))
		Me.meetingTittle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.meetingTittle1.ForeColor = System.Drawing.Color.White
		Me.meetingTittle1.Location = New System.Drawing.Point(16, 176)
		Me.meetingTittle1.Name = "meetingTittle1"
		Me.meetingTittle1.Size = New System.Drawing.Size(221, 39)
		Me.meetingTittle1.TabIndex = 4
		Me.meetingTittle1.Text = "Meeting Tittle"
		'
		'RoomName1
		'
		Me.RoomName1.AutoSize = True
		Me.RoomName1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(116, Byte), Integer))
		Me.RoomName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RoomName1.ForeColor = System.Drawing.Color.White
		Me.RoomName1.Location = New System.Drawing.Point(16, 211)
		Me.RoomName1.Name = "RoomName1"
		Me.RoomName1.Size = New System.Drawing.Size(208, 39)
		Me.RoomName1.TabIndex = 6
		Me.RoomName1.Text = "Room Name"
		'
		'TimeLeft1
		'
		Me.TimeLeft1.AutoSize = True
		Me.TimeLeft1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(116, Byte), Integer))
		Me.TimeLeft1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TimeLeft1.ForeColor = System.Drawing.Color.White
		Me.TimeLeft1.Location = New System.Drawing.Point(16, 247)
		Me.TimeLeft1.Name = "TimeLeft1"
		Me.TimeLeft1.Size = New System.Drawing.Size(136, 36)
		Me.TimeLeft1.TabIndex = 7
		Me.TimeLeft1.Text = "Time Left"
		'
		'meetingTittle2
		'
		Me.meetingTittle2.AutoSize = True
		Me.meetingTittle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(116, Byte), Integer))
		Me.meetingTittle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.meetingTittle2.ForeColor = System.Drawing.Color.White
		Me.meetingTittle2.Location = New System.Drawing.Point(16, 340)
		Me.meetingTittle2.Name = "meetingTittle2"
		Me.meetingTittle2.Size = New System.Drawing.Size(221, 39)
		Me.meetingTittle2.TabIndex = 8
		Me.meetingTittle2.Text = "Meeting Tittle"
		'
		'RoomName2
		'
		Me.RoomName2.AutoSize = True
		Me.RoomName2.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(116, Byte), Integer))
		Me.RoomName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RoomName2.ForeColor = System.Drawing.Color.White
		Me.RoomName2.Location = New System.Drawing.Point(16, 376)
		Me.RoomName2.Name = "RoomName2"
		Me.RoomName2.Size = New System.Drawing.Size(208, 39)
		Me.RoomName2.TabIndex = 9
		Me.RoomName2.Text = "Room Name"
		'
		'TimeLeft2
		'
		Me.TimeLeft2.AutoSize = True
		Me.TimeLeft2.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(116, Byte), Integer))
		Me.TimeLeft2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TimeLeft2.ForeColor = System.Drawing.Color.White
		Me.TimeLeft2.Location = New System.Drawing.Point(16, 412)
		Me.TimeLeft2.Name = "TimeLeft2"
		Me.TimeLeft2.Size = New System.Drawing.Size(136, 36)
		Me.TimeLeft2.TabIndex = 10
		Me.TimeLeft2.Text = "Time Left"
		'
		'BookBtn
		'
		Me.BookBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BookBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BookBtn.Location = New System.Drawing.Point(914, 491)
		Me.BookBtn.Name = "BookBtn"
		Me.BookBtn.Size = New System.Drawing.Size(119, 44)
		Me.BookBtn.TabIndex = 11
		Me.BookBtn.Text = "Book a Room"
		Me.BookBtn.UseVisualStyleBackColor = False
		'
		'EditBtn
		'
		Me.EditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EditBtn.Location = New System.Drawing.Point(1060, 491)
		Me.EditBtn.Name = "EditBtn"
		Me.EditBtn.Size = New System.Drawing.Size(119, 44)
		Me.EditBtn.TabIndex = 12
		Me.EditBtn.Text = "Edit Room"
		Me.EditBtn.UseVisualStyleBackColor = False
		'
		'DisplayBtn
		'
		Me.DisplayBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.DisplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DisplayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DisplayBtn.Location = New System.Drawing.Point(565, 491)
		Me.DisplayBtn.Name = "DisplayBtn"
		Me.DisplayBtn.Size = New System.Drawing.Size(146, 44)
		Me.DisplayBtn.TabIndex = 13
		Me.DisplayBtn.Text = "Display All Meeting"
		Me.DisplayBtn.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(943, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(264, 36)
		Me.Label1.TabIndex = 14
		Me.Label1.Text = "Upcoming Meeting"
		'
		'Panel1
		'
		Me.Panel1.Location = New System.Drawing.Point(948, 53)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(211, 3)
		Me.Panel1.TabIndex = 15
		'
		'meetingSideTittle1
		'
		Me.meetingSideTittle1.AutoSize = True
		Me.meetingSideTittle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.meetingSideTittle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.meetingSideTittle1.ForeColor = System.Drawing.Color.White
		Me.meetingSideTittle1.Location = New System.Drawing.Point(924, 79)
		Me.meetingSideTittle1.Name = "meetingSideTittle1"
		Me.meetingSideTittle1.Size = New System.Drawing.Size(177, 31)
		Me.meetingSideTittle1.TabIndex = 16
		Me.meetingSideTittle1.Text = "Meeting Tittle"
		'
		'MeetingSideLoc1
		'
		Me.MeetingSideLoc1.AutoSize = True
		Me.MeetingSideLoc1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.MeetingSideLoc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MeetingSideLoc1.ForeColor = System.Drawing.Color.White
		Me.MeetingSideLoc1.Location = New System.Drawing.Point(924, 104)
		Me.MeetingSideLoc1.Name = "MeetingSideLoc1"
		Me.MeetingSideLoc1.Size = New System.Drawing.Size(197, 29)
		Me.MeetingSideLoc1.TabIndex = 17
		Me.MeetingSideLoc1.Text = "Meeting Location"
		'
		'MeetingSideTime1
		'
		Me.MeetingSideTime1.AutoSize = True
		Me.MeetingSideTime1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.MeetingSideTime1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MeetingSideTime1.ForeColor = System.Drawing.Color.White
		Me.MeetingSideTime1.Location = New System.Drawing.Point(925, 128)
		Me.MeetingSideTime1.Name = "MeetingSideTime1"
		Me.MeetingSideTime1.Size = New System.Drawing.Size(131, 25)
		Me.MeetingSideTime1.TabIndex = 18
		Me.MeetingSideTime1.Text = "Meeting Time"
		'
		'meetingSideTittle2
		'
		Me.meetingSideTittle2.AutoSize = True
		Me.meetingSideTittle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.meetingSideTittle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.meetingSideTittle2.ForeColor = System.Drawing.Color.White
		Me.meetingSideTittle2.Location = New System.Drawing.Point(924, 217)
		Me.meetingSideTittle2.Name = "meetingSideTittle2"
		Me.meetingSideTittle2.Size = New System.Drawing.Size(177, 31)
		Me.meetingSideTittle2.TabIndex = 19
		Me.meetingSideTittle2.Text = "Meeting Tittle"
		'
		'MeetingSideLoc2
		'
		Me.MeetingSideLoc2.AutoSize = True
		Me.MeetingSideLoc2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.MeetingSideLoc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MeetingSideLoc2.ForeColor = System.Drawing.Color.White
		Me.MeetingSideLoc2.Location = New System.Drawing.Point(925, 242)
		Me.MeetingSideLoc2.Name = "MeetingSideLoc2"
		Me.MeetingSideLoc2.Size = New System.Drawing.Size(197, 29)
		Me.MeetingSideLoc2.TabIndex = 20
		Me.MeetingSideLoc2.Text = "Meeting Location"
		'
		'MeetingSideTime2
		'
		Me.MeetingSideTime2.AutoSize = True
		Me.MeetingSideTime2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.MeetingSideTime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MeetingSideTime2.ForeColor = System.Drawing.Color.White
		Me.MeetingSideTime2.Location = New System.Drawing.Point(924, 266)
		Me.MeetingSideTime2.Name = "MeetingSideTime2"
		Me.MeetingSideTime2.Size = New System.Drawing.Size(131, 25)
		Me.MeetingSideTime2.TabIndex = 21
		Me.MeetingSideTime2.Text = "Meeting Time"
		'
		'meetingSideTittle3
		'
		Me.meetingSideTittle3.AutoSize = True
		Me.meetingSideTittle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.meetingSideTittle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.meetingSideTittle3.ForeColor = System.Drawing.Color.White
		Me.meetingSideTittle3.Location = New System.Drawing.Point(924, 358)
		Me.meetingSideTittle3.Name = "meetingSideTittle3"
		Me.meetingSideTittle3.Size = New System.Drawing.Size(177, 31)
		Me.meetingSideTittle3.TabIndex = 22
		Me.meetingSideTittle3.Text = "Meeting Tittle"
		'
		'MeetingSideLoc3
		'
		Me.MeetingSideLoc3.AutoSize = True
		Me.MeetingSideLoc3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.MeetingSideLoc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MeetingSideLoc3.ForeColor = System.Drawing.Color.White
		Me.MeetingSideLoc3.Location = New System.Drawing.Point(925, 383)
		Me.MeetingSideLoc3.Name = "MeetingSideLoc3"
		Me.MeetingSideLoc3.Size = New System.Drawing.Size(197, 29)
		Me.MeetingSideLoc3.TabIndex = 23
		Me.MeetingSideLoc3.Text = "Meeting Location"
		'
		'MeetingSideTime3
		'
		Me.MeetingSideTime3.AutoSize = True
		Me.MeetingSideTime3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.MeetingSideTime3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MeetingSideTime3.ForeColor = System.Drawing.Color.White
		Me.MeetingSideTime3.Location = New System.Drawing.Point(925, 407)
		Me.MeetingSideTime3.Name = "MeetingSideTime3"
		Me.MeetingSideTime3.Size = New System.Drawing.Size(131, 25)
		Me.MeetingSideTime3.TabIndex = 24
		Me.MeetingSideTime3.Text = "Meeting Time"
		'
		'Time_Timer
		'
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1191, 547)
		Me.Controls.Add(Me.MeetingSideTime3)
		Me.Controls.Add(Me.MeetingSideLoc3)
		Me.Controls.Add(Me.meetingSideTittle3)
		Me.Controls.Add(Me.MeetingSideTime2)
		Me.Controls.Add(Me.MeetingSideLoc2)
		Me.Controls.Add(Me.meetingSideTittle2)
		Me.Controls.Add(Me.MeetingSideTime1)
		Me.Controls.Add(Me.MeetingSideLoc1)
		Me.Controls.Add(Me.meetingSideTittle1)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DisplayBtn)
		Me.Controls.Add(Me.EditBtn)
		Me.Controls.Add(Me.BookBtn)
		Me.Controls.Add(Me.TimeLeft2)
		Me.Controls.Add(Me.RoomName2)
		Me.Controls.Add(Me.meetingTittle2)
		Me.Controls.Add(Me.TimeLeft1)
		Me.Controls.Add(Me.RoomName1)
		Me.Controls.Add(Me.meetingTittle1)
		Me.Controls.Add(Me.PageTittle)
		Me.Controls.Add(Me.DateLabel)
		Me.Controls.Add(Me.TimeLabel)
		Me.Controls.Add(Me.PictureBox1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TimeLabel As Label
	Friend WithEvents DateLabel As Label
	Friend WithEvents PageTittle As Label
	Friend WithEvents meetingTittle1 As Label
	Friend WithEvents RoomName1 As Label
	Friend WithEvents TimeLeft1 As Label
	Friend WithEvents meetingTittle2 As Label
	Friend WithEvents RoomName2 As Label
	Friend WithEvents TimeLeft2 As Label
	Friend WithEvents BookBtn As Button
	Friend WithEvents EditBtn As Button
	Friend WithEvents DisplayBtn As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents meetingSideTittle1 As Label
	Friend WithEvents MeetingSideLoc1 As Label
	Friend WithEvents MeetingSideTime1 As Label
	Friend WithEvents meetingSideTittle2 As Label
	Friend WithEvents MeetingSideLoc2 As Label
	Friend WithEvents MeetingSideTime2 As Label
	Friend WithEvents meetingSideTittle3 As Label
	Friend WithEvents MeetingSideLoc3 As Label
	Friend WithEvents MeetingSideTime3 As Label
    Friend WithEvents Time_Timer As Timer
End Class
