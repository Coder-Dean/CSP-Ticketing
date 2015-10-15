<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTypeSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTypeSelect))
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtInfo = New System.Windows.Forms.TextBox
        Me.rbtnCash = New System.Windows.Forms.RadioButton
        Me.rbtnCheck = New System.Windows.Forms.RadioButton
        Me.rbtnCredit = New System.Windows.Forms.RadioButton
        Me.rbtnPresale = New System.Windows.Forms.RadioButton
        Me.rbtnOther = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.LightBlue
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(25, 244)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(91, 36)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Coral
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(160, 246)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 36)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtInfo
        '
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.Location = New System.Drawing.Point(127, 12)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(148, 211)
        Me.txtInfo.TabIndex = 5
        Me.txtInfo.TabStop = False
        '
        'rbtnCash
        '
        Me.rbtnCash.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbtnCash.AutoSize = True
        Me.rbtnCash.BackColor = System.Drawing.SystemColors.Control
        Me.rbtnCash.FlatAppearance.BorderSize = 2
        Me.rbtnCash.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen
        Me.rbtnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCash.Location = New System.Drawing.Point(22, 19)
        Me.rbtnCash.MinimumSize = New System.Drawing.Size(96, 32)
        Me.rbtnCash.Name = "rbtnCash"
        Me.rbtnCash.Size = New System.Drawing.Size(96, 32)
        Me.rbtnCash.TabIndex = 6
        Me.rbtnCash.TabStop = True
        Me.rbtnCash.Text = "CASH"
        Me.rbtnCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnCash.UseVisualStyleBackColor = False
        '
        'rbtnCheck
        '
        Me.rbtnCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbtnCheck.AutoSize = True
        Me.rbtnCheck.BackColor = System.Drawing.SystemColors.Control
        Me.rbtnCheck.FlatAppearance.BorderSize = 2
        Me.rbtnCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen
        Me.rbtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCheck.Location = New System.Drawing.Point(22, 62)
        Me.rbtnCheck.MinimumSize = New System.Drawing.Size(96, 32)
        Me.rbtnCheck.Name = "rbtnCheck"
        Me.rbtnCheck.Size = New System.Drawing.Size(96, 32)
        Me.rbtnCheck.TabIndex = 7
        Me.rbtnCheck.TabStop = True
        Me.rbtnCheck.Text = "CHECK"
        Me.rbtnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnCheck.UseVisualStyleBackColor = False
        '
        'rbtnCredit
        '
        Me.rbtnCredit.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbtnCredit.AutoSize = True
        Me.rbtnCredit.BackColor = System.Drawing.SystemColors.Control
        Me.rbtnCredit.FlatAppearance.BorderSize = 2
        Me.rbtnCredit.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen
        Me.rbtnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCredit.Location = New System.Drawing.Point(22, 105)
        Me.rbtnCredit.MinimumSize = New System.Drawing.Size(96, 32)
        Me.rbtnCredit.Name = "rbtnCredit"
        Me.rbtnCredit.Size = New System.Drawing.Size(96, 32)
        Me.rbtnCredit.TabIndex = 8
        Me.rbtnCredit.TabStop = True
        Me.rbtnCredit.Text = "CREDIT"
        Me.rbtnCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnCredit.UseVisualStyleBackColor = False
        '
        'rbtnPresale
        '
        Me.rbtnPresale.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbtnPresale.AutoSize = True
        Me.rbtnPresale.BackColor = System.Drawing.SystemColors.Control
        Me.rbtnPresale.FlatAppearance.BorderSize = 2
        Me.rbtnPresale.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen
        Me.rbtnPresale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnPresale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPresale.Location = New System.Drawing.Point(20, 148)
        Me.rbtnPresale.MinimumSize = New System.Drawing.Size(96, 32)
        Me.rbtnPresale.Name = "rbtnPresale"
        Me.rbtnPresale.Size = New System.Drawing.Size(96, 32)
        Me.rbtnPresale.TabIndex = 9
        Me.rbtnPresale.TabStop = True
        Me.rbtnPresale.Text = "ON-LINE"
        Me.rbtnPresale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnPresale.UseVisualStyleBackColor = False
        '
        'rbtnOther
        '
        Me.rbtnOther.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbtnOther.AutoSize = True
        Me.rbtnOther.FlatAppearance.BorderSize = 2
        Me.rbtnOther.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen
        Me.rbtnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtnOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOther.Location = New System.Drawing.Point(21, 191)
        Me.rbtnOther.MinimumSize = New System.Drawing.Size(96, 32)
        Me.rbtnOther.Name = "rbtnOther"
        Me.rbtnOther.Size = New System.Drawing.Size(96, 32)
        Me.rbtnOther.TabIndex = 10
        Me.rbtnOther.TabStop = True
        Me.rbtnOther.Text = "OTHER"
        Me.rbtnOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnOther.UseVisualStyleBackColor = True
        '
        'frmTypeSelect
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(284, 298)
        Me.Controls.Add(Me.rbtnOther)
        Me.Controls.Add(Me.rbtnPresale)
        Me.Controls.Add(Me.rbtnCredit)
        Me.Controls.Add(Me.rbtnCheck)
        Me.Controls.Add(Me.rbtnCash)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTypeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents rbtnCash As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCheck As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCredit As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPresale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnOther As System.Windows.Forms.RadioButton
End Class
