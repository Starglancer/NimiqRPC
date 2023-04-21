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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabStatus = New System.Windows.Forms.TabPage()
        Me.pbxStatus = New System.Windows.Forms.PictureBox()
        Me.tabBlockchain = New System.Windows.Forms.TabPage()
        Me.tabNetwork = New System.Windows.Forms.TabPage()
        Me.tabMiner = New System.Windows.Forms.TabPage()
        Me.tabWallet = New System.Windows.Forms.TabPage()
        Me.tabLog = New System.Windows.Forms.TabPage()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.tabHelp = New System.Windows.Forms.TabPage()
        Me.timUpdateData = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblStarglancer = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblConsensus = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtConsensus = New System.Windows.Forms.TextBox()
        Me.TabControl.SuspendLayout()
        Me.tabStatus.SuspendLayout()
        CType(Me.pbxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabStatus)
        Me.TabControl.Controls.Add(Me.tabBlockchain)
        Me.TabControl.Controls.Add(Me.tabNetwork)
        Me.TabControl.Controls.Add(Me.tabMiner)
        Me.TabControl.Controls.Add(Me.tabWallet)
        Me.TabControl.Controls.Add(Me.tabLog)
        Me.TabControl.Controls.Add(Me.tabSettings)
        Me.TabControl.Controls.Add(Me.tabHelp)
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
        'tabBlockchain
        '
        Me.tabBlockchain.Location = New System.Drawing.Point(4, 22)
        Me.tabBlockchain.Name = "tabBlockchain"
        Me.tabBlockchain.Size = New System.Drawing.Size(792, 424)
        Me.tabBlockchain.TabIndex = 1
        Me.tabBlockchain.Text = "Blockchain"
        Me.tabBlockchain.UseVisualStyleBackColor = True
        '
        'tabNetwork
        '
        Me.tabNetwork.Location = New System.Drawing.Point(4, 22)
        Me.tabNetwork.Name = "tabNetwork"
        Me.tabNetwork.Size = New System.Drawing.Size(792, 424)
        Me.tabNetwork.TabIndex = 2
        Me.tabNetwork.Text = "Network"
        Me.tabNetwork.UseVisualStyleBackColor = True
        '
        'tabMiner
        '
        Me.tabMiner.Location = New System.Drawing.Point(4, 22)
        Me.tabMiner.Name = "tabMiner"
        Me.tabMiner.Size = New System.Drawing.Size(792, 424)
        Me.tabMiner.TabIndex = 3
        Me.tabMiner.Text = "Miner"
        Me.tabMiner.UseVisualStyleBackColor = True
        '
        'tabWallet
        '
        Me.tabWallet.Location = New System.Drawing.Point(4, 22)
        Me.tabWallet.Name = "tabWallet"
        Me.tabWallet.Size = New System.Drawing.Size(792, 424)
        Me.tabWallet.TabIndex = 4
        Me.tabWallet.Text = "Wallet"
        Me.tabWallet.UseVisualStyleBackColor = True
        '
        'tabLog
        '
        Me.tabLog.Location = New System.Drawing.Point(4, 22)
        Me.tabLog.Name = "tabLog"
        Me.tabLog.Size = New System.Drawing.Size(792, 424)
        Me.tabLog.TabIndex = 5
        Me.tabLog.Text = "Log"
        Me.tabLog.UseVisualStyleBackColor = True
        '
        'tabSettings
        '
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(792, 424)
        Me.tabSettings.TabIndex = 6
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'tabHelp
        '
        Me.tabHelp.Location = New System.Drawing.Point(4, 22)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.Size = New System.Drawing.Size(792, 424)
        Me.tabHelp.TabIndex = 7
        Me.tabHelp.Text = "Help"
        Me.tabHelp.UseVisualStyleBackColor = True
        '
        'timUpdateData
        '
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(298, 57)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(424, 87)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Nimiq Client"
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(485, 170)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(33, 24)
        Me.lblBy.TabIndex = 2
        Me.lblBy.Text = "By"
        '
        'lblStarglancer
        '
        Me.lblStarglancer.AutoSize = True
        Me.lblStarglancer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarglancer.Location = New System.Drawing.Point(443, 220)
        Me.lblStarglancer.Name = "lblStarglancer"
        Me.lblStarglancer.Size = New System.Drawing.Size(116, 24)
        Me.lblStarglancer.TabIndex = 3
        Me.lblStarglancer.Text = "Starglancer"
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
        'lblConsensus
        '
        Me.lblConsensus.AutoSize = True
        Me.lblConsensus.Location = New System.Drawing.Point(454, 324)
        Me.lblConsensus.Name = "lblConsensus"
        Me.lblConsensus.Size = New System.Drawing.Size(59, 13)
        Me.lblConsensus.TabIndex = 5
        Me.lblConsensus.Text = "Consensus"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(168, 321)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 6
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtConsensus
        '
        Me.txtConsensus.Location = New System.Drawing.Point(542, 321)
        Me.txtConsensus.Name = "txtConsensus"
        Me.txtConsensus.Size = New System.Drawing.Size(100, 20)
        Me.txtConsensus.TabIndex = 7
        Me.txtConsensus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Nimiq Client"
        Me.TabControl.ResumeLayout(False)
        Me.tabStatus.ResumeLayout(False)
        Me.tabStatus.PerformLayout()
        CType(Me.pbxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents tabStatus As TabPage
    Friend WithEvents tabBlockchain As TabPage
    Friend WithEvents tabNetwork As TabPage
    Friend WithEvents tabMiner As TabPage
    Friend WithEvents tabWallet As TabPage
    Friend WithEvents tabLog As TabPage
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents tabHelp As TabPage
    Friend WithEvents timUpdateData As Timer
    Friend WithEvents pbxStatus As PictureBox
    Friend WithEvents lblStarglancer As Label
    Friend WithEvents lblBy As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtConsensus As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblConsensus As Label
    Friend WithEvents lblStatus As Label
End Class
