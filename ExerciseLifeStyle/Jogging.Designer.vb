<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jogging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jogging))
        Me.JoggingBox = New System.Windows.Forms.PictureBox()
        CType(Me.JoggingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JoggingBox
        '
        Me.JoggingBox.BackgroundImage = CType(resources.GetObject("JoggingBox.BackgroundImage"), System.Drawing.Image)
        Me.JoggingBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JoggingBox.Location = New System.Drawing.Point(1, 0)
        Me.JoggingBox.Name = "JoggingBox"
        Me.JoggingBox.Size = New System.Drawing.Size(299, 439)
        Me.JoggingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.JoggingBox.TabIndex = 0
        Me.JoggingBox.TabStop = False
        '
        'Jogging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(295, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.JoggingBox)
        Me.Name = "Jogging"
        Me.Text = "Jogging"
        CType(Me.JoggingBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents JoggingBox As PictureBox
End Class
