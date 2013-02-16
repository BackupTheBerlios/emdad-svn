<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralViewUserCtrl
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
        Me.btnAssign = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblCommands = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.SelectPictureGrid1 = New Emdad.SelectPictureGrid
        Me.DrpCommandsCtrl1 = New Emdad.drpCommandsCtrl
        CType(Me.mainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainSplitContainer.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainSplitContainer.Panel1.SuspendLayout()
        CType(Me.mainSplitContainer.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainSplitContainer.Panel2.SuspendLayout()
        Me.mainSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainSplitContainer
        '
        Me.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.Default
        Me.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainSplitContainer.IsSplitterFixed = True
        Me.mainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.mainSplitContainer.Name = "mainSplitContainer"
        Me.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'mainSplitContainer.Panel1
        '
        Me.mainSplitContainer.Panel1.Controls.Add(Me.SelectPictureGrid1)
        '
        'mainSplitContainer.Panel2
        '
        Me.mainSplitContainer.Panel2.Controls.Add(Me.lblCommands)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.DrpCommandsCtrl1)
        Me.mainSplitContainer.Panel2.Controls.Add(Me.btnAssign)
        Me.mainSplitContainer.Size = New System.Drawing.Size(664, 239)
        Me.mainSplitContainer.SplitterDistance = 187
        Me.mainSplitContainer.TabIndex = 0
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(571, 13)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(90, 25)
        Me.btnAssign.TabIndex = 0
        Me.btnAssign.Values.Text = "&Assign"
        '
        'lblCommands
        '
        Me.lblCommands.Location = New System.Drawing.Point(14, 18)
        Me.lblCommands.Name = "lblCommands"
        Me.lblCommands.Size = New System.Drawing.Size(70, 20)
        Me.lblCommands.TabIndex = 2
        Me.lblCommands.Values.Text = "Command:"
        '
        'SelectPictureGrid1
        '
        Me.SelectPictureGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectPictureGrid1.Location = New System.Drawing.Point(0, 0)
        Me.SelectPictureGrid1.Name = "SelectPictureGrid1"
        Me.SelectPictureGrid1.Size = New System.Drawing.Size(664, 187)
        Me.SelectPictureGrid1.TabIndex = 0
        '
        'DrpCommandsCtrl1
        '
        Me.DrpCommandsCtrl1.Location = New System.Drawing.Point(90, 18)
        Me.DrpCommandsCtrl1.Name = "DrpCommandsCtrl1"
        Me.DrpCommandsCtrl1.Size = New System.Drawing.Size(216, 19)
        Me.DrpCommandsCtrl1.TabIndex = 1
        '
        'GeneralViewUserCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mainSplitContainer)
        Me.Name = "GeneralViewUserCtrl"
        Me.Size = New System.Drawing.Size(664, 239)
        CType(Me.mainSplitContainer.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitContainer.Panel1.ResumeLayout(False)
        CType(Me.mainSplitContainer.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitContainer.Panel2.ResumeLayout(False)
        Me.mainSplitContainer.Panel2.PerformLayout()
        CType(Me.mainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainSplitContainer As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents SelectPictureGrid1 As Emdad.SelectPictureGrid
    Friend WithEvents btnAssign As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblCommands As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DrpCommandsCtrl1 As Emdad.drpCommandsCtrl

End Class
