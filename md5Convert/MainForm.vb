'
' Erstellt mit SharpDevelop.
' Benutzer: dominic
' Datum: 12.01.2010
' Zeit: 02:36
' 
' Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
'
Imports System.Security.Cryptography
Imports System.Text

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	' Funktion MD5StringHash geklaut bei:
	' http://dotnet-snippets.de/dns/vbnet-den-md5-hash-eines-strings-ermitteln-SID75.aspx
	Public Function MD5StringHash(ByVal strString As String) As String
    	Dim MD5 As New MD5CryptoServiceProvider
    	Dim Data As Byte()
    	Dim Result As Byte()
    	Dim Res As String = ""
    	Dim Tmp As String = ""
		
    	Data = Encoding.ASCII.GetBytes(strString)
    	Result = MD5.ComputeHash(Data)
    	For i As Integer = 0 To Result.Length - 1
        	Tmp = Hex(Result(i))
        	If Len(Tmp) = 1 Then Tmp = "0" & Tmp
    	   	Res += Tmp
    	Next
    	Return Res
	End Function
	
	Sub BtnConvertClick(sender As Object, e As EventArgs)
		txtHash.Text = MD5StringHash(txtString.Text)
	End Sub
	
    Sub BtnAboutClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAbout.Click
        'frmAbout.ActiveForm.Activate
        Dim Obj As New frmAbout()
        Obj.ShowDialog()
    End Sub
	
    Sub BtnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        System.Windows.Forms.Application.Exit()
    End Sub
	
    Sub TxtStringTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtString.TextChanged
        ' Ausgabe mit Kleinbuchstaben (.ToLower())
        On Error GoTo ShowError
        txtHash.Text = MD5StringHash(txtString.Text).ToLower()
        Exit Sub
ShowError:
        MessageBox.Show(Err.Description, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
