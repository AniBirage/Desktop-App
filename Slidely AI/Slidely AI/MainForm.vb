Public Class MainForm
    Public Sub BtnViewSubmissions_Click(sender As Object, e As EventArgs) Handles BtnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.ShowDialog()
    End Sub

    Public Sub BtnCreateSubmission_Click(sender As Object, e As EventArgs) Handles BtnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.ShowDialog()
    End Sub

    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Public Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Public Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            BtnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            BtnCreateSubmission.PerformClick()
        End If
    End Sub
End Class