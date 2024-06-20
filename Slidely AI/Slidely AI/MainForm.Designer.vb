<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.BtnViewSubmissions = New System.Windows.Forms.Button()
        Me.BtnCreateSubmission = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnViewSubmissions
        '
        Me.BtnViewSubmissions.AccessibleName = "BtnViewSubmissions"
        Me.BtnViewSubmissions.BackColor = System.Drawing.Color.Khaki
        Me.BtnViewSubmissions.Location = New System.Drawing.Point(12, 63)
        Me.BtnViewSubmissions.Name = "BtnViewSubmissions"
        Me.BtnViewSubmissions.Size = New System.Drawing.Size(776, 64)
        Me.BtnViewSubmissions.TabIndex = 0
        Me.BtnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.BtnViewSubmissions.UseVisualStyleBackColor = False
        '
        'BtnCreateSubmission
        '
        Me.BtnCreateSubmission.AccessibleName = "BtnCreateSubmission"
        Me.BtnCreateSubmission.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnCreateSubmission.Location = New System.Drawing.Point(12, 144)
        Me.BtnCreateSubmission.Name = "BtnCreateSubmission"
        Me.BtnCreateSubmission.Size = New System.Drawing.Size(776, 64)
        Me.BtnCreateSubmission.TabIndex = 1
        Me.BtnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.BtnCreateSubmission.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(666, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Aniruddha Birage, Slidely Task 2 - Slidely Form App"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 240)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCreateSubmission)
        Me.Controls.Add(Me.BtnViewSubmissions)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnViewSubmissions As Button
    Friend WithEvents BtnCreateSubmission As Button
    Friend WithEvents Label2 As Label
End Class
