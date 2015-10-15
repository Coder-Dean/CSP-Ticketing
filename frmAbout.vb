Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmAbout
	Inherits System.Windows.Forms.Form
	
	' Reg Key Security Options...
	Const READ_CONTROL As Integer = &H20000
	Const KEY_QUERY_VALUE As Integer = &H1
	Const KEY_SET_VALUE As Integer = &H2
	Const KEY_CREATE_SUB_KEY As Integer = &H4
	Const KEY_ENUMERATE_SUB_KEYS As Integer = &H8
	Const KEY_NOTIFY As Integer = &H10
	Const KEY_CREATE_LINK As Integer = &H20
	Const KEY_ALL_ACCESS As Double = KEY_QUERY_VALUE + KEY_SET_VALUE + KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL
	
	' Reg Key ROOT Types...
	Const HKEY_LOCAL_MACHINE As Integer = &H80000002
    Const READ_SUCCESS As Short = 0
	Const REG_SZ As Short = 1 ' Unicode nul terminated string
	Const REG_DWORD As Short = 4 ' 32-bit number
	
	Const gREGKEYSYSINFOLOC As String = "SOFTWARE\Microsoft\Shared Tools Location"
	Const gREGVALSYSINFOLOC As String = "MSINFO"
	Const gREGKEYSYSINFO As String = "SOFTWARE\Microsoft\Shared Tools\MSINFO"
	Const gREGVALSYSINFO As String = "PATH"
	
	Private Declare Function RegOpenKeyEx Lib "advapi32"  Alias "RegOpenKeyExA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
	Private Declare Function RegQueryValueEx Lib "advapi32"  Alias "RegQueryValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As String, ByRef lpcbData As Integer) As Integer
	Private Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Integer) As Integer
	
	
	Private Sub cmdSysInfo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSysInfo.Click
        Call FetchSysInfo()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Me.Close()
	End Sub
	
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Text = "About CSP Ticketing Software"
		lblVersion.Text = "Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
        lblTitle.Text = "Camarillo Skyway Playhouse Ticketing Software "
        lblDescription.Text = My.Application.Info.Description & Environment.NewLine & "Copyright " & My.Application.Info.Copyright
	End Sub
	
    Public Sub FetchSysInfo()
        Dim dir_exist As Boolean
        Dim SysInfoPath As String = Nothing

        Try
            ' Try To Get full System Info Program Path\Name From Registry...
            If GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFO, gREGVALSYSINFO, SysInfoPath) = False Then
                'no full path/file so try To Get System Info Program Path Only From Registry
                If GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFOLOC, gREGVALSYSINFOLOC, SysInfoPath) = True Then
                    ' check for existance Of known 32 Bit File Version
                    dir_exist = My.Computer.FileSystem.FileExists(SysInfoPath & "\MSINFO32.EXE") 'check if info exe file exists
                    If (dir_exist = True) Then
                        SysInfoPath = SysInfoPath & "\MSINFO32.EXE"
                    Else
                        'can't find file so set error 
                        Throw New System.Exception("Registry File cannot Be Found.")
                    End If
                    ' Error - Registry Entry Can Not Be Found...
                    Throw New System.Exception("Registry Entry cannot Be Found.")
                End If
                ' can't find path so set error 
                Throw New System.Exception("SysInfo path cannot Be Found.")
            End If
            'got it so show results
            Call Shell(SysInfoPath, AppWinStyle.NormalFocus)


        Catch SubErr As Exception
            MsgBox("System Information Is Unavailable At This Time - " & _
                   Environment.NewLine & SubErr.Message, MsgBoxStyle.OkOnly, "FetchSysInfo Error")
        End Try


    End Sub
	
	Public Function GetKeyValue(ByRef KeyRoot As Integer, ByRef KeyName As String, ByRef SubKeyRef As String, ByRef KeyVal As String) As Boolean
		Dim i As Integer ' Loop Counter
		Dim rc As Integer ' Return Code
		Dim hKey As Integer ' Handle To An Open Registry Key
        Dim KeyValType As Integer ' Data Type Of A Registry Key
		Dim tmpVal As String ' Tempory Storage For A Registry Key Value
        Dim KeyValSize As Integer ' Size Of Registry Key Variable

        Try
            ' Open RegKey Under KeyRoot {HKEY_LOCAL_MACHINE...}
            rc = RegOpenKeyEx(KeyRoot, KeyName, 0, KEY_ALL_ACCESS, hKey) ' Open Registry Key

            If (rc <> READ_SUCCESS) Then Throw New System.Exception("Failed to open Key")

            tmpVal = New String(Chr(0), 1024) ' Allocate Variable Space
            KeyValSize = 1024 ' Mark Variable Size

            ' Retrieve Registry Key Value...
            rc = RegQueryValueEx(hKey, SubKeyRef, 0, KeyValType, tmpVal, KeyValSize) ' Get/Create Key Value

            If (rc <> READ_SUCCESS) Then Throw New System.Exception("Failed to open Value")

            If (Asc(Mid(tmpVal, KeyValSize, 1)) = 0) Then ' Win95 Adds Null Terminated String...
                tmpVal = VB.Left(tmpVal, KeyValSize - 1) ' Null Found, Extract From String
            Else ' WinNT Does NOT Null Terminate String...
                tmpVal = VB.Left(tmpVal, KeyValSize) ' Null Not Found, Extract String Only
            End If
            ' Determine Key Value Type For Conversion...
            Select Case KeyValType ' Search Data Types...
                Case REG_SZ ' String Registry Key Data Type
                    KeyVal = tmpVal ' Copy String Value
                Case REG_DWORD ' Double Word Registry Key Data Type
                    For i = Len(tmpVal) To 1 Step -1 ' Convert Each Bit
                        KeyVal = KeyVal & Hex(Asc(Mid(tmpVal, i, 1))) ' Build Value Char. By Char.
                    Next
                    KeyVal = VB6.Format("&h" & KeyVal) ' Convert Double Word To String
            End Select

            GetKeyValue = True ' Return Success
            rc = RegCloseKey(hKey) ' Close Registry Key

        Catch
            KeyVal = "" ' Set Return Val To Empty String
            GetKeyValue = False ' Return Failure
            rc = RegCloseKey(hKey) ' Close Registry Key
        End Try
    End Function
	

End Class