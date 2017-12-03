Imports System
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Security
Imports System.Windows.Forms.DataGridView
Imports System.Windows.Forms.DataGrid
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Core

Public Module FormFunctions

    Dim RCSEntries As New Microsoft.VisualBasic.Collection()
    Dim currentRCSEntryTime As String

    Public Function GetFileHash(ByVal filePath As String)

        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        f.Close()

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next

        Dim md5string As String
        md5string = buff.ToString()

        Return md5string

    End Function

    Public Function GetHash(ByVal enteredInfo As Byte())

        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider

        md5.ComputeHash(enteredInfo)

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next

        Dim md5string As String
        md5string = buff.ToString()

        Return md5string

    End Function

    Public Sub SetTLInputBlank()

        frmMain.radTLIn.Checked = False
        frmMain.radTLOut.Checked = False
        frmMain.txtTLCompany.Text = ""
        frmMain.txtTLTruck.Text = ""
        frmMain.txtTLTrailer.Text = ""
        frmMain.txtTLDoor.Text = ""
        frmMain.txtTLConf.Text = ""
        frmMain.txtTLTime.Text = ""
        frmMain.chkTLDO.Checked = False
        frmMain.chkTLPU.Checked = False
        frmMain.txtTLSeal.Text = ""
        frmMain.txtTLSetTemp.Text = ""
        frmMain.txtTLCurrentTemp.Text = ""

    End Sub

    Public Function CheckTLInputBlanks()

        If frmMain.radTLIn.Checked = False And frmMain.radTLOut.Checked = False Then
            MessageBox.Show("Please select either 'In' or 'Out.'")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLCompany.Text) Then
            MessageBox.Show("Please enter the company name.")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLTruck.Text) Then
            MessageBox.Show("Please enter the truck number.")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLTrailer.Text) Then
            MessageBox.Show("Please enter the trailer number.")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLDoor.Text) Then
            MessageBox.Show("Please enter the door number.")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLConf.Text) Then
            MessageBox.Show("Please enter the conference number.")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLSeal.Text) Then
            MessageBox.Show("Please enter the seal number.")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLSetTemp.Text) Then
            MessageBox.Show("Please enter the set temperature.")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLCurrentTemp.Text) Then
            MessageBox.Show("Please enter the current tempterature.")
            SetTLInputBlank()
            Return True
        ElseIf frmMain.chkTLDO.Checked = False And frmMain.chkTLPU.Checked = False Then
            MessageBox.Show("Please select PU and/or DO.")
            SetTLInputBlank()
            Return True
        ElseIf String.IsNullOrWhiteSpace(frmMain.txtTLTime.Text) Then
            MessageBox.Show("Please enter the time.")
            SetTLInputBlank()
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub PopulateTL(InOut)

        If InOut = "In" Then
            frmMain.dgvTLInfo.Rows.Add(New String() {"X", "-", frmMain.txtTLCompany.Text.ToUpper, frmMain.txtTLTruck.Text.ToUpper, frmMain.txtTLTrailer.Text.ToUpper,
                                             frmMain.txtTLDoor.Text.ToUpper, frmMain.txtTLConf.Text.ToUpper, frmMain.txtTLTime.Text.ToUpper})
        Else
            frmMain.dgvTLInfo.Rows.Add(New String() {"-", "X", frmMain.txtTLCompany.Text.ToUpper, frmMain.txtTLTruck.Text.ToUpper, frmMain.txtTLTrailer.Text.ToUpper,
                                            frmMain.txtTLDoor.Text.ToUpper, frmMain.txtTLConf.Text.ToUpper, frmMain.txtTLTime.Text.ToUpper})
        End If

        If frmMain.chkTLPU.Checked = True And frmMain.chkTLDO.Checked = True Then
            frmMain.dgvTLInfo(8, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = "X"
            frmMain.dgvTLInfo(9, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = "X"
            frmMain.dgvTLInfo(10, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLSeal.Text.ToUpper
            frmMain.dgvTLInfo(12, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLSetTemp.Text.ToUpper
            frmMain.dgvTLInfo(13, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLCurrentTemp.Text.ToUpper
        ElseIf frmMain.chkTLPU.Checked = True And frmMain.chkTLDO.Checked = False Then
            frmMain.dgvTLInfo(8, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = "X"
            frmMain.dgvTLInfo(9, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = "-"
            frmMain.dgvTLInfo(10, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLSeal.Text.ToUpper
            frmMain.dgvTLInfo(12, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLSetTemp.Text.ToUpper
            frmMain.dgvTLInfo(13, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLCurrentTemp.Text.ToUpper
        ElseIf frmMain.chkTLPU.Checked = False And frmMain.chkTLDO.Checked = True Then
            frmMain.dgvTLInfo(8, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = "-"
            frmMain.dgvTLInfo(9, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = "X"
            frmMain.dgvTLInfo(10, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLSeal.Text.ToUpper
            frmMain.dgvTLInfo(12, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLSetTemp.Text.ToUpper
            frmMain.dgvTLInfo(13, Convert.ToInt32(frmMain.dgvTLInfo.NewRowIndex) - 1).Value = frmMain.txtTLCurrentTemp.Text.ToUpper
        End If

    End Sub
    Public Sub PopulateBTLIn()

        frmMain.dgvBTLInfo.Rows.Add(New String() {frmMain.txtTLCompany.Text.ToUpper, frmMain.txtTLTrailer.Text.ToUpper, frmMain.Calendar.SelectionStart,
                                          frmMain.txtTLTime.Text.ToUpper})
        If frmMain.chkTLPU.Checked = True And frmMain.chkTLDO.Checked = True Then
            frmMain.dgvBTLInfo(8, Convert.ToInt32(frmMain.dgvBTLInfo.NewRowIndex) - 1).Value = "X"
            frmMain.dgvBTLInfo(9, Convert.ToInt32(frmMain.dgvBTLInfo.NewRowIndex) - 1).Value = "X"
        ElseIf frmMain.chkTLPU.Checked = True And frmMain.chkTLDO.Checked = False Then
            frmMain.dgvBTLInfo(8, Convert.ToInt32(frmMain.dgvBTLInfo.NewRowIndex) - 1).Value = "X"
            frmMain.dgvBTLInfo(9, Convert.ToInt32(frmMain.dgvBTLInfo.NewRowIndex) - 1).Value = "-"
        ElseIf frmMain.chkTLPU.Checked = False And frmMain.chkTLDO.Checked = True Then
            frmMain.dgvBTLInfo(8, Convert.ToInt32(frmMain.dgvBTLInfo.NewRowIndex) - 1).Value = "-"
            frmMain.dgvBTLInfo(9, Convert.ToInt32(frmMain.dgvBTLInfo.NewRowIndex) - 1).Value = "X"
        End If

    End Sub
    Public Sub PopulateBTLOut()

        For rows As Integer = 0 To frmMain.dgvBTLInfo.Rows.Count - 1

            Dim company As String = frmMain.dgvBTLInfo(0, rows).Value
            Dim trailer As String = frmMain.dgvBTLInfo(1, rows).Value

            If String.Compare(frmMain.txtTLCompany.Text, company, True) = 0 Then
                If String.Compare(frmMain.txtTLTrailer.Text, trailer, True) = 0 Then
                    frmMain.dgvBTLInfo(5, rows).Value = DateString
                    frmMain.dgvBTLInfo(6, rows).Value = frmMain.txtTLTime.Text
                End If
            End If
        Next

    End Sub

    Public Function StringToBytes(ByVal str As String) As Byte()

        Return System.Text.Encoding.ASCII.GetBytes(str)

    End Function

End Module
