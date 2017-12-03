<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Me.txtCAFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOKCreate = New System.Windows.Forms.Button()
        Me.btnCancelCreate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCAPWCreate = New System.Windows.Forms.TextBox()
        Me.txtCAPWConfirm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCALastName = New System.Windows.Forms.TextBox()
        Me.txtCAUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCAFirstName
        '
        Me.txtCAFirstName.Location = New System.Drawing.Point(52, 72)
        Me.txtCAFirstName.Name = "txtCAFirstName"
        Me.txtCAFirstName.Size = New System.Drawing.Size(156, 20)
        Me.txtCAFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'btnOKCreate
        '
        Me.btnOKCreate.Location = New System.Drawing.Point(52, 215)
        Me.btnOKCreate.Name = "btnOKCreate"
        Me.btnOKCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnOKCreate.TabIndex = 4
        Me.btnOKCreate.Text = "OK"
        Me.btnOKCreate.UseVisualStyleBackColor = True
        '
        'btnCancelCreate
        '
        Me.btnCancelCreate.Location = New System.Drawing.Point(133, 215)
        Me.btnCancelCreate.Name = "btnCancelCreate"
        Me.btnCancelCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelCreate.TabIndex = 5
        Me.btnCancelCreate.Text = "Cancel"
        Me.btnCancelCreate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Retype Password"
        '
        'txtCAPWCreate
        '
        Me.txtCAPWCreate.Location = New System.Drawing.Point(52, 150)
        Me.txtCAPWCreate.Name = "txtCAPWCreate"
        Me.txtCAPWCreate.Size = New System.Drawing.Size(156, 20)
        Me.txtCAPWCreate.TabIndex = 2
        Me.txtCAPWCreate.UseSystemPasswordChar = True
        '
        'txtCAPWConfirm
        '
        Me.txtCAPWConfirm.Location = New System.Drawing.Point(52, 189)
        Me.txtCAPWConfirm.Name = "txtCAPWConfirm"
        Me.txtCAPWConfirm.Size = New System.Drawing.Size(156, 20)
        Me.txtCAPWConfirm.TabIndex = 3
        Me.txtCAPWConfirm.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Last Name"
        '
        'txtCALastName
        '
        Me.txtCALastName.Location = New System.Drawing.Point(52, 111)
        Me.txtCALastName.Name = "txtCALastName"
        Me.txtCALastName.Size = New System.Drawing.Size(156, 20)
        Me.txtCALastName.TabIndex = 1
        '
        'txtCAUsername
        '
        Me.txtCAUsername.Location = New System.Drawing.Point(52, 33)
        Me.txtCAUsername.Name = "txtCAUsername"
        Me.txtCAUsername.Size = New System.Drawing.Size(156, 20)
        Me.txtCAUsername.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Username"
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 259)
        Me.Controls.Add(Me.txtCALastName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCAPWConfirm)
        Me.Controls.Add(Me.txtCAPWCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelCreate)
        Me.Controls.Add(Me.btnOKCreate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCAUsername)
        Me.Controls.Add(Me.txtCAFirstName)
        Me.Name = "frmCreateAccount"
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCAFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOKCreate As System.Windows.Forms.Button
    Friend WithEvents btnCancelCreate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCAPWCreate As System.Windows.Forms.TextBox
    Friend WithEvents txtCAPWConfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCALastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCAUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
