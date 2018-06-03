Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Public Class frmMain
    Dim employeeInitials As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblMainClock.Text = Format(Now, "HH:mm:ss")

    End Sub

    Private Sub tsmLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        tabLogs.Enabled = False
        employeeInitials = ""
        btnMainLogin.Visible = True

    End Sub

    Private Sub tsmASCreateAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmASCreateAccount.Click

        frmCreateAccount.Show()

    End Sub

    Private Sub tsmASRecoverPW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmASRecoverPW.Click

        frmRecoverPW.Show()

    End Sub

    Private Sub tsmASChangePW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmASChangePW.Click

        frmChangePW.Show()

    End Sub

    Private Sub btnMainLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainLogin.Click

        Dim byHashedData As Byte()
        Dim encoder As New UTF8Encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        Dim strPW As String = txtMainPassword.Text
        Dim accountName As String = txtMainUsername.Text
        Dim accountFilePath As String
        Dim accountFileString As String
        Dim enteredInfoString As String

        accountFilePath = "C:\Users\tbrac\Documents\GitHub\Americold\Employee Accounts"

        'Gets entered account info as hash
        byHashedData = md5Hasher.ComputeHash(encoder.GetBytes(strPW & accountName))
        enteredInfoString = FormFunctions.GetHash(byHashedData)

        'Gets account info on file as hash
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(accountFilePath)
            accountFileString = FormFunctions.GetFileHash(foundFile)


            If enteredInfoString = accountFileString Then
                For i As Integer = 0 To 1
                    employeeInitials = employeeInitials + txtMainUsername.Text.Chars(i)
                    employeeInitials = employeeInitials.ToUpper
                Next
                lblMainLogin.Text = "Log in successful."
                tabLogs.Enabled = True
                txtMainUsername.Text = ""
                txtMainPassword.Text = ""
                Exit For
            Else
                txtMainPassword.Text = ""
                lblMainLogin.Text = "Log in failed."
            End If
        Next

    End Sub

    Private Sub txtTLSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTLSubmit.Click

        Dim check As Boolean = FormFunctions.CheckTLInputBlanks()

        If check = True Then
            Exit Sub
        End If

        'Inbound entry
        If radTLIn.Checked = True Then
            'Highlights for Foster Farms, adds entry to the TL, and doesn't put it in the BTL.
            If String.Compare(txtTLCompany.Text, "FF", True) = 0 Then
                FormFunctions.PopulateTL("In")

                'Highlights the row
                For columns As Integer = 0 To dgvTLInfo.Columns.Count - 1
                    dgvTLInfo(columns, Convert.ToInt32(dgvTLInfo.NewRowIndex) - 1).Style.BackColor = Color.Yellow
                Next

                FormFunctions.PopulateTL("In")

                'Adds entry to TL and BTL
            Else
                FormFunctions.PopulateTL("In")
                FormFunctions.PopulateBTLIn()

            End If

            'Outbound entry.
        Else
            FormFunctions.PopulateTL("Out")

            'Highlights the row
            If String.Compare(txtTLCompany.Text, "FF", True) = 0 Then
                For columns As Integer = 0 To dgvTLInfo.Columns.Count - 1
                    dgvTLInfo(columns, Convert.ToInt32(dgvTLInfo.NewRowIndex) - 1).Style.BackColor = Color.Yellow
                Next
            End If

            'Check for matching entry on BTL and signs it out.
            FormFunctions.PopulateBTLOut()

        End If

        FormFunctions.SetTLInputBlank()
        dgvTLInfo.ClearSelection()
        dgvBTLInfo.ClearSelection()

    End Sub

    Private Sub btnTLEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTLEdit.Click

        If dgvTLInfo.SelectedCells.Count = 0 And dgvBTLInfo.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a cell to edit.")
        Else
            If dgvTLInfo.SelectedCells.Count > 0 Then
                If String.IsNullOrWhiteSpace(dgvTLInfo.CurrentCell.Value) Then
                    MessageBox.Show("Please select a cell that contains information to edit.")
                Else
                    frmTLEdit.Show()
                End If
            End If

            If dgvBTLInfo.SelectedCells.Count > 0 Then
                If String.IsNullOrWhiteSpace(dgvBTLInfo.CurrentCell.Value) Then
                    MessageBox.Show("Please select a cell that contains information to edit.")
                Else
                    frmBTLEdit.Show()
                End If
            End If

        End If

    End Sub

    Private Sub dgvTLInfo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTLInfo.CellClick

        dgvBTLInfo.ClearSelection()
        dgvBTLInfo.CurrentCell = Nothing

    End Sub

    Private Sub dgvBTLInfo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBTLInfo.CellClick

        dgvTLInfo.ClearSelection()
        dgvTLInfo.CurrentCell = Nothing

    End Sub

    Private Sub btnPDLSubmit_Click(sender As Object, e As EventArgs) Handles btnPDLSubmit.Click

        Dim path As String = "C:\Users\TJB\Google Drive\Work\Work-Program\Passdowns"

        If txtPDLTitle.Text = "" Then
            MsgBox("Please enter a title.")
        ElseIf rtbPDLEntry.Text = "" Then
            MsgBox("Please enter text in the 'entry' field on the right.")
        Else
            Dim fs As FileStream = File.Create(path & "\" & txtPDLTitle.Text & ".txt")
            'lstPDLSelectEntries.Items.Add(Date.Now & " --- " & txtPDLTitle.Text)
            fs.Write(FormFunctions.StringToBytes(rtbPDLEntry.Text), 0, rtbPDLEntry.Text.IndexOf(rtbPDLEntry.Text.Last) + 1)
            fs.Close()
            txtPDLTitle.Text = ""
            rtbPDLEntry.Text = ""
        End If

    End Sub



    Private Sub tabBurnTimeLog_Click(sender As Object, e As EventArgs) Handles tabBurnTimeLog.Click

    End Sub
End Class