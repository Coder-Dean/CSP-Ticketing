Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmMain
	Inherits System.Windows.Forms.Form

    'variables for verification report
    Dim current_total_money As Decimal
    Dim current_total_count As Integer
    Dim online_total_money As Decimal
    Dim online_total_count As Integer

	
    Private Sub FrmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'If Screen.PrimaryScreen.Bounds.Width < 1200 AndAlso Screen.PrimaryScreen.Bounds.Height < 800 Then Me.Size = New Size(1200, Height)

        DatabaseExists = FindDatabase()
        ReadTicketDatabase()
        ReadPasswordsDatabase()
        ReadTicketPrices()
        ReadSpecialTicket()
        lblShowTitle.Text = "Current Show: " & Current_Show_Name
        WriteTicketHeader()
        HandleSpecialTickets()

    End Sub
	
	Private Sub cmdAdultTck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdultTck.Click
		receipt.adult_cnt = receipt.adult_cnt + 1
        receipt.adult_cost = receipt.adult_cnt * ticket_data.adult_price
        txtAdultCnt.Text = CStr(receipt.adult_cnt)
    End Sub
	
	
	Private Sub cmdCompTck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCompTck.Click
		receipt.comp_cnt = receipt.comp_cnt + 1
		receipt.comp_cost = receipt.adult_cnt * ticket_data.comp_price
        txtCompCnt.Text = CStr(receipt.comp_cnt)
	End Sub
	
	Private Sub cmdCSPTck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCSPTck.Click
		receipt.family_cnt = receipt.family_cnt + 1
		receipt.family_cost = receipt.family_cnt * ticket_data.family_price
        txtFamilyCnt.Text = CStr(receipt.family_cnt)
	End Sub
	
	Private Sub cmdMilitaryTck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMilitaryTck.Click
		receipt.military_cnt = receipt.military_cnt + 1
		receipt.military_cost = receipt.military_cnt * ticket_data.military_price
        txtMilitaryCnt.Text = CStr(receipt.military_cnt)
	End Sub
	
	Private Sub cmdPromoTck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPromoTck.Click
		receipt.promo_cnt = receipt.promo_cnt + 1
		receipt.promo_cost = receipt.promo_cnt * ticket_data.promo_price
        txtPromoCnt.Text = CStr(receipt.promo_cnt)
	End Sub
	
	Private Sub cmdSeasonTck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSeasonTck.Click
		receipt.season_cnt = receipt.season_cnt + 1
		receipt.season_cost = receipt.season_cnt * ticket_data.season_price
        txtSeasonCnt.Text = CStr(receipt.season_cnt)
	End Sub
	
	Private Sub cmdSeniorTck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSeniorTck.Click
		receipt.senior_cnt = receipt.senior_cnt + 1
		receipt.senior_cost = receipt.senior_cnt * ticket_data.senior_price
        txtSeniorCnt.Text = CStr(receipt.senior_cnt)
	End Sub
	
	Private Sub cmdStudentTck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStudentTck.Click
		receipt.student_cnt = receipt.student_cnt + 1
		receipt.student_cost = receipt.student_cnt * ticket_data.student_price
        txtStudentCnt.Text = CStr(receipt.student_cnt)
	End Sub
	
	Private Sub cmdDiscount_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDiscount.Click
		receipt.discount_cnt = receipt.discount_cnt + 1
		receipt.discount_cost = receipt.discount_cnt * ticket_data.discount_price
        txtDiscountCnt.Text = CStr(receipt.discount_cnt)
	End Sub

    Private Sub cmdN1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdN1.Click
        Dim index As Short = cmdN1.GetIndex(eventSender)
        Dim fd_cnt As Integer = txtN1(index).Text
        Dim sp_cost As Decimal

        'update special ticket fields
        txtN1(index).Text = CStr(fd_cnt + 1)
        sp_cost = special_ticket_data.sp_ticket(index).sp_ticket_value
        Select Case index
            Case 0
                receipt.special_cnt_1 = receipt.special_cnt_1 + 1
                receipt.special_cost_1 = receipt.special_cost_1 + sp_cost
            Case 1
                receipt.special_cnt_2 = receipt.special_cnt_2 + 1
                receipt.special_cost_2 = receipt.special_cost_2 + sp_cost
            Case 2
                receipt.special_cnt_3 = receipt.special_cnt_3 + 1
                receipt.special_cost_3 = receipt.special_cost_3 + sp_cost
            Case 3
                receipt.special_cnt_4 = receipt.special_cnt_4 + 1
                receipt.special_cost_4 = receipt.special_cost_4 + sp_cost
            Case 4
                receipt.special_cnt_5 = receipt.special_cnt_5 + 1
                receipt.special_cost_5 = receipt.special_cost_5 + sp_cost
            Case 5
                receipt.special_cnt_6 = receipt.special_cnt_6 + 1
                receipt.special_cost_6 = receipt.special_cost_6 + sp_cost
            Case 6
                receipt.special_cnt_7 = receipt.special_cnt_7 + 1
                receipt.special_cost_7 = receipt.special_cost_7 + sp_cost
            Case 7
                receipt.special_cnt_8 = receipt.special_cnt_8 + 1
                receipt.special_cost_8 = receipt.special_cost_8 + sp_cost
        End Select

    End Sub

    Private Sub btnCalculate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCalculate.Click

        UpdateSales()
        If current_total_count = 0 Then
            Return  'don't bother if no tickets
        End If
        'check for season tickets or comps and if we have either skip the transaction request.
        'for season tickets put the money into TRANSACTION_OTHER because there is no money handled at BO window
        'else ask BO person what type of transaction this is.
        If receipt.season_cnt = current_total_count Or receipt.comp_cnt = current_total_count Then
            transactionOk = True
            transactionType = TRANSACTION_OTHER
        Else
            frmTypeSelect.ShowDialog()
        End If
        If transactionOk = True Then
            With total_transaction
                Select Case transactionType
                    Case TRANSACTION_CASH
                        .cash_cnt = .cash_cnt + current_total_count - receipt.comp_cnt - receipt.season_cnt
                        .cash_monies = .cash_monies + current_total_money - receipt.season_cost
                    Case TRANSACTION_CHECK
                        .check_cnt = .check_cnt + current_total_count - receipt.comp_cnt - receipt.season_cnt
                        .check_monies = .check_monies + current_total_money - receipt.season_cost
                    Case TRANSACTION_CREDIT
                        .credit_cnt = .credit_cnt + current_total_count - receipt.comp_cnt - receipt.season_cnt
                        .credit_monies = .credit_monies + current_total_money - receipt.season_cost
                    Case TRANSACTION_ONLINE
                        .online_cnt = .online_cnt + online_total_count - receipt.comp_cnt - receipt.season_cnt
                        .online_monies = .online_monies + online_total_money - receipt.season_cost
                    Case TRANSACTION_OTHER
                        .other_cnt = .other_cnt + current_total_count
                        .other_monies = .other_monies + current_total_money
                    Case TRANSACTION_NONE
                        'take no action if we ever get here
                End Select
            End With
        End If

    End Sub

    Private Sub btnClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClear.Click
        With receipt
            .adult_cnt = 0
            .adult_cost = 0
            .comp_cnt = 0
            .comp_cost = 0
            .family_cnt = 0
            .family_cost = 0
            .military_cnt = 0
            .military_cost = 0
            .promo_cnt = 0
            .promo_cost = 0
            .season_cnt = 0
            .season_cost = 0
            .senior_cnt = 0
            .senior_cost = 0
            .student_cnt = 0
            .student_cost = 0
            .discount_cnt = 0
            .discount_cost = 0
            .special_cnt_1 = 0
            .special_cost_1 = 0
            .special_cnt_2 = 0
            .special_cost_2 = 0
            .special_cnt_3 = 0
            .special_cost_3 = 0
            .special_cnt_4 = 0
            .special_cost_4 = 0
            .special_cnt_5 = 0
            .special_cost_5 = 0
            .special_cnt_6 = 0
            .special_cost_6 = 0
            .special_cnt_7 = 0
            .special_cost_7 = 0
            .special_cnt_8 = 0
            .special_cost_8 = 0
        End With
        'clear all special boxes
        Dim i As Integer
        For i = 0 To 7
            txtN1(i).Text = "0"
        Next
        UpdateTicketCount()
        UpdateSales()

    End Sub

    Private Sub btnSaveData_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSaveData.Click
        'move to total field in grid
        MSFlexGrid1.Row = 12
        MSFlexGrid1.Col = 1
        'don't save into database if there's no tickets
        If MSFlexGrid1.Text <> "" And MSFlexGrid1.Text <> "0" Then
            If WriteSaleData() = True Then
                SumSalesData()
                lblSaved.Visible = True
            End If
        End If
        btnClear_Click(btnClear, New System.EventArgs())

    End Sub

    Private Sub btnSaveData_LostFocus(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSaveData.LostFocus
        'hide label when anything else is clicked
        lblSaved.Visible = False
    End Sub

    Public Sub mnuAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbout.Click
        VB6.ShowForm(frmAbout, VB6.FormShowConstants.Modeless, Me)
    End Sub

    'clear count values
    Private Sub ResetCount_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ResetCount.Click
        Dim index As Short = ResetCount.GetIndex(eventSender)
        Select Case index
            Case 0
                receipt.adult_cnt = -1
                cmdAdultTck_Click(cmdAdultTck, New System.EventArgs())
            Case 1
                receipt.student_cnt = -1
                cmdStudentTck_Click(cmdStudentTck, New System.EventArgs())
            Case 2
                receipt.senior_cnt = -1
                cmdSeniorTck_Click(cmdSeniorTck, New System.EventArgs())
            Case 3
                receipt.family_cnt = -1
                cmdCSPTck_Click(cmdCSPTck, New System.EventArgs())
            Case 4
                receipt.comp_cnt = -1
                cmdCompTck_Click(cmdCompTck, New System.EventArgs())
            Case 5
                receipt.season_cnt = -1
                cmdSeasonTck_Click(cmdSeasonTck, New System.EventArgs())
            Case 6
                receipt.military_cnt = -1
                cmdMilitaryTck_Click(cmdMilitaryTck, New System.EventArgs())
            Case 7
                receipt.promo_cnt = -1
                cmdPromoTck_Click(cmdPromoTck, New System.EventArgs())
            Case 8
                receipt.discount_cnt = -1
                cmdDiscount_Click(cmdDiscount, New System.EventArgs())
            Case 9
                txtN1(0).Text = "0"
                receipt.special_cnt_1 = 0
                receipt.special_cost_1 = 0
            Case 10
                txtN1(1).Text = "0"
                receipt.special_cnt_2 = 0
                receipt.special_cost_2 = 0
            Case 11
                txtN1(2).Text = "0"
                receipt.special_cnt_3 = 0
                receipt.special_cost_3 = 0

            Case 12
                txtN1(3).Text = "0"
                receipt.special_cnt_4 = 0
                receipt.special_cost_4 = 0
            Case 13
                txtN1(4).Text = "0"
                receipt.special_cnt_5 = 0
                receipt.special_cost_5 = 0
            Case 14
                txtN1(5).Text = "0"
                receipt.special_cnt_6 = 0
                receipt.special_cost_6 = 0
            Case 15
                txtN1(6).Text = "0"
                receipt.special_cnt_7 = 0
                receipt.special_cost_7 = 0
            Case 16
                txtN1(7).Text = "0"
                receipt.special_cnt_8 = 0
                receipt.special_cost_8 = 0
        End Select

    End Sub


    Private Sub UpdateTicketCount()
        With receipt
            txtAdultCnt.Text = CStr(.adult_cnt)
            txtStudentCnt.Text = CStr(.student_cnt)
            txtSeniorCnt.Text = CStr(.senior_cnt)
            txtFamilyCnt.Text = CStr(.family_cnt)
            txtCompCnt.Text = CStr(.comp_cnt)
            txtSeasonCnt.Text = CStr(.season_cnt)
            txtMilitaryCnt.Text = CStr(.military_cnt)
            txtPromoCnt.Text = CStr(.promo_cnt)
            txtDiscountCnt.Text = CStr(.discount_cnt)
        End With
    End Sub

    Private Sub UpdateSales()
        Dim sp_cost As Decimal
        Dim sp_cnt As Short

        current_total_money = 0 'reset global current sales
        current_total_count = 0
        'reset global online sales 
        online_total_money = 0D
        online_total_count = 0

        With receipt
            MSFlexGrid1.Row = 1
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.adult_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.Text = FormatCurrency(.adult_cost, 2)
            MSFlexGrid1.Row = 2
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.student_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.Text = FormatCurrency(.student_cost, 2)
            MSFlexGrid1.Row = 3
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.senior_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.Text = FormatCurrency(.senior_cost, 2)
            MSFlexGrid1.Row = 4
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.family_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.Text = FormatCurrency(.family_cost, 2)
            MSFlexGrid1.Row = 5
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.comp_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.CellForeColor = System.Drawing.Color.Blue   'no charge 
            MSFlexGrid1.Text = FormatCurrency(.comp_cost, 2)
            MSFlexGrid1.Row = 6
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.season_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.CellForeColor = System.Drawing.Color.Blue
            MSFlexGrid1.Text = FormatCurrency(0, 2) 'no charge for Season at B.O.
            MSFlexGrid1.Row = 7
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.military_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.Text = FormatCurrency(.military_cost, 2)
            MSFlexGrid1.Row = 8
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.promo_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.Text = FormatCurrency(.promo_cost, 2)
            MSFlexGrid1.Row = 9
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(.discount_cnt)
            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.Text = FormatCurrency(.discount_cost, 2, TriState.True, TriState.False)
            If .discount_cost < 0 Then
                MSFlexGrid1.CellForeColor = System.Drawing.Color.Red
            Else
                MSFlexGrid1.CellForeColor = System.Drawing.Color.Black
            End If
            sp_cnt = .special_cnt_1 + .special_cnt_2 + .special_cnt_3 + .special_cnt_4 + .special_cnt_5 + .special_cnt_6 + .special_cnt_7 + .special_cnt_8
            MSFlexGrid1.Row = 10
            MSFlexGrid1.Col = 1
            MSFlexGrid1.Text = CStr(sp_cnt)
            'if ticket is pre-paid then the cost at B.O. is zero, so only add if not pre-paid but
            'in case special tickets are on-line add now for verification report
            sp_cost = 0
            If special_ticket_data.sp_ticket(0).sp_ticket_prepaid = False Then
                sp_cost = sp_cost + .special_cost_1
            Else
                online_total_money = online_total_money + .special_cost_1
                online_total_count = online_total_count + .special_cnt_1
            End If

            If special_ticket_data.sp_ticket(1).sp_ticket_prepaid = False Then
                sp_cost = sp_cost + .special_cost_2
            Else
                online_total_money = online_total_money + .special_cost_2
                online_total_count = online_total_count + .special_cnt_2
            End If

            If special_ticket_data.sp_ticket(2).sp_ticket_prepaid = False Then
                sp_cost = sp_cost + .special_cost_3
            Else
                online_total_money = online_total_money + .special_cost_3
                online_total_count = online_total_count + .special_cnt_3
            End If

            If special_ticket_data.sp_ticket(3).sp_ticket_prepaid = False Then
                sp_cost = sp_cost + .special_cost_4
            Else
                online_total_money = online_total_money + .special_cost_4
                online_total_count = online_total_count + .special_cnt_4
            End If

            If special_ticket_data.sp_ticket(4).sp_ticket_prepaid = False Then
                sp_cost = sp_cost + .special_cost_5
            Else
                online_total_money = online_total_money + .special_cost_5
                online_total_count = online_total_count + .special_cnt_5
            End If

            If special_ticket_data.sp_ticket(5).sp_ticket_prepaid = False Then
                sp_cost = sp_cost + .special_cost_6
            Else
                online_total_money = online_total_money + .special_cost_6
                online_total_count = online_total_count + .special_cnt_6
            End If

            If special_ticket_data.sp_ticket(6).sp_ticket_prepaid = False Then
                sp_cost = sp_cost + .special_cost_7
            Else
                online_total_money = online_total_money + .special_cost_7
                online_total_count = online_total_count + .special_cnt_7
            End If

            If special_ticket_data.sp_ticket(7).sp_ticket_prepaid = False Then
                sp_cost = sp_cost + .special_cost_8
            Else
                online_total_money = online_total_money + .special_cost_8
                online_total_count = online_total_count + .special_cnt_8
            End If



            MSFlexGrid1.Col = 2
            MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
            MSFlexGrid1.Text = FormatCurrency(sp_cost, 2, TriState.True, TriState.False)

            current_total_money = .adult_cost + .comp_cost + .family_cost + .military_cost + .promo_cost + .season_cost + .senior_cost + .student_cost + .discount_cost + sp_cost
            current_total_count = .adult_cnt + .comp_cnt + .family_cnt + .military_cnt + .promo_cnt + .season_cnt + .senior_cnt + .student_cnt + .discount_cnt + sp_cnt
        End With

        MSFlexGrid1.Row = 12
        MSFlexGrid1.CellAlignment = MSFlexGridLib.AlignmentSettings.flexAlignRightCenter
        MSFlexGrid1.Text = FormatCurrency(current_total_money - receipt.season_cost, 2) 'remove season ticket cost for display on reciept because tickets are pre-paid
        MSFlexGrid1.Col = 1
        MSFlexGrid1.Text = CStr(current_total_count)


    End Sub

    Public Sub ReadTicketPrices()

        With ticket_data
            If Not DatabaseExists Then
                'use dummy values
                .adult_price = 10.0
                .student_price = 13.0#
                .senior_price = 13.0#
                .family_price = 10.0#
                .comp_price = 0.0#
                .season_price = 9.9
                .military_price = 13.0#
                .promo_price = 10.0#
                .discount_price = -2.0#
            End If
        End With

    End Sub

    Public Sub ReadSpecialTicket()
        Dim i As Short

        With special_ticket_data
            If Not DatabaseExists Then
                'use dummy values
                For i = 0 To 7
                    .sp_ticket(i).sp_ticket_name = "_SpecialTheatre"
                    .sp_ticket(i).sp_ticket_value = 11.0#
                Next
            End If
        End With

    End Sub

    'create receipt in grid
    Public Sub WriteTicketHeader()

        MSFlexGrid1.set_ColWidth(0, 3000)
        MSFlexGrid1.set_ColWidth(1, 850)
        MSFlexGrid1.set_ColWidth(2, 1650)

        MSFlexGrid1.Row = 0
        MSFlexGrid1.Col = 0
        MSFlexGrid1.Text = "Items"
        MSFlexGrid1.Col = 1
        MSFlexGrid1.Text = "Num"
        MSFlexGrid1.Col = 2
        MSFlexGrid1.Text = "Cost"
        MSFlexGrid1.Col = 0
        MSFlexGrid1.Row = 1
        MSFlexGrid1.Text = "Adult Total"
        MSFlexGrid1.Row = 2
        MSFlexGrid1.Text = "Student Total"
        MSFlexGrid1.Row = 3
        MSFlexGrid1.Text = "Senior Total"
        MSFlexGrid1.Row = 4
        MSFlexGrid1.Text = "CSP Family Total"
        MSFlexGrid1.Row = 5
        MSFlexGrid1.Text = "Comp Total"
        MSFlexGrid1.Row = 6
        MSFlexGrid1.Text = "Season Total"
        MSFlexGrid1.Row = 7
        MSFlexGrid1.Text = "Military Total"
        MSFlexGrid1.Row = 8
        MSFlexGrid1.Text = "Promotion Total"
        MSFlexGrid1.Row = 9
        MSFlexGrid1.Text = "Discount Total"
        MSFlexGrid1.Row = 10
        MSFlexGrid1.Text = "Special Total"
        MSFlexGrid1.Row = 12
        MSFlexGrid1.Text = "Sales Total"

        MSFlexGrid1.Col = 2
        MSFlexGrid1.Row = 11
        MSFlexGrid1.Text = "----------"


    End Sub

    'Check database and put in special names if needed else put in dashes and de-select
    Public Sub HandleSpecialTickets()
        Dim i As Short
        Dim str_tmp As String

        For i = 0 To 7
            str_tmp = special_ticket_data.sp_ticket(i).sp_ticket_name
            cmdN1(i).Text = str_tmp
            If str_tmp = "" Then
                cmdN1(i).Enabled = False
            Else
                cmdN1(i).Enabled = True
            End If
        Next
    End Sub

    ''***********************************************
    ' keep running tally of ticket count and ticket cost   
    Public Function SumSalesData() As Boolean

        Try
            With daily_receipt
                .adult_cnt = .adult_cnt + receipt.adult_cnt
                .adult_cost = .adult_cost + receipt.adult_cost
                .comp_cnt = .comp_cnt + receipt.comp_cnt
                .comp_cost = .comp_cost + receipt.comp_cost
                .discount_cnt = .discount_cnt + receipt.discount_cnt
                .discount_cost = .discount_cost + receipt.discount_cost
                .family_cnt = .family_cnt + receipt.family_cnt
                .family_cost = .family_cost + receipt.family_cost
                .military_cnt = .military_cnt + receipt.military_cnt
                .military_cost = .military_cost + receipt.military_cost
                .promo_cnt = .promo_cnt + receipt.promo_cnt
                .promo_cost = .promo_cost + receipt.promo_cost
                .season_cnt = .season_cnt + receipt.season_cnt
                .season_cost = .season_cost + receipt.season_cost
                .senior_cnt = .senior_cnt + receipt.senior_cnt
                .senior_cost = .senior_cost + receipt.senior_cost
                .student_cnt = .student_cnt + receipt.student_cnt
                .student_cost = .student_cost + receipt.student_cost
                .special_cnt_1 = .special_cnt_1 + receipt.special_cnt_1
                .special_cnt_2 = .special_cnt_2 + receipt.special_cnt_2
                .special_cnt_3 = .special_cnt_3 + receipt.special_cnt_3
                .special_cnt_4 = .special_cnt_4 + receipt.special_cnt_4
                .special_cnt_5 = .special_cnt_5 + receipt.special_cnt_5
                .special_cnt_6 = .special_cnt_6 + receipt.special_cnt_6
                .special_cnt_7 = .special_cnt_7 + receipt.special_cnt_7
                .special_cnt_8 = .special_cnt_8 + receipt.special_cnt_8
                .special_cost_1 = .special_cost_1 + receipt.special_cost_1
                .special_cost_2 = .special_cost_2 + receipt.special_cost_2
                .special_cost_3 = .special_cost_3 + receipt.special_cost_3
                .special_cost_4 = .special_cost_4 + receipt.special_cost_4
                .special_cost_5 = .special_cost_5 + receipt.special_cost_5
                .special_cost_6 = .special_cost_6 + receipt.special_cost_6
                .special_cost_7 = .special_cost_7 + receipt.special_cost_7
                .special_cost_8 = .special_cost_8 + receipt.special_cost_8
                SumSalesData = True
            End With

        Catch err As Exception
            SumSalesData = False
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "SumSalesData Error")
        End Try

    End Function

    Private Sub ClearTransactionHistory()
        With total_transaction
            .cash_cnt = 0
            .cash_monies = 0D
            .check_cnt = 0
            .check_monies = 0D
            .credit_cnt = 0
            .credit_monies = 0D
            .online_cnt = 0
            .online_monies = 0D
            .other_cnt = 0
            .other_monies = 0D
        End With
    End Sub

    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub mnuEdit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEdit.Click
        frmLogin.ShowDialog()
        'check if ok
        If passwordOk = True Or cancel_clicked = False Then
            frmTickets.Show()
        End If
    End Sub

    Public Sub mnuExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExit.Click
        btnExit_Click(btnExit, New System.EventArgs())
    End Sub

   
    Private Sub btnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click
        If CreateExcelSheet() = True Then   'continue if ok
            WriteFOH_Info()
            SaveFOHReport()
            PrintFOHReport()
            CloseReleaseExcel()
            ClearTransactionHistory()
        End If
    End Sub


End Class