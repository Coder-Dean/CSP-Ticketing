Option Strict Off
Option Explicit On

Imports System.Data.OleDb


Module DbModule

    'global database connections
    Public ConnectOle As New OleDb.OleDbConnection()
    'database source
    Public Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = "
    ''Name of the archive database
    Public Const DbName As String = "CSP_TicketDB"
    ''Archive Database file name
    Public Const DbFile As String = "\CSP_TicketDB.accdb"
    ''Archive Database path (may be on network, but will default to App.Path)
    Public DbPath As String
    ''cat of dbPath and dbFile
    Public TicketingDatabase As String
    'string flag for database not found
    Public Const Missing_database As String = "NOT_FOUND"
    ''Data Table in Archive Database
    Public Const SalesTable As String = "[Sales]"
    ''Standard ticket Table in Archive Database
    Public Const StdTicketTable As String = "[StandardTickets]"
    ''Special ticket Table in Archive Database
    Public Const SpcTicketTable As String = "[SpecialTickets]"
    ''Special ticket Table in Archive Database
    Public Const ShowNamesTable As String = "[ShowNames]"
    ''Special ticket Table in Archive Database
    Public Const PasswordTable As String = "[Passwords]"

    '
    Public SpecialTicketNameStrDB() As String
    Public FilenameStrdb() As String
    '
    'if we lost the database, flag for other routines
    Public DatabaseExists As Boolean


    ''***********************************************
    Public Function FindDatabase() As Boolean
        Dim db_exist As Boolean
        Dim ex_msg As String = ""

        FindDatabase = False
        Try
            ex_msg = " - Searching for path."
            GetDbPath() 'read registry
            db_exist = My.Computer.FileSystem.FileExists(TicketingDatabase) 'check if database exists
            If db_exist = True Then
                FindDatabase = True
            Else
                GetPathFromUser() 'ask where is database?
                If TicketingDatabase <> Missing_database Then
                    SaveDbPath() 'save good path
                    FindDatabase = True
                Else
                    MsgBox("Database file not found", MsgBoxStyle.OkOnly, "FindDatabase Error")
                    FindDatabase = False
                End If
            End If
            If FindDatabase = True Then
                ex_msg = " - Connecting to Access."
                'setup global database pointers
                ConnectOle.ConnectionString = Provider & TicketingDatabase & ";" & _
                       "Persist Security Info=False;"
                ex_msg = " - Opening Access."
                ConnectOle.Open()
            End If

        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "FindDatabase Error" & ex_msg)
        End Try

    End Function
    '
    ''***********************************************
    Public Sub ReadPasswordsDatabase()

        Try
            If DatabaseExists = True Then

                Dim db_cmd As System.Data.OleDb.OleDbCommand = ConnectOle.CreateCommand
                db_cmd.CommandText = "SELECT  * FROM " & PasswordTable

                Dim db_read As OleDbDataReader = db_cmd.ExecuteReader
                Dim i As Integer = 0
                While db_read.Read()
                    ReDim Preserve UserLogin(i + 1)
                    UserLogin(i) = db_read("User") & ""
                    i = i + 1
                End While
                db_read.Close()

                db_cmd.CommandText = "SELECT Admin FROM " & PasswordTable
                db_read = db_cmd.ExecuteReader
                i = 0
                While db_read.Read()
                    ReDim Preserve AdminLogin(i + 1)
                    AdminLogin(i) = db_read("Admin") & ""
                    i = i + 1
                End While
                db_read.Close()

                db_cmd.CommandText = "SELECT Privileged FROM " & PasswordTable
                db_read = db_cmd.ExecuteReader
                i = 0
                While db_read.Read()
                    ReDim Preserve PrivilegedLogin(i + 1)
                    PrivilegedLogin(i) = db_read("Privileged") & ""
                    i = i + 1
                End While
                db_read.Close()
            End If

        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "ReadPasswordsDatabase Error")
        End Try

    End Sub

    '
    ''***********************************************
    Public Sub ReadTicketDatabase()

        Try
            If DatabaseExists = True Then
                Dim db_cmd As System.Data.OleDb.OleDbCommand = ConnectOle.CreateCommand
                db_cmd.CommandText = "SELECT  * FROM " & StdTicketTable

                Dim db_read As OleDbDataReader = db_cmd.ExecuteReader
                With ticket_data
                    'read from database
                    db_read.Read()
                    .adult_price = db_read("Adult")
                    .student_price = db_read("Student")
                    .senior_price = db_read("Senior")
                    .family_price = db_read("CSP_Family")
                    .comp_price = db_read("Comp")
                    .season_price = db_read("Season")
                    .military_price = db_read("Military")
                    .promo_price = db_read("Promo")
                    .discount_price = db_read("Discount")
                End With
                db_read.Close()
                db_cmd.CommandText = "SELECT  * FROM " & SpcTicketTable
                db_read = db_cmd.ExecuteReader

                special_ticket_data.Initialize()    'dot net needs an init call for arrays before use
                With special_ticket_data
                    'read from database
                    db_read.Read()
                    .sp_ticket(0).sp_ticket_name = db_read("SpTicket_1_Name") & ""
                    .sp_ticket(0).sp_ticket_value = db_read("SpTicket_1_Value")
                    .sp_ticket(0).sp_ticket_prepaid = db_read("SpTicket_1_PrePaid")
                    .sp_ticket(1).sp_ticket_name = db_read("SpTicket_2_Name") & ""
                    .sp_ticket(1).sp_ticket_value = db_read("SpTicket_2_Value")
                    .sp_ticket(1).sp_ticket_prepaid = db_read("SpTicket_2_PrePaid")
                    .sp_ticket(2).sp_ticket_name = db_read("SpTicket_3_Name") & ""
                    .sp_ticket(2).sp_ticket_value = db_read("SpTicket_3_Value")
                    .sp_ticket(2).sp_ticket_prepaid = db_read("SpTicket_3_PrePaid")
                    .sp_ticket(3).sp_ticket_name = db_read("SpTicket_4_Name") & ""
                    .sp_ticket(3).sp_ticket_value = db_read("SpTicket_4_Value")
                    .sp_ticket(3).sp_ticket_prepaid = db_read("SpTicket_4_PrePaid")
                    .sp_ticket(4).sp_ticket_name = db_read("SpTicket_5_Name") & ""
                    .sp_ticket(4).sp_ticket_value = db_read("SpTicket_5_Value")
                    .sp_ticket(4).sp_ticket_prepaid = db_read("SpTicket_5_PrePaid")
                    .sp_ticket(5).sp_ticket_name = db_read("SpTicket_6_Name") & ""
                    .sp_ticket(5).sp_ticket_value = db_read("SpTicket_6_Value")
                    .sp_ticket(5).sp_ticket_prepaid = db_read("SpTicket_5_PrePaid")
                    .sp_ticket(6).sp_ticket_name = db_read("SpTicket_7_Name") & ""
                    .sp_ticket(6).sp_ticket_value = db_read("SpTicket_7_Value")
                    .sp_ticket(6).sp_ticket_prepaid = db_read("SpTicket_7_PrePaid")
                    .sp_ticket(7).sp_ticket_name = db_read("SpTicket_8_Name") & ""
                    .sp_ticket(7).sp_ticket_value = db_read("SpTicket_8_Value")
                    .sp_ticket(7).sp_ticket_prepaid = db_read("SpTicket_8_PrePaid")
                End With
                db_read.Close()
                'get list of show names
                db_cmd.CommandText = "SELECT ShowName FROM " & ShowNamesTable
                db_read = db_cmd.ExecuteReader
                Dim j As Integer = 0
                Dim tmp_str As String
                Current_Shows_Count = 0
                While db_read.Read()
                    tmp_str = db_read("ShowName") & ""
                    Current_Shows_Count = Current_Shows_Count + 1
                    If Current_Shows_Count > MAX_SHOW_LIST_NUMBER Then 'only get MAX shows, so rotate and clear last spot
                        Current_Shows_Count = MAX_SHOW_LIST_NUMBER
                        For j = 0 To MAX_SHOW_LIST_NUMBER - 2   'move last strings up
                            Current_Shows(j) = Current_Shows(j + 1)
                        Next
                        Current_Shows(MAX_SHOW_LIST_NUMBER - 1) = tmp_str   'add newest show in oldest slot
                    Else
                        Current_Shows(Current_Shows_Count - 1) = tmp_str    'zero indexed
                    End If
                End While
                db_read.Close()
                db_cmd.CommandText = "SELECT CurrentShow FROM " & ShowNamesTable
                db_read = db_cmd.ExecuteReader
                db_read.Read()
                Current_Show_Name = db_read("CurrentShow") & ""
                db_read.Close()
            Else
                MsgBox("Could not read database. File not found.", MsgBoxStyle.OkOnly, "Read Database Error")
            End If

        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "ReadTicketDatabase Error")
        End Try

    End Sub

    ''***********************************************
    Public Function WriteTicketDatabase() As Boolean

        Try
            If DatabaseExists = True Then
                'setup database pointers
                Dim db_cmd As System.Data.OleDb.OleDbCommand = ConnectOle.CreateCommand

                With ticket_data
                    'write to database
                    db_cmd.CommandText = "UPDATE " & StdTicketTable & _
                    " SET [Adult] = " & .adult_price & "," & _
                    " [Student] = " & .student_price & "," & _
                    " [Senior] = " & .senior_price & "," & _
                    " [CSP_Family] = " & .family_price & "," & _
                    " [Comp] = " & .comp_price & "," & _
                    " [Season] = " & .season_price & "," & _
                    " [Military] = " & .military_price & "," & _
                    " [Promo] = " & .promo_price & "," & _
                    " [Discount] = " & .discount_price & " "
                    db_cmd.ExecuteNonQuery()
                End With

                With special_ticket_data
                    'write to database
                    db_cmd.CommandText = "UPDATE " & SpcTicketTable & _
                    " SET [SpTicket_1_Name] = '" & .sp_ticket(0).sp_ticket_name & "' ," & _
                    " [SpTicket_1_Value] = " & .sp_ticket(0).sp_ticket_value & "," & _
                    " [SpTicket_2_Name] = '" & .sp_ticket(1).sp_ticket_name & "' ," & _
                    " [SpTicket_2_Value] = " & .sp_ticket(1).sp_ticket_value & "," & _
                    " [SpTicket_3_Name] = '" & .sp_ticket(2).sp_ticket_name & "' ," & _
                    " [SpTicket_3_Value] = " & .sp_ticket(2).sp_ticket_value & "," & _
                    " [SpTicket_4_Name] = '" & .sp_ticket(3).sp_ticket_name & "' ," & _
                    " [SpTicket_4_Value] = " & .sp_ticket(3).sp_ticket_value & "," & _
                    " [SpTicket_5_Name] = '" & .sp_ticket(4).sp_ticket_name & "' ," & _
                    " [SpTicket_5_Value] = " & .sp_ticket(4).sp_ticket_value & "," & _
                    " [SpTicket_6_Name] = '" & .sp_ticket(5).sp_ticket_name & "' ," & _
                    " [SpTicket_6_Value] = " & .sp_ticket(5).sp_ticket_value & "," & _
                    " [SpTicket_7_Name] = '" & .sp_ticket(6).sp_ticket_name & "' ," & _
                    " [SpTicket_7_Value] = " & .sp_ticket(6).sp_ticket_value & "," & _
                    " [SpTicket_8_Name] = '" & .sp_ticket(7).sp_ticket_name & "' ," & _
                    " [SpTicket_8_Value] = " & .sp_ticket(7).sp_ticket_value & "," & _
                    " [SpTicket_1_PrePaid] = " & .sp_ticket(0).sp_ticket_prepaid & "," & _
                    " [SpTicket_2_PrePaid] = " & .sp_ticket(1).sp_ticket_prepaid & "," & _
                    " [SpTicket_3_PrePaid] = " & .sp_ticket(2).sp_ticket_prepaid & "," & _
                    " [SpTicket_4_PrePaid] = " & .sp_ticket(3).sp_ticket_prepaid & "," & _
                    " [SpTicket_5_PrePaid] = " & .sp_ticket(4).sp_ticket_prepaid & "," & _
                    " [SpTicket_6_PrePaid] = " & .sp_ticket(5).sp_ticket_prepaid & "," & _
                    " [SpTicket_7_PrePaid] = " & .sp_ticket(6).sp_ticket_prepaid & "," & _
                    " [SpTicket_8_PrePaid] = " & .sp_ticket(7).sp_ticket_prepaid & " "
                    db_cmd.ExecuteNonQuery()
                End With
                'write new show name if added
                If Add_Show_Pending Then
                    db_cmd.CommandText = "INSERT INTO " & ShowNamesTable & " (ShowName) Values ('" & Add_Show_Text & "')"
                    db_cmd.ExecuteNonQuery()
                    Add_Show_Pending = False
                End If
                'update current show
                db_cmd.CommandText = "UPDATE " & ShowNamesTable & " SET [CurrentShow] = '" & Current_Show_Name & "'"
                db_cmd.ExecuteNonQuery()
                WriteTicketDatabase = True
            Else
                MsgBox("Could not save to database. File not found.", MsgBoxStyle.OkOnly, "Write Database Error")
            End If

        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "Write Database Error")
            WriteTicketDatabase = False
        End Try

    End Function

    ''***********************************************
    Public Sub CloseDbSystem()

        Try
            'NOTE: Object dbMaster may not be destroyed until it is garbage collected. 
            ConnectOle.Close()
            ConnectOle.Dispose()

        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "Database Close Error")
        End Try

    End Sub

    ''***********************************************
    ' ticket count and ticket cost and name of special tickets and date  
    Public Function WriteSaleData() As Boolean

        Try
            'setup database pointers
            Dim db_cmd As System.Data.OleDb.OleDbCommand = ConnectOle.CreateCommand

            With receipt
                'write to database
                db_cmd.CommandText = "INSERT INTO " & SalesTable & _
                " (AdultCount, AdultCurrency, StudentCount, StudentCurrency," & _
                " SeasonCount, SeasonCurrency, SeniorCount, SeniorCurrency," & _
                " CSP_FamilyCount, CSP_FamilyCurrency, CompCount, CompCurrency," & _
                " MilitaryCount, MilitaryCurrency, PromoCount, PromoCurrency," & _
                " DiscountCount, DiscountCurrency," & _
                " SpTicket_1Currency, SpTicket_1Count, SpTicket_1Name, SpTicket_2Currency, SpTicket_2Count, SpTicket_2Name," & _
                " SpTicket_3Currency, SpTicket_3Count, SpTicket_3Name, SpTicket_4Currency, SpTicket_4Count, SpTicket_4Name," & _
                " SpTicket_5Currency, SpTicket_5Count, SpTicket_5Name, SpTicket_6Currency, SpTicket_6Count, SpTicket_6Name," & _
                " SpTicket_7Currency, SpTicket_7Count, SpTicket_7Name, SpTicket_8Currency, SpTicket_8Count, SpTicket_8Name," & _
                " ShowName, SaleDate)" & _
                " Values (" & _
                .adult_cnt & "," & .adult_cost & "," & .student_cnt & "," & .student_cost & "," & .season_cnt & "," & _
                .season_cost & "," & .senior_cnt & "," & .senior_cost & "," & .family_cnt & "," & .family_cost & "," & _
                .comp_cnt & "," & .comp_cost & "," & .military_cnt & "," & .military_cost & "," & .promo_cnt & "," & _
                .promo_cost & "," & .discount_cnt & "," & .discount_cost & "," & _
                .special_cost_1 & "," & .special_cnt_1 & ", '" & special_ticket_data.sp_ticket(0).sp_ticket_name & "', " & _
                .special_cost_2 & "," & .special_cnt_2 & ", '" & special_ticket_data.sp_ticket(1).sp_ticket_name & "', " & _
                .special_cost_3 & "," & .special_cnt_3 & ", '" & special_ticket_data.sp_ticket(2).sp_ticket_name & "', " & _
                .special_cost_4 & "," & .special_cnt_4 & ", '" & special_ticket_data.sp_ticket(3).sp_ticket_name & "', " & _
                .special_cost_5 & "," & .special_cnt_5 & ", '" & special_ticket_data.sp_ticket(4).sp_ticket_name & "', " & _
                .special_cost_6 & "," & .special_cnt_6 & ", '" & special_ticket_data.sp_ticket(5).sp_ticket_name & "', " & _
                .special_cost_7 & "," & .special_cnt_7 & ", '" & special_ticket_data.sp_ticket(6).sp_ticket_name & "', " & _
                .special_cost_8 & "," & .special_cnt_8 & ", '" & special_ticket_data.sp_ticket(7).sp_ticket_name & "', " & _
                "'" & Current_Show_Name & "'" & "," & "'" & System.DateTime.Now & "')"
                db_cmd.ExecuteNonQuery()
                WriteSaleData = True
            End With

        Catch err As Exception
            WriteSaleData = False
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "WriteSaleData Error")
        End Try

    End Function

    '***********************************************
    Public Sub GetDbPath()
        TicketingDatabase = GetSetting(MyAppName, "Database", "DbPath", My.Application.Info.DirectoryPath & DbFile)
        'TicketingDatabase = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\dj Software\" & MyAppName & "\Database", "DbPath", My.Application.Info.DirectoryPath & DbFile)
    End Sub

    ''***********************************************
    Public Sub SaveDbPath()
        SaveSetting(MyAppName, "Database", "DbPath", TicketingDatabase)
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\dj Software\" & MyAppName & "\Database", "DbPath", My.Application.Info.DirectoryPath & DbFile)
    End Sub
    '
    ''***********************************************
    Public Sub GetPathFromUser()
        Dim openFileDialog1 As New OpenFileDialog()

        Try
            With FrmMain
                openFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath
                openFileDialog1.Title = "Find CSP Ticketing Database"
                openFileDialog1.FileName = "CSP_TicketDB.mdb"
                openFileDialog1.DefaultExt = "accdb"
                openFileDialog1.Filter = "Database Files (*.accdb)|*.accdb"
                openFileDialog1.Multiselect = False
                'openFileDialog1.Flags = MSComDlg.FileOpenConstants.cdlOFNShareAware
                'openFileDialog1.CancelError = True
                If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    TicketingDatabase = openFileDialog1.FileName
                Else
                    TicketingDatabase = Missing_database
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GetPathFromUser Error")
        End Try

    End Sub
    '
End Module