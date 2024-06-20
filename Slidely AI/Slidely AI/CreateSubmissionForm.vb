Imports System.Net
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Public stopwatch As New Stopwatch()

    Public Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles BtnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Public Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        ' Create a new submission object with the form data
        Dim submission = New Submission() With {
            .name = TextBox2.Text,
            .email = TextBox3.Text,
            .phone = TextBox1.Text,
            .github_link = TextBox4.Text,
            .stopwatch_time = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }

        ' Serialize the submission object to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)

        ' Send the JSON data to the backend using WebClient
        Using client As New WebClient()
            client.Headers(HttpRequestHeader.ContentType) = "application/json"
            Try
                client.UploadString("http://localhost:3002/submit", "POST", json)
                MessageBox.Show("Submission saved successfully!")
            Catch ex As Exception
                MessageBox.Show("Error submitting the form: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub UpdateStopwatchLabel()
        LblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Public Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Public Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            BtnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            BtnSubmit.PerformClick()
        End If
    End Sub


    Public Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class
End Class
