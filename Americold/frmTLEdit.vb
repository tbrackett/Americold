Public Class frmTLEdit

    Private Sub frmTLEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblTLECurrentInfo.Text = Convert.ToString(frmMain.dgvTLInfo.CurrentCell.Value.ToString)

        lblTLEColumn.Text = Convert.ToString(frmMain.dgvTLInfo.CurrentCell.OwningColumn.HeaderText)

    End Sub

    Private Sub btnTLECancel_Click(sender As System.Object, e As System.EventArgs) Handles btnTLECancel.Click

        Me.Close()

    End Sub

    Private Sub btnTLESubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTLESubmit.Click

        Dim currentSelectedRow As String
        Dim currentBTLRow As String
        Dim currentTLRow As String
        Dim outCheck As String = Convert.ToString(frmMain.dgvTLInfo.CurrentRow.Cells(0).Value)

        If frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 2 Or frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 4 Then
            currentSelectedRow = Convert.ToString(frmMain.dgvTLInfo.CurrentRow.Cells(2).Value) & Convert.ToString(frmMain.dgvTLInfo.CurrentRow.Cells(4).Value)

        Else
            currentSelectedRow = Convert.ToString(frmMain.dgvTLInfo.CurrentRow.Cells(2).Value) & Convert.ToString(frmMain.dgvTLInfo.CurrentRow.Cells(4).Value) &
                                    Convert.ToString(frmMain.dgvTLInfo.CurrentRow.Cells(7).Value) & Convert.ToString(frmMain.dgvTLInfo.CurrentRow.Cells(11).Value)

        End If

        'Looks for a match in the BTL and updates it.
        For rows As Integer = 0 To frmMain.dgvBTLInfo.Rows.Count - 1

            If frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 2 Or frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 4 Then
                currentBTLRow = Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(0).Value) & Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(1).Value)

            Else
                If String.Compare(outCheck, "-", True) = 1 Then
                    currentBTLRow = Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(0).Value) & Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(1).Value) &
                            Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(3).Value) & Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(4).Value)

                Else
                    currentBTLRow = Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(0).Value) & Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(1).Value) &
                            Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(6).Value) & Convert.ToString(frmMain.dgvBTLInfo.Rows(rows).Cells(7).Value)

                End If
            End If

            If String.Compare(currentSelectedRow, currentBTLRow, True) = 0 Then

                If frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 2 Then
                    frmMain.dgvBTLInfo.Rows(rows).Cells(0).Value = txtTLENewInfo.Text.ToUpper

                ElseIf frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 4 Then
                    frmMain.dgvBTLInfo.Rows(rows).Cells(1).Value = txtTLENewInfo.Text.ToUpper

                ElseIf frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 7 Then
                    If String.Compare(outCheck, "-", True) = 1 Then
                        frmMain.dgvBTLInfo.Rows(rows).Cells(3).Value = txtTLENewInfo.Text.ToUpper
                    Else
                        frmMain.dgvBTLInfo.Rows(rows).Cells(6).Value = txtTLENewInfo.Text.ToUpper
                    End If

                ElseIf frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 11 Then
                    If String.Compare(outCheck, "-", True) = 1 Then
                        frmMain.dgvBTLInfo.Rows(rows).Cells(4).Value = txtTLENewInfo.Text.ToUpper
                    Else
                        frmMain.dgvBTLInfo.Rows(rows).Cells(7).Value = txtTLENewInfo.Text.ToUpper
                    End If

                End If
            End If


        Next

        'Looks for a match in the TL and updates it.
        '!!! Need to update to change entries that aren't only based on the few selected columns. !!!
        For rows As Integer = 0 To frmMain.dgvTLInfo.Rows.Count - 1

            If frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 2 Or frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 4 Then
                currentTLRow = Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(2).Value) & Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(4).Value)

            Else
                currentTLRow = Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(2).Value) & Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(4).Value) &
                                Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(7).Value) & Convert.ToString(frmMain.dgvTLInfo.Rows(rows).Cells(11).Value)

            End If

            If String.Compare(currentSelectedRow, currentTLRow, True) = 0 Then

                If frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 2 Then
                    frmMain.dgvTLInfo.Rows(rows).Cells(2).Value = txtTLENewInfo.Text.ToUpper

                ElseIf frmMain.dgvTLInfo.CurrentCell.OwningColumn.Index = 4 Then
                    frmMain.dgvTLInfo.Rows(rows).Cells(4).Value = txtTLENewInfo.Text.ToUpper

                End If
            End If

        Next

        frmMain.dgvTLInfo.CurrentCell.Value = txtTLENewInfo.Text.ToUpper

        Me.Close()

    End Sub

End Class