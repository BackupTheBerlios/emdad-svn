<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPictureGrid
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pictureGrid = New System.Windows.Forms.DataGridView
        Me.picCol = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.pictureGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureGrid
        '
        Me.pictureGrid.AllowUserToAddRows = False
        Me.pictureGrid.AllowUserToDeleteRows = False
        Me.pictureGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.pictureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pictureGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.picCol})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pictureGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.pictureGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureGrid.Location = New System.Drawing.Point(0, 0)
        Me.pictureGrid.MultiSelect = False
        Me.pictureGrid.Name = "pictureGrid"
        Me.pictureGrid.ReadOnly = True
        Me.pictureGrid.RowTemplate.Height = 300
        Me.pictureGrid.Size = New System.Drawing.Size(670, 327)
        Me.pictureGrid.TabIndex = 0
        '
        'picCol
        '
        Me.picCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.picCol.DataPropertyName = "DrawingImage"
        Me.picCol.HeaderText = "PictureFile"
        Me.picCol.Name = "picCol"
        Me.picCol.ReadOnly = True
        '
        'SelectPictureGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pictureGrid)
        Me.Name = "SelectPictureGrid"
        Me.Size = New System.Drawing.Size(670, 327)
        CType(Me.pictureGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pictureGrid As System.Windows.Forms.DataGridView
    Friend WithEvents picCol As System.Windows.Forms.DataGridViewImageColumn

End Class
