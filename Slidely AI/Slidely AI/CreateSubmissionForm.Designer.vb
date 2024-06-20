<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnToggleStopwatch = New System.Windows.Forms.Button()
        Me.LblStopwatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 32)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "For Task 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 32)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Github Link"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(295, 362)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(495, 76)
        Me.TextBox4.TabIndex = 26
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(295, 281)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(495, 38)
        Me.TextBox1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 32)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Phone Num"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 32)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(666, 32)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Aniruddha Birage, Slidely Task 2 - Slidely Form App"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 32)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(295, 199)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(495, 38)
        Me.TextBox3.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(295, 110)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(495, 38)
        Me.TextBox2.TabIndex = 19
        '
        'BtnSubmit
        '
        Me.BtnSubmit.AccessibleName = "BtnSubmit"
        Me.BtnSubmit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnSubmit.Location = New System.Drawing.Point(15, 622)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(775, 64)
        Me.BtnSubmit.TabIndex = 18
        Me.BtnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnToggleStopwatch
        '
        Me.BtnToggleStopwatch.AccessibleName = "BtnToggleStopwatch"
        Me.BtnToggleStopwatch.BackColor = System.Drawing.Color.Khaki
        Me.BtnToggleStopwatch.Location = New System.Drawing.Point(15, 499)
        Me.BtnToggleStopwatch.Name = "BtnToggleStopwatch"
        Me.BtnToggleStopwatch.Size = New System.Drawing.Size(525, 70)
        Me.BtnToggleStopwatch.TabIndex = 17
        Me.BtnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.BtnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'LblStopwatch
        '
        Me.LblStopwatch.AccessibleName = "LblStopwatch"
        Me.LblStopwatch.AutoSize = True
        Me.LblStopwatch.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.LblStopwatch.Location = New System.Drawing.Point(586, 516)
        Me.LblStopwatch.Name = "LblStopwatch"
        Me.LblStopwatch.Size = New System.Drawing.Size(126, 32)
        Me.LblStopwatch.TabIndex = 30
        Me.LblStopwatch.Text = "00:00:00"
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 698)
        Me.Controls.Add(Me.LblStopwatch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnToggleStopwatch)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnToggleStopwatch As Button
    Friend WithEvents LblStopwatch As Label
End Class
