<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBTLEdit
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
        Me.btnBTLESubmit = New System.Windows.Forms.Button()
        Me.btnBTLECancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBTLENewInfo = New System.Windows.Forms.TextBox()
        Me.lblBTLEColumn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBTLECurrentInfo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpBTLE = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnBTLESubmit
        '
        Me.btnBTLESubmit.Location = New System.Drawing.Point(29, 109)
        Me.btnBTLESubmit.Name = "btnBTLESubmit"
        Me.btnBTLESubmit.Size = New System.Drawing.Size(100, 36)
        Me.btnBTLESubmit.TabIndex = 0
        Me.btnBTLESubmit.Text = "Submit"
        Me.btnBTLESubmit.UseVisualStyleBackColor = True
        '
        'btnBTLECancel
        '
        Me.btnBTLECancel.Location = New System.Drawing.Point(149, 109)
        Me.btnBTLECancel.Name = "btnBTLECancel"
        Me.btnBTLECancel.Size = New System.Drawing.Size(100, 36)
        Me.btnBTLECancel.TabIndex = 1
        Me.btnBTLECancel.Text = "Cancel"
        Me.btnBTLECancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Column:"
        '
        'txtBTLENewInfo
        '
        Me.txtBTLENewInfo.Location = New System.Drawing.Point(149, 72)
        Me.txtBTLENewInfo.Name = "txtBTLENewInfo"
        Me.txtBTLENewInfo.Size = New System.Drawing.Size(100, 20)
        Me.txtBTLENewInfo.TabIndex = 3
        '
        'lblBTLEColumn
        '
        Me.lblBTLEColumn.AutoSize = True
        Me.lblBTLEColumn.Location = New System.Drawing.Point(147, 30)
        Me.lblBTLEColumn.Name = "lblBTLEColumn"
        Me.lblBTLEColumn.Size = New System.Drawing.Size(13, 13)
        Me.lblBTLEColumn.TabIndex = 4
        Me.lblBTLEColumn.Text = "?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Current Information:"
        '
        'lblBTLECurrentInfo
        '
        Me.lblBTLECurrentInfo.AutoSize = True
        Me.lblBTLECurrentInfo.Location = New System.Drawing.Point(147, 44)
        Me.lblBTLECurrentInfo.Name = "lblBTLECurrentInfo"
        Me.lblBTLECurrentInfo.Size = New System.Drawing.Size(13, 13)
        Me.lblBTLECurrentInfo.TabIndex = 6
        Me.lblBTLECurrentInfo.Text = "?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Edit to:"
        '
        'dtpBTLE
        '
        Me.dtpBTLE.CustomFormat = "M/d/yyyy"
        Me.dtpBTLE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBTLE.Location = New System.Drawing.Point(150, 72)
        Me.dtpBTLE.Name = "dtpBTLE"
        Me.dtpBTLE.Size = New System.Drawing.Size(99, 20)
        Me.dtpBTLE.TabIndex = 8
        Me.dtpBTLE.Value = New Date(2015, 3, 18, 0, 0, 0, 0)
        Me.dtpBTLE.Visible = False
        '
        'frmBTLEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.dtpBTLE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblBTLECurrentInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblBTLEColumn)
        Me.Controls.Add(Me.txtBTLENewInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBTLECancel)
        Me.Controls.Add(Me.btnBTLESubmit)
        Me.Name = "frmBTLEdit"
        Me.Text = "Edit Burn Time Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBTLESubmit As System.Windows.Forms.Button
    Friend WithEvents btnBTLECancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBTLENewInfo As System.Windows.Forms.TextBox
    Friend WithEvents lblBTLEColumn As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBTLECurrentInfo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpBTLE As System.Windows.Forms.DateTimePicker
End Class
