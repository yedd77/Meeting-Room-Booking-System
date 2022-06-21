<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class validID
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(validID))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.MeetingPIN = New System.Windows.Forms.TextBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.BookBtn = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(144, 33)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(496, 31)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Enter Meeting Pin to edit your Meeting Room"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(27, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(32, 312)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 8
		Me.PictureBox1.TabStop = False
		'
		'MeetingPIN
		'
		Me.MeetingPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MeetingPIN.Location = New System.Drawing.Point(149, 80)
		Me.MeetingPIN.Name = "MeetingPIN"
		Me.MeetingPIN.Size = New System.Drawing.Size(250, 30)
		Me.MeetingPIN.TabIndex = 10
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(90, 0)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(32, 312)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 11
		Me.PictureBox2.TabStop = False
		'
		'BookBtn
		'
		Me.BookBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(188, Byte), Integer))
		Me.BookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BookBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BookBtn.Location = New System.Drawing.Point(483, 251)
		Me.BookBtn.Name = "BookBtn"
		Me.BookBtn.Size = New System.Drawing.Size(119, 44)
		Me.BookBtn.TabIndex = 13
		Me.BookBtn.Text = "Edit Room"
		Me.BookBtn.UseVisualStyleBackColor = False
		'
		'validID
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(614, 307)
		Me.Controls.Add(Me.BookBtn)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.MeetingPIN)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "validID"
		Me.Text = "validID"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents MeetingPIN As TextBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents BookBtn As Button
End Class
