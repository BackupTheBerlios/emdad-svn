<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommandsEntryFrm
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
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnOk = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.grpbxCommEntFrm = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.txtCommands = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.DrpFingerCombination1 = New Emdad.drpFingerCombination()
        Me.lblFinComb = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSound = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.BrowseFileCtrl1 = New Emdad.BrowseFileCtrl()
        Me.lblcommand = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.grpbxCommEntFrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxCommEntFrm.Panel.SuspendLayout()
        Me.grpbxCommEntFrm.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnCancel)
        Me.KryptonPanel.Controls.Add(Me.btnOk)
        Me.KryptonPanel.Controls.Add(Me.grpbxCommEntFrm)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(459, 288)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(256, 235)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Values.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(70, 235)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 25)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Values.Text = "Ok"
        '
        'grpbxCommEntFrm
        '
        Me.grpbxCommEntFrm.CaptionVisible = False
        Me.grpbxCommEntFrm.Location = New System.Drawing.Point(0, 3)
        Me.grpbxCommEntFrm.Name = "grpbxCommEntFrm"
        '
        'grpbxCommEntFrm.Panel
        '
        Me.grpbxCommEntFrm.Panel.Controls.Add(Me.txtCommands)
        Me.grpbxCommEntFrm.Panel.Controls.Add(Me.KryptonPanel2)
        Me.grpbxCommEntFrm.Panel.Controls.Add(Me.lblFinComb)
        Me.grpbxCommEntFrm.Panel.Controls.Add(Me.lblSound)
        Me.grpbxCommEntFrm.Panel.Controls.Add(Me.KryptonPanel1)
        Me.grpbxCommEntFrm.Panel.Controls.Add(Me.lblcommand)
        Me.grpbxCommEntFrm.Size = New System.Drawing.Size(459, 213)
        Me.grpbxCommEntFrm.TabIndex = 3
        '
        'txtCommands
        '
        Me.txtCommands.Location = New System.Drawing.Point(158, 22)
        Me.txtCommands.Name = "txtCommands"
        Me.txtCommands.Size = New System.Drawing.Size(272, 20)
        Me.txtCommands.TabIndex = 3
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.DrpFingerCombination1)
        Me.KryptonPanel2.Location = New System.Drawing.Point(158, 135)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(294, 40)
        Me.KryptonPanel2.TabIndex = 1
        '
        'DrpFingerCombination1
        '
        Me.DrpFingerCombination1.Location = New System.Drawing.Point(3, 3)
        Me.DrpFingerCombination1.Name = "DrpFingerCombination1"
        Me.DrpFingerCombination1.Size = New System.Drawing.Size(191, 24)
        Me.DrpFingerCombination1.TabIndex = 0
        '
        'lblFinComb
        '
        Me.lblFinComb.Location = New System.Drawing.Point(24, 142)
        Me.lblFinComb.Name = "lblFinComb"
        Me.lblFinComb.Size = New System.Drawing.Size(115, 20)
        Me.lblFinComb.TabIndex = 1
        Me.lblFinComb.Target = Me
        Me.lblFinComb.Values.Text = "FingerCombination"
        '
        'lblSound
        '
        Me.lblSound.Location = New System.Drawing.Point(24, 82)
        Me.lblSound.Name = "lblSound"
        Me.lblSound.Size = New System.Drawing.Size(46, 20)
        Me.lblSound.TabIndex = 2
        Me.lblSound.Values.Text = "Sound"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.BrowseFileCtrl1)
        Me.KryptonPanel1.Location = New System.Drawing.Point(158, 69)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(294, 40)
        Me.KryptonPanel1.TabIndex = 0
        '
        'BrowseFileCtrl1
        '
        Me.BrowseFileCtrl1.FilePath = Nothing
        Me.BrowseFileCtrl1.FileSize = Nothing
        Me.BrowseFileCtrl1.FileType = "*.*"
        Me.BrowseFileCtrl1.Location = New System.Drawing.Point(3, 3)
        Me.BrowseFileCtrl1.Name = "BrowseFileCtrl1"
        Me.BrowseFileCtrl1.Size = New System.Drawing.Size(269, 38)
        Me.BrowseFileCtrl1.TabIndex = 0
        Me.BrowseFileCtrl1.Title = Nothing
        '
        'lblcommand
        '
        Me.lblcommand.Location = New System.Drawing.Point(24, 22)
        Me.lblcommand.Name = "lblcommand"
        Me.lblcommand.Size = New System.Drawing.Size(67, 20)
        Me.lblcommand.TabIndex = 0
        Me.lblcommand.Values.Text = "Command"
        '
        'CommandsEntryFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 288)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CommandsEntryFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Custom Command and Sound"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.grpbxCommEntFrm.Panel.ResumeLayout(False)
        Me.grpbxCommEntFrm.Panel.PerformLayout()
        CType(Me.grpbxCommEntFrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxCommEntFrm.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
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
    Friend WithEvents lblSound As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFinComb As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblcommand As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpbxCommEntFrm As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents txtCommands As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DrpFingerCombination1 As Emdad.drpFingerCombination
    Friend WithEvents BrowseFileCtrl1 As Emdad.BrowseFileCtrl
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOk As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
