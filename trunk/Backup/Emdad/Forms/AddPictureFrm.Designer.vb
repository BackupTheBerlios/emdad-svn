<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPictureFrm
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
        Me.lblFingerCombination = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSelectPicture = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.GroupBoxAduredPict = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonPanelSelectPic = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonPanelFingComb = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.DrpFingerCombination1 = New Emdad.drpFingerCombination()
        Me.BrowseFileCtrl1 = New Emdad.BrowseFileCtrl()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.GroupBoxAduredPict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAduredPict.Panel.SuspendLayout()
        Me.GroupBoxAduredPict.SuspendLayout()
        CType(Me.KryptonPanelSelectPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanelSelectPic.SuspendLayout()
        CType(Me.KryptonPanelFingComb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanelFingComb.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.GroupBoxAduredPict)
        Me.KryptonPanel.Controls.Add(Me.btnCancel)
        Me.KryptonPanel.Controls.Add(Me.btnOk)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(475, 246)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(261, 177)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Values.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(75, 177)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 25)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Values.Text = "Ok"
        '
        'lblFingerCombination
        '
        Me.lblFingerCombination.Location = New System.Drawing.Point(16, 95)
        Me.lblFingerCombination.Name = "lblFingerCombination"
        Me.lblFingerCombination.Size = New System.Drawing.Size(117, 20)
        Me.lblFingerCombination.TabIndex = 1
        Me.lblFingerCombination.Values.Text = "Finger combination"
        '
        'lblSelectPicture
        '
        Me.lblSelectPicture.Location = New System.Drawing.Point(16, 13)
        Me.lblSelectPicture.Name = "lblSelectPicture"
        Me.lblSelectPicture.Size = New System.Drawing.Size(84, 20)
        Me.lblSelectPicture.TabIndex = 0
        Me.lblSelectPicture.Values.Text = "Select Picture"
        '
        'GroupBoxAduredPict
        '
        Me.GroupBoxAduredPict.CaptionVisible = False
        Me.GroupBoxAduredPict.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxAduredPict.Name = "GroupBoxAduredPict"
        '
        'GroupBoxAduredPict.Panel
        '
        Me.GroupBoxAduredPict.Panel.Controls.Add(Me.KryptonPanelFingComb)
        Me.GroupBoxAduredPict.Panel.Controls.Add(Me.KryptonPanelSelectPic)
        Me.GroupBoxAduredPict.Panel.Controls.Add(Me.lblSelectPicture)
        Me.GroupBoxAduredPict.Panel.Controls.Add(Me.lblFingerCombination)
        Me.GroupBoxAduredPict.Size = New System.Drawing.Size(472, 168)
        Me.GroupBoxAduredPict.TabIndex = 6
        '
        'KryptonPanelSelectPic
        '
        Me.KryptonPanelSelectPic.Controls.Add(Me.BrowseFileCtrl1)
        Me.KryptonPanelSelectPic.Location = New System.Drawing.Point(138, 3)
        Me.KryptonPanelSelectPic.Name = "KryptonPanelSelectPic"
        Me.KryptonPanelSelectPic.Size = New System.Drawing.Size(332, 57)
        Me.KryptonPanelSelectPic.TabIndex = 1
        '
        'KryptonPanelFingComb
        '
        Me.KryptonPanelFingComb.Controls.Add(Me.DrpFingerCombination1)
        Me.KryptonPanelFingComb.Location = New System.Drawing.Point(139, 84)
        Me.KryptonPanelFingComb.Name = "KryptonPanelFingComb"
        Me.KryptonPanelFingComb.Size = New System.Drawing.Size(332, 57)
        Me.KryptonPanelFingComb.TabIndex = 3
        '
        'DrpFingerCombination1
        '
        Me.DrpFingerCombination1.Location = New System.Drawing.Point(35, 11)
        Me.DrpFingerCombination1.Name = "DrpFingerCombination1"
        Me.DrpFingerCombination1.Size = New System.Drawing.Size(191, 24)
        Me.DrpFingerCombination1.TabIndex = 3
        '
        'BrowseFileCtrl1
        '
        Me.BrowseFileCtrl1.FilePath = Nothing
        Me.BrowseFileCtrl1.FileSize = Nothing
        Me.BrowseFileCtrl1.FileType = "*.*"
        Me.BrowseFileCtrl1.Location = New System.Drawing.Point(36, 4)
        Me.BrowseFileCtrl1.Name = "BrowseFileCtrl1"
        Me.BrowseFileCtrl1.Size = New System.Drawing.Size(269, 38)
        Me.BrowseFileCtrl1.TabIndex = 2
        Me.BrowseFileCtrl1.Title = Nothing
        '
        'AddPictureFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 246)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddPictureFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Picture"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.GroupBoxAduredPict.Panel.ResumeLayout(False)
        Me.GroupBoxAduredPict.Panel.PerformLayout()
        CType(Me.GroupBoxAduredPict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAduredPict.ResumeLayout(False)
        CType(Me.KryptonPanelSelectPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanelSelectPic.ResumeLayout(False)
        CType(Me.KryptonPanelFingComb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanelFingComb.ResumeLayout(False)
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
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOk As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DrpFingerCombination1 As Emdad.drpFingerCombination
    Friend WithEvents BrowseFileCtrl1 As Emdad.BrowseFileCtrl
    Friend WithEvents lblFingerCombination As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblSelectPicture As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBoxAduredPict As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonPanelSelectPic As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanelFingComb As ComponentFactory.Krypton.Toolkit.KryptonPanel
End Class
