Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        submissions = New List(Of Submission)()
        Dim client As New HttpClient()
        Dim index As Integer = 0

        While True
            Dim response As HttpResponseMessage = Await client.GetAsync($"{ApiConstants.ReadUrl}?index={index}")
            If response.IsSuccessStatusCode Then
                Dim submissionJson = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(submissionJson)
                submissions.Add(submission)
                index += 1
            Else
                Exit While
            End If
        End While

        If submissions.Count > 0 Then
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("No submissions found.")
        End If
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions Is Nothing OrElse submissions.Count = 0 Then Return

        Dim submission As Submission = submissions(index)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhoneNum.Text = submission.PhoneNum
        txtGithubLink.Text = submission.GithubLink
        lblStopwatch.Text = submission.StopwatchTime
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("No previous submissions.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("No more submissions.")
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
