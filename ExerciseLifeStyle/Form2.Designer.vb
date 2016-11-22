<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.JumpropeBox = New System.Windows.Forms.PictureBox()
        CType(Me.JumpropeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JumpropeBox
        '
        Me.JumpropeBox.Image = CType(resources.GetObject("JumpropeBox.Image"), System.Drawing.Image)
        Me.JumpropeBox.Location = New System.Drawing.Point(-2, -1)
        Me.JumpropeBox.Name = "JumpropeBox"
        Me.JumpropeBox.Size = New System.Drawing.Size(397, 303)
        Me.JumpropeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.JumpropeBox.TabIndex = 0
        Me.JumpropeBox.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(394, 294)
        Me.Controls.Add(Me.JumpropeBox)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.JumpropeBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents JumpropeBox As PictureBox
End Class
