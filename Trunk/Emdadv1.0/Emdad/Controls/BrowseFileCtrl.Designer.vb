<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseFileCtrl
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
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.fileOpenDialouge = New System.Windows.Forms.OpenFileDialog()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.ColumnCount = 2
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.74905!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.25095!))
        Me.mainTableLayoutPanel.Controls.Add(Me.txtPath, 0, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.btnSelect, 1, 0)
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 1
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(263, 29)
        Me.mainTableLayoutPanel.TabIndex = 0
        '
        'txtPath
        '
        Me.txtPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPath.Location = New System.Drawing.Point(3, 3)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(208, 20)
        Me.txtPath.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelect.Location = New System.Drawing.Point(217, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(43, 23)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "..."
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'fileOpenDialouge
        '
        Me.fileOpenDialouge.FileName = "OpenFileDialog1"
        '
        'BrowseFileCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.Name = "BrowseFileCtrl"
        Me.Size = New System.Drawing.Size(269, 38)
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents fileOpenDialouge As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSelect As System.Windows.Forms.Button

End Class
