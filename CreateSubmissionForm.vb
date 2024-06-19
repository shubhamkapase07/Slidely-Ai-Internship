Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch = New Stopwatch()

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNum = txtPhoneNum.Text,
            .GithubLink = txtGithubLink.Text,
            .StopwatchTime = lblStopwatch.Text
        }

        Dim jsonData As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

        Dim client As New HttpClient()
        Dim response As HttpResponseMessage = Await client.PostAsync(ApiConstants.SubmitUrl, content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!")
        Else
            MessageBox.Show("Failed to submit data.")
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class
