<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailListwrkspaceCtrl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.mainSplitContainer = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.FingerCombinationListCtrl1 = New Emdadv1._0.FingerCombinationListCtrl
        Me.detailSplitContainer = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.UpperPanelHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.LowerHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        CType(Me.mainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainSplitContainer.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainSplitContainer.Panel1.SuspendLayout()
        CType(Me.mainSplitContainer.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainSplitContainer.Panel2.SuspendLayout()
        Me.mainSplitContainer.SuspendLayout()
        CType(Me.detailSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detailSplitContainer.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detailSplitContainer.Panel1.SuspendLayout()
        CType(Me.detailSplitContainer.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detailSplitContainer.Panel2.SuspendLayout()
        Me.detailSplitContainer.SuspendLayout()
        CType(Me.UpperPanelHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpperPanelHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpperPanelHeaderGroup1.SuspendLayout()
        CType(Me.LowerHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowerHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LowerHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainSplitContainer
        '
        Me.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.mainSplitContainer.IsSplitterFixed = True
        Me.mainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.mainSplitContainer.Name = "mainSplitContainer"
        '
        'mainSplitContainer.Panel1
        '
        Me.mainSplitContainer.Panel1.Controls.Add(Me.FingerCombinationListCtrl1)
        '
        'mainSplitContainer.Panel2
        '
        Me.mainSplitContainer.Panel2.Controls.Add(Me.detailSplitContainer)
        Me.mainSplitContainer.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.mainSplitContainer.Size = New System.Drawing.Size(912, 468)
        Me.mainSplitContainer.SplitterDistance = 214
        Me.mainSplitContainer.TabIndex = 0
        '
        'FingerCombinationListCtrl1
        '
        Me.FingerCombinationListCtrl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FingerCombinationListCtrl1.Location = New System.Drawing.Point(0, 0)
        Me.FingerCombinationListCtrl1.Name = "FingerCombinationListCtrl1"
        Me.FingerCombinationListCtrl1.Size = New System.Drawing.Size(214, 468)
        Me.FingerCombinationListCtrl1.TabIndex = 0
        '
        'detailSplitContainer
        '
        Me.detailSplitContainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.detailSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.detailSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.detailSplitContainer.Name = "detailSplitContainer"
        Me.detailSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'detailSplitContainer.Panel1
        '
        Me.detailSplitContainer.Panel1.Controls.Add(Me.UpperPanelHeaderGroup1)
        '
        'detailSplitContainer.Panel2
        '
        Me.detailSplitContainer.Panel2.Controls.Add(Me.LowerHeaderGroup1)
        Me.detailSplitContainer.Size = New System.Drawing.Size(693, 468)
        Me.detailSplitContainer.SplitterDistance = 231
        Me.detailSplitContainer.TabIndex = 0
        '
        'UpperPanelHeaderGroup1
        '
        Me.UpperPanelHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpperPanelHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.UpperPanelHeaderGroup1.Name = "UpperPanelHeaderGroup1"
        Me.UpperPanelHeaderGroup1.Size = New System.Drawing.Size(693, 231)
        Me.UpperPanelHeaderGroup1.TabIndex = 0
        '
        'LowerHeaderGroup1
        '
        Me.LowerHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LowerHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LowerHeaderGroup1.Name = "LowerHeaderGroup1"
        Me.LowerHeaderGroup1.Size = New System.Drawing.Size(693, 232)
        Me.LowerHeaderGroup1.TabIndex = 1
        '
        'DetailListwrkspaceCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mainSplitContainer)
        Me.Name = "DetailListwrkspaceCtrl"
        Me.Size = New System.Drawing.Size(912, 468)
        CType(Me.mainSplitContainer.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitContainer.Panel1.ResumeLayout(False)
        CType(Me.mainSplitContainer.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.mainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitContainer.ResumeLayout(False)
        CType(Me.detailSplitContainer.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detailSplitContainer.Panel1.ResumeLayout(False)
        CType(Me.detailSplitContainer.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detailSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.detailSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detailSplitContainer.ResumeLayout(False)
        CType(Me.UpperPanelHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpperPanelHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpperPanelHeaderGroup1.ResumeLayout(False)
        CType(Me.LowerHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowerHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LowerHeaderGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainSplitContainer As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents FingerCombinationListCtrl1 As Emdadv1._0.FingerCombinationListCtrl
    Friend WithEvents detailSplitContainer As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents UpperPanelHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents LowerHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup

End Class
