Attribute VB_Name = "DbExl"
Option Explicit

Public RExl As Object
Const STAT_START_ROW = 18
Const DATA_START_ROW_NULL = 8
Const DATA_START_ROW_FS = 26
Const LIMIT_START_ROW_NULL = 2
Const LIMIT_START_ROW_FS = 4
Const CALC_RESULTS_START_COL = 2

Dim TestDate As String
Dim FirstDate As String
Dim LastDate As String

#Const PRINTER_READY = 1  'skip printing in debug (debug=0)
#Const SHOW_EXCEL = 1   'debug excel sheets/charts (debug=1)
Dim ContinuePrinting As KEY_RESPONSE    'allows quiting during print action




'*****************************************************************
Public Sub LoadExcel()
    Dim xRow As Long, xCol As Long, last_float_col As Long
    Dim i As Integer
    
  
    On Error GoTo ErrorHandler

    
    If OpenExcel() = False Then 'check if we can open Excel
        Exit Sub
    Else
        RExl.Workbooks.Add  'all OK so open New Work Book
    End If
   

 
    
    With RExl.ActiveSheet
        i = 0
        xRow = DATA_START_ROW_NULL 'starting row for data in grid
        xCol = CALC_RESULTS_START_COL

   
       
        'Load data into Excel using global database recordset
   

    
    With RExl
        '******** setup cell formats **********
        'floating point numerical data cells
'        Rng = "B" & DATA_START_ROW_NULL& ":" & Chr(3 + Asc("B") - 2) & _
'            DATA_START_ROW_NULL+ total_tested - 1
'        .Range(Rng).Select
'        .Selection.NumberFormat = "0.000"
'        xcol = 3   'format columns by options
'        'Nest number cells (format is always in printout even if data is not)
'        Rng = Chr(xcol + Asc("A")) & DATA_START_ROW_NULL- 1 & ":" & _
'            Chr(xcol + Asc("A")) & DATA_START_ROW_NULL+ total_tested - 1
'        .Range(Rng).Select
'        .Range(Rng).HorizontalAlignment = xlCenter
'        xcol = xcol + 1
        
'        'status cells (always in printout)
'        Rng = Chr(xcol + Asc("A")) & DATA_START_ROW_NULL- 1 & ":" & _
'            Chr(xcol + Asc("A")) & DATA_START_ROW_NULL+ total_tested - 1
'        .Range(Rng).Select
'        .Selection.HorizontalAlignment = xlCenter
'        xcol = xcol + 1
        
        'write header for the statistics block
        .Cells(DATA_START_ROW_NULL - 1, 1).Value = "Process Statistics P1"
        .Cells(DATA_START_ROW_FS - 1, 1).Value = "Process Statistics P3"
        
        'now add text for totals
'        .Cells(STAT_START_ROW - 1, 1).Value = "Total Tested = " & Format(total_tested, "0")
'        .Cells(STAT_START_ROW - 1, 4).Value = "Total Failed = " & Format(total_failed, "0")
        
        If SampleData.UseSampling = True Then
            'write labels for CalcStatistics sub
            .Cells(LIMIT_START_ROW_NULL, 1).Value = "P1 Low Limit = "
            .Cells(LIMIT_START_ROW_NULL + 1, 1).Value = "P1 High Limit = "
            .Cells(LIMIT_START_ROW_FS, 1).Value = "P3 Low Limit = "
            .Cells(LIMIT_START_ROW_FS + 1, 1).Value = "P3 High Limit = "
            .Cells(LIMIT_START_ROW_NULL, 3).Value = Format(spec.prs1Lo, "0.000")
            .Cells(LIMIT_START_ROW_NULL + 1, 3).Value = Format(spec.prs1Hi, "0.000")
            .Cells(LIMIT_START_ROW_FS, 3).Value = Format(spec.prs3Lo, "0.000")
            .Cells(LIMIT_START_ROW_FS + 1, 3).Value = Format(spec.prs3Hi, "0.000")
            
            For i = 0 To SampleData.AvgSamples - 1
                .Cells(DATA_START_ROW_NULL + i, 1).Value = "s" & i + 1
                .Cells(DATA_START_ROW_FS + i, 1).Value = "s" & i + 1
            Next
            .Cells(DATA_START_ROW_NULL + 10, 1).Value = "Minimum"
            .Cells(DATA_START_ROW_NULL + 11, 1).Value = "Maximum"
            .Cells(DATA_START_ROW_NULL + 12, 1).Value = "Mean"
            .Cells(DATA_START_ROW_NULL + 13, 1).Value = "Std Dev"
            .Cells(DATA_START_ROW_NULL + 14, 1).Value = "Cp"
            .Cells(DATA_START_ROW_NULL + 15, 1).Value = "Cpk"
            
            .Cells(DATA_START_ROW_FS + 10, 1).Value = "Minimum"
            .Cells(DATA_START_ROW_FS + 11, 1).Value = "Maximum"
            .Cells(DATA_START_ROW_FS + 12, 1).Value = "Mean"
            .Cells(DATA_START_ROW_FS + 13, 1).Value = "Std Dev"
            .Cells(DATA_START_ROW_FS + 14, 1).Value = "Cp"
            .Cells(DATA_START_ROW_FS + 15, 1).Value = "Cpk"
        End If
        
             

'        frmMain.UpdateCalcInfo "Writing Excel text fields..."
'        CreateHeader RExl  'write all header info to worksheet
'        CreateDataLine RExl  'write data line info to worksheet
'        frmMain.UpdateCalcProgress
        

        
'        SetPrintProperties .ActiveSheet.PageSetup
'        frmMain.UpdateCalcProgress
        

        
#If PRINTER_READY = 1 Then
'        ContinuePrinting = YesKeyPressed
'        If PrnOptions.UsePrintPreview = True Then
'            RExl.Visible = True
'            .WindowState = xlMaximized
'            .ActiveSheet.PrintPreview
'            .WindowState = xlMinimized
'            RExl.Visible = False
'            ContinuePrinting = SystemMsgBox("Continue DATA PRINT?", QuestionMsg, "Printing...", YesNoKey)
'        End If
'        If ContinuePrinting = YesKeyPressed Then
'            If PrnOptions.PrintRawData = True Then
'                .ActiveSheet.PrintOut
'            Else
'                .Rows(DATA_START_ROW_NULL- 2).PageBreak = xlPageBreakManual
'                .ActiveSheet.PrintOut 1, 1
'            End If
'        End If
#End If
        

'        frmMain.UpdateCalcInfo "Creating Excel Chart #1..."
'        err_step = 4
'        Sheets("sheet1").Activate
'        CreateExcelChart RExl, "B", " PRESSURE 1 ", spec.prs1Lo, spec.prs1Hi, total_tested, _
'            total_failed, TestDate, 0
        frmMain.UpdateCalcProgress
        


'        frmMain.UpdateCalcInfo "Creating Excel Chart #2..."
'        Sheets("sheet1").Activate
'        CreateExcelChart RExl, "D", " PRESSURE 3 ", spec.prs3Lo, spec.prs3Hi, total_tested, _
'            total_failed, TestDate, 2
        frmMain.UpdateCalcProgress
        

    End With

    GoTo CleanExit
    
ErrorHandler:
    Screen.MousePointer = vbDefault
    DoEvents    'needed to update mouse
    SystemMsgBox Err.Description, CriticalMsg, "Excel Error -[LoadExcel " & err_step & "]", _
        OkKeyOnly
CleanExit:
    Set rsMaster = Nothing

End Sub


'**************************************************
Public Sub CreateHeader(XObj As Object)
    Dim xRow As Integer, xCol As Integer
    
    On Error GoTo ErrorHandler
    'set up header
    With XObj
        .Cells(1, 4).Value = "KAVLICO, A COMPANY OF SCHENIDER ELECTRIC"
        .Cells(2, 4).Value = "PRESSURE TEST DATA"
        .Cells(4, 1).Value = "PartNumber: " & spec.PartNum
        .Cells(4, 5).Value = "Customer: " & spec.CustomerName
        .Cells(4, 7).Value = "TrackingNumber: " & spec.TrackingNumber
        .Cells(5, 1).Value = "Test Date: " & TestDate
        .Cells(5, 5).Value = "Work Order: " & spec.LotNum
       
            .Cells(5, 7).Value = "Temperature: " & Format(spec.Temperature, "0") & Chr(176)
            .Cells(5, 7).HorizontalAlignment = xlRight
       
        .Cells(7, 1).Value = "Test Pressures, " & spec.mode
        
        .Cells(4, 7).HorizontalAlignment = xlLeft
        'now do parameters as one line because we don't know the column size if the
        'operator changes the number of columns to print
        .Cells(7, 4).Value = "Test Parameters    High Limits    Low Limits"
        .Cells(7, 4).HorizontalAlignment = xlLeft
        xRow = 8    'next row in sheet
        
            .Cells(DATA_START_ROW_NULL - 1, 2).Value = "P1"
            .Cells(DATA_START_ROW_NULL - 1, 2).HorizontalAlignment = xlRight
            .Cells(xRow, 1).Value = "P1:  " & spec.prs1
            .Cells(xRow, 4).Value = "P1" & Space(29) & Format(spec.prs1Hi, "0.000") & _
            Space(12) & Format(spec.prs1Lo, "0.000")
            .Cells(xRow, 4).HorizontalAlignment = xlLeft
            xRow = xRow + 1
        
       
            .Cells(DATA_START_ROW_NULL - 1, 3).Value = "P2"
            .Cells(DATA_START_ROW_NULL - 1, 3).HorizontalAlignment = xlRight
            .Cells(xRow, 1).Value = "P2:  " & spec.prs2
            .Cells(xRow, 4).Value = "P2" & Space(29) & Format(spec.prs2Hi, "0.000") & _
            Space(12) & Format(spec.prs2Lo, "0.000")
            .Cells(xRow, 4).HorizontalAlignment = xlLeft
            xRow = xRow + 1
       
       
            .Cells(DATA_START_ROW_NULL - 1, 4).Value = "P3"
            .Cells(DATA_START_ROW_NULL - 1, 4).HorizontalAlignment = xlRight
            .Cells(xRow, 1).Value = "P3:  " & spec.prs3
            .Cells(xRow, 4).Value = "P3" & Space(29) & Format(spec.prs3Hi, "0.000") & _
                 Space(12) & Format(spec.prs3Lo, "0.000")
            .Cells(xRow, 4).HorizontalAlignment = xlLeft
            xRow = xRow + 1
       
        
            .Cells(xRow, 4).Value = "Linearity" & Space(40) & Format(spec.linearity, "0.00")
            .Cells(xRow, 4).HorizontalAlignment = xlLeft
            xRow = xRow + 1
 
        
    End With
    Exit Sub
    
ErrorHandler:
    SystemMsgBox Err.Description, CriticalMsg, "Excel Error - [CreateHeader]", OkKeyOnly

End Sub

'**************************************************
Public Sub CreateDataLine(XObj As Object)
    Dim xRow As Integer, xCol As Integer
    
    On Error GoTo ErrorHandler
    'set up header
    With XObj
        .Cells(DATA_START_ROW_NULL - 1, 1).Value = "Part"
        .Cells(DATA_START_ROW_NULL - 1, 1).HorizontalAlignment = xlRight
        .Cells(DATA_START_ROW_NULL - 1, 1).ColumnWidth = 8.4
        .Cells(DATA_START_ROW_NULL - 1, 2).ColumnWidth = 8.4
        .Cells(DATA_START_ROW_NULL - 1, 3).ColumnWidth = 8.4
        .Cells(DATA_START_ROW_NULL - 1, 4).ColumnWidth = 8.4
        
        xCol = 5
            .Cells(DATA_START_ROW_NULL - 1, xCol).Value = "Span"
            .Cells(DATA_START_ROW_NULL - 1, xCol).HorizontalAlignment = xlRight
            .Cells(DATA_START_ROW_NULL - 1, xCol).ColumnWidth = 8.4
            xCol = xCol + 1

 
            .Cells(DATA_START_ROW_NULL - 1, xCol).Value = "Lin"
            .Cells(DATA_START_ROW_NULL - 1, xCol).HorizontalAlignment = xlRight
            .Cells(DATA_START_ROW_NULL - 1, xCol).ColumnWidth = 8.4
            xCol = xCol + 1
 
        
        .Cells(DATA_START_ROW_NULL - 1, xCol).ColumnWidth = 4   '(Nest format always there)
 
            .Cells(DATA_START_ROW_NULL - 1, xCol).Value = "Nest"
            .Cells(DATA_START_ROW_NULL - 1, xCol).HorizontalAlignment = xlCenter
 
        xCol = xCol + 1
        
        .Cells(DATA_START_ROW_NULL - 1, xCol).Value = "Status"
        .Cells(DATA_START_ROW_NULL - 1, xCol).HorizontalAlignment = xlCenter
        .Cells(DATA_START_ROW_NULL - 1, xCol).ColumnWidth = 19.5
        xCol = xCol + 1
        
        .Cells(DATA_START_ROW_NULL - 1, xCol).ColumnWidth = 19.5 '(SerialNum format always there)

            .Cells(DATA_START_ROW_NULL - 1, xCol).Value = "SerialNum"
            .Cells(DATA_START_ROW_NULL - 1, xCol).HorizontalAlignment = xlCenter
'            xcol = xcol + 1
   
        'now create a line to separate header from data
        .Range("A" & DATA_START_ROW_NULL - 2 & ":" & Chr(xCol + Asc("A") - 1) & _
            DATA_START_ROW_NULL - 2).Select
        .Selection.Borders(xlDiagonalDown).LineStyle = xlNone
        .Selection.Borders(xlDiagonalUp).LineStyle = xlNone
        .Selection.Borders(xlEdgeLeft).LineStyle = xlNone
        .Selection.Borders(xlEdgeTop).LineStyle = xlNone
        .Selection.Borders(xlEdgeBottom).LineStyle = xlDouble
        .Selection.Borders(xlEdgeBottom).Weight = xlThick
        .Selection.Borders(xlEdgeBottom).ColorIndex = xlAutomatic
    End With
    Exit Sub
    
ErrorHandler:
    SystemMsgBox Err.Description, CriticalMsg, "Excel Error - [CreateDataLine]", OkKeyOnly
    
End Sub


'**************************************************
Public Sub SetPrintProperties(XObj As Object)
    On Error GoTo ErrorHandler
    With XObj
        .RightFooter = ""
        .LeftMargin = Application.InchesToPoints(0.55)
        .RightMargin = Application.InchesToPoints(0.25)
        .TopMargin = Application.InchesToPoints(0)
        .BottomMargin = Application.InchesToPoints(0)
        .HeaderMargin = Application.InchesToPoints(0)
        .FooterMargin = Application.InchesToPoints(0)
        .Zoom = 100
        .Orientation = xlPortrait
    End With
    Exit Sub
    
ErrorHandler:
    SystemMsgBox Err.Description, CriticalMsg, "Excel Error - [SetPrintProperties]", OkKeyOnly
    
End Sub

'**************************************************
Public Function OpenExcel() As Boolean

    On Error Resume Next
        
    ' See if Excel is already running
    Set RExl = GetObject(, "Excel.Application") 'sets error if not running
    
    If Err.Number <> 0 Then
        Err.Clear
        'must create a reference: [Project.References.Microsoft Excel 8.0 Object Library]
        ' If it was not running start a new instance
        Set RExl = New Excel.Application
        'check if new worked
        If Err.Number <> 0 Then
            SystemMsgBox "Can't Create Excel Object!", _
                CriticalMsg, "Database Error - [OpenExcel]"
            OpenExcel = False
            Exit Function 'give up
        End If
    End If
    
#If SHOW_EXCEL = 1 Then ' Make Excel Visible for debugging
    RExl.Visible = True
    RExl.WindowState = xlMinimized
#End If

    OpenExcel = True
    
End Function

'*****************************************************************
Public Sub CloseExcel()

    On Error GoTo ErrorHandler



    RExl.WindowState = xlMinimized
    RExl.DisplayAlerts = False
    RExl.Quit
    Set RExl = Nothing
        


    Exit Sub
    
ErrorHandler:
    SystemMsgBox Err.Description, CriticalMsg, "Excel Error - [CloseExcel]", OkKeyOnly

End Sub

'**********************************************
Public Sub WriteMaintLog(msg As String)
    Dim filenum As Integer
    Dim txt_str As String
    
    On Error GoTo ErrorHandler
    filenum = FreeFile(0)   'get available file number
    Open App.Path & "\Maint.Log" For Append As #filenum
    txt_str = msg & " at " & Date & " " & Time
    Print #filenum, txt_str
    Close #filenum
    
ErrorHandler:       ' Error-handling routine.
    'if problems with file handler just return
End Sub
 
