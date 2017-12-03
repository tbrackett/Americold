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
        Me.tabPassDownLog = New System.Windows.Forms.TabPage()
        Me.txtPDLTitle = New System.Windows.Forms.TextBox()
        Me.btnPDLEdit = New System.Windows.Forms.Button()
        Me.rtbPDLPastEntry = New System.Windows.Forms.RichTextBox()
        Me.btnPDLRead = New System.Windows.Forms.Button()
        Me.btnPDLSubmit = New System.Windows.Forms.Button()
        Me.lstPDLSelectEntries = New System.Windows.Forms.ListBox()
        Me.rtbPDLEntry = New System.Windows.Forms.RichTextBox()
        Me.tabBurnTimeLog = New System.Windows.Forms.TabPage()
        Me.dgvBTLInfo = New System.Windows.Forms.DataGridView()
        Me.clmCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTrailer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmInDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmInTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEngineIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOutDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEngineOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTLTime = New System.Windows.Forms.TextBox()
        Me.btnTLEdit = New System.Windows.Forms.Button()
        Me.dgvTLInfo = New System.Windows.Forms.DataGridView()
        Me.clmTLIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLTruck = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLTrailer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLDoor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLConf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLPU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLSeal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLEngineHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLSetTemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTLTemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTLSubmit = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTLCurrentTemp = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTLSetTemp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTLEngineHours = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTLSeal = New System.Windows.Forms.TextBox()
        Me.chkTLDO = New System.Windows.Forms.CheckBox()
        Me.chkTLPU = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTLConf = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTLDoor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTLTruck = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTLTrailer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTLCompany = New System.Windows.Forms.TextBox()
        Me.radTLOut = New System.Windows.Forms.RadioButton()
        Me.radTLIn = New System.Windows.Forms.RadioButton()
        Me.tabReeferLog = New System.Windows.Forms.TabPage()
        Me.btnRLUpdate = New System.Windows.Forms.Button()
        Me.cmbRLTime = New System.Windows.Forms.ComboBox()
        Me.dgvRLTracker = New System.Windows.Forms.DataGridView()
        Me.clmRLCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRLTrailer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRLTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRLDateIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRLTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRLDateOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRLTotalTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRLIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRLOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radRLOn = New System.Windows.Forms.RadioButton()
        Me.radRLOff = New System.Windows.Forms.RadioButton()
        Me.btnRLEdit = New System.Windows.Forms.Button()
        Me.dgvRLMain = New System.Windows.Forms.DataGridView()
        Me.clmRCSCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRCSTrailer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRCSOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRCSOff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRCSTemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRCSTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRCSComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRCSIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRCSOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtRLComments = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRLTemp = New System.Windows.Forms.TextBox()
        Me.btnRLSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRLTrailer = New System.Windows.Forms.TextBox()
        Me.txtRLCompany = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radRLOut = New System.Windows.Forms.RadioButton()
        Me.radRLIn = New System.Windows.Forms.RadioButton()
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
        Me.btnMainLogout = New System.Windows.Forms.Button()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.tabLogs.SuspendLayout()
        Me.tabPassDownLog.SuspendLayout()
        Me.tabBurnTimeLog.SuspendLayout()
        CType(Me.dgvBTLInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTLInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReeferLog.SuspendLayout()
        CType(Me.dgvRLTracker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRLMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabLogs
        '
        Me.tabLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabLogs.Controls.Add(Me.tabPassDownLog)
        Me.tabLogs.Controls.Add(Me.tabBurnTimeLog)
        Me.tabLogs.Controls.Add(Me.tabReeferLog)
        Me.tabLogs.Enabled = False
        Me.tabLogs.Location = New System.Drawing.Point(12, 36)
        Me.tabLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabLogs.Name = "tabLogs"
        Me.tabLogs.SelectedIndex = 0
        Me.tabLogs.ShowToolTips = True
        Me.tabLogs.Size = New System.Drawing.Size(1059, 639)
        Me.tabLogs.TabIndex = 0
        '
        'tabPassDownLog
        '
        Me.tabPassDownLog.Controls.Add(Me.txtPDLTitle)
        Me.tabPassDownLog.Controls.Add(Me.btnPDLEdit)
        Me.tabPassDownLog.Controls.Add(Me.rtbPDLPastEntry)
        Me.tabPassDownLog.Controls.Add(Me.btnPDLRead)
        Me.tabPassDownLog.Controls.Add(Me.btnPDLSubmit)
        Me.tabPassDownLog.Controls.Add(Me.lstPDLSelectEntries)
        Me.tabPassDownLog.Controls.Add(Me.rtbPDLEntry)
        Me.tabPassDownLog.Location = New System.Drawing.Point(4, 22)
        Me.tabPassDownLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabPassDownLog.Name = "tabPassDownLog"
        Me.tabPassDownLog.Size = New System.Drawing.Size(1051, 613)
        Me.tabPassDownLog.TabIndex = 2
        Me.tabPassDownLog.Text = "Pass Down Log"
        Me.tabPassDownLog.UseVisualStyleBackColor = True
        '
        'txtPDLTitle
        '
        Me.txtPDLTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPDLTitle.Location = New System.Drawing.Point(524, 4)
        Me.txtPDLTitle.Name = "txtPDLTitle"
        Me.txtPDLTitle.Size = New System.Drawing.Size(523, 20)
        Me.txtPDLTitle.TabIndex = 6
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
        'rtbPDLPastEntry
        '
        Me.rtbPDLPastEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPDLPastEntry.Enabled = False
        Me.rtbPDLPastEntry.Location = New System.Drawing.Point(7, 185)
        Me.rtbPDLPastEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbPDLPastEntry.Name = "rtbPDLPastEntry"
        Me.rtbPDLPastEntry.Size = New System.Drawing.Size(509, 361)
        Me.rtbPDLPastEntry.TabIndex = 4
        Me.rtbPDLPastEntry.Text = ""
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
        Me.btnPDLSubmit.Location = New System.Drawing.Point(874, 554)
        Me.btnPDLSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPDLSubmit.Name = "btnPDLSubmit"
        Me.btnPDLSubmit.Size = New System.Drawing.Size(173, 55)
        Me.btnPDLSubmit.TabIndex = 1
        Me.btnPDLSubmit.Text = "Submit"
        Me.btnPDLSubmit.UseVisualStyleBackColor = True
        '
        'lstPDLSelectEntries
        '
        Me.lstPDLSelectEntries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPDLSelectEntries.FormattingEnabled = True
        Me.lstPDLSelectEntries.Location = New System.Drawing.Point(8, 4)
        Me.lstPDLSelectEntries.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPDLSelectEntries.Name = "lstPDLSelectEntries"
        Me.lstPDLSelectEntries.Size = New System.Drawing.Size(509, 173)
        Me.lstPDLSelectEntries.TabIndex = 1
        '
        'rtbPDLEntry
        '
        Me.rtbPDLEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPDLEntry.Location = New System.Drawing.Point(524, 31)
        Me.rtbPDLEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbPDLEntry.Name = "rtbPDLEntry"
        Me.rtbPDLEntry.Size = New System.Drawing.Size(523, 515)
        Me.rtbPDLEntry.TabIndex = 0
        Me.rtbPDLEntry.Text = ""
        '
        'tabBurnTimeLog
        '
        Me.tabBurnTimeLog.Controls.Add(Me.dgvBTLInfo)
        Me.tabBurnTimeLog.Controls.Add(Me.Label7)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLTime)
        Me.tabBurnTimeLog.Controls.Add(Me.btnTLEdit)
        Me.tabBurnTimeLog.Controls.Add(Me.dgvTLInfo)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLSubmit)
        Me.tabBurnTimeLog.Controls.Add(Me.Label16)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLCurrentTemp)
        Me.tabBurnTimeLog.Controls.Add(Me.Label15)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLSetTemp)
        Me.tabBurnTimeLog.Controls.Add(Me.Label14)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLEngineHours)
        Me.tabBurnTimeLog.Controls.Add(Me.Label13)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLSeal)
        Me.tabBurnTimeLog.Controls.Add(Me.chkTLDO)
        Me.tabBurnTimeLog.Controls.Add(Me.chkTLPU)
        Me.tabBurnTimeLog.Controls.Add(Me.Label12)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLConf)
        Me.tabBurnTimeLog.Controls.Add(Me.Label11)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLDoor)
        Me.tabBurnTimeLog.Controls.Add(Me.Label10)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLTruck)
        Me.tabBurnTimeLog.Controls.Add(Me.Label9)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLTrailer)
        Me.tabBurnTimeLog.Controls.Add(Me.Label8)
        Me.tabBurnTimeLog.Controls.Add(Me.txtTLCompany)
        Me.tabBurnTimeLog.Controls.Add(Me.radTLOut)
        Me.tabBurnTimeLog.Controls.Add(Me.radTLIn)
        Me.tabBurnTimeLog.Location = New System.Drawing.Point(4, 22)
        Me.tabBurnTimeLog.Margin = New System.Windows.Forms.Padding(4)
        Me.tabBurnTimeLog.Name = "tabBurnTimeLog"
        Me.tabBurnTimeLog.Size = New System.Drawing.Size(1051, 613)
        Me.tabBurnTimeLog.TabIndex = 4
        Me.tabBurnTimeLog.Text = "Burn Time Log"
        Me.tabBurnTimeLog.UseVisualStyleBackColor = True
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
        Me.dgvBTLInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCompany, Me.clmTrailer, Me.clmInDate, Me.clmInTime, Me.clmEngineIn, Me.clmOutDate, Me.clmOutTime, Me.clmEngineOut, Me.clmPU, Me.clmDO})
        Me.dgvBTLInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBTLInfo.Location = New System.Drawing.Point(3, 324)
        Me.dgvBTLInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvBTLInfo.MultiSelect = False
        Me.dgvBTLInfo.Name = "dgvBTLInfo"
        Me.dgvBTLInfo.RowTemplate.Height = 24
        Me.dgvBTLInfo.Size = New System.Drawing.Size(1044, 235)
        Me.dgvBTLInfo.TabIndex = 18
        '
        'clmCompany
        '
        Me.clmCompany.HeaderText = "Company"
        Me.clmCompany.Name = "clmCompany"
        Me.clmCompany.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmCompany.Width = 125
        '
        'clmTrailer
        '
        Me.clmTrailer.HeaderText = "Trailer #"
        Me.clmTrailer.Name = "clmTrailer"
        Me.clmTrailer.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTrailer.Width = 125
        '
        'clmInDate
        '
        Me.clmInDate.HeaderText = "In Date"
        Me.clmInDate.Name = "clmInDate"
        Me.clmInDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmInTime
        '
        Me.clmInTime.HeaderText = "In Time"
        Me.clmInTime.Name = "clmInTime"
        Me.clmInTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmInTime.Width = 75
        '
        'clmEngineIn
        '
        Me.clmEngineIn.HeaderText = "Engine Hours In"
        Me.clmEngineIn.Name = "clmEngineIn"
        Me.clmEngineIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmEngineIn.Width = 125
        '
        'clmOutDate
        '
        Me.clmOutDate.HeaderText = "Out Date"
        Me.clmOutDate.Name = "clmOutDate"
        Me.clmOutDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmOutTime
        '
        Me.clmOutTime.HeaderText = "Out Time"
        Me.clmOutTime.Name = "clmOutTime"
        Me.clmOutTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmOutTime.Width = 75
        '
        'clmEngineOut
        '
        Me.clmEngineOut.HeaderText = "Engine Hours Out"
        Me.clmEngineOut.Name = "clmEngineOut"
        Me.clmEngineOut.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmEngineOut.Width = 125
        '
        'clmPU
        '
        Me.clmPU.HeaderText = "PU"
        Me.clmPU.Name = "clmPU"
        Me.clmPU.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmPU.Width = 75
        '
        'clmDO
        '
        Me.clmDO.HeaderText = "DO"
        Me.clmDO.Name = "clmDO"
        Me.clmDO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmDO.Width = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(467, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Time"
        '
        'txtTLTime
        '
        Me.txtTLTime.Location = New System.Drawing.Point(467, 30)
        Me.txtTLTime.Name = "txtTLTime"
        Me.txtTLTime.Size = New System.Drawing.Size(39, 20)
        Me.txtTLTime.TabIndex = 7
        '
        'btnTLEdit
        '
        Me.btnTLEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTLEdit.Location = New System.Drawing.Point(4, 565)
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
        Me.dgvTLInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmTLIn, Me.clmTLOut, Me.clmTLCompany, Me.clmTLTruck, Me.clmTLTrailer, Me.clmTLDoor, Me.clmTLConf, Me.clmTLTime, Me.clmTLPU, Me.clmTLDO, Me.clmTLSeal, Me.clmTLEngineHours, Me.clmTLSetTemp, Me.clmTLTemp})
        Me.dgvTLInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTLInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvTLInfo.Location = New System.Drawing.Point(4, 58)
        Me.dgvTLInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTLInfo.MultiSelect = False
        Me.dgvTLInfo.Name = "dgvTLInfo"
        Me.dgvTLInfo.Size = New System.Drawing.Size(1043, 260)
        Me.dgvTLInfo.TabIndex = 32
        '
        'clmTLIn
        '
        Me.clmTLIn.HeaderText = "In"
        Me.clmTLIn.Name = "clmTLIn"
        Me.clmTLIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLIn.Width = 50
        '
        'clmTLOut
        '
        Me.clmTLOut.HeaderText = "Out"
        Me.clmTLOut.Name = "clmTLOut"
        Me.clmTLOut.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLOut.Width = 50
        '
        'clmTLCompany
        '
        Me.clmTLCompany.HeaderText = "Company"
        Me.clmTLCompany.Name = "clmTLCompany"
        Me.clmTLCompany.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLCompany.Width = 125
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
        Me.clmTLConf.Width = 50
        '
        'clmTLTime
        '
        Me.clmTLTime.HeaderText = "Time"
        Me.clmTLTime.Name = "clmTLTime"
        Me.clmTLTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLTime.Width = 75
        '
        'clmTLPU
        '
        Me.clmTLPU.HeaderText = "PU"
        Me.clmTLPU.Name = "clmTLPU"
        Me.clmTLPU.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLPU.Width = 50
        '
        'clmTLDO
        '
        Me.clmTLDO.HeaderText = "DO"
        Me.clmTLDO.Name = "clmTLDO"
        Me.clmTLDO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmTLDO.Width = 50
        '
        'clmTLSeal
        '
        Me.clmTLSeal.HeaderText = "Seal #"
        Me.clmTLSeal.Name = "clmTLSeal"
        Me.clmTLSeal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmTLEngineHours
        '
        Me.clmTLEngineHours.HeaderText = "Engine Hours"
        Me.clmTLEngineHours.Name = "clmTLEngineHours"
        Me.clmTLEngineHours.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(859, 5)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Temp"
        '
        'txtTLCurrentTemp
        '
        Me.txtTLCurrentTemp.Location = New System.Drawing.Point(862, 30)
        Me.txtTLCurrentTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLCurrentTemp.Name = "txtTLCurrentTemp"
        Me.txtTLCurrentTemp.Size = New System.Drawing.Size(69, 20)
        Me.txtTLCurrentTemp.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(787, 5)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Set Temp"
        '
        'txtTLSetTemp
        '
        Me.txtTLSetTemp.Location = New System.Drawing.Point(785, 30)
        Me.txtTLSetTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLSetTemp.Name = "txtTLSetTemp"
        Me.txtTLSetTemp.Size = New System.Drawing.Size(69, 20)
        Me.txtTLSetTemp.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(685, 5)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Engine Hours"
        '
        'txtTLEngineHours
        '
        Me.txtTLEngineHours.Location = New System.Drawing.Point(688, 30)
        Me.txtTLEngineHours.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLEngineHours.Name = "txtTLEngineHours"
        Me.txtTLEngineHours.Size = New System.Drawing.Size(89, 20)
        Me.txtTLEngineHours.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(569, 5)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Seal #"
        '
        'txtTLSeal
        '
        Me.txtTLSeal.Location = New System.Drawing.Point(572, 30)
        Me.txtTLSeal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLSeal.Name = "txtTLSeal"
        Me.txtTLSeal.Size = New System.Drawing.Size(108, 20)
        Me.txtTLSeal.TabIndex = 10
        '
        'chkTLDO
        '
        Me.chkTLDO.AutoSize = True
        Me.chkTLDO.Location = New System.Drawing.Point(513, 31)
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
        Me.chkTLPU.Location = New System.Drawing.Point(513, 2)
        Me.chkTLPU.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTLPU.Name = "chkTLPU"
        Me.chkTLPU.Size = New System.Drawing.Size(41, 17)
        Me.chkTLPU.TabIndex = 8
        Me.chkTLPU.Text = "PU"
        Me.chkTLPU.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(411, 5)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Conf #"
        '
        'txtTLConf
        '
        Me.txtTLConf.Location = New System.Drawing.Point(410, 30)
        Me.txtTLConf.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLConf.Name = "txtTLConf"
        Me.txtTLConf.Size = New System.Drawing.Size(50, 20)
        Me.txtTLConf.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(364, 5)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Door"
        '
        'txtTLDoor
        '
        Me.txtTLDoor.Location = New System.Drawing.Point(367, 30)
        Me.txtTLDoor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLDoor.Name = "txtTLDoor"
        Me.txtTLDoor.Size = New System.Drawing.Size(35, 20)
        Me.txtTLDoor.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(178, 5)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Truck #"
        '
        'txtTLTruck
        '
        Me.txtTLTruck.Location = New System.Drawing.Point(181, 30)
        Me.txtTLTruck.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLTruck.Name = "txtTLTruck"
        Me.txtTLTruck.Size = New System.Drawing.Size(85, 20)
        Me.txtTLTruck.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Trailer #"
        '
        'txtTLTrailer
        '
        Me.txtTLTrailer.Location = New System.Drawing.Point(274, 30)
        Me.txtTLTrailer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTLTrailer.Name = "txtTLTrailer"
        Me.txtTLTrailer.Size = New System.Drawing.Size(85, 20)
        Me.txtTLTrailer.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Company"
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
        'tabReeferLog
        '
        Me.tabReeferLog.BackColor = System.Drawing.Color.White
        Me.tabReeferLog.Controls.Add(Me.btnRLUpdate)
        Me.tabReeferLog.Controls.Add(Me.cmbRLTime)
        Me.tabReeferLog.Controls.Add(Me.dgvRLTracker)
        Me.tabReeferLog.Controls.Add(Me.Panel1)
        Me.tabReeferLog.Controls.Add(Me.btnRLEdit)
        Me.tabReeferLog.Controls.Add(Me.dgvRLMain)
        Me.tabReeferLog.Controls.Add(Me.Label17)
        Me.tabReeferLog.Controls.Add(Me.txtRLComments)
        Me.tabReeferLog.Controls.Add(Me.Label4)
        Me.tabReeferLog.Controls.Add(Me.Label3)
        Me.tabReeferLog.Controls.Add(Me.txtRLTemp)
        Me.tabReeferLog.Controls.Add(Me.btnRLSubmit)
        Me.tabReeferLog.Controls.Add(Me.Label2)
        Me.tabReeferLog.Controls.Add(Me.txtRLTrailer)
        Me.tabReeferLog.Controls.Add(Me.txtRLCompany)
        Me.tabReeferLog.Controls.Add(Me.Label1)
        Me.tabReeferLog.Controls.Add(Me.radRLOut)
        Me.tabReeferLog.Controls.Add(Me.radRLIn)
        Me.tabReeferLog.Location = New System.Drawing.Point(4, 22)
        Me.tabReeferLog.Margin = New System.Windows.Forms.Padding(4)
        Me.tabReeferLog.Name = "tabReeferLog"
        Me.tabReeferLog.Size = New System.Drawing.Size(1051, 613)
        Me.tabReeferLog.TabIndex = 3
        Me.tabReeferLog.Text = "Reefer Log"
        '
        'btnRLUpdate
        '
        Me.btnRLUpdate.Location = New System.Drawing.Point(914, 564)
        Me.btnRLUpdate.Name = "btnRLUpdate"
        Me.btnRLUpdate.Size = New System.Drawing.Size(133, 44)
        Me.btnRLUpdate.TabIndex = 19
        Me.btnRLUpdate.Text = "Update"
        Me.btnRLUpdate.UseVisualStyleBackColor = True
        '
        'cmbRLTime
        '
        Me.cmbRLTime.FormattingEnabled = True
        Me.cmbRLTime.Items.AddRange(New Object() {"0000", "0200", "0400", "0600", "0800", "1000", "1200", "1400", "1600", "1800", "2000", "2200"})
        Me.cmbRLTime.Location = New System.Drawing.Point(492, 30)
        Me.cmbRLTime.Name = "cmbRLTime"
        Me.cmbRLTime.Size = New System.Drawing.Size(87, 21)
        Me.cmbRLTime.TabIndex = 18
        '
        'dgvRLTracker
        '
        Me.dgvRLTracker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRLTracker.ColumnHeadersHeight = 40
        Me.dgvRLTracker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRLTracker.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmRLCompany, Me.clmRLTrailer, Me.clmRLTimeIn, Me.clmRLDateIn, Me.clmRLTimeOut, Me.clmRLDateOut, Me.clmRLTotalTime, Me.clmRLIn, Me.clmRLOut})
        Me.dgvRLTracker.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRLTracker.Location = New System.Drawing.Point(3, 325)
        Me.dgvRLTracker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvRLTracker.Name = "dgvRLTracker"
        Me.dgvRLTracker.RowTemplate.Height = 24
        Me.dgvRLTracker.Size = New System.Drawing.Size(1044, 234)
        Me.dgvRLTracker.TabIndex = 9
        '
        'clmRLCompany
        '
        Me.clmRLCompany.HeaderText = "Company"
        Me.clmRLCompany.Name = "clmRLCompany"
        Me.clmRLCompany.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRLCompany.Width = 150
        '
        'clmRLTrailer
        '
        Me.clmRLTrailer.HeaderText = "Trailer #"
        Me.clmRLTrailer.Name = "clmRLTrailer"
        Me.clmRLTrailer.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRLTrailer.Width = 150
        '
        'clmRLTimeIn
        '
        Me.clmRLTimeIn.HeaderText = "Time In"
        Me.clmRLTimeIn.Name = "clmRLTimeIn"
        Me.clmRLTimeIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmRLDateIn
        '
        Me.clmRLDateIn.HeaderText = "Date In"
        Me.clmRLDateIn.Name = "clmRLDateIn"
        Me.clmRLDateIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRLDateIn.Width = 125
        '
        'clmRLTimeOut
        '
        Me.clmRLTimeOut.HeaderText = "Time Out"
        Me.clmRLTimeOut.Name = "clmRLTimeOut"
        Me.clmRLTimeOut.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmRLDateOut
        '
        Me.clmRLDateOut.HeaderText = "Date Out"
        Me.clmRLDateOut.Name = "clmRLDateOut"
        Me.clmRLDateOut.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRLDateOut.Width = 125
        '
        'clmRLTotalTime
        '
        Me.clmRLTotalTime.HeaderText = "Total Time"
        Me.clmRLTotalTime.Name = "clmRLTotalTime"
        Me.clmRLTotalTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmRLIn
        '
        Me.clmRLIn.HeaderText = "In"
        Me.clmRLIn.Name = "clmRLIn"
        Me.clmRLIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRLIn.Width = 75
        '
        'clmRLOut
        '
        Me.clmRLOut.HeaderText = "Out"
        Me.clmRLOut.Name = "clmRLOut"
        Me.clmRLOut.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRLOut.Width = 75
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radRLOn)
        Me.Panel1.Controls.Add(Me.radRLOff)
        Me.Panel1.Location = New System.Drawing.Point(283, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(56, 51)
        Me.Panel1.TabIndex = 17
        '
        'radRLOn
        '
        Me.radRLOn.AutoSize = True
        Me.radRLOn.Location = New System.Drawing.Point(4, 5)
        Me.radRLOn.Margin = New System.Windows.Forms.Padding(4)
        Me.radRLOn.Name = "radRLOn"
        Me.radRLOn.Size = New System.Drawing.Size(39, 17)
        Me.radRLOn.TabIndex = 3
        Me.radRLOn.TabStop = True
        Me.radRLOn.Text = "On"
        Me.radRLOn.UseVisualStyleBackColor = True
        '
        'radRLOff
        '
        Me.radRLOff.AutoSize = True
        Me.radRLOff.Location = New System.Drawing.Point(4, 32)
        Me.radRLOff.Margin = New System.Windows.Forms.Padding(4)
        Me.radRLOff.Name = "radRLOff"
        Me.radRLOff.Size = New System.Drawing.Size(39, 17)
        Me.radRLOff.TabIndex = 3
        Me.radRLOff.TabStop = True
        Me.radRLOff.Text = "Off"
        Me.radRLOff.UseVisualStyleBackColor = True
        '
        'btnRLEdit
        '
        Me.btnRLEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRLEdit.Location = New System.Drawing.Point(4, 567)
        Me.btnRLEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRLEdit.Name = "btnRLEdit"
        Me.btnRLEdit.Size = New System.Drawing.Size(133, 44)
        Me.btnRLEdit.TabIndex = 10
        Me.btnRLEdit.Text = "Edit"
        Me.btnRLEdit.UseVisualStyleBackColor = True
        '
        'dgvRLMain
        '
        Me.dgvRLMain.AllowUserToResizeColumns = False
        Me.dgvRLMain.AllowUserToResizeRows = False
        Me.dgvRLMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRLMain.ColumnHeadersHeight = 40
        Me.dgvRLMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRLMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmRCSCompany, Me.clmRCSTrailer, Me.clmRCSOn, Me.clmRCSOff, Me.clmRCSTemp, Me.clmRCSTime, Me.clmRCSComments, Me.clmRCSIn, Me.clmRCSOut})
        Me.dgvRLMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRLMain.Location = New System.Drawing.Point(4, 59)
        Me.dgvRLMain.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRLMain.Name = "dgvRLMain"
        Me.dgvRLMain.Size = New System.Drawing.Size(1043, 260)
        Me.dgvRLMain.TabIndex = 16
        '
        'clmRCSCompany
        '
        Me.clmRCSCompany.HeaderText = "Company"
        Me.clmRCSCompany.Name = "clmRCSCompany"
        Me.clmRCSCompany.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRCSCompany.Width = 150
        '
        'clmRCSTrailer
        '
        Me.clmRCSTrailer.HeaderText = "Trailer #"
        Me.clmRCSTrailer.Name = "clmRCSTrailer"
        Me.clmRCSTrailer.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRCSTrailer.Width = 150
        '
        'clmRCSOn
        '
        Me.clmRCSOn.HeaderText = "On"
        Me.clmRCSOn.Name = "clmRCSOn"
        Me.clmRCSOn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRCSOn.Width = 50
        '
        'clmRCSOff
        '
        Me.clmRCSOff.HeaderText = "Off"
        Me.clmRCSOff.Name = "clmRCSOff"
        Me.clmRCSOff.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRCSOff.Width = 50
        '
        'clmRCSTemp
        '
        Me.clmRCSTemp.HeaderText = "Temp"
        Me.clmRCSTemp.Name = "clmRCSTemp"
        Me.clmRCSTemp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmRCSTime
        '
        Me.clmRCSTime.HeaderText = "Time"
        Me.clmRCSTime.Name = "clmRCSTime"
        Me.clmRCSTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmRCSComments
        '
        Me.clmRCSComments.HeaderText = "Comments"
        Me.clmRCSComments.Name = "clmRCSComments"
        Me.clmRCSComments.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRCSComments.Width = 300
        '
        'clmRCSIn
        '
        Me.clmRCSIn.HeaderText = "In"
        Me.clmRCSIn.Name = "clmRCSIn"
        Me.clmRCSIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRCSIn.Width = 50
        '
        'clmRCSOut
        '
        Me.clmRCSOut.HeaderText = "Out"
        Me.clmRCSOut.Name = "clmRCSOut"
        Me.clmRCSOut.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmRCSOut.Width = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(583, 6)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Comments"
        '
        'txtRLComments
        '
        Me.txtRLComments.Location = New System.Drawing.Point(586, 31)
        Me.txtRLComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRLComments.Name = "txtRLComments"
        Me.txtRLComments.Size = New System.Drawing.Size(320, 20)
        Me.txtRLComments.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Temp"
        '
        'txtRLTemp
        '
        Me.txtRLTemp.Location = New System.Drawing.Point(353, 31)
        Me.txtRLTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRLTemp.Name = "txtRLTemp"
        Me.txtRLTemp.Size = New System.Drawing.Size(132, 20)
        Me.txtRLTemp.TabIndex = 4
        '
        'btnRLSubmit
        '
        Me.btnRLSubmit.Location = New System.Drawing.Point(964, 7)
        Me.btnRLSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRLSubmit.Name = "btnRLSubmit"
        Me.btnRLSubmit.Size = New System.Drawing.Size(83, 47)
        Me.btnRLSubmit.TabIndex = 9
        Me.btnRLSubmit.Text = "Submit"
        Me.btnRLSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Trailer"
        '
        'txtRLTrailer
        '
        Me.txtRLTrailer.Location = New System.Drawing.Point(144, 31)
        Me.txtRLTrailer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRLTrailer.Name = "txtRLTrailer"
        Me.txtRLTrailer.Size = New System.Drawing.Size(132, 20)
        Me.txtRLTrailer.TabIndex = 2
        '
        'txtRLCompany
        '
        Me.txtRLCompany.Location = New System.Drawing.Point(4, 31)
        Me.txtRLCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRLCompany.Name = "txtRLCompany"
        Me.txtRLCompany.Size = New System.Drawing.Size(132, 20)
        Me.txtRLCompany.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Company"
        '
        'radRLOut
        '
        Me.radRLOut.AutoSize = True
        Me.radRLOut.Location = New System.Drawing.Point(914, 32)
        Me.radRLOut.Margin = New System.Windows.Forms.Padding(4)
        Me.radRLOut.Name = "radRLOut"
        Me.radRLOut.Size = New System.Drawing.Size(42, 17)
        Me.radRLOut.TabIndex = 8
        Me.radRLOut.Text = "Out"
        Me.radRLOut.UseVisualStyleBackColor = True
        '
        'radRLIn
        '
        Me.radRLIn.AutoSize = True
        Me.radRLIn.Location = New System.Drawing.Point(914, 5)
        Me.radRLIn.Margin = New System.Windows.Forms.Padding(4)
        Me.radRLIn.Name = "radRLIn"
        Me.radRLIn.Size = New System.Drawing.Size(34, 17)
        Me.radRLIn.TabIndex = 7
        Me.radRLIn.Text = "In"
        Me.radRLIn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
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
        Me.Calendar.BackColor = System.Drawing.SystemColors.Window
        Me.Calendar.Location = New System.Drawing.Point(1099, 507)
        Me.Calendar.MaxSelectionCount = 1
        Me.Calendar.Name = "Calendar"
        Me.Calendar.TabIndex = 2
        '
        'lblMainClock
        '
        Me.lblMainClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMainClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainClock.Location = New System.Drawing.Point(1094, 468)
        Me.lblMainClock.Name = "lblMainClock"
        Me.lblMainClock.Size = New System.Drawing.Size(254, 30)
        Me.lblMainClock.TabIndex = 3
        Me.lblMainClock.Text = "Clock"
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
        Me.txtMainUsername.Location = New System.Drawing.Point(1078, 82)
        Me.txtMainUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMainUsername.Name = "txtMainUsername"
        Me.txtMainUsername.Size = New System.Drawing.Size(267, 20)
        Me.txtMainUsername.TabIndex = 0
        '
        'txtMainPassword
        '
        Me.txtMainPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMainPassword.Location = New System.Drawing.Point(1078, 130)
        Me.txtMainPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMainPassword.Name = "txtMainPassword"
        Me.txtMainPassword.Size = New System.Drawing.Size(267, 20)
        Me.txtMainPassword.TabIndex = 1
        Me.txtMainPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1075, 61)
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
        Me.Label6.Location = New System.Drawing.Point(1075, 109)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password"
        '
        'lblMainLogin
        '
        Me.lblMainLogin.AutoSize = True
        Me.lblMainLogin.Location = New System.Drawing.Point(1077, 196)
        Me.lblMainLogin.Name = "lblMainLogin"
        Me.lblMainLogin.Size = New System.Drawing.Size(13, 13)
        Me.lblMainLogin.TabIndex = 9
        Me.lblMainLogin.Text = "?"
        Me.lblMainLogin.Visible = False
        '
        'btnMainLogout
        '
        Me.btnMainLogout.Location = New System.Drawing.Point(1078, 159)
        Me.btnMainLogout.Name = "btnMainLogout"
        Me.btnMainLogout.Size = New System.Drawing.Size(131, 34)
        Me.btnMainLogout.TabIndex = 10
        Me.btnMainLogout.Text = "Log Out"
        Me.btnMainLogout.UseVisualStyleBackColor = True
        Me.btnMainLogout.Visible = False
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
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1360, 684)
        Me.Controls.Add(Me.btnMainLogout)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Americold Security Logs"
        Me.tabLogs.ResumeLayout(False)
        Me.tabPassDownLog.ResumeLayout(False)
        Me.tabPassDownLog.PerformLayout()
        Me.tabBurnTimeLog.ResumeLayout(False)
        Me.tabBurnTimeLog.PerformLayout()
        CType(Me.dgvBTLInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTLInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReeferLog.ResumeLayout(False)
        Me.tabReeferLog.PerformLayout()
        CType(Me.dgvRLTracker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvRLMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabLogs As System.Windows.Forms.TabControl
    Friend WithEvents tabPassDownLog As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Calendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgvBTLInfo As System.Windows.Forms.DataGridView
    Friend WithEvents lblMainClock As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgvRLTracker As System.Windows.Forms.DataGridView
    Friend WithEvents tabBurnTimeLog As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTLConf As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTLDoor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTLTruck As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTLTrailer As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTLCompany As System.Windows.Forms.TextBox
    Friend WithEvents radTLOut As System.Windows.Forms.RadioButton
    Friend WithEvents radTLIn As System.Windows.Forms.RadioButton
    Friend WithEvents tabReeferLog As System.Windows.Forms.TabPage
    Friend WithEvents txtTLSeal As System.Windows.Forms.TextBox
    Friend WithEvents chkTLDO As System.Windows.Forms.CheckBox
    Friend WithEvents chkTLPU As System.Windows.Forms.CheckBox
    Friend WithEvents txtTLSubmit As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTLCurrentTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTLSetTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTLEngineHours As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgvTLInfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnTLEdit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRLTrailer As System.Windows.Forms.TextBox
    Friend WithEvents txtRLCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radRLOut As System.Windows.Forms.RadioButton
    Friend WithEvents radRLIn As System.Windows.Forms.RadioButton
    Friend WithEvents btnRLSubmit As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRLComments As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radRLOff As System.Windows.Forms.RadioButton
    Friend WithEvents radRLOn As System.Windows.Forms.RadioButton
    Friend WithEvents txtRLTemp As System.Windows.Forms.TextBox
    Friend WithEvents btnRLEdit As System.Windows.Forms.Button
    Friend WithEvents dgvRLMain As System.Windows.Forms.DataGridView
    Friend WithEvents btnPDLSubmit As System.Windows.Forms.Button
    Friend WithEvents lstPDLSelectEntries As System.Windows.Forms.ListBox
    Friend WithEvents rtbPDLEntry As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbPDLPastEntry As System.Windows.Forms.RichTextBox
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTLTime As System.Windows.Forms.TextBox
    Friend WithEvents lblMainLogin As System.Windows.Forms.Label
    Friend WithEvents btnPDLEdit As System.Windows.Forms.Button
    Friend WithEvents tsmFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFileLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMainLogout As System.Windows.Forms.Button
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents cmbRLTime As System.Windows.Forms.ComboBox
    Friend WithEvents btnRLUpdate As System.Windows.Forms.Button
    Friend WithEvents clmCompany As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTrailer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmInDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmInTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEngineIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmOutDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmOutTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEngineOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLCompany As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLTruck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLTrailer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLDoor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLConf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLPU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLSeal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLEngineHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLSetTemp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTLTemp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLCompany As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLTrailer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLTimeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLDateIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLTimeOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLDateOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLTotalTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRLOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSCompany As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSTrailer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSOn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSOff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSTemp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRCSOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPDLTitle As System.Windows.Forms.TextBox
End Class
