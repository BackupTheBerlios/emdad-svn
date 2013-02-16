<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class drpCommandsCtrl
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
        Me.drpCommands = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'drpCommands
        '
        Me.drpCommands.Dock = System.Windows.Forms.DockStyle.Fill
        Me.drpCommands.FormattingEnabled = True
        Me.drpCommands.Location = New System.Drawing.Point(0, 0)
        Me.drpCommands.Name = "drpCommands"
        Me.drpCommands.Size = New System.Drawing.Size(216, 21)
        Me.drpCommands.TabIndex = 0
        '
        'drpCommandsCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.drpCommands)
        Me.Name = "drpCommandsCtrl"
        Me.Size = New System.Drawing.Size(216, 19)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents drpCommands As System.Windows.Forms.ComboBox

End Class
