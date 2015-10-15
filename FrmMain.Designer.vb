<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMain
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDash3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public cmDialogOpen As System.Windows.Forms.OpenFileDialog
	Public cmDialogSave As System.Windows.Forms.SaveFileDialog
	Public cmDialogFont As System.Windows.Forms.FontDialog
	Public cmDialogColor As System.Windows.Forms.ColorDialog
	Public cmDialogPrint As System.Windows.Forms.PrintDialog
	Public WithEvents btnSaveData As System.Windows.Forms.Button
	Public WithEvents _ResetCount_16 As System.Windows.Forms.Button
	Public WithEvents _ResetCount_15 As System.Windows.Forms.Button
	Public WithEvents _ResetCount_14 As System.Windows.Forms.Button
	Public WithEvents _ResetCount_13 As System.Windows.Forms.Button
	Public WithEvents _ResetCount_12 As System.Windows.Forms.Button
	Public WithEvents _ResetCount_11 As System.Windows.Forms.Button
	Public WithEvents _ResetCount_10 As System.Windows.Forms.Button
	Public WithEvents _ResetCount_9 As System.Windows.Forms.Button
	Public WithEvents _txtN1_7 As System.Windows.Forms.TextBox
	Public WithEvents _txtN1_6 As System.Windows.Forms.TextBox
	Public WithEvents _txtN1_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtN1_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtN1_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtN1_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtN1_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtN1_0 As System.Windows.Forms.TextBox
    Public WithEvents cmdN1_0 As System.Windows.Forms.Button
    Public WithEvents cmdN1_1 As System.Windows.Forms.Button
    Public WithEvents cmdN1_2 As System.Windows.Forms.Button
    Public WithEvents cmdN1_3 As System.Windows.Forms.Button
    Public WithEvents cmdN1_4 As System.Windows.Forms.Button
    Public WithEvents cmdN1_5 As System.Windows.Forms.Button
    Public WithEvents cmdN1_6 As System.Windows.Forms.Button
    Public WithEvents cmdN1_7 As System.Windows.Forms.Button
    Public WithEvents _ResetCount_8 As System.Windows.Forms.Button
    Public WithEvents txtDiscountCnt As System.Windows.Forms.TextBox
    Public WithEvents cmdDiscount As System.Windows.Forms.Button
    Public WithEvents _ResetCount_7 As System.Windows.Forms.Button
    Public WithEvents _ResetCount_6 As System.Windows.Forms.Button
    Public WithEvents _ResetCount_5 As System.Windows.Forms.Button
    Public WithEvents _ResetCount_4 As System.Windows.Forms.Button
    Public WithEvents _ResetCount_3 As System.Windows.Forms.Button
    Public WithEvents _ResetCount_2 As System.Windows.Forms.Button
    Public WithEvents _ResetCount_1 As System.Windows.Forms.Button
    Public WithEvents _ResetCount_0 As System.Windows.Forms.Button
    Public WithEvents MSFlexGrid1 As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents btnCalculate As System.Windows.Forms.Button
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents txtPromoCnt As System.Windows.Forms.TextBox
    Public WithEvents txtMilitaryCnt As System.Windows.Forms.TextBox
    Public WithEvents txtSeasonCnt As System.Windows.Forms.TextBox
    Public WithEvents txtCompCnt As System.Windows.Forms.TextBox
    Public WithEvents txtFamilyCnt As System.Windows.Forms.TextBox
    Public WithEvents txtSeniorCnt As System.Windows.Forms.TextBox
    Public WithEvents txtStudentCnt As System.Windows.Forms.TextBox
    Public WithEvents txtAdultCnt As System.Windows.Forms.TextBox
    Public WithEvents cmdPromoTck As System.Windows.Forms.Button
    Public WithEvents cmdMilitaryTck As System.Windows.Forms.Button
    Public WithEvents cmdSeasonTck As System.Windows.Forms.Button
    Public WithEvents cmdCompTck As System.Windows.Forms.Button
    Public WithEvents cmdCSPTck As System.Windows.Forms.Button
    Public WithEvents cmdSeniorTck As System.Windows.Forms.Button
    Public WithEvents cmdStudentTck As System.Windows.Forms.Button
    Public WithEvents cmdAdultTck As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents _Label1_16 As System.Windows.Forms.Label
    Public WithEvents _Label1_15 As System.Windows.Forms.Label
    Public WithEvents _Label1_14 As System.Windows.Forms.Label
    Public WithEvents _Label1_13 As System.Windows.Forms.Label
    Public WithEvents _Label1_12 As System.Windows.Forms.Label
    Public WithEvents _Label1_11 As System.Windows.Forms.Label
    Public WithEvents _Label1_10 As System.Windows.Forms.Label
    Public WithEvents _Label1_9 As System.Windows.Forms.Label
    Public WithEvents _Label1_8 As System.Windows.Forms.Label
    Public WithEvents _Label1_7 As System.Windows.Forms.Label
    Public WithEvents _Label1_6 As System.Windows.Forms.Label
    Public WithEvents _Label1_5 As System.Windows.Forms.Label
    Public WithEvents _Label1_4 As System.Windows.Forms.Label
    Public WithEvents _Label1_3 As System.Windows.Forms.Label
    Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Public WithEvents _Label1_0 As System.Windows.Forms.Label
    Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents ResetCount As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents cmdN1 As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
    Public WithEvents txtN1 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSaveData = New System.Windows.Forms.Button
        Me._ResetCount_16 = New System.Windows.Forms.Button
        Me._ResetCount_15 = New System.Windows.Forms.Button
        Me._ResetCount_14 = New System.Windows.Forms.Button
        Me._ResetCount_13 = New System.Windows.Forms.Button
        Me._ResetCount_12 = New System.Windows.Forms.Button
        Me._ResetCount_11 = New System.Windows.Forms.Button
        Me._ResetCount_10 = New System.Windows.Forms.Button
        Me._ResetCount_9 = New System.Windows.Forms.Button
        Me._ResetCount_8 = New System.Windows.Forms.Button
        Me._ResetCount_7 = New System.Windows.Forms.Button
        Me._ResetCount_6 = New System.Windows.Forms.Button
        Me._ResetCount_5 = New System.Windows.Forms.Button
        Me._ResetCount_4 = New System.Windows.Forms.Button
        Me._ResetCount_3 = New System.Windows.Forms.Button
        Me._ResetCount_2 = New System.Windows.Forms.Button
        Me._ResetCount_1 = New System.Windows.Forms.Button
        Me._ResetCount_0 = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnPrintReport = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDash3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.cmDialogOpen = New System.Windows.Forms.OpenFileDialog
        Me.cmDialogSave = New System.Windows.Forms.SaveFileDialog
        Me.cmDialogFont = New System.Windows.Forms.FontDialog
        Me.cmDialogColor = New System.Windows.Forms.ColorDialog
        Me.cmDialogPrint = New System.Windows.Forms.PrintDialog
        Me._txtN1_7 = New System.Windows.Forms.TextBox
        Me._txtN1_6 = New System.Windows.Forms.TextBox
        Me._txtN1_5 = New System.Windows.Forms.TextBox
        Me._txtN1_4 = New System.Windows.Forms.TextBox
        Me._txtN1_3 = New System.Windows.Forms.TextBox
        Me._txtN1_2 = New System.Windows.Forms.TextBox
        Me._txtN1_1 = New System.Windows.Forms.TextBox
        Me._txtN1_0 = New System.Windows.Forms.TextBox
        Me.cmdN1_0 = New System.Windows.Forms.Button
        Me.cmdN1_1 = New System.Windows.Forms.Button
        Me.cmdN1_2 = New System.Windows.Forms.Button
        Me.cmdN1_3 = New System.Windows.Forms.Button
        Me.cmdN1_4 = New System.Windows.Forms.Button
        Me.cmdN1_5 = New System.Windows.Forms.Button
        Me.cmdN1_6 = New System.Windows.Forms.Button
        Me.cmdN1_7 = New System.Windows.Forms.Button
        Me.txtDiscountCnt = New System.Windows.Forms.TextBox
        Me.cmdDiscount = New System.Windows.Forms.Button
        Me.txtPromoCnt = New System.Windows.Forms.TextBox
        Me.txtMilitaryCnt = New System.Windows.Forms.TextBox
        Me.txtSeasonCnt = New System.Windows.Forms.TextBox
        Me.txtCompCnt = New System.Windows.Forms.TextBox
        Me.txtFamilyCnt = New System.Windows.Forms.TextBox
        Me.txtSeniorCnt = New System.Windows.Forms.TextBox
        Me.txtStudentCnt = New System.Windows.Forms.TextBox
        Me.txtAdultCnt = New System.Windows.Forms.TextBox
        Me.cmdPromoTck = New System.Windows.Forms.Button
        Me.cmdMilitaryTck = New System.Windows.Forms.Button
        Me.cmdSeasonTck = New System.Windows.Forms.Button
        Me.cmdCompTck = New System.Windows.Forms.Button
        Me.cmdCSPTck = New System.Windows.Forms.Button
        Me.cmdSeniorTck = New System.Windows.Forms.Button
        Me.cmdStudentTck = New System.Windows.Forms.Button
        Me.cmdAdultTck = New System.Windows.Forms.Button
        Me._Label1_16 = New System.Windows.Forms.Label
        Me._Label1_15 = New System.Windows.Forms.Label
        Me._Label1_14 = New System.Windows.Forms.Label
        Me._Label1_13 = New System.Windows.Forms.Label
        Me._Label1_12 = New System.Windows.Forms.Label
        Me._Label1_11 = New System.Windows.Forms.Label
        Me._Label1_10 = New System.Windows.Forms.Label
        Me._Label1_9 = New System.Windows.Forms.Label
        Me._Label1_8 = New System.Windows.Forms.Label
        Me._Label1_7 = New System.Windows.Forms.Label
        Me._Label1_6 = New System.Windows.Forms.Label
        Me._Label1_5 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.ResetCount = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.cmdN1 = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.txtN1 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.MSFlexGrid1 = New AxMSFlexGridLib.AxMSFlexGrid
        Me.lblShowTitle = New System.Windows.Forms.Label
        Me.lblSaved = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MainMenu1.SuspendLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResetCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdN1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtN1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSFlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveData
        '
        Me.btnSaveData.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaveData.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSaveData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveData.Location = New System.Drawing.Point(1070, 145)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSaveData.Size = New System.Drawing.Size(84, 84)
        Me.btnSaveData.TabIndex = 72
        Me.btnSaveData.Text = "Save and Clear"
        Me.ToolTip1.SetToolTip(Me.btnSaveData, "Save to Database and clear Receipt")
        Me.btnSaveData.UseVisualStyleBackColor = False
        '
        '_ResetCount_16
        '
        Me._ResetCount_16.BackColor = System.Drawing.Color.Red
        Me._ResetCount_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_16, CType(16, Short))
        Me._ResetCount_16.Location = New System.Drawing.Point(260, 458)
        Me._ResetCount_16.Name = "_ResetCount_16"
        Me._ResetCount_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_16.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_16.TabIndex = 71
        Me._ResetCount_16.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_16, "Reset count")
        Me._ResetCount_16.UseVisualStyleBackColor = False
        '
        '_ResetCount_15
        '
        Me._ResetCount_15.BackColor = System.Drawing.Color.Red
        Me._ResetCount_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_15, CType(15, Short))
        Me._ResetCount_15.Location = New System.Drawing.Point(260, 401)
        Me._ResetCount_15.Name = "_ResetCount_15"
        Me._ResetCount_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_15.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_15.TabIndex = 70
        Me._ResetCount_15.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_15, "Reset count")
        Me._ResetCount_15.UseVisualStyleBackColor = False
        '
        '_ResetCount_14
        '
        Me._ResetCount_14.BackColor = System.Drawing.Color.Red
        Me._ResetCount_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_14, CType(14, Short))
        Me._ResetCount_14.Location = New System.Drawing.Point(260, 347)
        Me._ResetCount_14.Name = "_ResetCount_14"
        Me._ResetCount_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_14.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_14.TabIndex = 69
        Me._ResetCount_14.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_14, "Reset count")
        Me._ResetCount_14.UseVisualStyleBackColor = False
        '
        '_ResetCount_13
        '
        Me._ResetCount_13.BackColor = System.Drawing.Color.Red
        Me._ResetCount_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_13, CType(13, Short))
        Me._ResetCount_13.Location = New System.Drawing.Point(260, 292)
        Me._ResetCount_13.Name = "_ResetCount_13"
        Me._ResetCount_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_13.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_13.TabIndex = 68
        Me._ResetCount_13.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_13, "Reset count")
        Me._ResetCount_13.UseVisualStyleBackColor = False
        '
        '_ResetCount_12
        '
        Me._ResetCount_12.BackColor = System.Drawing.Color.Red
        Me._ResetCount_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_12, CType(12, Short))
        Me._ResetCount_12.Location = New System.Drawing.Point(260, 237)
        Me._ResetCount_12.Name = "_ResetCount_12"
        Me._ResetCount_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_12.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_12.TabIndex = 67
        Me._ResetCount_12.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_12, "Reset count")
        Me._ResetCount_12.UseVisualStyleBackColor = False
        '
        '_ResetCount_11
        '
        Me._ResetCount_11.BackColor = System.Drawing.Color.Red
        Me._ResetCount_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_11, CType(11, Short))
        Me._ResetCount_11.Location = New System.Drawing.Point(260, 182)
        Me._ResetCount_11.Name = "_ResetCount_11"
        Me._ResetCount_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_11.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_11.TabIndex = 66
        Me._ResetCount_11.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_11, "Reset count")
        Me._ResetCount_11.UseVisualStyleBackColor = False
        '
        '_ResetCount_10
        '
        Me._ResetCount_10.BackColor = System.Drawing.Color.Red
        Me._ResetCount_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_10, CType(10, Short))
        Me._ResetCount_10.Location = New System.Drawing.Point(260, 128)
        Me._ResetCount_10.Name = "_ResetCount_10"
        Me._ResetCount_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_10.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_10.TabIndex = 65
        Me._ResetCount_10.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_10, "Reset count")
        Me._ResetCount_10.UseVisualStyleBackColor = False
        '
        '_ResetCount_9
        '
        Me._ResetCount_9.BackColor = System.Drawing.Color.Red
        Me._ResetCount_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_9, CType(9, Short))
        Me._ResetCount_9.Location = New System.Drawing.Point(260, 72)
        Me._ResetCount_9.Name = "_ResetCount_9"
        Me._ResetCount_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_9.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_9.TabIndex = 64
        Me._ResetCount_9.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_9, "Reset count")
        Me._ResetCount_9.UseVisualStyleBackColor = False
        '
        '_ResetCount_8
        '
        Me._ResetCount_8.BackColor = System.Drawing.Color.Red
        Me._ResetCount_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_8, CType(8, Short))
        Me._ResetCount_8.Location = New System.Drawing.Point(564, 506)
        Me._ResetCount_8.Name = "_ResetCount_8"
        Me._ResetCount_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_8.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_8.TabIndex = 38
        Me._ResetCount_8.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_8, "Reset count")
        Me._ResetCount_8.UseVisualStyleBackColor = False
        '
        '_ResetCount_7
        '
        Me._ResetCount_7.BackColor = System.Drawing.Color.Red
        Me._ResetCount_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_7, CType(7, Short))
        Me._ResetCount_7.Location = New System.Drawing.Point(564, 452)
        Me._ResetCount_7.Name = "_ResetCount_7"
        Me._ResetCount_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_7.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_7.TabIndex = 35
        Me._ResetCount_7.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_7, "Reset count")
        Me._ResetCount_7.UseVisualStyleBackColor = False
        '
        '_ResetCount_6
        '
        Me._ResetCount_6.BackColor = System.Drawing.Color.Red
        Me._ResetCount_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_6, CType(6, Short))
        Me._ResetCount_6.Location = New System.Drawing.Point(564, 398)
        Me._ResetCount_6.Name = "_ResetCount_6"
        Me._ResetCount_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_6.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_6.TabIndex = 34
        Me._ResetCount_6.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_6, "Reset count")
        Me._ResetCount_6.UseVisualStyleBackColor = False
        '
        '_ResetCount_5
        '
        Me._ResetCount_5.BackColor = System.Drawing.Color.Red
        Me._ResetCount_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_5, CType(5, Short))
        Me._ResetCount_5.Location = New System.Drawing.Point(564, 344)
        Me._ResetCount_5.Name = "_ResetCount_5"
        Me._ResetCount_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_5.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_5.TabIndex = 33
        Me._ResetCount_5.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_5, "Reset count")
        Me._ResetCount_5.UseVisualStyleBackColor = False
        '
        '_ResetCount_4
        '
        Me._ResetCount_4.BackColor = System.Drawing.Color.Red
        Me._ResetCount_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_4, CType(4, Short))
        Me._ResetCount_4.Location = New System.Drawing.Point(564, 290)
        Me._ResetCount_4.Name = "_ResetCount_4"
        Me._ResetCount_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_4.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_4.TabIndex = 32
        Me._ResetCount_4.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_4, "Reset count")
        Me._ResetCount_4.UseVisualStyleBackColor = False
        '
        '_ResetCount_3
        '
        Me._ResetCount_3.BackColor = System.Drawing.Color.Red
        Me._ResetCount_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_3, CType(3, Short))
        Me._ResetCount_3.Location = New System.Drawing.Point(564, 236)
        Me._ResetCount_3.Name = "_ResetCount_3"
        Me._ResetCount_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_3.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_3.TabIndex = 31
        Me._ResetCount_3.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_3, "Reset count")
        Me._ResetCount_3.UseVisualStyleBackColor = False
        '
        '_ResetCount_2
        '
        Me._ResetCount_2.BackColor = System.Drawing.Color.Red
        Me._ResetCount_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_2, CType(2, Short))
        Me._ResetCount_2.Location = New System.Drawing.Point(564, 182)
        Me._ResetCount_2.Name = "_ResetCount_2"
        Me._ResetCount_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_2.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_2.TabIndex = 30
        Me._ResetCount_2.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_2, "Reset count")
        Me._ResetCount_2.UseVisualStyleBackColor = False
        '
        '_ResetCount_1
        '
        Me._ResetCount_1.BackColor = System.Drawing.Color.Red
        Me._ResetCount_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_1, CType(1, Short))
        Me._ResetCount_1.Location = New System.Drawing.Point(564, 128)
        Me._ResetCount_1.Name = "_ResetCount_1"
        Me._ResetCount_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_1.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_1.TabIndex = 29
        Me._ResetCount_1.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_1, "Reset count")
        Me._ResetCount_1.UseVisualStyleBackColor = False
        '
        '_ResetCount_0
        '
        Me._ResetCount_0.BackColor = System.Drawing.Color.Red
        Me._ResetCount_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._ResetCount_0.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._ResetCount_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetCount.SetIndex(Me._ResetCount_0, CType(0, Short))
        Me._ResetCount_0.Location = New System.Drawing.Point(564, 74)
        Me._ResetCount_0.Name = "_ResetCount_0"
        Me._ResetCount_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._ResetCount_0.Size = New System.Drawing.Size(35, 29)
        Me._ResetCount_0.TabIndex = 28
        Me._ResetCount_0.Text = "R"
        Me.ToolTip1.SetToolTip(Me._ResetCount_0, "Reset count")
        Me._ResetCount_0.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(1070, 19)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculate.Size = New System.Drawing.Size(84, 84)
        Me.btnCalculate.TabIndex = 26
        Me.btnCalculate.Text = "Calculate Receipt"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Display Totals")
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(1070, 240)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(84, 84)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Reset Receipt"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Reset all Counts and Totals")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(1070, 458)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(84, 84)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Quit program")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrintReport
        '
        Me.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrintReport.ForeColor = System.Drawing.Color.Black
        Me.btnPrintReport.Location = New System.Drawing.Point(1070, 357)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(84, 84)
        Me.btnPrintReport.TabIndex = 78
        Me.btnPrintReport.Text = "Print Report"
        Me.ToolTip1.SetToolTip(Me.btnPrintReport, "Close register and print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End-of-Day report.")
        Me.btnPrintReport.UseVisualStyleBackColor = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Dock = System.Windows.Forms.DockStyle.None
        Me.MainMenu1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuAbout})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(206, 28)
        Me.MainMenu1.TabIndex = 73
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit, Me.mnuDash3, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(203, 24)
        Me.mnuEdit.Text = "&Box Office Options"
        '
        'mnuDash3
        '
        Me.mnuDash3.Name = "mnuDash3"
        Me.mnuDash3.Size = New System.Drawing.Size(200, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(203, 24)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(62, 24)
        Me.mnuAbout.Text = "&About"
        '
        '_txtN1_7
        '
        Me._txtN1_7.AcceptsReturn = True
        Me._txtN1_7.BackColor = System.Drawing.SystemColors.Window
        Me._txtN1_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtN1_7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtN1_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN1.SetIndex(Me._txtN1_7, CType(7, Short))
        Me._txtN1_7.Location = New System.Drawing.Point(183, 458)
        Me._txtN1_7.MaxLength = 0
        Me._txtN1_7.Name = "_txtN1_7"
        Me._txtN1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtN1_7.Size = New System.Drawing.Size(76, 29)
        Me._txtN1_7.TabIndex = 63
        Me._txtN1_7.Text = "0"
        Me._txtN1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtN1_6
        '
        Me._txtN1_6.AcceptsReturn = True
        Me._txtN1_6.BackColor = System.Drawing.SystemColors.Window
        Me._txtN1_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtN1_6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtN1_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN1.SetIndex(Me._txtN1_6, CType(6, Short))
        Me._txtN1_6.Location = New System.Drawing.Point(183, 403)
        Me._txtN1_6.MaxLength = 0
        Me._txtN1_6.Name = "_txtN1_6"
        Me._txtN1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtN1_6.Size = New System.Drawing.Size(76, 29)
        Me._txtN1_6.TabIndex = 62
        Me._txtN1_6.Text = "0"
        Me._txtN1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtN1_5
        '
        Me._txtN1_5.AcceptsReturn = True
        Me._txtN1_5.BackColor = System.Drawing.SystemColors.Window
        Me._txtN1_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtN1_5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtN1_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN1.SetIndex(Me._txtN1_5, CType(5, Short))
        Me._txtN1_5.Location = New System.Drawing.Point(183, 348)
        Me._txtN1_5.MaxLength = 0
        Me._txtN1_5.Name = "_txtN1_5"
        Me._txtN1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtN1_5.Size = New System.Drawing.Size(76, 29)
        Me._txtN1_5.TabIndex = 61
        Me._txtN1_5.Text = "0"
        Me._txtN1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtN1_4
        '
        Me._txtN1_4.AcceptsReturn = True
        Me._txtN1_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtN1_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtN1_4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtN1_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN1.SetIndex(Me._txtN1_4, CType(4, Short))
        Me._txtN1_4.Location = New System.Drawing.Point(183, 293)
        Me._txtN1_4.MaxLength = 0
        Me._txtN1_4.Name = "_txtN1_4"
        Me._txtN1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtN1_4.Size = New System.Drawing.Size(76, 29)
        Me._txtN1_4.TabIndex = 60
        Me._txtN1_4.Text = "0"
        Me._txtN1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtN1_3
        '
        Me._txtN1_3.AcceptsReturn = True
        Me._txtN1_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtN1_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtN1_3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtN1_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN1.SetIndex(Me._txtN1_3, CType(3, Short))
        Me._txtN1_3.Location = New System.Drawing.Point(183, 238)
        Me._txtN1_3.MaxLength = 0
        Me._txtN1_3.Name = "_txtN1_3"
        Me._txtN1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtN1_3.Size = New System.Drawing.Size(76, 29)
        Me._txtN1_3.TabIndex = 59
        Me._txtN1_3.Text = "0"
        Me._txtN1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtN1_2
        '
        Me._txtN1_2.AcceptsReturn = True
        Me._txtN1_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtN1_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtN1_2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtN1_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN1.SetIndex(Me._txtN1_2, CType(2, Short))
        Me._txtN1_2.Location = New System.Drawing.Point(183, 183)
        Me._txtN1_2.MaxLength = 0
        Me._txtN1_2.Name = "_txtN1_2"
        Me._txtN1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtN1_2.Size = New System.Drawing.Size(76, 29)
        Me._txtN1_2.TabIndex = 58
        Me._txtN1_2.Text = "0"
        Me._txtN1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtN1_1
        '
        Me._txtN1_1.AcceptsReturn = True
        Me._txtN1_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtN1_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtN1_1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtN1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN1.SetIndex(Me._txtN1_1, CType(1, Short))
        Me._txtN1_1.Location = New System.Drawing.Point(183, 128)
        Me._txtN1_1.MaxLength = 0
        Me._txtN1_1.Name = "_txtN1_1"
        Me._txtN1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtN1_1.Size = New System.Drawing.Size(76, 29)
        Me._txtN1_1.TabIndex = 57
        Me._txtN1_1.Text = "0"
        Me._txtN1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtN1_0
        '
        Me._txtN1_0.AcceptsReturn = True
        Me._txtN1_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtN1_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtN1_0.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtN1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtN1.SetIndex(Me._txtN1_0, CType(0, Short))
        Me._txtN1_0.Location = New System.Drawing.Point(183, 73)
        Me._txtN1_0.MaxLength = 0
        Me._txtN1_0.Name = "_txtN1_0"
        Me._txtN1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtN1_0.Size = New System.Drawing.Size(76, 29)
        Me._txtN1_0.TabIndex = 56
        Me._txtN1_0.Text = "0"
        Me._txtN1_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdN1_0
        '
        Me.cmdN1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdN1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdN1_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdN1.SetIndex(Me.cmdN1_0, CType(0, Short))
        Me.cmdN1_0.Location = New System.Drawing.Point(12, 70)
        Me.cmdN1_0.Name = "cmdN1_0"
        Me.cmdN1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdN1_0.Size = New System.Drawing.Size(152, 42)
        Me.cmdN1_0.TabIndex = 46
        Me.cmdN1_0.Text = "Special Ticket 1"
        Me.cmdN1_0.UseVisualStyleBackColor = False
        '
        'cmdN1_1
        '
        Me.cmdN1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdN1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdN1_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdN1.SetIndex(Me.cmdN1_1, CType(1, Short))
        Me.cmdN1_1.Location = New System.Drawing.Point(12, 125)
        Me.cmdN1_1.Name = "cmdN1_1"
        Me.cmdN1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdN1_1.Size = New System.Drawing.Size(152, 42)
        Me.cmdN1_1.TabIndex = 45
        Me.cmdN1_1.Text = "Special Ticket 1"
        Me.cmdN1_1.UseVisualStyleBackColor = False
        '
        'cmdN1_2
        '
        Me.cmdN1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdN1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdN1_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdN1.SetIndex(Me.cmdN1_2, CType(2, Short))
        Me.cmdN1_2.Location = New System.Drawing.Point(12, 180)
        Me.cmdN1_2.Name = "cmdN1_2"
        Me.cmdN1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdN1_2.Size = New System.Drawing.Size(152, 42)
        Me.cmdN1_2.TabIndex = 44
        Me.cmdN1_2.Text = "Special Ticket 1"
        Me.cmdN1_2.UseVisualStyleBackColor = False
        '
        'cmdN1_3
        '
        Me.cmdN1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdN1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdN1_3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdN1.SetIndex(Me.cmdN1_3, CType(3, Short))
        Me.cmdN1_3.Location = New System.Drawing.Point(12, 235)
        Me.cmdN1_3.Name = "cmdN1_3"
        Me.cmdN1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdN1_3.Size = New System.Drawing.Size(152, 42)
        Me.cmdN1_3.TabIndex = 43
        Me.cmdN1_3.Text = "Special Ticket 1"
        Me.cmdN1_3.UseVisualStyleBackColor = False
        '
        'cmdN1_4
        '
        Me.cmdN1_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdN1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdN1_4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdN1.SetIndex(Me.cmdN1_4, CType(4, Short))
        Me.cmdN1_4.Location = New System.Drawing.Point(12, 290)
        Me.cmdN1_4.Name = "cmdN1_4"
        Me.cmdN1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdN1_4.Size = New System.Drawing.Size(152, 42)
        Me.cmdN1_4.TabIndex = 42
        Me.cmdN1_4.Text = "Special Ticket 1"
        Me.cmdN1_4.UseVisualStyleBackColor = False
        '
        'cmdN1_5
        '
        Me.cmdN1_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdN1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdN1_5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdN1.SetIndex(Me.cmdN1_5, CType(5, Short))
        Me.cmdN1_5.Location = New System.Drawing.Point(12, 345)
        Me.cmdN1_5.Name = "cmdN1_5"
        Me.cmdN1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdN1_5.Size = New System.Drawing.Size(152, 42)
        Me.cmdN1_5.TabIndex = 41
        Me.cmdN1_5.Text = "Special Ticket 1"
        Me.cmdN1_5.UseVisualStyleBackColor = False
        '
        'cmdN1_6
        '
        Me.cmdN1_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdN1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdN1_6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdN1.SetIndex(Me.cmdN1_6, CType(6, Short))
        Me.cmdN1_6.Location = New System.Drawing.Point(12, 400)
        Me.cmdN1_6.Name = "cmdN1_6"
        Me.cmdN1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdN1_6.Size = New System.Drawing.Size(152, 42)
        Me.cmdN1_6.TabIndex = 40
        Me.cmdN1_6.Text = "Special Ticket 1"
        Me.cmdN1_6.UseVisualStyleBackColor = False
        '
        'cmdN1_7
        '
        Me.cmdN1_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdN1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdN1_7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdN1.SetIndex(Me.cmdN1_7, CType(7, Short))
        Me.cmdN1_7.Location = New System.Drawing.Point(12, 455)
        Me.cmdN1_7.Name = "cmdN1_7"
        Me.cmdN1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdN1_7.Size = New System.Drawing.Size(152, 42)
        Me.cmdN1_7.TabIndex = 39
        Me.cmdN1_7.Text = "Special Ticket 1"
        Me.cmdN1_7.UseVisualStyleBackColor = False
        '
        'txtDiscountCnt
        '
        Me.txtDiscountCnt.AcceptsReturn = True
        Me.txtDiscountCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiscountCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiscountCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiscountCnt.Location = New System.Drawing.Point(486, 506)
        Me.txtDiscountCnt.MaxLength = 4
        Me.txtDiscountCnt.Name = "txtDiscountCnt"
        Me.txtDiscountCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiscountCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtDiscountCnt.TabIndex = 37
        Me.txtDiscountCnt.TabStop = False
        Me.txtDiscountCnt.Text = "0"
        Me.txtDiscountCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDiscount.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDiscount.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDiscount.Location = New System.Drawing.Point(314, 501)
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDiscount.Size = New System.Drawing.Size(152, 42)
        Me.cmdDiscount.TabIndex = 36
        Me.cmdDiscount.Text = "Discount"
        Me.cmdDiscount.UseVisualStyleBackColor = False
        '
        'txtPromoCnt
        '
        Me.txtPromoCnt.AcceptsReturn = True
        Me.txtPromoCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtPromoCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPromoCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromoCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPromoCnt.Location = New System.Drawing.Point(486, 452)
        Me.txtPromoCnt.MaxLength = 4
        Me.txtPromoCnt.Name = "txtPromoCnt"
        Me.txtPromoCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPromoCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtPromoCnt.TabIndex = 24
        Me.txtPromoCnt.TabStop = False
        Me.txtPromoCnt.Text = "0"
        Me.txtPromoCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMilitaryCnt
        '
        Me.txtMilitaryCnt.AcceptsReturn = True
        Me.txtMilitaryCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtMilitaryCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMilitaryCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMilitaryCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMilitaryCnt.Location = New System.Drawing.Point(486, 398)
        Me.txtMilitaryCnt.MaxLength = 4
        Me.txtMilitaryCnt.Name = "txtMilitaryCnt"
        Me.txtMilitaryCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMilitaryCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtMilitaryCnt.TabIndex = 23
        Me.txtMilitaryCnt.TabStop = False
        Me.txtMilitaryCnt.Text = "0"
        Me.txtMilitaryCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSeasonCnt
        '
        Me.txtSeasonCnt.AcceptsReturn = True
        Me.txtSeasonCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtSeasonCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSeasonCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeasonCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSeasonCnt.Location = New System.Drawing.Point(486, 344)
        Me.txtSeasonCnt.MaxLength = 4
        Me.txtSeasonCnt.Name = "txtSeasonCnt"
        Me.txtSeasonCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSeasonCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtSeasonCnt.TabIndex = 22
        Me.txtSeasonCnt.TabStop = False
        Me.txtSeasonCnt.Text = "0"
        Me.txtSeasonCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCompCnt
        '
        Me.txtCompCnt.AcceptsReturn = True
        Me.txtCompCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompCnt.Location = New System.Drawing.Point(486, 290)
        Me.txtCompCnt.MaxLength = 4
        Me.txtCompCnt.Name = "txtCompCnt"
        Me.txtCompCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtCompCnt.TabIndex = 21
        Me.txtCompCnt.TabStop = False
        Me.txtCompCnt.Text = "0"
        Me.txtCompCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFamilyCnt
        '
        Me.txtFamilyCnt.AcceptsReturn = True
        Me.txtFamilyCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtFamilyCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFamilyCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamilyCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFamilyCnt.Location = New System.Drawing.Point(486, 236)
        Me.txtFamilyCnt.MaxLength = 4
        Me.txtFamilyCnt.Name = "txtFamilyCnt"
        Me.txtFamilyCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFamilyCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtFamilyCnt.TabIndex = 20
        Me.txtFamilyCnt.TabStop = False
        Me.txtFamilyCnt.Text = "0"
        Me.txtFamilyCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSeniorCnt
        '
        Me.txtSeniorCnt.AcceptsReturn = True
        Me.txtSeniorCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtSeniorCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSeniorCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeniorCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSeniorCnt.Location = New System.Drawing.Point(486, 182)
        Me.txtSeniorCnt.MaxLength = 4
        Me.txtSeniorCnt.Name = "txtSeniorCnt"
        Me.txtSeniorCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSeniorCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtSeniorCnt.TabIndex = 19
        Me.txtSeniorCnt.TabStop = False
        Me.txtSeniorCnt.Text = "0"
        Me.txtSeniorCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStudentCnt
        '
        Me.txtStudentCnt.AcceptsReturn = True
        Me.txtStudentCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtStudentCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStudentCnt.Location = New System.Drawing.Point(486, 128)
        Me.txtStudentCnt.MaxLength = 4
        Me.txtStudentCnt.Name = "txtStudentCnt"
        Me.txtStudentCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStudentCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtStudentCnt.TabIndex = 18
        Me.txtStudentCnt.TabStop = False
        Me.txtStudentCnt.Text = "0"
        Me.txtStudentCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAdultCnt
        '
        Me.txtAdultCnt.AcceptsReturn = True
        Me.txtAdultCnt.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdultCnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdultCnt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdultCnt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAdultCnt.Location = New System.Drawing.Point(486, 74)
        Me.txtAdultCnt.MaxLength = 4
        Me.txtAdultCnt.Name = "txtAdultCnt"
        Me.txtAdultCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAdultCnt.Size = New System.Drawing.Size(76, 29)
        Me.txtAdultCnt.TabIndex = 17
        Me.txtAdultCnt.TabStop = False
        Me.txtAdultCnt.Text = "0"
        Me.txtAdultCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdPromoTck
        '
        Me.cmdPromoTck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdPromoTck.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPromoTck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPromoTck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPromoTck.Location = New System.Drawing.Point(314, 447)
        Me.cmdPromoTck.Name = "cmdPromoTck"
        Me.cmdPromoTck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPromoTck.Size = New System.Drawing.Size(152, 42)
        Me.cmdPromoTck.TabIndex = 8
        Me.cmdPromoTck.Text = "Promo"
        Me.cmdPromoTck.UseVisualStyleBackColor = False
        '
        'cmdMilitaryTck
        '
        Me.cmdMilitaryTck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdMilitaryTck.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMilitaryTck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMilitaryTck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMilitaryTck.Location = New System.Drawing.Point(314, 395)
        Me.cmdMilitaryTck.Name = "cmdMilitaryTck"
        Me.cmdMilitaryTck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMilitaryTck.Size = New System.Drawing.Size(152, 42)
        Me.cmdMilitaryTck.TabIndex = 7
        Me.cmdMilitaryTck.Text = "Military"
        Me.cmdMilitaryTck.UseVisualStyleBackColor = False
        '
        'cmdSeasonTck
        '
        Me.cmdSeasonTck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSeasonTck.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSeasonTck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSeasonTck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSeasonTck.Location = New System.Drawing.Point(314, 339)
        Me.cmdSeasonTck.Name = "cmdSeasonTck"
        Me.cmdSeasonTck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSeasonTck.Size = New System.Drawing.Size(152, 42)
        Me.cmdSeasonTck.TabIndex = 6
        Me.cmdSeasonTck.Text = "Season"
        Me.cmdSeasonTck.UseVisualStyleBackColor = False
        '
        'cmdCompTck
        '
        Me.cmdCompTck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCompTck.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCompTck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompTck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCompTck.Location = New System.Drawing.Point(314, 287)
        Me.cmdCompTck.Name = "cmdCompTck"
        Me.cmdCompTck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCompTck.Size = New System.Drawing.Size(152, 42)
        Me.cmdCompTck.TabIndex = 5
        Me.cmdCompTck.Text = "Comp"
        Me.cmdCompTck.UseVisualStyleBackColor = False
        '
        'cmdCSPTck
        '
        Me.cmdCSPTck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCSPTck.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCSPTck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCSPTck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCSPTck.Location = New System.Drawing.Point(314, 233)
        Me.cmdCSPTck.Name = "cmdCSPTck"
        Me.cmdCSPTck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCSPTck.Size = New System.Drawing.Size(152, 42)
        Me.cmdCSPTck.TabIndex = 4
        Me.cmdCSPTck.Text = "CSP Family"
        Me.cmdCSPTck.UseVisualStyleBackColor = False
        '
        'cmdSeniorTck
        '
        Me.cmdSeniorTck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSeniorTck.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSeniorTck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSeniorTck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSeniorTck.Location = New System.Drawing.Point(314, 178)
        Me.cmdSeniorTck.Name = "cmdSeniorTck"
        Me.cmdSeniorTck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSeniorTck.Size = New System.Drawing.Size(152, 42)
        Me.cmdSeniorTck.TabIndex = 3
        Me.cmdSeniorTck.Text = "Senior"
        Me.cmdSeniorTck.UseVisualStyleBackColor = False
        '
        'cmdStudentTck
        '
        Me.cmdStudentTck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdStudentTck.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStudentTck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStudentTck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStudentTck.Location = New System.Drawing.Point(314, 124)
        Me.cmdStudentTck.Name = "cmdStudentTck"
        Me.cmdStudentTck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStudentTck.Size = New System.Drawing.Size(152, 42)
        Me.cmdStudentTck.TabIndex = 2
        Me.cmdStudentTck.Text = "Student"
        Me.cmdStudentTck.UseVisualStyleBackColor = False
        '
        'cmdAdultTck
        '
        Me.cmdAdultTck.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAdultTck.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdultTck.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdultTck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdultTck.Location = New System.Drawing.Point(314, 70)
        Me.cmdAdultTck.Name = "cmdAdultTck"
        Me.cmdAdultTck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdultTck.Size = New System.Drawing.Size(152, 42)
        Me.cmdAdultTck.TabIndex = 1
        Me.cmdAdultTck.Text = "Adult"
        Me.cmdAdultTck.UseVisualStyleBackColor = False
        '
        '_Label1_16
        '
        Me._Label1_16.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_16, CType(16, Short))
        Me._Label1_16.Location = New System.Drawing.Point(163, 465)
        Me._Label1_16.Name = "_Label1_16"
        Me._Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_16.Size = New System.Drawing.Size(25, 20)
        Me._Label1_16.TabIndex = 55
        Me._Label1_16.Text = "X"
        '
        '_Label1_15
        '
        Me._Label1_15.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_15.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_15, CType(15, Short))
        Me._Label1_15.Location = New System.Drawing.Point(163, 410)
        Me._Label1_15.Name = "_Label1_15"
        Me._Label1_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_15.Size = New System.Drawing.Size(25, 20)
        Me._Label1_15.TabIndex = 54
        Me._Label1_15.Text = "X"
        '
        '_Label1_14
        '
        Me._Label1_14.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_14.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_14, CType(14, Short))
        Me._Label1_14.Location = New System.Drawing.Point(163, 355)
        Me._Label1_14.Name = "_Label1_14"
        Me._Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_14.Size = New System.Drawing.Size(25, 20)
        Me._Label1_14.TabIndex = 53
        Me._Label1_14.Text = "X"
        '
        '_Label1_13
        '
        Me._Label1_13.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_13.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_13, CType(13, Short))
        Me._Label1_13.Location = New System.Drawing.Point(163, 300)
        Me._Label1_13.Name = "_Label1_13"
        Me._Label1_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_13.Size = New System.Drawing.Size(25, 20)
        Me._Label1_13.TabIndex = 52
        Me._Label1_13.Text = "X"
        '
        '_Label1_12
        '
        Me._Label1_12.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_12.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_12, CType(12, Short))
        Me._Label1_12.Location = New System.Drawing.Point(163, 245)
        Me._Label1_12.Name = "_Label1_12"
        Me._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_12.Size = New System.Drawing.Size(25, 20)
        Me._Label1_12.TabIndex = 51
        Me._Label1_12.Text = "X"
        '
        '_Label1_11
        '
        Me._Label1_11.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_11.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_11, CType(11, Short))
        Me._Label1_11.Location = New System.Drawing.Point(163, 190)
        Me._Label1_11.Name = "_Label1_11"
        Me._Label1_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_11.Size = New System.Drawing.Size(25, 20)
        Me._Label1_11.TabIndex = 50
        Me._Label1_11.Text = "X"
        '
        '_Label1_10
        '
        Me._Label1_10.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_10, CType(10, Short))
        Me._Label1_10.Location = New System.Drawing.Point(163, 135)
        Me._Label1_10.Name = "_Label1_10"
        Me._Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_10.Size = New System.Drawing.Size(25, 20)
        Me._Label1_10.TabIndex = 49
        Me._Label1_10.Text = "X"
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_9, CType(9, Short))
        Me._Label1_9.Location = New System.Drawing.Point(163, 80)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_9.Size = New System.Drawing.Size(25, 20)
        Me._Label1_9.TabIndex = 48
        Me._Label1_9.Text = "X"
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_8, CType(8, Short))
        Me._Label1_8.Location = New System.Drawing.Point(466, 510)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_8.Size = New System.Drawing.Size(25, 20)
        Me._Label1_8.TabIndex = 47
        Me._Label1_8.Text = "X"
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_7, CType(7, Short))
        Me._Label1_7.Location = New System.Drawing.Point(466, 456)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_7.Size = New System.Drawing.Size(25, 20)
        Me._Label1_7.TabIndex = 16
        Me._Label1_7.Text = "X"
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_6, CType(6, Short))
        Me._Label1_6.Location = New System.Drawing.Point(466, 404)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(25, 20)
        Me._Label1_6.TabIndex = 15
        Me._Label1_6.Text = "X"
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_5, CType(5, Short))
        Me._Label1_5.Location = New System.Drawing.Point(466, 349)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(25, 20)
        Me._Label1_5.TabIndex = 14
        Me._Label1_5.Text = "X"
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(466, 296)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(25, 20)
        Me._Label1_4.TabIndex = 13
        Me._Label1_4.Text = "X"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(466, 242)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(25, 20)
        Me._Label1_3.TabIndex = 12
        Me._Label1_3.Text = "X"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(466, 187)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(25, 20)
        Me._Label1_2.TabIndex = 11
        Me._Label1_2.Text = "X"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(466, 133)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(25, 20)
        Me._Label1_1.TabIndex = 10
        Me._Label1_1.Text = "X"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(466, 79)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(25, 20)
        Me._Label1_0.TabIndex = 9
        Me._Label1_0.Text = "X"
        '
        'ResetCount
        '
        '
        'cmdN1
        '
        '
        'MSFlexGrid1
        '
        Me.MSFlexGrid1.Location = New System.Drawing.Point(637, 74)
        Me.MSFlexGrid1.Name = "MSFlexGrid1"
        Me.MSFlexGrid1.OcxState = CType(resources.GetObject("MSFlexGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSFlexGrid1.Size = New System.Drawing.Size(407, 429)
        Me.MSFlexGrid1.TabIndex = 27
        '
        'lblShowTitle
        '
        Me.lblShowTitle.AutoSize = True
        Me.lblShowTitle.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowTitle.Location = New System.Drawing.Point(501, 34)
        Me.lblShowTitle.Name = "lblShowTitle"
        Me.lblShowTitle.Size = New System.Drawing.Size(127, 28)
        Me.lblShowTitle.TabIndex = 74
        Me.lblShowTitle.Text = "Show Title"
        '
        'lblSaved
        '
        Me.lblSaved.AutoSize = True
        Me.lblSaved.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Blue
        Me.lblSaved.Location = New System.Drawing.Point(1066, 120)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(80, 22)
        Me.lblSaved.TabIndex = 75
        Me.lblSaved.Text = "(Saved)"
        Me.lblSaved.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Special Tickets"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 19)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Standard Tickets"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1194, 576)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.lblShowTitle)
        Me.Controls.Add(Me.btnSaveData)
        Me.Controls.Add(Me._ResetCount_16)
        Me.Controls.Add(Me._ResetCount_15)
        Me.Controls.Add(Me._ResetCount_14)
        Me.Controls.Add(Me._ResetCount_13)
        Me.Controls.Add(Me._ResetCount_12)
        Me.Controls.Add(Me._ResetCount_11)
        Me.Controls.Add(Me._ResetCount_10)
        Me.Controls.Add(Me._ResetCount_9)
        Me.Controls.Add(Me._txtN1_7)
        Me.Controls.Add(Me._txtN1_6)
        Me.Controls.Add(Me._txtN1_5)
        Me.Controls.Add(Me._txtN1_4)
        Me.Controls.Add(Me._txtN1_3)
        Me.Controls.Add(Me._txtN1_2)
        Me.Controls.Add(Me._txtN1_1)
        Me.Controls.Add(Me._txtN1_0)
        Me.Controls.Add(Me.cmdN1_0)
        Me.Controls.Add(Me.cmdN1_1)
        Me.Controls.Add(Me.cmdN1_2)
        Me.Controls.Add(Me.cmdN1_3)
        Me.Controls.Add(Me.cmdN1_4)
        Me.Controls.Add(Me.cmdN1_5)
        Me.Controls.Add(Me.cmdN1_6)
        Me.Controls.Add(Me.cmdN1_7)
        Me.Controls.Add(Me._ResetCount_8)
        Me.Controls.Add(Me.txtDiscountCnt)
        Me.Controls.Add(Me.cmdDiscount)
        Me.Controls.Add(Me._ResetCount_7)
        Me.Controls.Add(Me._ResetCount_6)
        Me.Controls.Add(Me._ResetCount_5)
        Me.Controls.Add(Me._ResetCount_4)
        Me.Controls.Add(Me._ResetCount_3)
        Me.Controls.Add(Me._ResetCount_2)
        Me.Controls.Add(Me._ResetCount_1)
        Me.Controls.Add(Me._ResetCount_0)
        Me.Controls.Add(Me.MSFlexGrid1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtPromoCnt)
        Me.Controls.Add(Me.txtMilitaryCnt)
        Me.Controls.Add(Me.txtSeasonCnt)
        Me.Controls.Add(Me.txtCompCnt)
        Me.Controls.Add(Me.txtFamilyCnt)
        Me.Controls.Add(Me.txtSeniorCnt)
        Me.Controls.Add(Me.txtStudentCnt)
        Me.Controls.Add(Me.txtAdultCnt)
        Me.Controls.Add(Me.cmdPromoTck)
        Me.Controls.Add(Me.cmdMilitaryTck)
        Me.Controls.Add(Me.cmdSeasonTck)
        Me.Controls.Add(Me.cmdCompTck)
        Me.Controls.Add(Me.cmdCSPTck)
        Me.Controls.Add(Me.cmdSeniorTck)
        Me.Controls.Add(Me.cmdStudentTck)
        Me.Controls.Add(Me.cmdAdultTck)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me._Label1_16)
        Me.Controls.Add(Me._Label1_15)
        Me.Controls.Add(Me._Label1_14)
        Me.Controls.Add(Me._Label1_13)
        Me.Controls.Add(Me._Label1_12)
        Me.Controls.Add(Me._Label1_11)
        Me.Controls.Add(Me._Label1_10)
        Me.Controls.Add(Me._Label1_9)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(81, 128)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Camarillo Skyway Playhouse Box Office"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResetCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdN1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtN1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSFlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblShowTitle As System.Windows.Forms.Label
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPrintReport As System.Windows.Forms.Button
#End Region
End Class