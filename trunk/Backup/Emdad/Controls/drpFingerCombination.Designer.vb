<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class drpFingerCombination
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
        Me.drpFingerCombinationList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'drpFingerCombinationList
        '
        Me.drpFingerCombinationList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.drpFingerCombinationList.FormattingEnabled = True
        Me.drpFingerCombinationList.Location = New System.Drawing.Point(0, 0)
        Me.drpFingerCombinationList.Name = "drpFingerCombinationList"
        Me.drpFingerCombinationList.Size = New System.Drawing.Size(191, 21)
        Me.drpFingerCombinationList.TabIndex = 0
        '
        'drpFingerCombination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.drpFingerCombinationList)
        Me.Name = "drpFingerCombination"
        Me.Size = New System.Drawing.Size(191, 24)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents drpFingerCombinationList As System.Windows.Forms.ComboBox

End Class
