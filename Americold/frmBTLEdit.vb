Public Class frmBTLEdit

    Private Sub frmBTLEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 2 Or frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 5 Then
            dtpBTLE.Visible = True
            txtBTLENewInfo.Visible = False

        End If

        lblBTLECurrentInfo.Text = Convert.ToString(frmMain.dgvBTLInfo.CurrentCell.Value.ToString)

        lblBTLEColumn.Text = Convert.ToString(frmMain.dgvBTLInfo.CurrentCell.OwningColumn.HeaderText)

    End Sub

    Private Sub btnBTLECancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBTLECancel.Click

        Me.Close()

    End Sub

    Private Sub btnBTLESubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBTLESubmit.Click

        Dim currentRow As String
        Dim currentTLRow As String

        'Changes matching based on selected cell
        If frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 6 Or frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 7 Then
            currentRow = Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(0).Value) & Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(1).Value) &
                            Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(6).Value) & Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(7).Value)

        ElseIf frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 3 Or frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 4 Then
            currentRow = Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(0).Value) & Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(1).Value) &
                            Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(3).Value) & Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(4).Value)

        Else
            currentRow = Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(0).Value) & Convert.ToString(frmMain.dgvBTLInfo.CurrentRow.Cells(1).Value)

        End If

        'Updates the TL when the BTL is editted.
        For rows As Integer = 0 To frmMain.dgvTLInfo.Rows.Count - 1

            If frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 0 Or frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 1 Then
                currentTLRow = Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(2).Value) & Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(4).Value)
            Else
                currentTLRow = Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(2).Value) & Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(4).Value) &
                                            Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(7).Value) & Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(11).Value)
            End If

            If String.Compare(currentRow, currentTLRow, True) = 0 Then

                Dim outCheck As String = Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(0).Value)

                If frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 0 Then
                    frmMain.dgvTLInfo.Rows(rows).Cells(2).Value = txtBTLENewInfo.Text.ToUpper

                ElseIf frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 1 Then
                    frmMain.dgvTLInfo.Rows(rows).Cells(4).Value = txtBTLENewInfo.Text.ToUpper

                ElseIf frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 3 Then
                    If String.Compare(outCheck, "-", True) = 1 Then
                        frmMain.dgvTLInfo.Rows(rows).Cells(7).Value = txtBTLENewInfo.Text.ToUpper
                    End If

                ElseIf frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 4 Then
                    If String.Compare(outCheck, "-", True) = 1 Then
                        frmMain.dgvTLInfo.Rows(rows).Cells(11).Value = txtBTLENewInfo.Text.ToUpper
                    End If

                ElseIf frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 6 Then
                    If String.Compare(outCheck, "-", True) = 0 Then
                        frmMain.dgvTLInfo.Rows(rows).Cells(7).Value = txtBTLENewInfo.Text.ToUpper
                    End If

                ElseIf frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 7 Then
                    If String.Compare(outCheck, "-", True) = 0 Then
                        frmMain.dgvTLInfo.Rows(rows).Cells(11).Value = txtBTLENewInfo.Text.ToUpper
                    End If
                End If

            Else
                If frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 2 Or frmMain.dgvBTLInfo.CurrentCell.OwningColumn.Index = 5 Then
                    frmMain.dgvBTLInfo.CurrentCell.Value = dtpBTLE.Text

                End If

            End If

        Next

        frmMain.dgvBTLInfo.CurrentCell.Value = txtBTLENewInfo.Text.ToUpper

        Me.Close()

    End Sub

End Class