'
' Erstellt mit SharpDevelop.
' Benutzer: dominic
' Datum: 12.01.2010
' Zeit: 03:40
' Update: 11.11.2013 02:42
' Aktualisierung von Website und Email
' Update: 15.11.2014 15:27
' Aktualisierung von Website und Email, Look & Feel
'

Public Partial Class frmAbout
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
    Sub FrmAboutLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'lblTop.Text = "Dominic Reich" & Chr(13) & "Seite 37" & Chr(13) & "6433 Ötz"
        lblTop.Text = "Dominic Reich"
        lblNotice.Text = "(C) 2010,2016 Dominic Reich" + Chr(13) + "Redesigned 2016"
    End Sub
	
    Sub LnkEmailLinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkEmail.LinkClicked
        ' http://dotnet-snippets.de/dns/c-webseite-mit-standartbrowser-oeffnen-SID919.aspx
        On Error GoTo ShowError
        System.Diagnostics.Process.Start("mailto:Dominic Reich <info@dominicreich.com>")
        lnkEmail.LinkVisited = True
        Exit Sub
ShowError:
        MessageBox.Show(Err.Description, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub BtnCloseAboutClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnCloseAbout.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkWebsiteLink.LinkClicked
        ' http://dotnet-snippets.de/dns/c-webseite-mit-standartbrowser-oeffnen-SID919.aspx
        On Error GoTo ShowError
        System.Diagnostics.Process.Start("https://dominicreich.com")
        lnkWebsiteLink.LinkVisited = True
        Exit Sub
ShowError:
        MessageBox.Show(Err.Description, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class