Imports System.IO
Imports System.Text

Public Class ConnectionCase

    Sub New(op As Release)
        Options = op
    End Sub

    Private WithEvents Engine As Process
    Private log As StreamWriter

    Private Property Options As Release

    Public Sub Start()
        If Engine IsNot Nothing Then
            Engine.Start()
        Else
            Engine = New Process()
            Engine.StartInfo = New ProcessStartInfo(Options.ExefilePath, Options.Paramenters)
            With Engine.StartInfo
                .CreateNoWindow = True
                .UseShellExecute = False
                .RedirectStandardError = True
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
                .ErrorDialog = False
            End With
            Engine.Start()
        End If
        log = New StreamWriter(File.OpenWrite(Options.ExefilePath + ".log"))
    End Sub

    Public Sub [Stop]()
        Try
            Options.AutoRestart = False
            Engine.Kill()
            Engine.Close()
            log.Close()
            log = Nothing
        Catch ex As Exception

        Finally
            Engine = Nothing
        End Try
    End Sub

    Private Sub Engine_OutputDataReceived(sender As Object, e As DataReceivedEventArgs) Handles Engine.OutputDataReceived
        If log IsNot Nothing Then log.WriteLine($"[{Date.Now.ToString("yyyy-MM-dd hh:mm:ss")}] [I] {e.Data}")
    End Sub

    Private Sub Engine_Exited(sender As Object, e As EventArgs) Handles Engine.Exited
        If Engine.ExitCode Then
            If Options.AutoRestart Then
                [Stop]()
                Start()
            End If
        Else
            [Stop]()
        End If
    End Sub

    Private Sub Engine_ErrorDataReceived(sender As Object, e As DataReceivedEventArgs) Handles Engine.ErrorDataReceived
        If log IsNot Nothing Then log.WriteLine($"[{Date.Now.ToString("yyyy-MM-dd hh:mm:ss")}] [E] {e.Data}")
    End Sub

End Class
