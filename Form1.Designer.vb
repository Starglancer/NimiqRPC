<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabStatus = New System.Windows.Forms.TabPage()
        Me.txtConsensus = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblConsensus = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStarglancer = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbxStatus = New System.Windows.Forms.PictureBox()
        Me.tabBlockNumber = New System.Windows.Forms.TabPage()
        Me.chtBlocknumber = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtBlocknumber = New System.Windows.Forms.TextBox()
        Me.lblBlocknumber = New System.Windows.Forms.Label()
        Me.tabPeerCount = New System.Windows.Forms.TabPage()
        Me.chtPeerCount = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtTotalPeers = New System.Windows.Forms.TextBox()
        Me.lblTotalPeers = New System.Windows.Forms.Label()
        Me.tabPeerList = New System.Windows.Forms.TabPage()
        Me.grdPeers = New System.Windows.Forms.DataGridView()
        Me.timUpdateData = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxFilter = New System.Windows.Forms.GroupBox()
        Me.gbxSort = New System.Windows.Forms.GroupBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmbConnection = New System.Windows.Forms.ComboBox()
        Me.cmbColumn = New System.Windows.Forms.ComboBox()
        Me.cmbDirection = New System.Windows.Forms.ComboBox()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Connection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Latency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.tabMining = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TabControl.SuspendLayout()
        Me.tabStatus.SuspendLayout()
        CType(Me.pbxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBlockNumber.SuspendLayout()
        CType(Me.chtBlocknumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPeerCount.SuspendLayout()
        CType(Me.chtPeerCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPeerList.SuspendLayout()
        CType(Me.grdPeers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotifyMenu.SuspendLayout()
        Me.gbxFilter.SuspendLayout()
        Me.gbxSort.SuspendLayout()
        Me.tabMining.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabStatus)
        Me.TabControl.Controls.Add(Me.tabBlockNumber)
        Me.TabControl.Controls.Add(Me.tabPeerCount)
        Me.TabControl.Controls.Add(Me.tabPeerList)
        Me.TabControl.Controls.Add(Me.tabMining)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(800, 450)
        Me.TabControl.TabIndex = 0
        '
        'tabStatus
        '
        Me.tabStatus.Controls.Add(Me.txtConsensus)
        Me.tabStatus.Controls.Add(Me.txtStatus)
        Me.tabStatus.Controls.Add(Me.lblConsensus)
        Me.tabStatus.Controls.Add(Me.lblStatus)
        Me.tabStatus.Controls.Add(Me.lblStarglancer)
        Me.tabStatus.Controls.Add(Me.lblBy)
        Me.tabStatus.Controls.Add(Me.lblTitle)
        Me.tabStatus.Controls.Add(Me.pbxStatus)
        Me.tabStatus.Location = New System.Drawing.Point(4, 22)
        Me.tabStatus.Name = "tabStatus"
        Me.tabStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStatus.Size = New System.Drawing.Size(792, 424)
        Me.tabStatus.TabIndex = 0
        Me.tabStatus.Text = "Status"
        Me.tabStatus.UseVisualStyleBackColor = True
        '
        'txtConsensus
        '
        Me.txtConsensus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtConsensus.Location = New System.Drawing.Point(542, 321)
        Me.txtConsensus.Name = "txtConsensus"
        Me.txtConsensus.ReadOnly = True
        Me.txtConsensus.Size = New System.Drawing.Size(100, 20)
        Me.txtConsensus.TabIndex = 7
        Me.txtConsensus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStatus.Location = New System.Drawing.Point(168, 321)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 6
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblConsensus
        '
        Me.lblConsensus.AutoSize = True
        Me.lblConsensus.Location = New System.Drawing.Point(454, 324)
        Me.lblConsensus.Name = "lblConsensus"
        Me.lblConsensus.Size = New System.Drawing.Size(59, 13)
        Me.lblConsensus.TabIndex = 5
        Me.lblConsensus.Text = "Consensus"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(109, 324)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status"
        '
        'lblStarglancer
        '
        Me.lblStarglancer.AutoSize = True
        Me.lblStarglancer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarglancer.Location = New System.Drawing.Point(463, 234)
        Me.lblStarglancer.Name = "lblStarglancer"
        Me.lblStarglancer.Size = New System.Drawing.Size(116, 24)
        Me.lblStarglancer.TabIndex = 3
        Me.lblStarglancer.Text = "Starglancer"
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(504, 178)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(33, 24)
        Me.lblBy.TabIndex = 2
        Me.lblBy.Text = "By"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(291, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(451, 117)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Nimiq RPC"
        '
        'pbxStatus
        '
        Me.pbxStatus.Image = Global.NimiqRPC.My.Resources.Resources.Red
        Me.pbxStatus.Location = New System.Drawing.Point(33, 76)
        Me.pbxStatus.Name = "pbxStatus"
        Me.pbxStatus.Size = New System.Drawing.Size(210, 182)
        Me.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStatus.TabIndex = 0
        Me.pbxStatus.TabStop = False
        '
        'tabBlockNumber
        '
        Me.tabBlockNumber.Controls.Add(Me.chtBlocknumber)
        Me.tabBlockNumber.Controls.Add(Me.txtBlocknumber)
        Me.tabBlockNumber.Controls.Add(Me.lblBlocknumber)
        Me.tabBlockNumber.Location = New System.Drawing.Point(4, 22)
        Me.tabBlockNumber.Name = "tabBlockNumber"
        Me.tabBlockNumber.Size = New System.Drawing.Size(792, 424)
        Me.tabBlockNumber.TabIndex = 1
        Me.tabBlockNumber.Text = "Block Number"
        Me.tabBlockNumber.UseVisualStyleBackColor = True
        '
        'chtBlocknumber
        '
        Me.chtBlocknumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chtBlocknumber.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.chtBlocknumber.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtBlocknumber.Legends.Add(Legend1)
        Me.chtBlocknumber.Location = New System.Drawing.Point(0, 42)
        Me.chtBlocknumber.Name = "chtBlocknumber"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtBlocknumber.Series.Add(Series1)
        Me.chtBlocknumber.Size = New System.Drawing.Size(789, 379)
        Me.chtBlocknumber.TabIndex = 2
        Me.chtBlocknumber.Text = "Chart1"
        '
        'txtBlocknumber
        '
        Me.txtBlocknumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBlocknumber.Location = New System.Drawing.Point(375, 16)
        Me.txtBlocknumber.Name = "txtBlocknumber"
        Me.txtBlocknumber.ReadOnly = True
        Me.txtBlocknumber.Size = New System.Drawing.Size(100, 20)
        Me.txtBlocknumber.TabIndex = 1
        Me.txtBlocknumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBlocknumber
        '
        Me.lblBlocknumber.AutoSize = True
        Me.lblBlocknumber.Location = New System.Drawing.Point(238, 19)
        Me.lblBlocknumber.Name = "lblBlocknumber"
        Me.lblBlocknumber.Size = New System.Drawing.Size(111, 13)
        Me.lblBlocknumber.TabIndex = 0
        Me.lblBlocknumber.Text = "Current Block Number"
        '
        'tabPeerCount
        '
        Me.tabPeerCount.Controls.Add(Me.chtPeerCount)
        Me.tabPeerCount.Controls.Add(Me.txtTotalPeers)
        Me.tabPeerCount.Controls.Add(Me.lblTotalPeers)
        Me.tabPeerCount.Location = New System.Drawing.Point(4, 22)
        Me.tabPeerCount.Name = "tabPeerCount"
        Me.tabPeerCount.Size = New System.Drawing.Size(792, 424)
        Me.tabPeerCount.TabIndex = 2
        Me.tabPeerCount.Text = "Peer Count"
        Me.tabPeerCount.UseVisualStyleBackColor = True
        '
        'chtPeerCount
        '
        Me.chtPeerCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chtPeerCount.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.chtPeerCount.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chtPeerCount.Legends.Add(Legend2)
        Me.chtPeerCount.Location = New System.Drawing.Point(3, 45)
        Me.chtPeerCount.Name = "chtPeerCount"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chtPeerCount.Series.Add(Series2)
        Me.chtPeerCount.Size = New System.Drawing.Size(789, 379)
        Me.chtPeerCount.TabIndex = 3
        Me.chtPeerCount.Text = "Chart1"
        '
        'txtTotalPeers
        '
        Me.txtTotalPeers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalPeers.Location = New System.Drawing.Point(372, 16)
        Me.txtTotalPeers.Name = "txtTotalPeers"
        Me.txtTotalPeers.ReadOnly = True
        Me.txtTotalPeers.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPeers.TabIndex = 1
        Me.txtTotalPeers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalPeers
        '
        Me.lblTotalPeers.AutoSize = True
        Me.lblTotalPeers.Location = New System.Drawing.Point(262, 19)
        Me.lblTotalPeers.Name = "lblTotalPeers"
        Me.lblTotalPeers.Size = New System.Drawing.Size(87, 13)
        Me.lblTotalPeers.TabIndex = 0
        Me.lblTotalPeers.Text = "Total Peer Count"
        '
        'tabPeerList
        '
        Me.tabPeerList.Controls.Add(Me.lblRowCount)
        Me.tabPeerList.Controls.Add(Me.gbxSort)
        Me.tabPeerList.Controls.Add(Me.gbxFilter)
        Me.tabPeerList.Controls.Add(Me.grdPeers)
        Me.tabPeerList.Location = New System.Drawing.Point(4, 22)
        Me.tabPeerList.Name = "tabPeerList"
        Me.tabPeerList.Size = New System.Drawing.Size(792, 424)
        Me.tabPeerList.TabIndex = 3
        Me.tabPeerList.Text = "Peer List"
        Me.tabPeerList.UseVisualStyleBackColor = True
        '
        'grdPeers
        '
        Me.grdPeers.AllowUserToAddRows = False
        Me.grdPeers.AllowUserToDeleteRows = False
        Me.grdPeers.AllowUserToResizeColumns = False
        Me.grdPeers.AllowUserToResizeRows = False
        Me.grdPeers.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdPeers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdPeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPeers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Address, Me.Type, Me.Connection, Me.Rx, Me.Tx, Me.Latency})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdPeers.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdPeers.GridColor = System.Drawing.Color.White
        Me.grdPeers.Location = New System.Drawing.Point(8, 61)
        Me.grdPeers.Name = "grdPeers"
        Me.grdPeers.ReadOnly = True
        Me.grdPeers.RowHeadersVisible = False
        Me.grdPeers.Size = New System.Drawing.Size(776, 343)
        Me.grdPeers.TabIndex = 0
        '
        'timUpdateData
        '
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.NotifyMenu
        Me.NotifyIcon.Text = "NotifyIcon1"
        Me.NotifyIcon.Visible = True
        '
        'NotifyMenu
        '
        Me.NotifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.NotifyMenu.Name = "NotifyMenu"
        Me.NotifyMenu.Size = New System.Drawing.Size(94, 26)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(93, 22)
        Me.mnuExit.Text = "Exit"
        '
        'gbxFilter
        '
        Me.gbxFilter.Controls.Add(Me.cmbConnection)
        Me.gbxFilter.Controls.Add(Me.cmbType)
        Me.gbxFilter.Controls.Add(Me.lblConnection)
        Me.gbxFilter.Controls.Add(Me.lblType)
        Me.gbxFilter.Location = New System.Drawing.Point(17, 4)
        Me.gbxFilter.Name = "gbxFilter"
        Me.gbxFilter.Size = New System.Drawing.Size(457, 51)
        Me.gbxFilter.TabIndex = 1
        Me.gbxFilter.TabStop = False
        Me.gbxFilter.Text = "Filter"
        '
        'gbxSort
        '
        Me.gbxSort.Controls.Add(Me.cmbDirection)
        Me.gbxSort.Controls.Add(Me.cmbColumn)
        Me.gbxSort.Location = New System.Drawing.Point(490, 4)
        Me.gbxSort.Name = "gbxSort"
        Me.gbxSort.Size = New System.Drawing.Size(284, 50)
        Me.gbxSort.TabIndex = 2
        Me.gbxSort.TabStop = False
        Me.gbxSort.Text = "Sort"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(37, 22)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type"
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Location = New System.Drawing.Point(232, 22)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(61, 13)
        Me.lblConnection.TabIndex = 1
        Me.lblConnection.Text = "Connection"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"--all--", "ws", "wss", "rtc", "dumb"})
        Me.cmbType.Location = New System.Drawing.Point(74, 19)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 2
        Me.cmbType.Text = "--all--"
        '
        'cmbConnection
        '
        Me.cmbConnection.FormattingEnabled = True
        Me.cmbConnection.Items.AddRange(New Object() {"--all--", "established", "failed", "new"})
        Me.cmbConnection.Location = New System.Drawing.Point(299, 19)
        Me.cmbConnection.Name = "cmbConnection"
        Me.cmbConnection.Size = New System.Drawing.Size(121, 21)
        Me.cmbConnection.TabIndex = 3
        Me.cmbConnection.Text = "established"
        '
        'cmbColumn
        '
        Me.cmbColumn.FormattingEnabled = True
        Me.cmbColumn.Items.AddRange(New Object() {"bytes recieved", "bytes sent", "latency"})
        Me.cmbColumn.Location = New System.Drawing.Point(18, 19)
        Me.cmbColumn.Name = "cmbColumn"
        Me.cmbColumn.Size = New System.Drawing.Size(121, 21)
        Me.cmbColumn.TabIndex = 0
        Me.cmbColumn.Text = "bytes recieved"
        '
        'cmbDirection
        '
        Me.cmbDirection.FormattingEnabled = True
        Me.cmbDirection.Items.AddRange(New Object() {"ascending", "descending"})
        Me.cmbDirection.Location = New System.Drawing.Point(145, 19)
        Me.cmbDirection.Name = "cmbDirection"
        Me.cmbDirection.Size = New System.Drawing.Size(121, 21)
        Me.cmbDirection.TabIndex = 1
        Me.cmbDirection.Text = "descending"
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Address.Width = 400
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Type.Width = 50
        '
        'Connection
        '
        Me.Connection.HeaderText = "Connection"
        Me.Connection.Name = "Connection"
        Me.Connection.ReadOnly = True
        Me.Connection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Connection.Width = 70
        '
        'Rx
        '
        Me.Rx.HeaderText = "Bytes Received"
        Me.Rx.Name = "Rx"
        Me.Rx.ReadOnly = True
        Me.Rx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Rx.Width = 80
        '
        'Tx
        '
        Me.Tx.HeaderText = "Bytes Sent"
        Me.Tx.Name = "Tx"
        Me.Tx.ReadOnly = True
        Me.Tx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Tx.Width = 80
        '
        'Latency
        '
        Me.Latency.HeaderText = "Latency (ms)"
        Me.Latency.Name = "Latency"
        Me.Latency.ReadOnly = True
        Me.Latency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Latency.Width = 75
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Location = New System.Drawing.Point(355, 407)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(0, 13)
        Me.lblRowCount.TabIndex = 3
        '
        'tabMining
        '
        Me.tabMining.Controls.Add(Me.GroupBox2)
        Me.tabMining.Controls.Add(Me.GroupBox1)
        Me.tabMining.Location = New System.Drawing.Point(4, 22)
        Me.tabMining.Name = "tabMining"
        Me.tabMining.Size = New System.Drawing.Size(792, 424)
        Me.tabMining.TabIndex = 4
        Me.tabMining.Text = "Mining"
        Me.tabMining.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(66, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Miner Enabled"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(269, 17)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(126, 45)
        Me.TrackBar1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(401, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(569, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Threads"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(512, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hashrate"
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(18, 61)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(739, 209)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Chart1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 323)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Miner"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(765, 73)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mining Pool"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mining Address"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(239, 285)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(356, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pool"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(293, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Pool Connection"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(537, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Pool Balance"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(77, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(178, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(384, 30)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(613, 30)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Nimiq RPC"
        Me.TabControl.ResumeLayout(False)
        Me.tabStatus.ResumeLayout(False)
        Me.tabStatus.PerformLayout()
        CType(Me.pbxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBlockNumber.ResumeLayout(False)
        Me.tabBlockNumber.PerformLayout()
        CType(Me.chtBlocknumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPeerCount.ResumeLayout(False)
        Me.tabPeerCount.PerformLayout()
        CType(Me.chtPeerCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPeerList.ResumeLayout(False)
        Me.tabPeerList.PerformLayout()
        CType(Me.grdPeers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotifyMenu.ResumeLayout(False)
        Me.gbxFilter.ResumeLayout(False)
        Me.gbxFilter.PerformLayout()
        Me.gbxSort.ResumeLayout(False)
        Me.tabMining.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents tabStatus As TabPage
    Friend WithEvents tabBlockNumber As TabPage
    Friend WithEvents tabPeerCount As TabPage
    Friend WithEvents timUpdateData As Timer
    Friend WithEvents pbxStatus As PictureBox
    Friend WithEvents lblStarglancer As Label
    Friend WithEvents lblBy As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtConsensus As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblConsensus As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents NotifyMenu As ContextMenuStrip
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents txtBlocknumber As TextBox
    Friend WithEvents lblBlocknumber As Label
    Friend WithEvents chtBlocknumber As DataVisualization.Charting.Chart
    Friend WithEvents txtTotalPeers As TextBox
    Friend WithEvents lblTotalPeers As Label
    Friend WithEvents chtPeerCount As DataVisualization.Charting.Chart
    Friend WithEvents tabPeerList As TabPage
    Friend WithEvents grdPeers As DataGridView
    Friend WithEvents gbxSort As GroupBox
    Friend WithEvents cmbDirection As ComboBox
    Friend WithEvents cmbColumn As ComboBox
    Friend WithEvents gbxFilter As GroupBox
    Friend WithEvents cmbConnection As ComboBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblConnection As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Connection As DataGridViewTextBoxColumn
    Friend WithEvents Rx As DataGridViewTextBoxColumn
    Friend WithEvents Tx As DataGridViewTextBoxColumn
    Friend WithEvents Latency As DataGridViewTextBoxColumn
    Friend WithEvents lblRowCount As Label
    Friend WithEvents tabMining As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents CheckBox1 As CheckBox
End Class
