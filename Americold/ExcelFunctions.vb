Module ExcelFunctions

    Public Sub CreateExcelWorkbook()

        Dim xlApp As Excel.Application
        Dim Workbook As Excel.Workbook
        Dim firstDayOfWeek As String
        Dim lastDayOfWeek As String
        Dim today As Date = Date.Today
        Dim dayDiffSat As Integer = today.DayOfWeek - DayOfWeek.Saturday
        Dim dayDiffSun As Integer = today.DayOfWeek - DayOfWeek.Sunday
        Dim xlFileName As String

        firstDayOfWeek = today.AddDays(-dayDiffSun)
        lastDayOfWeek = today.AddDays(-dayDiffSat)
        xlFileName = "C:\Users\TJB\Google Drive\Work\Work-Program\" + firstDayOfWeek + "-" + lastDayOfWeek + " Security Logs.xlsm"

        xlApp = CreateObject("Excel.Application")
        Workbook = xlApp.Workbooks.Add

        Workbook.Worksheets.Add.Name = "Trailer Log"
        Workbook.Worksheets.Add.Name = "Burn Time Log"
        Workbook.Worksheets.Add.Name = "Reefer Check Sheet"
        Workbook.Worksheets.Add.Name = "Reefer Log"

        Workbook.SaveCopyAs(xlFileName) 'Why you no work?
        xlApp.Quit()

    End Sub

    Public Sub ImportTLToExcel()

    End Sub

    Public Sub ImportBTLToExcel()

    End Sub

    Public Sub ImportRCSToExcel()

    End Sub

    Public Sub ImportRLToExcel()

    End Sub

    Public Sub ImportPDLToExcel()

    End Sub

End Module
