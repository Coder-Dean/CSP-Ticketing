Public Class frmTypeSelect

    Private Sub frmTypeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.StartPosition = FormStartPosition.CenterParent
        'locate at parent form top edge and a little away from the left edge
        Me.Left = FrmMain.Left + (FrmMain.Width \ 6)
        Me.Top = FrmMain.Top
        txtInfo.Text = "Select payment type (cash, check, credit, on-line or other) then click the OK buton. Press Cancel (or Esc) to return if a correcton is needed."
        transactionOk = False
        transactionType = TRANSACTION_NONE
        rbtnCash.Checked = False
        rbtnCheck.Checked = False
        rbtnCredit.Checked = False
        rbtnPresale.Checked = False
        rbtnOther.Checked = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        transactionOk = False
        transactionType = TRANSACTION_NONE
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        transactionOk = True
        If rbtnCash.Checked = True Then
            transactionType = TRANSACTION_CASH
        ElseIf rbtnCheck.Checked = True Then
            transactionType = TRANSACTION_CHECK
        ElseIf rbtnCredit.Checked = True Then
            transactionType = TRANSACTION_CREDIT
        ElseIf rbtnPresale.Checked = True Then
            transactionType = TRANSACTION_ONLINE
        ElseIf rbtnOther.Checked = True Then
            transactionType = TRANSACTION_OTHER
        Else
            transactionOk = False
            transactionType = TRANSACTION_NONE
        End If

        Me.Close()
    End Sub



End Class