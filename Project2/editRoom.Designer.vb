<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editRoom
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editRoom))
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.confirmBtn = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.CBmeetTime = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.CBmeetRoom = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.meetingTitleTF = New System.Windows.Forms.TextBox()
		Me.DaysTF = New System.Windows.Forms.TextBox()
		Me.yearTF = New System.Windows.Forms.TextBox()
		Me.MonthsTF = New System.Windows.Forms.TextBox()
		Me.DeleteBtn = New System.Windows.Forms.Button()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
		Me.PictureBox3.Location = New System.Drawing.Point(-1, 0)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(32, 463)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox3.TabIndex = 3
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(58, 0)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(32, 463)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 4
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(124, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(32, 463)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 5
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(162, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(307, 31)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Edit Your Meeting Room"
		'
		'confirmBtn
		'
		Me.confirmBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.confirmBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.confirmBtn.Location = New System.Drawing.Point(600, 402)
		Me.confirmBtn.Name = "confirmBtn"
		Me.confirmBtn.Size = New System.Drawing.Size(119, 44)
		Me.confirmBtn.TabIndex = 13
		Me.confirmBtn.Text = "Update"
		Me.confirmBtn.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(177, 96)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(99, 20)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Meeting Title"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(177, 169)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(105, 20)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "Meeting Date"
		'
		'CBmeetTime
		'
		Me.CBmeetTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CBmeetTime.FormattingEnabled = True
		Me.CBmeetTime.Items.AddRange(New Object() {"0900", "0930", "1000", "1030", "1100", "1130", "1200", "1230", "1300", "1330", "1400", "1430", "1500", "1530", "1600", "1630", "1700"})
		Me.CBmeetTime.Location = New System.Drawing.Point(181, 267)
		Me.CBmeetTime.Name = "CBmeetTime"
		Me.CBmeetTime.Size = New System.Drawing.Size(208, 28)
		Me.CBmeetTime.TabIndex = 20
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(177, 243)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(104, 20)
		Me.Label6.TabIndex = 19
		Me.Label6.Text = "Meeting Time"
		'
		'CBmeetRoom
		'
		Me.CBmeetRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CBmeetRoom.FormattingEnabled = True
		Me.CBmeetRoom.Items.AddRange(New Object() {"Yellow Room", "Red Room", "Green Room", "Meeting Room 1", "Meeting Room 2", "Meeting Room 3", "MeetBox 1", "MeetBox 2", "MeetBox 3"})
		Me.CBmeetRoom.Location = New System.Drawing.Point(181, 344)
		Me.CBmeetRoom.Name = "CBmeetRoom"
		Me.CBmeetRoom.Size = New System.Drawing.Size(208, 28)
		Me.CBmeetRoom.TabIndex = 22
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(177, 320)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(113, 20)
		Me.Label5.TabIndex = 21
		Me.Label5.Text = "Meeting Room"
		'
		'meetingTitleTF
		'
		Me.meetingTitleTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.meetingTitleTF.Location = New System.Drawing.Point(182, 124)
		Me.meetingTitleTF.Name = "meetingTitleTF"
		Me.meetingTitleTF.Size = New System.Drawing.Size(207, 26)
		Me.meetingTitleTF.TabIndex = 23
		'
		'DaysTF
		'
		Me.DaysTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DaysTF.Location = New System.Drawing.Point(182, 197)
		Me.DaysTF.Name = "DaysTF"
		Me.DaysTF.Size = New System.Drawing.Size(49, 26)
		Me.DaysTF.TabIndex = 24
		'
		'yearTF
		'
		Me.yearTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.yearTF.Location = New System.Drawing.Point(292, 197)
		Me.yearTF.Name = "yearTF"
		Me.yearTF.Size = New System.Drawing.Size(97, 26)
		Me.yearTF.TabIndex = 26
		'
		'MonthsTF
		'
		Me.MonthsTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MonthsTF.Location = New System.Drawing.Point(237, 197)
		Me.MonthsTF.Name = "MonthsTF"
		Me.MonthsTF.Size = New System.Drawing.Size(49, 26)
		Me.MonthsTF.TabIndex = 27
		'
		'DeleteBtn
		'
		Me.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DeleteBtn.Location = New System.Drawing.Point(475, 402)
		Me.DeleteBtn.Name = "DeleteBtn"
		Me.DeleteBtn.Size = New System.Drawing.Size(119, 44)
		Me.DeleteBtn.TabIndex = 28
		Me.DeleteBtn.Text = "Delete"
		Me.DeleteBtn.UseVisualStyleBackColor = False
		'
		'editRoom
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(731, 458)
		Me.Controls.Add(Me.DeleteBtn)
		Me.Controls.Add(Me.MonthsTF)
		Me.Controls.Add(Me.yearTF)
		Me.Controls.Add(Me.DaysTF)
		Me.Controls.Add(Me.meetingTitleTF)
		Me.Controls.Add(Me.CBmeetRoom)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.CBmeetTime)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.confirmBtn)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.PictureBox3)
		Me.Name = "editRoom"
		Me.Text = "editRoom"
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents confirmBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents meetingPIN As TextBox
    Friend WithEvents Label3 As Label
	Friend WithEvents CBmeetTime As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents CBmeetRoom As ComboBox
	Friend WithEvents Label5 As Label
	Friend WithEvents meetingTitleTF As TextBox
	Friend WithEvents DaysTF As TextBox
	Friend WithEvents yearTF As TextBox
	Friend WithEvents MonthsTF As TextBox
	Friend WithEvents DeleteBtn As Button
End Class
