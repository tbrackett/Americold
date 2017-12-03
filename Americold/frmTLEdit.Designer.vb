<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTLEdit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTLECurrentInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTLEColumn = New System.Windows.Forms.Label()
        Me.btnTLESubmit = New System.Windows.Forms.Button()
        Me.btnTLECancel = New System.Windows.Forms.Button()
        Me.txtTLENewInfo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Information:"
        '
        'lblTLECurrentInfo
        '
        Me.lblTLECurrentInfo.AutoSize = True
        Me.lblTLECurrentInfo.Location = New System.Drawing.Point(147, 44)
        Me.lblTLECurrentInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTLECurrentInfo.Name = "lblTLECurrentInfo"
        Me.lblTLECurrentInfo.Size = New System.Drawing.Size(13, 13)
        Me.lblTLECurrentInfo.TabIndex = 1
        Me.lblTLECurrentInfo.Text = "?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Column:"
        '
        'lblTLEColumn
        '
        Me.lblTLEColumn.AutoSize = True
        Me.lblTLEColumn.Location = New System.Drawing.Point(147, 30)
        Me.lblTLEColumn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTLEColumn.Name = "lblTLEColumn"
        Me.lblTLEColumn.Size = New System.Drawing.Size(13, 13)
        Me.lblTLEColumn.TabIndex = 3
        Me.lblTLEColumn.Text = "?"
        '
        'btnTLESubmit
        '
        Me.btnTLESubmit.Location = New System.Drawing.Point(29, 109)
        Me.btnTLESubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTLESubmit.Name = "btnTLESubmit"
        Me.btnTLESubmit.Size = New System.Drawing.Size(100, 36)
        Me.btnTLESubmit.TabIndex = 4
        Me.btnTLESubmit.Text = "Submit"
        Me.btnTLESubmit.UseVisualStyleBackColor = True
        '
        'btnTLECancel
        '
        Me.btnTLECancel.Location = New System.Drawing.Point(149, 109)
        Me.btnTLECancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTLECancel.Name = "btnTLECancel"
        Me.btnTLECancel.Size = New System.Drawing.Size(100, 36)
        Me.btnTLECancel.TabIndex = 5
        Me.btnTLECancel.Text = "Cancel"
        Me.btnTLECancel.UseVisualStyleBackColor = True
        '
        'txtTLENewInfo
        '
        Me.txtTLENewInfo.Location = New System.Drawing.Point(149, 72)
        Me.txtTLENewInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTLENewInfo.Name = "txtTLENewInfo"
        Me.txtTLENewInfo.Size = New System.Drawing.Size(100, 20)
        Me.txtTLENewInfo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Edit to:"
        '
        'frmTLEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTLENewInfo)
        Me.Controls.Add(Me.btnTLECancel)
        Me.Controls.Add(Me.btnTLESubmit)
        Me.Controls.Add(Me.lblTLEColumn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTLECurrentInfo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTLEdit"
        Me.Text = "Edit Truck Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTLECurrentInfo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTLEColumn As System.Windows.Forms.Label
    Friend WithEvents btnTLESubmit As System.Windows.Forms.Button
    Friend WithEvents btnTLECancel As System.Windows.Forms.Button
    Friend WithEvents txtTLENewInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
