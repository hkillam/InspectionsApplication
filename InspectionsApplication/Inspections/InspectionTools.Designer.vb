<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InspectionTools
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.AddRegion = New System.Windows.Forms.Button
        Me.ZoomIn = New System.Windows.Forms.Button
        Me.Button_zoomout = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'AddRegion
        '
        Me.AddRegion.Location = New System.Drawing.Point(23, 28)
        Me.AddRegion.Name = "AddRegion"
        Me.AddRegion.Size = New System.Drawing.Size(130, 43)
        Me.AddRegion.TabIndex = 1
        Me.AddRegion.Text = "Add Region"
        Me.AddRegion.UseVisualStyleBackColor = True
        '
        'ZoomIn
        '
        Me.ZoomIn.Location = New System.Drawing.Point(26, 86)
        Me.ZoomIn.Name = "ZoomIn"
        Me.ZoomIn.Size = New System.Drawing.Size(42, 36)
        Me.ZoomIn.TabIndex = 2
        Me.ZoomIn.Text = "Zoom In"
        Me.ZoomIn.UseVisualStyleBackColor = True
        '
        'Button_zoomout
        '
        Me.Button_zoomout.Location = New System.Drawing.Point(80, 86)
        Me.Button_zoomout.Name = "Button_zoomout"
        Me.Button_zoomout.Size = New System.Drawing.Size(45, 35)
        Me.Button_zoomout.TabIndex = 3
        Me.Button_zoomout.Text = "Zoom Out"
        Me.Button_zoomout.UseVisualStyleBackColor = True
        '
        'InspectionTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(170, 315)
        Me.Controls.Add(Me.Button_zoomout)
        Me.Controls.Add(Me.ZoomIn)
        Me.Controls.Add(Me.AddRegion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InspectionTools"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inspection Tools"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddRegion As System.Windows.Forms.Button
    Friend WithEvents ZoomIn As System.Windows.Forms.Button
    Friend WithEvents Button_zoomout As System.Windows.Forms.Button

End Class
