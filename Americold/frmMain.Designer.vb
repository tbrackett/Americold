<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.tabLogs = New System.Windows.Forms.TabControl()
        Me.tabBurnTimeLog = New System.Windows.Forms.TabPage()
        Me.dtpTLDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBTLInfo = New System.Windows.Forms.DataGridView()
        Me.clmBLCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLTrailer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLInDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLInTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLInInitials = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLOutDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLOutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLOutInitials = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLPU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBLDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BurnTimeLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTLTime = New System.Windows.Forms.TextBox()
        Me.btnTLEdit = New System.Windows.Forms.Button()
        Me.dgvTLInfo = New System.Windows.Forms.DataGridView()
        Me.clmTLIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLCarrier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLTruck = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLTrailer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLPU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLDoor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLConf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLSeal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLSetTemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLTemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLInitials = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TruckLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTLSubmit = New System.Windows.Forms.Button()
        Me.txtTLCurrentTemp = New System.Windows.Forms.TextBox()
        Me.txtTLSetTemp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTLSeal = New System.Windows.Forms.TextBox()
        Me.chkTLDO = New System.Windows.Forms.CheckBox()
        Me.chkTLPU = New System.Windows.Forms.CheckBox()
        Me.txtTLConf = New System.Windows.Forms.TextBox()
        Me.txtTLDoor = New System.Windows.Forms.TextBox()
        Me.txtTLTruck = New System.Windows.Forms.TextBox()
        Me.txtTLTrailer = New System.Windows.Forms.TextBox()
        Me.txtTLCompany = New System.Windows.Forms.TextBox()
        Me.radTLOut = New System.Windows.Forms.RadioButton()
        Me.radTLIn = New System.Windows.Forms.RadioButton()
        Me.tabPassdownLog = New System.Windows.Forms.TabPage()
        Me.txtPDLTitle = New System.Windows.Forms.TextBox()
        Me.btnPDLEdit = New System.Windows.Forms.Button()
        Me.rtbPDLPastEntries = New System.Windows.Forms.RichTextBox()
        Me.btnPDLRead = New System.Windows.Forms.Button()
        Me.btnPDLSubmit = New System.Windows.Forms.Button()
        Me.lstPDLEntries = New System.Windows.Forms.ListBox()
        Me.rtbPDLEntry = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFileLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAccountSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmASCreateAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmASRecoverPW = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmASChangePW = New System.Windows.Forms.ToolStripMenuItem()
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.lblMainClock = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnMainLogin = New System.Windows.Forms.Button()
        Me.txtMainUsername = New System.Windows.Forms.TextBox()
        Me.txtMainPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMainLogin = New System.Windows.Forms.Label()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.tabLogs.SuspendLayout()
        Me.tabBurnTimeLog.SuspendLayout()
        CType(Me.dgvBTLInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurnTimeLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTLInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TruckLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPassdownLog.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabLogs
        '
        Me.tabLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabLogs.Controls.Add(Me.tabBurnTimeLog)
        Me.tabLogs.Controls.Add(Me.tabPassdownLog)
        Me.tabLogs.Enabled = False
        Me.tabLogs.Location = New System.Drawing.Point(12, 36)
        Me.tabLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabLogs.Name = "tabLogs"
        Me.tabLogs.SelectedIndex = 0
        Me.tabLogs.ShowToolTips = True
        Me.tabLogs.Size = New System.Drawing.Size(1100, 639)
        Me.tabLogs.TabIndex = 0
        '
        'tabBurnTimeLog
        '
        Me.tabBurnTimeLog.Controls.Add(Me.dtpTLDate)
        Me.tabBurnTimeLog.Controls.Add(Me.Label10)
        Me.tabBurnTimeLog.Controls.Add(Me.Label9)
        Me.tabBurnTimeLog.Controls.Add(Me.Label11)
        Me.tabBurnTimeLog.Controls.Add(Me.Label12)
        Me.tabBurnTimeLog.Controls.Add(Me.Label8)
        Me.tabBurnTimeLog.Controls.Add(Me.Label7)
        Me.tabBurnTimeLog.Controls.Add(Me.Label4)
        Me.tabBurnTimeLog.Controls.Add(Me.Label3)
        Me.tabBurnTimeLog.Controls.Add(Me.Label2)
        Me.tabBurnTimeLog.Controls.Add(Me.Label1)
        Me.tabBurnTimeLog.Controls.Add(Me.dgvBTLInfo)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLTime)
        Me.tabBurnTimeLog.Controls.Add(Me.btnTLEdit)
        Me.tabBurnTimeLog.Controls.Add(Me.dgvTLInfo)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLSubmit)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLCurrentTemp)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLSetTemp)
        Me.tabBurnTimeLog.Controls.Add(Me.Label13)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLSeal)
        Me.tabBurnTimeLog.Controls.Add(Me.chkTLDO)
        Me.tabBurnTimeLog.Controls.Add(Me.chkTLPU)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLConf)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLDoor)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLTruck)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLTrailer)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLCompany)
        Me.tabBurnTimeLog.Controls.Add(Me.radTLOut)
        Me.tabBurnTimeLog.Controls.Add(Me.radTLIn)
        Me.tabBurnTimeLog.Location = New System.Drawing.Point(4, 22)
        Me.tabBurnTimeLog.Margin = New System.Windows.Forms.Padding(4)
        Me.tabBurnTimeLog.Name = "tabBurnTimeLog"
        Me.tabBurnTimeLog.Size = New System.Drawing.Size(1092, 613)
        Me.tabBurnTimeLog.TabIndex = 4
        Me.tabBurnTimeLog.Text = "Burn Time Log"
        Me.tabBurnTimeLog.UseVisualStyleBackColor = True
        '
        'dtpTLDate
        '
        Me.dtpTLDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpTLDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTLDate.Location = New System.Drawing.Point(841, 29)
        Me.dtpTLDate.Name = "dtpTLDate"
        Me.dtpTLDate.Size = New System.Drawing.Size(116, 20)
        Me.dtpTLDate.TabIndex = 34
        Me.dtpTLDate.Value = New Date(2017, 12, 2, 15, 51, 13, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(639, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Set Temp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(523, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Seal #"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(716, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Current Temp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(838, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(792, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(465, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Conf #"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(422, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Door"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Trailer #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Truck #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Carrier"
        '
        'dgvBTLInfo
        '
        Me.dgvBTLInfo.AllowUserToDeleteRows = False
        Me.dgvBTLInfo.AllowUserToResizeColumns = False
        Me.dgvBTLInfo.AllowUserToResizeRows = False
        Me.dgvBTLInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBTLInfo.ColumnHeadersHeight = 40
        Me.dgvBTLInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBTLInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmBLCompany, Me.clmBLTrailer, Me.clmBLInDate, Me.clmBLInTime, Me.clmBLInInitials, Me.clmBLOutDate, Me.clmBLOutTime, Me.clmBLOutInitials, Me.clmBLPU, Me.clmBLDO})
        Me.dgvBTLInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBTLInfo.Location = New System.Drawing.Point(3, 324)
        Me.dgvBTLInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvBTLInfo.MultiSelect = False
        Me.dgvBTLInfo.Name = "dgvBTLInfo"
        Me.dgvBTLInfo.RowTemplate.Height = 24
        Me.dgvBTLInfo.Size = New System.Drawing.Size(1085, 235)
        Me.dgvBTLInfo.TabIndex = 18
        '
        'clmBLCompany
        '
        Me.clmBLCompany.HeaderText = "Company"
        Me.clmBLCompany.Name = "clmBLCompany"
        Me.clmBLCompany.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmBLCompany.Width = 125
        '
        'clmBLTrailer
        '
        Me.clmBLTrailer.HeaderText = "Trailer #"
        Me.clmBLTrailer.Name = "clmBLTrailer"
        Me.clmBLTrailer.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmBLTrailer.Width = 125
        '
        'clmBLInDate
        '
        Me.clmBLInDate.HeaderText = "In Date"
        Me.clmBLInDate.Name = "clmBLInDate"
        Me.clmBLInDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmBLInTime
        '
        Me.clmBLInTime.HeaderText = "In Time"
        Me.clmBLInTime.Name = "clmBLInTime"
        Me.clmBLInTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmBLInTime.Width = 75
        '
        'clmBLInInitials
        '
        Me.clmBLInInitials.HeaderText = "In Initials"
        Me.clmBLInInitials.Name = "clmBLInInitials"
        Me.clmBLInInitials.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmBLInInitials.Width = 125
        '
        'clmBLOutDate
        '
        Me.clmBLOutDate.HeaderText = "Out Date"
        Me.clmBLOutDate.Name = "clmBLOutDate"
        Me.clmBLOutDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmBLOutTime
        '
        Me.clmBLOutTime.HeaderText = "Out Time"
        Me.clmBLOutTime.Name = "clmBLOutTime"
        Me.clmBLOutTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmBLOutTime.Width = 75
        '
        'clmBLOutInitials
        '
        Me.clmBLOutInitials.HeaderText = "Out Initials"
        Me.clmBLOutInitials.Name = "clmBLOutInitials"
        Me.clmBLOutInitials.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmBLOutInitials.Width = 125
        '
        'clmBLPU
        '
        Me.clmBLPU.HeaderText = "PU"
        Me.clmBLPU.Name = "clmBLPU"
        Me.clmBLPU.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmBLPU.Width = 75
        '
        'clmBLDO
        '
        Me.clmBLDO.HeaderText = "DO"
        Me.clmBLDO.Name = "clmBLDO"
        Me.clmBLDO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmBLDO.Width = 75
        '
        'BurnTimeLogBindingSource
        '
        Me.BurnTimeLogBindingSource.DataMember = "Burn Time Log"
        '
        'txtTLTime
        '
        Me.txtTLTime.Location = New System.Drawing.Point(795, 30)
        Me.txtTLTime.Name = "txtTLTime"
        Me.txtTLTime.Size = New System.Drawing.Size(39, 20)
        Me.txtTLTime.TabIndex = 7
        '
        'btnTLEdit
        '
        Me.btnTLEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTLEdit.Location = New System.Drawing.Point(45, 565)
        Me.btnTLEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTLEdit.Name = "btnTLEdit"
        Me.btnTLEdit.Size = New System.Drawing.Size(133, 44)
        Me.btnTLEdit.TabIndex = 15
        Me.btnTLEdit.Text = "Edit"
        Me.btnTLEdit.UseVisualStyleBackColor = True
        '
        'dgvTLInfo
        '
        Me.dgvTLInfo.AllowUserToDeleteRows = False
        Me.dgvTLInfo.AllowUserToResizeColumns = False
        Me.dgvTLInfo.AllowUserToResizeRows = False
        Me.dgvTLInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTLInfo.ColumnHeadersHeight = 40
        Me.dgvTLInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTLInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmTLIn, Me.clmTLOut, Me.clmTLCarrier, Me.clmTLTruck, Me.clmTLTrailer, Me.clmTLPU, Me.clmTLDO, Me.clmTLDoor, Me.clmTLConf, Me.clmTLSeal, Me.clmTLSetTemp, Me.clmTLTemp, Me.clmTLTime, Me.clmTLDate, Me.clmTLInitials})
        Me.dgvTLInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTLInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvTLInfo.Location = New System.Drawing.Point(4, 58)
        Me.dgvTLInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTLInfo.MultiSelect = False
        Me.dgvTLInfo.Name = "dgvTLInfo"
        Me.dgvTLInfo.Size = New System.Drawing.Size(1084, 260)
        Me.dgvTLInfo.TabIndex = 32
        '
        'clmTLIn
        '
        Me.clmTLIn.HeaderText = "In"
        Me.clmTLIn.Name = "clmTLIn"
        Me.clmTLIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLIn.Width = 35
        '
        'clmTLOut
        '
        Me.clmTLOut.HeaderText = "Out"
        Me.clmTLOut.Name = "clmTLOut"
        Me.clmTLOut.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLOut.Width = 35
        '
        'clmTLCarrier
        '
        Me.clmTLCarrier.HeaderText = "Carrier"
        Me.clmTLCarrier.Name = "clmTLCarrier"
        Me.clmTLCarrier.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLCarrier.Width = 110
        '
        'clmTLTruck
        '
        Me.clmTLTruck.HeaderText = "Truck #"
        Me.clmTLTruck.Name = "clmTLTruck"
        Me.clmTLTruck.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmTLTrailer
        '
        Me.clmTLTrailer.HeaderText = "Trailer #"
        Me.clmTLTrailer.Name = "clmTLTrailer"
        Me.clmTLTrailer.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmTLPU
        '
        Me.clmTLPU.HeaderText = "PU"
        Me.clmTLPU.Name = "clmTLPU"
        Me.clmTLPU.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLPU.Width = 35
        '
        'clmTLDO
        '
        Me.clmTLDO.HeaderText = "DO"
        Me.clmTLDO.Name = "clmTLDO"
        Me.clmTLDO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLDO.Width = 35
        '
        'clmTLDoor
        '
        Me.clmTLDoor.HeaderText = "Door"
        Me.clmTLDoor.Name = "clmTLDoor"
        Me.clmTLDoor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLDoor.Width = 50
        '
        'clmTLConf
        '
        Me.clmTLConf.HeaderText = "Conf #"
        Me.clmTLConf.Name = "clmTLConf"
        Me.clmTLConf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmTLSeal
        '
        Me.clmTLSeal.HeaderText = "Seal #"
        Me.clmTLSeal.Name = "clmTLSeal"
        Me.clmTLSeal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmTLSetTemp
        '
        Me.clmTLSetTemp.HeaderText = "Set Temp"
        Me.clmTLSetTemp.Name = "clmTLSetTemp"
        Me.clmTLSetTemp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLSetTemp.Width = 50
        '
        'clmTLTemp
        '
        Me.clmTLTemp.HeaderText = "Temp"
        Me.clmTLTemp.Name = "clmTLTemp"
        Me.clmTLTemp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLTemp.Width = 50
        '
        'clmTLTime
        '
        Me.clmTLTime.HeaderText = "Time"
        Me.clmTLTime.Name = "clmTLTime"
        Me.clmTLTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLTime.Width = 50
        '
        'clmTLDate
        '
        Me.clmTLDate.HeaderText = "Date"
        Me.clmTLDate.Name = "clmTLDate"
        '
        'clmTLInitials
        '
        Me.clmTLInitials.HeaderText = "Initials"
        Me.clmTLInitials.Name = "clmTLInitials"
        Me.clmTLInitials.Width = 50
        '
        'TruckLogBindingSource
        '
        Me.TruckLogBindingSource.DataMember = "Truck Log"
        '
        'txtTLSubmit
        '
        Me.txtTLSubmit.Location = New System.Drawing.Point(964, 5)
        Me.txtTLSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLSubmit.Name = "txtTLSubmit"
        Me.txtTLSubmit.Size = New System.Drawing.Size(83, 48)
        Me.txtTLSubmit.TabIndex = 14
        Me.txtTLSubmit.Text = "Submit"
        Me.txtTLSubmit.UseVisualStyleBackColor = True
        '
        'txtTLCurrentTemp
        '
        Me.txtTLCurrentTemp.Location = New System.Drawing.Point(719, 30)
        Me.txtTLCurrentTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLCurrentTemp.Name = "txtTLCurrentTemp"
        Me.txtTLCurrentTemp.Size = New System.Drawing.Size(69, 20)
        Me.txtTLCurrentTemp.TabIndex = 13
        '
        'txtTLSetTemp
        '
        Me.txtTLSetTemp.Location = New System.Drawing.Point(642, 30)
        Me.txtTLSetTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLSetTemp.Name = "txtTLSetTemp"
        Me.txtTLSetTemp.Size = New System.Drawing.Size(69, 20)
        Me.txtTLSetTemp.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(569, 5)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 24
        '
        'txtTLSeal
        '
        Me.txtTLSeal.Location = New System.Drawing.Point(526, 30)
        Me.txtTLSeal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLSeal.Name = "txtTLSeal"
        Me.txtTLSeal.Size = New System.Drawing.Size(108, 20)
        Me.txtTLSeal.TabIndex = 10
        '
        'chkTLDO
        '
        Me.chkTLDO.AutoSize = True
        Me.chkTLDO.Location = New System.Drawing.Point(375, 32)
        Me.chkTLDO.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTLDO.Name = "chkTLDO"
        Me.chkTLDO.Size = New System.Drawing.Size(42, 17)
        Me.chkTLDO.TabIndex = 9
        Me.chkTLDO.Text = "DO"
        Me.chkTLDO.UseVisualStyleBackColor = True
        '
        'chkTLPU
        '
        Me.chkTLPU.AutoSize = True
        Me.chkTLPU.Location = New System.Drawing.Point(375, 9)
        Me.chkTLPU.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTLPU.Name = "chkTLPU"
        Me.chkTLPU.Size = New System.Drawing.Size(41, 17)
        Me.chkTLPU.TabIndex = 8
        Me.chkTLPU.Text = "PU"
        Me.chkTLPU.UseVisualStyleBackColor = True
        '
        'txtTLConf
        '
        Me.txtTLConf.Location = New System.Drawing.Point(468, 30)
        Me.txtTLConf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLConf.Name = "txtTLConf"
        Me.txtTLConf.Size = New System.Drawing.Size(50, 20)
        Me.txtTLConf.TabIndex = 6
        '
        'txtTLDoor
        '
        Me.txtTLDoor.Location = New System.Drawing.Point(425, 30)
        Me.txtTLDoor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLDoor.Name = "txtTLDoor"
        Me.txtTLDoor.Size = New System.Drawing.Size(35, 20)
        Me.txtTLDoor.TabIndex = 5
        '
        'txtTLTruck
        '
        Me.txtTLTruck.Location = New System.Drawing.Point(181, 30)
        Me.txtTLTruck.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLTruck.Name = "txtTLTruck"
        Me.txtTLTruck.Size = New System.Drawing.Size(85, 20)
        Me.txtTLTruck.TabIndex = 3
        '
        'txtTLTrailer
        '
        Me.txtTLTrailer.Location = New System.Drawing.Point(274, 30)
        Me.txtTLTrailer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLTrailer.Name = "txtTLTrailer"
        Me.txtTLTrailer.Size = New System.Drawing.Size(85, 20)
        Me.txtTLTrailer.TabIndex = 4
        '
        'txtTLCompany
        '
        Me.txtTLCompany.Location = New System.Drawing.Point(68, 30)
        Me.txtTLCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLCompany.Name = "txtTLCompany"
        Me.txtTLCompany.Size = New System.Drawing.Size(105, 20)
        Me.txtTLCompany.TabIndex = 2
        '
        'radTLOut
        '
        Me.radTLOut.AutoSize = True
        Me.radTLOut.Location = New System.Drawing.Point(4, 31)
        Me.radTLOut.Margin = New System.Windows.Forms.Padding(4)
        Me.radTLOut.Name = "radTLOut"
        Me.radTLOut.Size = New System.Drawing.Size(42, 17)
        Me.radTLOut.TabIndex = 1
        Me.radTLOut.Text = "Out"
        Me.radTLOut.UseVisualStyleBackColor = True
        '
        'radTLIn
        '
        Me.radTLIn.AutoSize = True
        Me.radTLIn.Checked = True
        Me.radTLIn.Location = New System.Drawing.Point(4, 2)
        Me.radTLIn.Margin = New System.Windows.Forms.Padding(4)
        Me.radTLIn.Name = "radTLIn"
        Me.radTLIn.Size = New System.Drawing.Size(34, 17)
        Me.radTLIn.TabIndex = 0
        Me.radTLIn.TabStop = True
        Me.radTLIn.Text = "In"
        Me.radTLIn.UseVisualStyleBackColor = True
        '
        'tabPassdownLog
        '
        Me.tabPassdownLog.Controls.Add(Me.txtPDLTitle)
        Me.tabPassdownLog.Controls.Add(Me.btnPDLEdit)
        Me.tabPassdownLog.Controls.Add(Me.rtbPDLPastEntries)
        Me.tabPassdownLog.Controls.Add(Me.btnPDLRead)
        Me.tabPassdownLog.Controls.Add(Me.btnPDLSubmit)
        Me.tabPassdownLog.Controls.Add(Me.lstPDLEntries)
        Me.tabPassdownLog.Controls.Add(Me.rtbPDLEntry)
        Me.tabPassdownLog.Location = New System.Drawing.Point(4, 22)
        Me.tabPassdownLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabPassdownLog.Name = "tabPassdownLog"
        Me.tabPassdownLog.Size = New System.Drawing.Size(1092, 613)
        Me.tabPassdownLog.TabIndex = 2
        Me.tabPassdownLog.Text = "Passdown Log"
        Me.tabPassdownLog.UseVisualStyleBackColor = True
        '
        'txtPDLTitle
        '
        Me.txtPDLTitle.Location = New System.Drawing.Point(4, 432)
        Me.txtPDLTitle.Name = "txtPDLTitle"
        Me.txtPDLTitle.Size = New System.Drawing.Size(509, 20)
        Me.txtPDLTitle.TabIndex = 6
        Me.txtPDLTitle.Text = "txtPDLTitle"
        '
        'btnPDLEdit
        '
        Me.btnPDLEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPDLEdit.Location = New System.Drawing.Point(343, 554)
        Me.btnPDLEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPDLEdit.Name = "btnPDLEdit"
        Me.btnPDLEdit.Size = New System.Drawing.Size(173, 55)
        Me.btnPDLEdit.TabIndex = 5
        Me.btnPDLEdit.Text = "Edit"
        Me.btnPDLEdit.UseVisualStyleBackColor = True
        '
        'rtbPDLPastEntries
        '
        Me.rtbPDLPastEntries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPDLPastEntries.Enabled = False
        Me.rtbPDLPastEntries.Location = New System.Drawing.Point(4, 4)
        Me.rtbPDLPastEntries.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbPDLPastEntries.Name = "rtbPDLPastEntries"
        Me.rtbPDLPastEntries.Size = New System.Drawing.Size(550, 421)
        Me.rtbPDLPastEntries.TabIndex = 4
        Me.rtbPDLPastEntries.Text = ""
        '
        'btnPDLRead
        '
        Me.btnPDLRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPDLRead.Location = New System.Drawing.Point(4, 554)
        Me.btnPDLRead.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPDLRead.Name = "btnPDLRead"
        Me.btnPDLRead.Size = New System.Drawing.Size(173, 55)
        Me.btnPDLRead.TabIndex = 2
        Me.btnPDLRead.Text = "Read"
        Me.btnPDLRead.UseVisualStyleBackColor = True
        '
        'btnPDLSubmit
        '
        Me.btnPDLSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPDLSubmit.Location = New System.Drawing.Point(915, 554)
        Me.btnPDLSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPDLSubmit.Name = "btnPDLSubmit"
        Me.btnPDLSubmit.Size = New System.Drawing.Size(173, 55)
        Me.btnPDLSubmit.TabIndex = 1
        Me.btnPDLSubmit.Text = "Submit"
        Me.btnPDLSubmit.UseVisualStyleBackColor = True
        '
        'lstPDLEntries
        '
        Me.lstPDLEntries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPDLEntries.FormattingEnabled = True
        Me.lstPDLEntries.Location = New System.Drawing.Point(4, 459)
        Me.lstPDLEntries.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPDLEntries.Name = "lstPDLEntries"
        Me.lstPDLEntries.Size = New System.Drawing.Size(550, 82)
        Me.lstPDLEntries.TabIndex = 1
        '
        'rtbPDLEntry
        '
        Me.rtbPDLEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPDLEntry.Location = New System.Drawing.Point(524, 4)
        Me.rtbPDLEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbPDLEntry.Name = "rtbPDLEntry"
        Me.rtbPDLEntry.Size = New System.Drawing.Size(564, 537)
        Me.rtbPDLEntry.TabIndex = 0
        Me.rtbPDLEntry.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.tsmAccountSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1360, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFileSave, Me.tsmFileLoad})
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmFile.Text = "File"
        '
        'tsmFileSave
        '
        Me.tsmFileSave.Name = "tsmFileSave"
        Me.tsmFileSave.Size = New System.Drawing.Size(100, 22)
        Me.tsmFileSave.Text = "Save"
        '
        'tsmFileLoad
        '
        Me.tsmFileLoad.Name = "tsmFileLoad"
        Me.tsmFileLoad.Size = New System.Drawing.Size(100, 22)
        Me.tsmFileLoad.Text = "Load"
        '
        'tsmAccountSettings
        '
        Me.tsmAccountSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmASCreateAccount, Me.tsmASRecoverPW, Me.tsmASChangePW})
        Me.tsmAccountSettings.Name = "tsmAccountSettings"
        Me.tsmAccountSettings.Size = New System.Drawing.Size(109, 20)
        Me.tsmAccountSettings.Text = "Account Settings"
        '
        'tsmASCreateAccount
        '
        Me.tsmASCreateAccount.Name = "tsmASCreateAccount"
        Me.tsmASCreateAccount.Size = New System.Drawing.Size(169, 22)
        Me.tsmASCreateAccount.Text = "Create Account"
        '
        'tsmASRecoverPW
        '
        Me.tsmASRecoverPW.Name = "tsmASRecoverPW"
        Me.tsmASRecoverPW.Size = New System.Drawing.Size(169, 22)
        Me.tsmASRecoverPW.Text = "Recover Password"
        '
        'tsmASChangePW
        '
        Me.tsmASChangePW.Name = "tsmASChangePW"
        Me.tsmASChangePW.Size = New System.Drawing.Size(169, 22)
        Me.tsmASChangePW.Text = "Change Password"
        '
        'Calendar
        '
        Me.Calendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calendar.Location = New System.Drawing.Point(1118, 468)
        Me.Calendar.MaxSelectionCount = 1
        Me.Calendar.Name = "Calendar"
        Me.Calendar.TabIndex = 2
        '
        'lblMainClock
        '
        Me.lblMainClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMainClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainClock.Location = New System.Drawing.Point(1118, 429)
        Me.lblMainClock.Name = "lblMainClock"
        Me.lblMainClock.Size = New System.Drawing.Size(227, 30)
        Me.lblMainClock.TabIndex = 3
        Me.lblMainClock.Text = "Clock"
        Me.lblMainClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnMainLogin
        '
        Me.btnMainLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMainLogin.Location = New System.Drawing.Point(1214, 159)
        Me.btnMainLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMainLogin.Name = "btnMainLogin"
        Me.btnMainLogin.Size = New System.Drawing.Size(131, 34)
        Me.btnMainLogin.TabIndex = 2
        Me.btnMainLogin.Text = "Log In"
        Me.btnMainLogin.UseVisualStyleBackColor = True
        '
        'txtMainUsername
        '
        Me.txtMainUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMainUsername.Location = New System.Drawing.Point(1214, 82)
        Me.txtMainUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMainUsername.Name = "txtMainUsername"
        Me.txtMainUsername.Size = New System.Drawing.Size(131, 20)
        Me.txtMainUsername.TabIndex = 0
        '
        'txtMainPassword
        '
        Me.txtMainPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMainPassword.Location = New System.Drawing.Point(1214, 130)
        Me.txtMainPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMainPassword.Name = "txtMainPassword"
        Me.txtMainPassword.Size = New System.Drawing.Size(131, 20)
        Me.txtMainPassword.TabIndex = 1
        Me.txtMainPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1211, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1211, 113)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password"
        '
        'lblMainLogin
        '
        Me.lblMainLogin.AutoSize = True
        Me.lblMainLogin.Location = New System.Drawing.Point(1211, 197)
        Me.lblMainLogin.Name = "lblMainLogin"
        Me.lblMainLogin.Size = New System.Drawing.Size(13, 13)
        Me.lblMainLogin.TabIndex = 9
        Me.lblMainLogin.Text = "?"
        Me.lblMainLogin.Visible = False
        '
        'EventLog1
        '
        Me.EventLog1.Log = "Application"
        Me.EventLog1.SynchronizingObject = Me
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1360, 684)
        Me.Controls.Add(Me.lblMainLogin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMainPassword)
        Me.Controls.Add(Me.txtMainUsername)
        Me.Controls.Add(Me.btnMainLogin)
        Me.Controls.Add(Me.lblMainClock)
        Me.Controls.Add(Me.Calendar)
        Me.Controls.Add(Me.tabLogs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Americold Security Logs"
        Me.tabLogs.ResumeLayout(False)
        Me.tabBurnTimeLog.ResumeLayout(False)
        Me.tabBurnTimeLog.PerformLayout()
        CType(Me.dgvBTLInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurnTimeLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTLInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TruckLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPassdownLog.ResumeLayout(False)
        Me.tabPassdownLog.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabLogs As System.Windows.Forms.TabControl
    Friend WithEvents tabPassdownLog As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Calendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblMainClock As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPDLSubmit As System.Windows.Forms.Button
    Friend WithEvents lstPDLEntries As System.Windows.Forms.ListBox
    Friend WithEvents rtbPDLEntry As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbPDLPastEntries As System.Windows.Forms.RichTextBox
    Friend WithEvents btnPDLRead As System.Windows.Forms.Button
    Friend WithEvents btnMainLogin As System.Windows.Forms.Button
    Friend WithEvents txtMainUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtMainPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tsmAccountSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmASCreateAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmASRecoverPW As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmASChangePW As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMainLogin As System.Windows.Forms.Label
    Friend WithEvents btnPDLEdit As System.Windows.Forms.Button
    Friend WithEvents tsmFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFileLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents txtPDLTitle As System.Windows.Forms.TextBox
    Friend WithEvents tabBurnTimeLog As TabPage
    Friend WithEvents dgvBTLInfo As DataGridView
    Friend WithEvents clmBLCompany As DataGridViewTextBoxColumn
    Friend WithEvents clmBLTrailer As DataGridViewTextBoxColumn
    Friend WithEvents clmBLInDate As DataGridViewTextBoxColumn
    Friend WithEvents clmBLInTime As DataGridViewTextBoxColumn
    Friend WithEvents clmBLInInitials As DataGridViewTextBoxColumn
    Friend WithEvents clmBLOutDate As DataGridViewTextBoxColumn
    Friend WithEvents clmBLOutTime As DataGridViewTextBoxColumn
    Friend WithEvents clmBLOutInitials As DataGridViewTextBoxColumn
    Friend WithEvents clmBLPU As DataGridViewTextBoxColumn
    Friend WithEvents clmBLDO As DataGridViewTextBoxColumn
    Friend WithEvents txtTLTime As System.Windows.Forms.TextBox
    Friend WithEvents btnTLEdit As System.Windows.Forms.Button
    Friend WithEvents dgvTLInfo As DataGridView
    Friend WithEvents clmTLIn As DataGridViewTextBoxColumn
    Friend WithEvents clmTLOut As DataGridViewTextBoxColumn
    Friend WithEvents clmTLCarrier As DataGridViewTextBoxColumn
    Friend WithEvents clmTLTruck As DataGridViewTextBoxColumn
    Friend WithEvents clmTLTrailer As DataGridViewTextBoxColumn
    Friend WithEvents clmTLPU As DataGridViewTextBoxColumn
    Friend WithEvents clmTLDO As DataGridViewTextBoxColumn
    Friend WithEvents clmTLDoor As DataGridViewTextBoxColumn
    Friend WithEvents clmTLConf As DataGridViewTextBoxColumn
    Friend WithEvents clmTLSeal As DataGridViewTextBoxColumn
    Friend WithEvents clmTLSetTemp As DataGridViewTextBoxColumn
    Friend WithEvents clmTLTemp As DataGridViewTextBoxColumn
    Friend WithEvents clmTLTime As DataGridViewTextBoxColumn
    Friend WithEvents clmTLDate As DataGridViewTextBoxColumn
    Friend WithEvents clmTLInitials As DataGridViewTextBoxColumn
    Friend WithEvents txtTLSubmit As System.Windows.Forms.Button
    Friend WithEvents txtTLCurrentTemp As System.Windows.Forms.TextBox
    Friend WithEvents txtTLSetTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTLSeal As System.Windows.Forms.TextBox
    Friend WithEvents chkTLDO As System.Windows.Forms.CheckBox
    Friend WithEvents chkTLPU As System.Windows.Forms.CheckBox
    Friend WithEvents txtTLConf As System.Windows.Forms.TextBox
    Friend WithEvents txtTLDoor As System.Windows.Forms.TextBox
    Friend WithEvents txtTLTruck As System.Windows.Forms.TextBox
    Friend WithEvents txtTLTrailer As System.Windows.Forms.TextBox
    Friend WithEvents txtTLCompany As System.Windows.Forms.TextBox
    Friend WithEvents radTLOut As RadioButton
    Friend WithEvents radTLIn As RadioButton
    Friend WithEvents TruckLogBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarrierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TruckNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrailerNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PickDropDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoorNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConfNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SealNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SetTempDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentTempDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InitialsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BurnTimeLogBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CarrierDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TruckNumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TrailerNumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents InTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InInitialsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutInitialsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTLDate As DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
