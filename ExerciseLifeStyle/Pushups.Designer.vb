<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pushups
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pushups))
        Me.PushupBox = New System.Windows.Forms.PictureBox()
        CType(Me.PushupBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PushupBox
        '
        Me.PushupBox.BackColor = System.Drawing.Color.White
        Me.PushupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PushupBox.Image = CType(resources.GetObject("PushupBox.Image"), System.Drawing.Image)
        Me.PushupBox.Location = New System.Drawing.Point(-2, -6)
        Me.PushupBox.Name = "PushupBox"
        Me.PushupBox.Size = New System.Drawing.Size(500, 426)
        Me.PushupBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PushupBox.TabIndex = 0
        Me.PushupBox.TabStop = False
        '
        'Pushups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.PushupBox)
        Me.MinimizeBox = False
        Me.Name = "Pushups"
        Me.ShowIcon = False
        Me.Text = "Pushups"
        Me.TopMost = True
        CType(Me.PushupBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PushupBox As PictureBox
End Class
