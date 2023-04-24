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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.tabBlockList = New System.Windows.Forms.TabPage()
        Me.grdBlocks = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabBlockDetail = New System.Windows.Forms.TabPage()
        Me.gbxSearch = New System.Windows.Forms.GroupBox()
        Me.btnBlockSearch = New System.Windows.Forms.Button()
        Me.tabPeerCount = New System.Windows.Forms.TabPage()
        Me.chtPeerCount = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtTotalPeers = New System.Windows.Forms.TextBox()
        Me.lblTotalPeers = New System.Windows.Forms.Label()
        Me.tabPeerList = New System.Windows.Forms.TabPage()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.gbxSort = New System.Windows.Forms.GroupBox()
        Me.cmbDirection = New System.Windows.Forms.ComboBox()
        Me.cmbColumn = New System.Windows.Forms.ComboBox()
        Me.gbxFilter = New System.Windows.Forms.GroupBox()
        Me.cmbConnection = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.grdPeers = New System.Windows.Forms.DataGridView()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Connection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Latency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabMining = New System.Windows.Forms.TabPage()
        Me.gbxMiningPool = New System.Windows.Forms.GroupBox()
        Me.cmbPool = New System.Windows.Forms.ComboBox()
        Me.txtPoolBalance = New System.Windows.Forms.TextBox()
        Me.txtPoolConnection = New System.Windows.Forms.TextBox()
        Me.lblPoolBalance = New System.Windows.Forms.Label()
        Me.lblPoolConnection = New System.Windows.Forms.Label()
        Me.lblPool = New System.Windows.Forms.Label()
        Me.gbxMiner = New System.Windows.Forms.GroupBox()
        Me.txtMiningAddress = New System.Windows.Forms.TextBox()
        Me.lblMiningAddress = New System.Windows.Forms.Label()
        Me.chtHashRate = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblThreads = New System.Windows.Forms.Label()
        Me.txtHashRate = New System.Windows.Forms.TextBox()
        Me.txtThreads = New System.Windows.Forms.TextBox()
        Me.tbrThreads = New System.Windows.Forms.TrackBar()
        Me.chkMiner = New System.Windows.Forms.CheckBox()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.gbxLogging = New System.Windows.Forms.GroupBox()
        Me.cmbLoggingLevel = New System.Windows.Forms.ComboBox()
        Me.lblLoggingLevel = New System.Windows.Forms.Label()
        Me.gbxPool = New System.Windows.Forms.GroupBox()
        Me.txtPoolList = New System.Windows.Forms.TextBox()
        Me.lblPoolList = New System.Windows.Forms.Label()
        Me.gbxLogin = New System.Windows.Forms.GroupBox()
        Me.btnSaveLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.txtScheme = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblScheme = New System.Windows.Forms.Label()
        Me.timUpdateData = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBlock_Number = New System.Windows.Forms.Label()
        Me.lblBlock_Hash = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabControl.SuspendLayout()
        Me.tabStatus.SuspendLayout()
        CType(Me.pbxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBlockNumber.SuspendLayout()
        CType(Me.chtBlocknumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBlockList.SuspendLayout()
        CType(Me.grdBlocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBlockDetail.SuspendLayout()
        Me.gbxSearch.SuspendLayout()
        Me.tabPeerCount.SuspendLayout()
        CType(Me.chtPeerCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPeerList.SuspendLayout()
        Me.gbxSort.SuspendLayout()
        Me.gbxFilter.SuspendLayout()
        CType(Me.grdPeers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMining.SuspendLayout()
        Me.gbxMiningPool.SuspendLayout()
        Me.gbxMiner.SuspendLayout()
        CType(Me.chtHashRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSettings.SuspendLayout()
        Me.gbxLogging.SuspendLayout()
        Me.gbxPool.SuspendLayout()
        Me.gbxLogin.SuspendLayout()
        Me.NotifyMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabStatus)
        Me.TabControl.Controls.Add(Me.tabBlockNumber)
        Me.TabControl.Controls.Add(Me.tabBlockList)
        Me.TabControl.Controls.Add(Me.tabBlockDetail)
        Me.TabControl.Controls.Add(Me.tabPeerCount)
        Me.TabControl.Controls.Add(Me.tabPeerList)
        Me.TabControl.Controls.Add(Me.tabMining)
        Me.TabControl.Controls.Add(Me.tabSettings)
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
        'tabBlockList
        '
        Me.tabBlockList.Controls.Add(Me.grdBlocks)
        Me.tabBlockList.Location = New System.Drawing.Point(4, 22)
        Me.tabBlockList.Name = "tabBlockList"
        Me.tabBlockList.Size = New System.Drawing.Size(792, 424)
        Me.tabBlockList.TabIndex = 7
        Me.tabBlockList.Text = "Block List"
        Me.tabBlockList.UseVisualStyleBackColor = True
        '
        'grdBlocks
        '
        Me.grdBlocks.AllowUserToAddRows = False
        Me.grdBlocks.AllowUserToDeleteRows = False
        Me.grdBlocks.AllowUserToResizeColumns = False
        Me.grdBlocks.AllowUserToResizeRows = False
        Me.grdBlocks.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBlocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBlocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.Timestamp, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdBlocks.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdBlocks.GridColor = System.Drawing.Color.White
        Me.grdBlocks.Location = New System.Drawing.Point(8, 15)
        Me.grdBlocks.Name = "grdBlocks"
        Me.grdBlocks.ReadOnly = True
        Me.grdBlocks.RowHeadersVisible = False
        Me.grdBlocks.Size = New System.Drawing.Size(776, 401)
        Me.grdBlocks.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Block Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Transactions"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column1
        '
        Me.Column1.HeaderText = "Size"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 75
        '
        'Timestamp
        '
        Me.Timestamp.HeaderText = "Local Time"
        Me.Timestamp.Name = "Timestamp"
        Me.Timestamp.ReadOnly = True
        Me.Timestamp.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Miner Address"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 330
        '
        'tabBlockDetail
        '
        Me.tabBlockDetail.Controls.Add(Me.gbxSearch)
        Me.tabBlockDetail.Location = New System.Drawing.Point(4, 22)
        Me.tabBlockDetail.Name = "tabBlockDetail"
        Me.tabBlockDetail.Size = New System.Drawing.Size(792, 424)
        Me.tabBlockDetail.TabIndex = 8
        Me.tabBlockDetail.Text = "Block Detail"
        Me.tabBlockDetail.UseVisualStyleBackColor = True
        '
        'gbxSearch
        '
        Me.gbxSearch.Controls.Add(Me.TextBox2)
        Me.gbxSearch.Controls.Add(Me.TextBox1)
        Me.gbxSearch.Controls.Add(Me.lblBlock_Hash)
        Me.gbxSearch.Controls.Add(Me.lblBlock_Number)
        Me.gbxSearch.Controls.Add(Me.btnBlockSearch)
        Me.gbxSearch.Location = New System.Drawing.Point(12, 11)
        Me.gbxSearch.Name = "gbxSearch"
        Me.gbxSearch.Size = New System.Drawing.Size(764, 58)
        Me.gbxSearch.TabIndex = 0
        Me.gbxSearch.TabStop = False
        Me.gbxSearch.Text = "Search"
        '
        'btnBlockSearch
        '
        Me.btnBlockSearch.Location = New System.Drawing.Point(661, 22)
        Me.btnBlockSearch.Name = "btnBlockSearch"
        Me.btnBlockSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnBlockSearch.TabIndex = 0
        Me.btnBlockSearch.Text = "Search"
        Me.btnBlockSearch.UseVisualStyleBackColor = True
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
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Location = New System.Drawing.Point(355, 407)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(0, 13)
        Me.lblRowCount.TabIndex = 3
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
        'cmbDirection
        '
        Me.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDirection.FormattingEnabled = True
        Me.cmbDirection.Items.AddRange(New Object() {"ascending", "descending"})
        Me.cmbDirection.Location = New System.Drawing.Point(145, 19)
        Me.cmbDirection.Name = "cmbDirection"
        Me.cmbDirection.Size = New System.Drawing.Size(121, 21)
        Me.cmbDirection.TabIndex = 1
        '
        'cmbColumn
        '
        Me.cmbColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColumn.FormattingEnabled = True
        Me.cmbColumn.Items.AddRange(New Object() {"bytes recieved", "bytes sent", "latency"})
        Me.cmbColumn.Location = New System.Drawing.Point(18, 19)
        Me.cmbColumn.Name = "cmbColumn"
        Me.cmbColumn.Size = New System.Drawing.Size(121, 21)
        Me.cmbColumn.TabIndex = 0
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
        'cmbConnection
        '
        Me.cmbConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConnection.FormattingEnabled = True
        Me.cmbConnection.Items.AddRange(New Object() {"--all--", "established", "failed", "new"})
        Me.cmbConnection.Location = New System.Drawing.Point(299, 19)
        Me.cmbConnection.Name = "cmbConnection"
        Me.cmbConnection.Size = New System.Drawing.Size(121, 21)
        Me.cmbConnection.TabIndex = 3
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"--all--", "ws", "wss", "rtc", "dumb"})
        Me.cmbType.Location = New System.Drawing.Point(74, 19)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 2
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
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(37, 22)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type"
        '
        'grdPeers
        '
        Me.grdPeers.AllowUserToAddRows = False
        Me.grdPeers.AllowUserToDeleteRows = False
        Me.grdPeers.AllowUserToResizeColumns = False
        Me.grdPeers.AllowUserToResizeRows = False
        Me.grdPeers.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdPeers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdPeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPeers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Address, Me.Type, Me.Connection, Me.Rx, Me.Tx, Me.Latency})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdPeers.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdPeers.GridColor = System.Drawing.Color.White
        Me.grdPeers.Location = New System.Drawing.Point(8, 61)
        Me.grdPeers.Name = "grdPeers"
        Me.grdPeers.ReadOnly = True
        Me.grdPeers.RowHeadersVisible = False
        Me.grdPeers.Size = New System.Drawing.Size(776, 343)
        Me.grdPeers.TabIndex = 0
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
        'tabMining
        '
        Me.tabMining.Controls.Add(Me.gbxMiningPool)
        Me.tabMining.Controls.Add(Me.gbxMiner)
        Me.tabMining.Location = New System.Drawing.Point(4, 22)
        Me.tabMining.Name = "tabMining"
        Me.tabMining.Size = New System.Drawing.Size(792, 424)
        Me.tabMining.TabIndex = 4
        Me.tabMining.Text = "Mining"
        Me.tabMining.UseVisualStyleBackColor = True
        '
        'gbxMiningPool
        '
        Me.gbxMiningPool.Controls.Add(Me.cmbPool)
        Me.gbxMiningPool.Controls.Add(Me.txtPoolBalance)
        Me.gbxMiningPool.Controls.Add(Me.txtPoolConnection)
        Me.gbxMiningPool.Controls.Add(Me.lblPoolBalance)
        Me.gbxMiningPool.Controls.Add(Me.lblPoolConnection)
        Me.gbxMiningPool.Controls.Add(Me.lblPool)
        Me.gbxMiningPool.Location = New System.Drawing.Point(16, 343)
        Me.gbxMiningPool.Name = "gbxMiningPool"
        Me.gbxMiningPool.Size = New System.Drawing.Size(768, 73)
        Me.gbxMiningPool.TabIndex = 8
        Me.gbxMiningPool.TabStop = False
        Me.gbxMiningPool.Text = "Mining Pool"
        '
        'cmbPool
        '
        Me.cmbPool.FormattingEnabled = True
        Me.cmbPool.Location = New System.Drawing.Point(73, 29)
        Me.cmbPool.Name = "cmbPool"
        Me.cmbPool.Size = New System.Drawing.Size(186, 21)
        Me.cmbPool.TabIndex = 6
        '
        'txtPoolBalance
        '
        Me.txtPoolBalance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPoolBalance.Location = New System.Drawing.Point(613, 30)
        Me.txtPoolBalance.Name = "txtPoolBalance"
        Me.txtPoolBalance.ReadOnly = True
        Me.txtPoolBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtPoolBalance.TabIndex = 5
        Me.txtPoolBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPoolConnection
        '
        Me.txtPoolConnection.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPoolConnection.Location = New System.Drawing.Point(384, 30)
        Me.txtPoolConnection.Name = "txtPoolConnection"
        Me.txtPoolConnection.ReadOnly = True
        Me.txtPoolConnection.Size = New System.Drawing.Size(100, 20)
        Me.txtPoolConnection.TabIndex = 4
        Me.txtPoolConnection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPoolBalance
        '
        Me.lblPoolBalance.AutoSize = True
        Me.lblPoolBalance.Location = New System.Drawing.Point(510, 33)
        Me.lblPoolBalance.Name = "lblPoolBalance"
        Me.lblPoolBalance.Size = New System.Drawing.Size(97, 13)
        Me.lblPoolBalance.TabIndex = 2
        Me.lblPoolBalance.Text = "Pool Balance (Nim)"
        '
        'lblPoolConnection
        '
        Me.lblPoolConnection.AutoSize = True
        Me.lblPoolConnection.Location = New System.Drawing.Point(293, 33)
        Me.lblPoolConnection.Name = "lblPoolConnection"
        Me.lblPoolConnection.Size = New System.Drawing.Size(85, 13)
        Me.lblPoolConnection.TabIndex = 1
        Me.lblPoolConnection.Text = "Pool Connection"
        '
        'lblPool
        '
        Me.lblPool.AutoSize = True
        Me.lblPool.Location = New System.Drawing.Point(39, 33)
        Me.lblPool.Name = "lblPool"
        Me.lblPool.Size = New System.Drawing.Size(28, 13)
        Me.lblPool.TabIndex = 0
        Me.lblPool.Text = "Pool"
        '
        'gbxMiner
        '
        Me.gbxMiner.Controls.Add(Me.txtMiningAddress)
        Me.gbxMiner.Controls.Add(Me.lblMiningAddress)
        Me.gbxMiner.Controls.Add(Me.chtHashRate)
        Me.gbxMiner.Controls.Add(Me.Label2)
        Me.gbxMiner.Controls.Add(Me.lblThreads)
        Me.gbxMiner.Controls.Add(Me.txtHashRate)
        Me.gbxMiner.Controls.Add(Me.txtThreads)
        Me.gbxMiner.Controls.Add(Me.tbrThreads)
        Me.gbxMiner.Controls.Add(Me.chkMiner)
        Me.gbxMiner.Location = New System.Drawing.Point(16, 14)
        Me.gbxMiner.Name = "gbxMiner"
        Me.gbxMiner.Size = New System.Drawing.Size(768, 323)
        Me.gbxMiner.TabIndex = 7
        Me.gbxMiner.TabStop = False
        Me.gbxMiner.Text = "Miner"
        '
        'txtMiningAddress
        '
        Me.txtMiningAddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMiningAddress.Location = New System.Drawing.Point(239, 285)
        Me.txtMiningAddress.Name = "txtMiningAddress"
        Me.txtMiningAddress.ReadOnly = True
        Me.txtMiningAddress.Size = New System.Drawing.Size(312, 20)
        Me.txtMiningAddress.TabIndex = 8
        Me.txtMiningAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMiningAddress
        '
        Me.lblMiningAddress.AutoSize = True
        Me.lblMiningAddress.Location = New System.Drawing.Point(154, 288)
        Me.lblMiningAddress.Name = "lblMiningAddress"
        Me.lblMiningAddress.Size = New System.Drawing.Size(79, 13)
        Me.lblMiningAddress.TabIndex = 7
        Me.lblMiningAddress.Text = "Mining Address"
        '
        'chtHashRate
        '
        Me.chtHashRate.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.chtHashRate.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chtHashRate.Legends.Add(Legend3)
        Me.chtHashRate.Location = New System.Drawing.Point(18, 61)
        Me.chtHashRate.Name = "chtHashRate"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chtHashRate.Series.Add(Series3)
        Me.chtHashRate.Size = New System.Drawing.Size(739, 209)
        Me.chtHashRate.TabIndex = 6
        Me.chtHashRate.Text = "Chart1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(486, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hashrate (H/s)"
        '
        'lblThreads
        '
        Me.lblThreads.AutoSize = True
        Me.lblThreads.Location = New System.Drawing.Point(217, 21)
        Me.lblThreads.Name = "lblThreads"
        Me.lblThreads.Size = New System.Drawing.Size(46, 13)
        Me.lblThreads.TabIndex = 4
        Me.lblThreads.Text = "Threads"
        '
        'txtHashRate
        '
        Me.txtHashRate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtHashRate.Location = New System.Drawing.Point(569, 19)
        Me.txtHashRate.Name = "txtHashRate"
        Me.txtHashRate.ReadOnly = True
        Me.txtHashRate.Size = New System.Drawing.Size(100, 20)
        Me.txtHashRate.TabIndex = 3
        Me.txtHashRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtThreads
        '
        Me.txtThreads.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtThreads.Location = New System.Drawing.Point(401, 19)
        Me.txtThreads.Name = "txtThreads"
        Me.txtThreads.ReadOnly = True
        Me.txtThreads.Size = New System.Drawing.Size(26, 20)
        Me.txtThreads.TabIndex = 2
        Me.txtThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbrThreads
        '
        Me.tbrThreads.Location = New System.Drawing.Point(269, 17)
        Me.tbrThreads.Name = "tbrThreads"
        Me.tbrThreads.Size = New System.Drawing.Size(126, 45)
        Me.tbrThreads.TabIndex = 1
        '
        'chkMiner
        '
        Me.chkMiner.AutoSize = True
        Me.chkMiner.Location = New System.Drawing.Point(66, 21)
        Me.chkMiner.Name = "chkMiner"
        Me.chkMiner.Size = New System.Drawing.Size(94, 17)
        Me.chkMiner.TabIndex = 0
        Me.chkMiner.Text = "Miner Enabled"
        Me.chkMiner.UseVisualStyleBackColor = True
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.gbxLogging)
        Me.tabSettings.Controls.Add(Me.gbxPool)
        Me.tabSettings.Controls.Add(Me.gbxLogin)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(792, 424)
        Me.tabSettings.TabIndex = 5
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'gbxLogging
        '
        Me.gbxLogging.Controls.Add(Me.cmbLoggingLevel)
        Me.gbxLogging.Controls.Add(Me.lblLoggingLevel)
        Me.gbxLogging.Location = New System.Drawing.Point(377, 147)
        Me.gbxLogging.Name = "gbxLogging"
        Me.gbxLogging.Size = New System.Drawing.Size(391, 51)
        Me.gbxLogging.TabIndex = 9
        Me.gbxLogging.TabStop = False
        Me.gbxLogging.Text = "Logging"
        '
        'cmbLoggingLevel
        '
        Me.cmbLoggingLevel.FormattingEnabled = True
        Me.cmbLoggingLevel.Items.AddRange(New Object() {"trace", "verbose", "debug", "info", "warning", "error", "assert"})
        Me.cmbLoggingLevel.Location = New System.Drawing.Point(208, 19)
        Me.cmbLoggingLevel.Name = "cmbLoggingLevel"
        Me.cmbLoggingLevel.Size = New System.Drawing.Size(121, 21)
        Me.cmbLoggingLevel.TabIndex = 1
        '
        'lblLoggingLevel
        '
        Me.lblLoggingLevel.AutoSize = True
        Me.lblLoggingLevel.Location = New System.Drawing.Point(85, 22)
        Me.lblLoggingLevel.Name = "lblLoggingLevel"
        Me.lblLoggingLevel.Size = New System.Drawing.Size(103, 13)
        Me.lblLoggingLevel.TabIndex = 0
        Me.lblLoggingLevel.Text = "Client Logging Level"
        '
        'gbxPool
        '
        Me.gbxPool.Controls.Add(Me.txtPoolList)
        Me.gbxPool.Controls.Add(Me.lblPoolList)
        Me.gbxPool.Location = New System.Drawing.Point(377, 19)
        Me.gbxPool.Name = "gbxPool"
        Me.gbxPool.Size = New System.Drawing.Size(391, 112)
        Me.gbxPool.TabIndex = 8
        Me.gbxPool.TabStop = False
        Me.gbxPool.Text = "Pool"
        '
        'txtPoolList
        '
        Me.txtPoolList.Location = New System.Drawing.Point(91, 16)
        Me.txtPoolList.Multiline = True
        Me.txtPoolList.Name = "txtPoolList"
        Me.txtPoolList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPoolList.Size = New System.Drawing.Size(255, 86)
        Me.txtPoolList.TabIndex = 1
        '
        'lblPoolList
        '
        Me.lblPoolList.AutoSize = True
        Me.lblPoolList.Location = New System.Drawing.Point(38, 45)
        Me.lblPoolList.Name = "lblPoolList"
        Me.lblPoolList.Size = New System.Drawing.Size(47, 13)
        Me.lblPoolList.TabIndex = 0
        Me.lblPoolList.Text = "Pool List"
        '
        'gbxLogin
        '
        Me.gbxLogin.Controls.Add(Me.btnSaveLogin)
        Me.gbxLogin.Controls.Add(Me.txtPassword)
        Me.gbxLogin.Controls.Add(Me.txtUser)
        Me.gbxLogin.Controls.Add(Me.txtPort)
        Me.gbxLogin.Controls.Add(Me.txtHost)
        Me.gbxLogin.Controls.Add(Me.txtScheme)
        Me.gbxLogin.Controls.Add(Me.lblPassword)
        Me.gbxLogin.Controls.Add(Me.lblUser)
        Me.gbxLogin.Controls.Add(Me.lblPort)
        Me.gbxLogin.Controls.Add(Me.lblHost)
        Me.gbxLogin.Controls.Add(Me.lblScheme)
        Me.gbxLogin.Location = New System.Drawing.Point(28, 19)
        Me.gbxLogin.Name = "gbxLogin"
        Me.gbxLogin.Size = New System.Drawing.Size(320, 179)
        Me.gbxLogin.TabIndex = 7
        Me.gbxLogin.TabStop = False
        Me.gbxLogin.Text = "Login"
        '
        'btnSaveLogin
        '
        Me.btnSaveLogin.Location = New System.Drawing.Point(248, 82)
        Me.btnSaveLogin.Name = "btnSaveLogin"
        Me.btnSaveLogin.Size = New System.Drawing.Size(52, 23)
        Me.btnSaveLogin.TabIndex = 12
        Me.btnSaveLogin.Text = "Save"
        Me.btnSaveLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(95, 140)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(137, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(95, 112)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(137, 20)
        Me.txtUser.TabIndex = 10
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(95, 85)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(137, 20)
        Me.txtPort.TabIndex = 9
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(95, 58)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(137, 20)
        Me.txtHost.TabIndex = 8
        Me.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtScheme
        '
        Me.txtScheme.Location = New System.Drawing.Point(95, 29)
        Me.txtScheme.Name = "txtScheme"
        Me.txtScheme.Size = New System.Drawing.Size(137, 20)
        Me.txtScheme.TabIndex = 7
        Me.txtScheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(14, 143)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(38, 115)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(29, 13)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "User"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(41, 88)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 4
        Me.lblPort.Text = "Port"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(38, 61)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(29, 13)
        Me.lblHost.TabIndex = 3
        Me.lblHost.Text = "Host"
        '
        'lblScheme
        '
        Me.lblScheme.AutoSize = True
        Me.lblScheme.Location = New System.Drawing.Point(21, 32)
        Me.lblScheme.Name = "lblScheme"
        Me.lblScheme.Size = New System.Drawing.Size(46, 13)
        Me.lblScheme.TabIndex = 2
        Me.lblScheme.Text = "Scheme"
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
        'lblBlock_Number
        '
        Me.lblBlock_Number.AutoSize = True
        Me.lblBlock_Number.Location = New System.Drawing.Point(30, 26)
        Me.lblBlock_Number.Name = "lblBlock_Number"
        Me.lblBlock_Number.Size = New System.Drawing.Size(74, 13)
        Me.lblBlock_Number.TabIndex = 1
        Me.lblBlock_Number.Text = "Block Number"
        '
        'lblBlock_Hash
        '
        Me.lblBlock_Hash.AutoSize = True
        Me.lblBlock_Hash.Location = New System.Drawing.Point(249, 27)
        Me.lblBlock_Hash.Name = "lblBlock_Hash"
        Me.lblBlock_Hash.Size = New System.Drawing.Size(62, 13)
        Me.lblBlock_Hash.TabIndex = 2
        Me.lblBlock_Hash.Text = "Block Hash"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(317, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(318, 20)
        Me.TextBox2.TabIndex = 4
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
        Me.tabBlockList.ResumeLayout(False)
        CType(Me.grdBlocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBlockDetail.ResumeLayout(False)
        Me.gbxSearch.ResumeLayout(False)
        Me.gbxSearch.PerformLayout()
        Me.tabPeerCount.ResumeLayout(False)
        Me.tabPeerCount.PerformLayout()
        CType(Me.chtPeerCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPeerList.ResumeLayout(False)
        Me.tabPeerList.PerformLayout()
        Me.gbxSort.ResumeLayout(False)
        Me.gbxFilter.ResumeLayout(False)
        Me.gbxFilter.PerformLayout()
        CType(Me.grdPeers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMining.ResumeLayout(False)
        Me.gbxMiningPool.ResumeLayout(False)
        Me.gbxMiningPool.PerformLayout()
        Me.gbxMiner.ResumeLayout(False)
        Me.gbxMiner.PerformLayout()
        CType(Me.chtHashRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrThreads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSettings.ResumeLayout(False)
        Me.gbxLogging.ResumeLayout(False)
        Me.gbxLogging.PerformLayout()
        Me.gbxPool.ResumeLayout(False)
        Me.gbxPool.PerformLayout()
        Me.gbxLogin.ResumeLayout(False)
        Me.gbxLogin.PerformLayout()
        Me.NotifyMenu.ResumeLayout(False)
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
    Friend WithEvents gbxMiningPool As GroupBox
    Friend WithEvents txtPoolBalance As TextBox
    Friend WithEvents txtPoolConnection As TextBox
    Friend WithEvents lblPoolBalance As Label
    Friend WithEvents lblPoolConnection As Label
    Friend WithEvents lblPool As Label
    Friend WithEvents gbxMiner As GroupBox
    Friend WithEvents lblMiningAddress As Label
    Friend WithEvents chtHashRate As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents lblThreads As Label
    Friend WithEvents txtHashRate As TextBox
    Friend WithEvents txtThreads As TextBox
    Friend WithEvents tbrThreads As TrackBar
    Friend WithEvents chkMiner As CheckBox
    Friend WithEvents cmbPool As ComboBox
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents txtPoolList As TextBox
    Friend WithEvents lblPoolList As Label
    Friend WithEvents txtMiningAddress As TextBox
    Friend WithEvents gbxLogin As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtHost As TextBox
    Friend WithEvents txtScheme As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblScheme As Label
    Friend WithEvents btnSaveLogin As Button
    Friend WithEvents gbxLogging As GroupBox
    Friend WithEvents cmbLoggingLevel As ComboBox
    Friend WithEvents lblLoggingLevel As Label
    Friend WithEvents gbxPool As GroupBox
    Friend WithEvents tabBlockList As TabPage
    Friend WithEvents grdBlocks As DataGridView
    Friend WithEvents tabBlockDetail As TabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Timestamp As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents gbxSearch As GroupBox
    Friend WithEvents btnBlockSearch As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblBlock_Hash As Label
    Friend WithEvents lblBlock_Number As Label
End Class
