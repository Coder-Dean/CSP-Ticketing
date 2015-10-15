Option Strict Off
Option Explicit On
'UPGRADE_NOTE: Globals was upgraded to Globals_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
Module Globals_Renamed

    Public MyAppName As String = "CSP_Ticketing"

    Public Structure transaction_info
        Dim adult_cnt As Short
        Dim adult_cost As Decimal
        Dim student_cnt As Short
        Dim student_cost As Decimal
        Dim senior_cnt As Short
        Dim senior_cost As Decimal
        Dim family_cnt As Short
        Dim family_cost As Decimal
        Dim comp_cnt As Short
        Dim comp_cost As Decimal
        Dim season_cnt As Short
        Dim season_cost As Decimal
        Dim military_cnt As Short
        Dim military_cost As Decimal
        Dim promo_cnt As Short
        Dim promo_cost As Decimal
        Dim discount_cnt As Short
        Dim discount_cost As Decimal
        Dim special_cnt_1 As Short
        Dim special_cost_1 As Decimal
        Dim special_cnt_2 As Short
        Dim special_cost_2 As Decimal
        Dim special_cnt_3 As Short
        Dim special_cost_3 As Decimal
        Dim special_cnt_4 As Short
        Dim special_cost_4 As Decimal
        Dim special_cnt_5 As Short
        Dim special_cost_5 As Decimal
        Dim special_cnt_6 As Short
        Dim special_cost_6 As Decimal
        Dim special_cnt_7 As Short
        Dim special_cost_7 As Decimal
        Dim special_cnt_8 As Short
        Dim special_cost_8 As Decimal
    End Structure

    Public receipt As transaction_info

    Public daily_receipt As transaction_info


    Public Structure ticket_db
        Dim adult_price As Decimal
        Dim student_price As Decimal
        Dim senior_price As Decimal
        Dim family_price As Decimal
        Dim comp_price As Decimal
        Dim season_price As Decimal
        Dim military_price As Decimal
        Dim promo_price As Decimal
        Dim discount_price As Decimal
        Dim special_t1 As Decimal
        Dim special_t2 As Decimal
        Dim special_t3 As Decimal
        Dim special_t4 As Decimal
        Dim special_t5 As Decimal
        Dim special_t6 As Decimal
        Dim special_t7 As Decimal
        Dim special_t8 As Decimal
    End Structure

    Public ticket_data As ticket_db

    Public Structure special_ticket_info
        Dim sp_ticket_name As String
        Dim sp_ticket_value As Decimal
        Dim sp_ticket_prepaid As Boolean
    End Structure

    Public Structure special_ticket_db
        Dim sp_ticket() As special_ticket_info

        ' "Initialize" must be called to initialize instances of this structure. 
        Public Sub Initialize()
            ReDim sp_ticket(7)
        End Sub
    End Structure

    ' special_ticket_data needs to be initialized before use
    Public special_ticket_data As special_ticket_db

    Public Const MAX_SHOW_LIST_NUMBER As Integer = 12   'only fetch number of last shows, 
    Public Current_Shows(MAX_SHOW_LIST_NUMBER - 1) As String    'zero indexed
    Public Current_Shows_Count As Integer
    Public Current_Show_Name As String
    Public Add_Show_Pending As Boolean
    Public Add_Show_Text As String = ""

    'items for password login
    Public passwordOk As Boolean
    Public user_name As String
    Public cancel_clicked As Boolean
    Public password_privilege As Integer
    Public AdminLogin() As String   'array of Admin password strings
    Public UserLogin() As String
    Public PrivilegedLogin() As String
    Public Const PRIVILEGE_NONE As Integer = 0
    Public Const PRIVILEGE_USER As Integer = 1
    Public Const PRIVILEGE_ADMIN As Integer = 2
    Public Const PRIVILEGE_SUPERUSER As Integer = 3

    'items for transaction totals
    Public Structure transactions
        Dim cash_cnt As Integer
        Dim cash_monies As Decimal
        Dim check_cnt As Integer
        Dim check_monies As Decimal
        Dim credit_cnt As Integer
        Dim credit_monies As Decimal
        Dim online_cnt As Integer
        Dim online_monies As Decimal
        Dim other_cnt As Integer
        Dim other_monies As Decimal
    End Structure

    Public total_transaction As transactions
    Public transactionOk As Boolean 'ok to use transaction data
    Public Const TRANSACTION_NONE As Integer = 0
    Public Const TRANSACTION_CASH As Integer = 1
    Public Const TRANSACTION_CHECK As Integer = 2
    Public Const TRANSACTION_CREDIT As Integer = 3
    Public Const TRANSACTION_ONLINE As Integer = 4
    Public Const TRANSACTION_OTHER As Integer = 5
    'flag for type of sales
    Public transactionType As Integer
    '
End Module