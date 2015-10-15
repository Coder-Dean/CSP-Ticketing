Option Strict Off
Option Explicit On


Friend Class frmTickets
	Inherits System.Windows.Forms.Form

    Private Sub frmTickets_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Me.Left = FrmMain.Left + 10
        Me.Top = FrmMain.Top + 10

        LoadTicketInfo() 'fill price textboxes
        'read last shows and put in reverse order so most current is at top
        Dim i As Integer = Current_Shows_Count - 1  'zero indexed
        While i >= 0
            cboShowNames.Items.Add(Current_Shows(i))
            i = i - 1
        End While
        cboShowNames.SelectedIndex = 0
        Select Case password_privilege
            Case PRIVILEGE_NONE
                btnSave.Enabled = False
                btnAddShow.Enabled = False
                Me.Text = "Box Office Options  - Edit Level: None"
            Case PRIVILEGE_USER
                btnSave.Enabled = False
                btnAddShow.Enabled = True
                Me.Text = "Box Office Options  - Edit Level: User"
            Case PRIVILEGE_ADMIN
                btnSave.Enabled = True
                btnAddShow.Enabled = True
                Me.Text = "Box Office Options  - Edit Level: Admin"
            Case PRIVILEGE_SUPERUSER
                btnSave.Enabled = True
                btnAddShow.Enabled = True
                Me.Text = "Box Office Options  - Edit Level: Superuser"
        End Select

    End Sub
	
	
    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
        Try
            Current_Show_Name = cboShowNames.SelectedItem.ToString()
            FrmMain.lblShowTitle.Text = "Current Show: " & Current_Show_Name
        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.OkOnly, "Read List Error")
        End Try

        Me.Close()
    End Sub
	
    Private Sub btnSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSave.Click
        Dim i As Short

        'save into memory
        With ticket_data
            .adult_price = CDec(txtAdult.Text)
            .student_price = CDec(txtStudent.Text)
            .senior_price = CDec(txtSenior.Text)
            .family_price = CDec(txtFamily.Text)
            .comp_price = CDec(txtComp.Text)
            .season_price = CDec(txtSeason.Text)
            .military_price = CDec(txtMilitary.Text)
            .promo_price = CDec(txtPromo.Text)
            .discount_price = CDec(txtDiscount.Text)
        End With
        With special_ticket_data
            For i = 0 To 7
                .sp_ticket(i).sp_ticket_name = txtTicketNameInput(i).Text
                .sp_ticket(i).sp_ticket_value = CDec(FormatCurrency(txtSpecialPrice(i).Text))
            Next
            .sp_ticket(0).sp_ticket_prepaid = ckPreSale1.Checked
            .sp_ticket(1).sp_ticket_prepaid = ckPreSale2.Checked
            .sp_ticket(2).sp_ticket_prepaid = ckPreSale3.Checked
            .sp_ticket(3).sp_ticket_prepaid = ckPreSale4.Checked
            .sp_ticket(4).sp_ticket_prepaid = ckPreSale5.Checked
            .sp_ticket(5).sp_ticket_prepaid = ckPreSale6.Checked
            .sp_ticket(6).sp_ticket_prepaid = ckPreSale7.Checked
            .sp_ticket(7).sp_ticket_prepaid = ckPreSale8.Checked
        End With
        'display save into database
        If WriteTicketDatabase() = True Then
            lblSaveInfo.Visible = True
        End If

    End Sub

    Private Sub btnSave_LostFocus(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSave.LostFocus
        lblSaveInfo.Visible = False 'clear message if we do more stuff
    End Sub

    Private Sub LoadTicketInfo()
        Dim i As Short

        With ticket_data
            txtAdult.Text = FormatCurrency(.adult_price, 2)
            txtStudent.Text = FormatCurrency(.student_price, 2)
            txtSenior.Text = FormatCurrency(.senior_price, 2)
            txtFamily.Text = FormatCurrency(.family_price, 2)
            txtComp.Text = FormatCurrency(.comp_price, 2)
            txtSeason.Text = FormatCurrency(.season_price, 2)
            txtMilitary.Text = FormatCurrency(.military_price, 2)
            txtPromo.Text = FormatCurrency(.promo_price, 2)
            txtDiscount.Text = FormatCurrency(.discount_price, 2, TriState.True, TriState.False, TriState.UseDefault)
        End With
        With special_ticket_data
            For i = 0 To 7
                txtTicketNameInput(i).Text = .sp_ticket(i).sp_ticket_name
                txtSpecialPrice(i).Text = FormatCurrency(.sp_ticket(i).sp_ticket_value)
            Next
            ckPreSale1.Checked = .sp_ticket(0).sp_ticket_prepaid
            ckPreSale2.Checked = .sp_ticket(1).sp_ticket_prepaid
            ckPreSale3.Checked = .sp_ticket(2).sp_ticket_prepaid
            ckPreSale4.Checked = .sp_ticket(3).sp_ticket_prepaid
            ckPreSale5.Checked = .sp_ticket(4).sp_ticket_prepaid
            ckPreSale6.Checked = .sp_ticket(5).sp_ticket_prepaid
            ckPreSale7.Checked = .sp_ticket(6).sp_ticket_prepaid
            ckPreSale8.Checked = .sp_ticket(7).sp_ticket_prepaid
        End With

    End Sub
	

    Private Sub txtAdult_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAdult.Enter, txtAdult.Click
        txtAdult.SelectAll()
    End Sub

    Private Sub txtAdult_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAdult.Leave
        If txtAdult.TextLength = 0 Then txtAdult.Text = ticket_data.adult_price
        txtAdult.Text = FormatCurrency(txtAdult.Text, 2)
    End Sub

    Private Sub txtComp_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComp.Enter, txtComp.Click
        txtComp.SelectAll()
    End Sub

    Private Sub txtComp_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComp.Leave
        If txtComp.TextLength = 0 Then txtComp.Text = ticket_data.comp_price
        txtComp.Text = FormatCurrency(txtComp.Text, 2)
    End Sub

    Private Sub txtDiscount_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDiscount.Enter, txtDiscount.Click
        txtDiscount.SelectAll()
    End Sub

    Private Sub txtDiscount_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDiscount.Leave
        Dim curr As Decimal
        If txtDiscount.TextLength = 0 Then txtDiscount.Text = ticket_data.discount_price
        curr = CDec(txtDiscount.Text)
        If curr > 0 Then
            curr = curr * -1 'discount is always negative number
            txtDiscount.Text = CStr(curr)
        End If
        txtDiscount.Text = FormatCurrency(txtDiscount.Text, 2, TriState.True, TriState.False, TriState.UseDefault)
    End Sub

    Private Sub txtFamily_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFamily.Enter, txtFamily.Click
        txtFamily.SelectAll()
    End Sub

    Private Sub txtFamily_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFamily.Leave
        If txtFamily.TextLength = 0 Then txtFamily.Text = ticket_data.family_price
        txtFamily.Text = FormatCurrency(txtFamily.Text, 2)
    End Sub

    Private Sub txtMilitary_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMilitary.Enter, txtMilitary.Click
        txtMilitary.SelectAll()
    End Sub

    Private Sub txtMilitary_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMilitary.Leave
        If txtMilitary.TextLength = 0 Then txtMilitary.Text = ticket_data.military_price
        txtMilitary.Text = FormatCurrency(txtMilitary.Text, 2)
    End Sub

    Private Sub txtPromo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPromo.Enter, txtPromo.Click
        txtPromo.SelectAll()
    End Sub

    Private Sub txtPromo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPromo.Leave
        If txtPromo.TextLength = 0 Then txtPromo.Text = ticket_data.promo_price
        txtPromo.Text = FormatCurrency(txtPromo.Text, 2)
    End Sub

    Private Sub txtSeason_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSeason.Enter, txtSeason.Click
        txtSeason.SelectAll()
    End Sub

    Private Sub txtSeason_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSeason.Leave
        If txtSeason.TextLength = 0 Then txtSeason.Text = ticket_data.season_price
        txtSeason.Text = FormatCurrency(txtSeason.Text, 2)
    End Sub

    Private Sub txtSenior_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSenior.Enter, txtSenior.Click
        txtSenior.SelectAll()
    End Sub

    Private Sub txtSenior_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSenior.Leave
        If txtSenior.TextLength = 0 Then txtSenior.Text = ticket_data.senior_price
        txtSenior.Text = FormatCurrency(txtSenior.Text, 2)
    End Sub

    Private Sub txtStudent_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStudent.Enter, txtStudent.Click
        txtStudent.SelectAll()
    End Sub

    Private Sub txtStudent_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStudent.Leave
        If txtStudent.TextLength = 0 Then txtStudent.Text = ticket_data.student_price
        txtStudent.Text = FormatCurrency(txtStudent.Text, 2)
    End Sub

    '*********************************************************
    'Do special tickets now
    Private Sub ProcessEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtTicketNameInput.Enter, txtSpecialPrice.Enter, txtTicketNameInput.Click, txtSpecialPrice.Click
        Dim str_name As String = DirectCast(sender, TextBox).Name

        If StrComp(str_name.Substring(0, 8), "txtTicke") = 0 Then
            Dim index As Short = txtTicketNameInput.GetIndex(sender)
            txtTicketNameInput(index).SelectAll()
        ElseIf StrComp(str_name.Substring(0, 8), "txtSpeci") = 0 Then
            Dim index As Short = txtSpecialPrice.GetIndex(sender)
            txtSpecialPrice(index).SelectAll()
        End If
    End Sub

    Private Sub ProcessLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtTicketNameInput.Leave, txtSpecialPrice.Leave
        Dim str_name As String = DirectCast(sender, TextBox).Name

        If StrComp(str_name.Substring(0, 8), "txtTicke") = 0 Then
            Dim index As Short = txtTicketNameInput.GetIndex(sender)
            'If txtTicketNameInput(index).TextLength = 0 Then

            'End If
            'txtTicketNameInput(index).Text = special_ticket_data.sp_ticket(index).sp_ticket_name
        ElseIf StrComp(str_name.Substring(0, 8), "txtSpeci") = 0 Then
            Dim index As Short = txtSpecialPrice.GetIndex(sender)
            'If txtTicketNameInput(index).TextLength = 0 Then txtTicketNameInput(index).Text = special_ticket_data.sp_ticket(index).sp_ticket_value
            txtSpecialPrice(index).Text = FormatCurrency(txtSpecialPrice(index).Text, 2)
        End If
    End Sub

    Private Sub txtAddShow_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAddShow.Enter, txtAddShow.Click
        txtAddShow.Text = ""
    End Sub

    Private Sub btnAddShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddShow.Click
        If txtAddShow.TextLength <> 0 And txtAddShow.Text <> "" Then
            cboShowNames.Items.Add(txtAddShow.Text)
            Add_Show_Pending = True
            Add_Show_Text = txtAddShow.Text

        End If
    End Sub
End Class