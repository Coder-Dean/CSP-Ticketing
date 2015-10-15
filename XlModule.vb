'Option Strict On
Imports Excel = Microsoft.Office.Interop.Excel

Module XlModule
    'the excel template file to use as our template
    Public Const ExcelTemplateFoh As String = "\FOH_Template.xltx"
    Dim xApp As New Microsoft.Office.Interop.Excel.Application
    Dim xWorkbook As Microsoft.Office.Interop.Excel.Workbook
    Dim xWorksheet As Microsoft.Office.Interop.Excel.Worksheet

    Public Function CreateExcelSheet() As Boolean
        Dim xFilename As String 'current daily report
        Dim extn As String = "(0)"  'debug help

        CreateExcelSheet = False
        Try
            extn = "(1)"
            'format filename as year_month_day
            xFilename = "Foh_Closeout_" & Format(Date.Now, "yyyy") & "_" & Format(Date.Now, "MM") & "_" & Format(Date.Now, "dd") & ".xlsx"
            'add path to file
            xFilename = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & xFilename

            'check whether Excel is installed
            If xApp Is Nothing Then
                MessageBox.Show("Excel is not properly installed.", "System Error")
                Return False
            End If
            extn = "(2)"

            'open template file
            xWorkbook = xApp.Workbooks.Open(My.Application.Info.DirectoryPath & ExcelTemplateFoh)
            'only for debug
            '#If DEBUG Then
            '            xApp.Visible = True
            '#End If
            extn = "(3)"

            'rename template file as daily file and save in my docs
            xWorkbook.SaveAs(xFilename)
            extn = "(4)"

            xWorksheet = CType(xWorkbook.Worksheets("sheet1"), Excel.Worksheet)

            CreateExcelSheet = True

        Catch Err As Exception
            MsgBox(Err.Message, MsgBoxStyle.OkOnly, "CreateExcelSheet Error " & extn)
            CloseReleaseExcel()
        End Try

    End Function

    Public Function CloseReleaseExcel() As Boolean

        CloseReleaseExcel = False
        Try
            xWorkbook.Close(True)
            xApp.Quit()
            'releaseObject(xWorksheet)
            'releaseObject(xWorkbook)
            'releaseObject(xApp)

            CloseReleaseExcel = True

        Catch Err As Exception
            MsgBox(Err.Message, MsgBoxStyle.OkOnly, "CloseExcelApp Error")
        End Try

    End Function

    Public Sub WriteFOH_Info()
        Try
            xWorksheet.Cells(3, 1).Value = "Current Show: " & Current_Show_Name & "      " & Format(Date.Now, "Long Date")
            With daily_receipt
                'do special ticket names
                xWorksheet.Cells(29, 1).Value = special_ticket_data.sp_ticket(0).sp_ticket_name
                xWorksheet.Cells(30, 1).Value = special_ticket_data.sp_ticket(1).sp_ticket_name
                xWorksheet.Cells(31, 1).Value = special_ticket_data.sp_ticket(2).sp_ticket_name
                xWorksheet.Cells(32, 1).Value = special_ticket_data.sp_ticket(3).sp_ticket_name
                xWorksheet.Cells(33, 1).Value = special_ticket_data.sp_ticket(4).sp_ticket_name
                xWorksheet.Cells(34, 1).Value = special_ticket_data.sp_ticket(5).sp_ticket_name
                xWorksheet.Cells(35, 1).Value = special_ticket_data.sp_ticket(6).sp_ticket_name
                xWorksheet.Cells(36, 1).Value = special_ticket_data.sp_ticket(7).sp_ticket_name
                'do ticket count
                xWorksheet.Cells(20, 2).Value = .adult_cnt
                xWorksheet.Cells(21, 2).Value = .student_cnt
                xWorksheet.Cells(22, 2).Value = .senior_cnt
                xWorksheet.Cells(23, 2).Value = .season_cnt
                xWorksheet.Cells(24, 2).Value = .family_cnt
                xWorksheet.Cells(25, 2).Value = .military_cnt
                xWorksheet.Cells(26, 2).Value = .comp_cnt
                xWorksheet.Cells(27, 2).Value = .promo_cnt
                xWorksheet.Cells(28, 2).Value = .discount_cnt
                xWorksheet.Cells(29, 2).Value = .special_cnt_1
                xWorksheet.Cells(30, 2).Value = .special_cnt_2
                xWorksheet.Cells(31, 2).Value = .special_cnt_3
                xWorksheet.Cells(32, 2).Value = .special_cnt_4
                xWorksheet.Cells(33, 2).Value = .special_cnt_5
                xWorksheet.Cells(34, 2).Value = .special_cnt_6
                xWorksheet.Cells(35, 2).Value = .special_cnt_7
                xWorksheet.Cells(36, 2).Value = .special_cnt_8
                xWorksheet.Cells(37, 2).Formula = "=SUM(B20:B36)"
                'co ticket monies
                xWorksheet.Cells(20, 4).Value = .adult_cost
                xWorksheet.Cells(21, 4).Value = .student_cost
                xWorksheet.Cells(22, 4).Value = .senior_cost
                xWorksheet.Cells(23, 4).Value = .season_cost
                xWorksheet.Cells(24, 4).Value = .family_cost
                xWorksheet.Cells(25, 4).Value = .military_cost
                xWorksheet.Cells(26, 4).Value = .comp_cost
                xWorksheet.Cells(27, 4).Value = .promo_cost
                xWorksheet.Cells(28, 4).Value = .discount_cost
                xWorksheet.Cells(29, 4).Value = .special_cost_1
                xWorksheet.Cells(30, 4).Value = .special_cost_2
                xWorksheet.Cells(31, 4).Value = .special_cost_3
                xWorksheet.Cells(32, 4).Value = .special_cost_4
                xWorksheet.Cells(33, 4).Value = .special_cost_5
                xWorksheet.Cells(34, 4).Value = .special_cost_6
                xWorksheet.Cells(35, 4).Value = .special_cost_7
                xWorksheet.Cells(36, 4).Value = .special_cost_8
                xWorksheet.Cells(37, 4).Formula = "=SUM(D20:D36)"
            End With
            'write transaction summary
            xWorksheet.Cells(33, 6).Value = " " & total_transaction.cash_monies.ToString("C2") & " on " & _
                total_transaction.cash_cnt.ToString("##0") & " cash sales."
            xWorksheet.Cells(34, 6).Value = " " & total_transaction.check_monies.ToString("C2") & " on " & _
                total_transaction.check_cnt.ToString("##0") & " check sales."
            xWorksheet.Cells(35, 6).Value = " " & total_transaction.credit_monies.ToString("C2") & " on " & _
                total_transaction.credit_cnt.ToString("##0") & " credit sales."
            xWorksheet.Cells(36, 6).Value = " " & total_transaction.online_monies.ToString("C2") & " on " & _
                total_transaction.online_cnt.ToString("##0") & " online sales."

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "WriteFOH_Info Error")
        End Try

    End Sub

    Public Sub PrintFOHReport()
        Try
            xWorksheet.PrintOut(1, 1, 1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "PrintFOHReport Error")
        End Try
    End Sub

    Public Sub SaveFOHReport()
        Try
            xWorkbook.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SaveFOHReport Error")
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "releaseObject Error")
            'obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module

