'
' Erstellt mit SharpDevelop.
' Benutzer: dominic
' Datum: 12.01.2010
' Zeit: 02:36
' 
' Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.txtHash = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtString
        '
        Me.txtString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtString.Location = New System.Drawing.Point(14, 14)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(455, 21)
        Me.txtString.TabIndex = 1
        Me.txtString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHash
        '
        Me.txtHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHash.Location = New System.Drawing.Point(14, 44)
        Me.txtHash.Name = "txtHash"
        Me.txtHash.ReadOnly = True
        Me.txtHash.Size = New System.Drawing.Size(455, 21)
        Me.txtHash.TabIndex = 10
        Me.txtHash.TabStop = False
        Me.txtHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(14, 130)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(455, 35)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close Program"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Location = New System.Drawing.Point(14, 89)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(455, 35)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "&About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(483, 179)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtHash)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnAbout)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "md5Convert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private txtHash As System.Windows.Forms.TextBox
    Private WithEvents btnAbout As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents txtString As System.Windows.Forms.TextBox
End Class
