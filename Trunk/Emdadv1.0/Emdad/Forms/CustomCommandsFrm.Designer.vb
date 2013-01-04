<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomCommandsFrm
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.GrpBoxCustomcommands = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItems3 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuHeading1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuSeparator1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.CommandMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandsGrid1 = New Emdad.CommandsGrid()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.GrpBoxCustomcommands, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxCustomcommands.Panel.SuspendLayout()
        Me.GrpBoxCustomcommands.SuspendLayout()
        Me.CommandMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnClose)
        Me.KryptonPanel.Controls.Add(Me.GrpBoxCustomcommands)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(513, 293)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(411, 256)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 25)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Values.Text = "Close"
        '
        'GrpBoxCustomcommands
        '
        Me.GrpBoxCustomcommands.CaptionVisible = False
        Me.GrpBoxCustomcommands.Location = New System.Drawing.Point(0, 0)
        Me.GrpBoxCustomcommands.Name = "GrpBoxCustomcommands"
        '
        'GrpBoxCustomcommands.Panel
        '
        Me.GrpBoxCustomcommands.Panel.Controls.Add(Me.CommandsGrid1)
        Me.GrpBoxCustomcommands.Size = New System.Drawing.Size(513, 243)
        Me.GrpBoxCustomcommands.TabIndex = 0
        '
        'KryptonContextMenuHeading1
        '
        Me.KryptonContextMenuHeading1.ExtraText = ""
        '
        'CommandMenu
        '
        Me.CommandMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CommandMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.CommandMenu.Name = "CommandMenu"
        Me.CommandMenu.Size = New System.Drawing.Size(108, 48)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CommandsGrid1
        '
        Me.CommandsGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommandsGrid1.Location = New System.Drawing.Point(0, 0)
        Me.CommandsGrid1.Name = "CommandsGrid1"
        Me.CommandsGrid1.Size = New System.Drawing.Size(509, 239)
        Me.CommandsGrid1.TabIndex = 0
        '
        'CustomCommandsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 293)
        Me.ContextMenuStrip = Me.CommandMenu
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomCommandsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Commands"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.GrpBoxCustomcommands.Panel.ResumeLayout(False)
        CType(Me.GrpBoxCustomcommands, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxCustomcommands.ResumeLayout(False)
        Me.CommandMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents GrpBoxCustomcommands As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents CommandsGrid1 As Emdad.CommandsGrid
    Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItems3 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuHeading1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuSeparator1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents CommandMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
