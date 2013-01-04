<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommandsGrid
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
        Me.CommandsDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.CommandsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommandsDataGridView
        '
        Me.CommandsDataGridView.AllowUserToAddRows = False
        Me.CommandsDataGridView.AllowUserToDeleteRows = False
        Me.CommandsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CommandsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommandsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CommandsDataGridView.Name = "CommandsDataGridView"
        Me.CommandsDataGridView.ReadOnly = True
        Me.CommandsDataGridView.Size = New System.Drawing.Size(836, 424)
        Me.CommandsDataGridView.TabIndex = 0
        '
        'CommandsGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CommandsDataGridView)
        Me.Name = "CommandsGrid"
        Me.Size = New System.Drawing.Size(836, 424)
        CType(Me.CommandsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CommandsDataGridView As System.Windows.Forms.DataGridView

End Class
