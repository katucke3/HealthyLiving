<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mountclimb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mountclimb))
        Me.MountclimbBox = New System.Windows.Forms.PictureBox()
        CType(Me.MountclimbBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MountclimbBox
        '
        Me.MountclimbBox.ErrorImage = Nothing
        Me.MountclimbBox.Image = CType(resources.GetObject("MountclimbBox.Image"), System.Drawing.Image)
        Me.MountclimbBox.Location = New System.Drawing.Point(-4, -1)
        Me.MountclimbBox.Name = "MountclimbBox"
        Me.MountclimbBox.Size = New System.Drawing.Size(432, 298)
        Me.MountclimbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MountclimbBox.TabIndex = 0
        Me.MountclimbBox.TabStop = False
        '
        'Mountclimb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.MountclimbBox)
        Me.Name = "Mountclimb"
        Me.Text = "Mountclimb"
        CType(Me.MountclimbBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MountclimbBox As PictureBox
End Class
