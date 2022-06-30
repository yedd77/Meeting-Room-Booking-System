<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class meeting
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridView1.Location = New System.Drawing.Point(12, 102)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.Size = New System.Drawing.Size(1057, 530)
		Me.DataGridView1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(276, 31)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Booked Room Details"
		'
		'meeting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(1083, 640)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "meeting"
		Me.Text = "meeting"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label1 As Label
End Class
