<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mainRibbon = New ComponentFactory.Krypton.Ribbon.KryptonRibbon()
        Me.userTab = New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab()
        Me.ViewListRibbonGroup = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.ViewDetailListRibbonGroupTriple = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.btnCombinationDetailList = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.CustomRibbonGroup = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.CustomRibbonGroupTriple = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.btnCustomPicture = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.btnCustomCommands = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.TabAdministrator = New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab()
        Me.AddRibonGroup = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.AddTripleButton = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.btnAddCommands = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.btnAddpictures = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.ViewRibbonGroup = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.ViewTripleButton = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.btnViewCommands = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.btnViewPictures = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.mainPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.DetailListwrkspaceCtrl1 = New Emdad.DetailListwrkspaceCtrl()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.mainRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 386)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(837, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'mainRibbon
        '
        Me.mainRibbon.InDesignHelperMode = True
        Me.mainRibbon.Name = "mainRibbon"
        Me.mainRibbon.RibbonTabs.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab() {Me.userTab, Me.TabAdministrator})
        Me.mainRibbon.SelectedContext = Nothing
        Me.mainRibbon.SelectedTab = Me.userTab
        Me.mainRibbon.Size = New System.Drawing.Size(837, 115)
        Me.mainRibbon.TabIndex = 1
        '
        'userTab
        '
        Me.userTab.Groups.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup() {Me.ViewListRibbonGroup, Me.CustomRibbonGroup})
        Me.userTab.Text = "Main"
        '
        'ViewListRibbonGroup
        '
        Me.ViewListRibbonGroup.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.ViewDetailListRibbonGroupTriple})
        Me.ViewListRibbonGroup.TextLine1 = "View"
        '
        'ViewDetailListRibbonGroupTriple
        '
        Me.ViewDetailListRibbonGroupTriple.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.btnCombinationDetailList})
        '
        'btnCombinationDetailList
        '
        Me.btnCombinationDetailList.TextLine1 = "Details List"
        '
        'CustomRibbonGroup
        '
        Me.CustomRibbonGroup.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.CustomRibbonGroupTriple})
        Me.CustomRibbonGroup.TextLine1 = "Custom"
        '
        'CustomRibbonGroupTriple
        '
        Me.CustomRibbonGroupTriple.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.btnCustomPicture, Me.btnCustomCommands})
        '
        'btnCustomPicture
        '
        Me.btnCustomPicture.TextLine1 = "Custom"
        Me.btnCustomPicture.TextLine2 = "Picture"
        '
        'btnCustomCommands
        '
        Me.btnCustomCommands.TextLine1 = "Custom"
        Me.btnCustomCommands.TextLine2 = "Command"
        '
        'TabAdministrator
        '
        Me.TabAdministrator.Groups.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup() {Me.AddRibonGroup, Me.ViewRibbonGroup})
        Me.TabAdministrator.Text = "Administrator"
        '
        'AddRibonGroup
        '
        Me.AddRibonGroup.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.AddTripleButton})
        Me.AddRibonGroup.TextLine1 = "Add"
        '
        'AddTripleButton
        '
        Me.AddTripleButton.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.btnAddCommands, Me.btnAddpictures})
        '
        'btnAddCommands
        '
        Me.btnAddCommands.TextLine1 = "Add"
        Me.btnAddCommands.TextLine2 = "Commands"
        '
        'btnAddpictures
        '
        Me.btnAddpictures.TextLine1 = "Add"
        Me.btnAddpictures.TextLine2 = "Pictures"
        '
        'ViewRibbonGroup
        '
        Me.ViewRibbonGroup.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.ViewTripleButton})
        Me.ViewRibbonGroup.TextLine1 = "View"
        '
        'ViewTripleButton
        '
        Me.ViewTripleButton.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.btnViewCommands, Me.btnViewPictures})
        '
        'btnViewCommands
        '
        Me.btnViewCommands.TextLine1 = "View"
        Me.btnViewCommands.TextLine2 = "Commands"
        '
        'btnViewPictures
        '
        Me.btnViewPictures.TextLine1 = "View"
        Me.btnViewPictures.TextLine2 = "Pictures"
        '
        'mainPanel
        '
        Me.mainPanel.Controls.Add(Me.DetailListwrkspaceCtrl1)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 115)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(837, 271)
        Me.mainPanel.TabIndex = 2
        '
        'DetailListwrkspaceCtrl1
        '
        Me.DetailListwrkspaceCtrl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailListwrkspaceCtrl1.Location = New System.Drawing.Point(0, 0)
        Me.DetailListwrkspaceCtrl1.Name = "DetailListwrkspaceCtrl1"
        Me.DetailListwrkspaceCtrl1.Size = New System.Drawing.Size(837, 271)
        Me.DetailListwrkspaceCtrl1.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 408)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.mainRibbon)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emdad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.mainRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents mainRibbon As ComponentFactory.Krypton.Ribbon.KryptonRibbon
    Friend WithEvents mainPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents userTab As ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents ViewListRibbonGroup As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents ViewDetailListRibbonGroupTriple As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnCombinationDetailList As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents CustomRibbonGroup As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents CustomRibbonGroupTriple As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnCustomPicture As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnCustomCommands As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents DetailListwrkspaceCtrl1 As Emdad.DetailListwrkspaceCtrl
    Friend WithEvents TabAdministrator As ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents AddRibonGroup As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents AddTripleButton As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnAddCommands As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnAddpictures As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents ViewRibbonGroup As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents ViewTripleButton As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnViewCommands As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnViewPictures As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    'Friend WithEvents DetailListwrkspaceCtrl1 As Emdadv1._0.DetailListwrkspaceCtrl

End Class
