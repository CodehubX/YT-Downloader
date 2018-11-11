Imports System.IO
Imports System.IO.Stream
Imports VideoLibrary

Public Class Form1

    Public dialog = New FolderBrowserDialog
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        
        ProgressBar1.Value = 25
        Dim video = YouTube.Default.GetVideo(TextBox1.Text)
        ProgressBar1.Value = 50
        File.WriteAllBytes(dialog.SelectedPath + "/" & video.FullName, video.GetBytes())
        ProgressBar1.Value = 100

        MessageBox.Show("Video Download Complete and Successful")
        ProgressBar1.Value = 0

        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dialog.ShowDialog()
        Button1.Enabled = True
        TextBox2.Text = dialog.SelectedPath()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("This feature is not currently available")


    End Sub
End Class