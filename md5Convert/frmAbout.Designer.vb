'
' Erstellt mit SharpDevelop.
' Benutzer: dominic
' Datum: 12.01.2010
' Zeit: 03:40
' 
' Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
'
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblTop = New System.Windows.Forms.Label()
        Me.lnkEmail = New System.Windows.Forms.LinkLabel()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCloseAbout = New System.Windows.Forms.Button()
        Me.lnkWebsiteLink = New System.Windows.Forms.LinkLabel()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTop
        '
        Me.lblTop.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTop.Location = New System.Drawing.Point(14, 14)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(455, 57)
        Me.lblTop.TabIndex = 0
        Me.lblTop.Text = "label1"
        '
        'lnkEmail
        '
        Me.lnkEmail.AutoSize = True
        Me.lnkEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkEmail.Location = New System.Drawing.Point(17, 41)
        Me.lnkEmail.Name = "lnkEmail"
        Me.lnkEmail.Size = New System.Drawing.Size(100, 19)
        Me.lnkEmail.TabIndex = 1
        Me.lnkEmail.TabStop = True
        Me.lnkEmail.Text = "dominic@tmsn.at"
        Me.lnkEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkEmail.UseCompatibleTextRendering = True
        '
        'lblNotice
        '
        Me.lblNotice.AutoSize = True
        Me.lblNotice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.Location = New System.Drawing.Point(14, 141)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(41, 15)
        Me.lblNotice.TabIndex = 3
        Me.lblNotice.Text = "label1"
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox1.Enabled = False
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(411, 14)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(58, 57)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'btnCloseAbout
        '
        Me.btnCloseAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseAbout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseAbout.Location = New System.Drawing.Point(342, 130)
        Me.btnCloseAbout.Name = "btnCloseAbout"
        Me.btnCloseAbout.Size = New System.Drawing.Size(127, 35)
        Me.btnCloseAbout.TabIndex = 0
        Me.btnCloseAbout.Text = "Clo&se About"
        Me.btnCloseAbout.UseVisualStyleBackColor = True
        '
        'lnkWebsiteLink
        '
        Me.lnkWebsiteLink.AutoSize = True
        Me.lnkWebsiteLink.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkWebsiteLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkWebsiteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkWebsiteLink.Location = New System.Drawing.Point(17, 63)
        Me.lnkWebsiteLink.Name = "lnkWebsiteLink"
        Me.lnkWebsiteLink.Size = New System.Drawing.Size(185, 19)
        Me.lnkWebsiteLink.TabIndex = 5
        Me.lnkWebsiteLink.TabStop = True
        Me.lnkWebsiteLink.Text = "http://tmsn.at/?tools&&md5convert"
        Me.lnkWebsiteLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkWebsiteLink.UseCompatibleTextRendering = True
        '
        'frmAbout
        '
        Me.AcceptButton = Me.btnCloseAbout
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 179)
        Me.Controls.Add(Me.lnkWebsiteLink)
        Me.Controls.Add(Me.btnCloseAbout)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lblNotice)
        Me.Controls.Add(Me.lnkEmail)
        Me.Controls.Add(Me.lblTop)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "md5Convert - About"
        Me.TopMost = True
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnCloseAbout As System.Windows.Forms.Button
    Private pictureBox1 As System.Windows.Forms.PictureBox
    Private lblNotice As System.Windows.Forms.Label
    Private WithEvents lnkEmail As System.Windows.Forms.LinkLabel
    Private lblTop As System.Windows.Forms.Label
    Private WithEvents lnkWebsiteLink As System.Windows.Forms.LinkLabel
End Class
