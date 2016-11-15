<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtboxMinutes = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.comboWorkout = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type of Workout"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Length of Workout"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Calories burned"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Goal"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(179, 304)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 22)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(179, 247)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(196, 22)
        Me.TextBox3.TabIndex = 6
        '
        'txtboxMinutes
        '
        Me.txtboxMinutes.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtboxMinutes.Location = New System.Drawing.Point(179, 195)
        Me.txtboxMinutes.Name = "txtboxMinutes"
        Me.txtboxMinutes.Size = New System.Drawing.Size(196, 22)
        Me.txtboxMinutes.TabIndex = 7
        '
        'comboWorkout
        '
        Me.comboWorkout.BackColor = System.Drawing.Color.DarkKhaki
        Me.comboWorkout.FormattingEnabled = True
        Me.comboWorkout.Items.AddRange(New Object() {"Jump Rope", "Jogging", "Sit-Ups", "Treadmill", "Cycling", "Pull-Ups"})
        Me.comboWorkout.Location = New System.Drawing.Point(165, 127)
        Me.comboWorkout.Name = "comboWorkout"
        Me.comboWorkout.Size = New System.Drawing.Size(210, 24)
        Me.comboWorkout.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(942, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 388)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Minutes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 643)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.comboWorkout)
        Me.Controls.Add(Me.txtboxMinutes)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtboxMinutes As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents comboWorkout As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
