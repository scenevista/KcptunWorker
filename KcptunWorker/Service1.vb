Imports System.ComponentModel
Imports System.Configuration.Install


Public Class Service1
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' 请在此处添加代码以启动您的服务。此方法应完成设置工作，
        ' 以使您的服务开始工作。

        Init()
    End Sub

    Protected Overrides Sub OnStop()
        ' 在此处添加代码以执行任何必要的拆解操作，从而停止您的服务。

        UnInit()
    End Sub

    Protected Overrides Sub OnCustomCommand(command As Integer)
        MyBase.OnCustomCommand(command)
        Select Case command
            Case KcptunWorker.Command.Reload
                ReloadConfig()
                ReloadClients()
        End Select
    End Sub

    Protected Overrides Sub OnPause()
        MyBase.OnPause()
    End Sub

    Protected Overrides Sub OnContinue()
        MyBase.OnContinue()
    End Sub

    Protected Overrides Sub OnShutdown()
        MyBase.OnShutdown()
    End Sub
End Class
