<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bicycle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bicycle))
        Me.BicycleBox = New System.Windows.Forms.PictureBox()
        CType(Me.BicycleBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BicycleBox
        '
        Me.BicycleBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BicycleBox.Image = CType(resources.GetObject("BicycleBox.Image"), System.Drawing.Image)
        Me.BicycleBox.Location = New System.Drawing.Point(2, 0)
        Me.BicycleBox.Name = "BicycleBox"
        Me.BicycleBox.Size = New System.Drawing.Size(600, 341)
        Me.BicycleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BicycleBox.TabIndex = 0
        Me.BicycleBox.TabStop = False
        '
        'Bicycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 339)
        Me.ControlBox = False
        Me.Controls.Add(Me.BicycleBox)
        Me.Name = "Bicycle"
        Me.Text = "Bicycle"
        CType(Me.BicycleBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BicycleBox As PictureBox
End Class
