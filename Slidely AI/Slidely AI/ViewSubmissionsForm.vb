Imports System.Net
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Public Submissions As List(Of Submission)
    Public currentIndex As Integer = 0

    Public Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        FetchSubmissions()
        DisplaySubmission()
    End Sub

    Public Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        Else
            MessageBox.Show("No previous Submissions.")
        End If
    End Sub

    Public Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If currentIndex < Submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        Else
            MessageBox.Show("No more Submissions.")
        End If
    End Sub

    Public Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            BtnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            BtnNext.PerformClick()
        End If
    End Sub

    Public Sub FetchSubmissions()
        Using client As New WebClient()
            Try
                Dim response As String = client.DownloadString("http://localhost:3002/read-all")
                Submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(response)
            Catch ex As Exception
                MessageBox.Show("Error fetching Submissions: " & ex.Message)
                Submissions = New List(Of Submission)()
            End Try
        End Using
    End Sub

    Public Sub DisplaySubmission()
        If Submissions IsNot Nothing AndAlso Submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < Submissions.Count Then
            Dim submission As Submission = Submissions(currentIndex)
            TextBox2.Text = submission.name
            TextBox3.Text = submission.email
            TextBox1.Text = submission.phone
            TextBox4.Text = submission.github_link
            TextBox5.Text = submission.stopwatch_time
        Else
            MessageBox.Show("No Submissions to display.")
        End If
    End Sub
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
