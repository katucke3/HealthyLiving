<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Treadmill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Treadmill))
        Me.TreadmillBox = New System.Windows.Forms.PictureBox()
        CType(Me.TreadmillBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreadmillBox
        '
        Me.TreadmillBox.Image = CType(resources.GetObject("TreadmillBox.Image"), System.Drawing.Image)
        Me.TreadmillBox.Location = New System.Drawing.Point(31, 12)
        Me.TreadmillBox.Name = "TreadmillBox"
        Me.TreadmillBox.Size = New System.Drawing.Size(215, 351)
        Me.TreadmillBox.TabIndex = 0
        Me.TreadmillBox.TabStop = False
        '
        'Treadmill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(277, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.TreadmillBox)
        Me.Name = "Treadmill"
        Me.Text = "Treadmill"
        CType(Me.TreadmillBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreadmillBox As PictureBox
End Class
