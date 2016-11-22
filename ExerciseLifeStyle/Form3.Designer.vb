<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SitUps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SitUps))
        Me.situpsbox = New System.Windows.Forms.PictureBox()
        CType(Me.situpsbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'situpsbox
        '
        Me.situpsbox.Image = CType(resources.GetObject("situpsbox.Image"), System.Drawing.Image)
        Me.situpsbox.Location = New System.Drawing.Point(42, 36)
        Me.situpsbox.Name = "situpsbox"
        Me.situpsbox.Size = New System.Drawing.Size(356, 283)
        Me.situpsbox.TabIndex = 0
        Me.situpsbox.TabStop = False
        '
        'SitUps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 355)
        Me.Controls.Add(Me.situpsbox)
        Me.Name = "SitUps"
        Me.Text = "SitUps"
        CType(Me.situpsbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents situpsbox As PictureBox
End Class
