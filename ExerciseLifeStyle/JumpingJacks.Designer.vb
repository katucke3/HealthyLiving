<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JumpingJacks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JumpingJacks))
        Me.JumpingBox = New System.Windows.Forms.PictureBox()
        CType(Me.JumpingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JumpingBox
        '
        Me.JumpingBox.BackgroundImage = CType(resources.GetObject("JumpingBox.BackgroundImage"), System.Drawing.Image)
        Me.JumpingBox.Image = CType(resources.GetObject("JumpingBox.Image"), System.Drawing.Image)
        Me.JumpingBox.Location = New System.Drawing.Point(38, 12)
        Me.JumpingBox.Name = "JumpingBox"
        Me.JumpingBox.Size = New System.Drawing.Size(519, 302)
        Me.JumpingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.JumpingBox.TabIndex = 0
        Me.JumpingBox.TabStop = False
        '
        'JumpingJacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 392)
        Me.Controls.Add(Me.JumpingBox)
        Me.Name = "JumpingJacks"
        Me.Text = "JumpingJacks"
        CType(Me.JumpingBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents JumpingBox As PictureBox
End Class
