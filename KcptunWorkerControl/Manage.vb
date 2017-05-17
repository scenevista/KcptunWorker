Imports System.Configuration.Install
Imports KcptunWorker
Imports System.ServiceProcess
Imports System.Reflection
Imports System.IO

Module Manage
    Private path As String = My.Application.Info.DirectoryPath & "\KcptunWorker.exe"
    Dim ht As IDictionary = New Hashtable

    Public Data As Config

    Public Function InstallService() As Boolean
        If CheckService() Then Return False
        Dim ai As New AssemblyInstaller()
        ai.Path = "C:\ProgramData\KcptunWorker\KcptunWorker.exe"
        Try
            Using installer As New TransactedInstaller
                ai.UseNewContext = True
                installer.Installers.Add(ai)
                installer.Install(ht)
            End Using
            Return True
        Catch ex As Exception
            Return False
        Finally
            ai.Dispose()
            ht.Clear()
        End Try
    End Function

    Public Function UninstallService() As Boolean
        If Not CheckService() Then Return False
        Dim ai As New AssemblyInstaller("C:\ProgramData\KcptunWorker\KcptunWorker.exe", {})
        Using installer As New TransactedInstaller
            ai.UseNewContext = True
            installer.Installers.Add(ai)
            installer.Uninstall(Nothing)
        End Using
        Return True
    End Function

    Private Function CheckService() As Boolean
        Call EnsureServiceFile(True)
        Try
            Dim services = ServiceController.GetServices()
            For Each serv In services
                If serv.ServiceName = "KcptunWorker" Then
                    Return True
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Function CheckServiceState() As ServiceState
        Call EnsureServiceFile()
        Dim services = ServiceController.GetServices()
        For Each serv In services
            If serv.ServiceName = "KcptunWorker" Then
                Return New ServiceState With {.installed = True, .running = serv.Status = ServiceControllerStatus.Running}
                Exit For
            End If
        Next
        Return New ServiceState With {.installed = False, .running = False}
    End Function

    Private Function GetServiceByName(name As String) As ServiceController
        Dim services = ServiceController.GetServices()
        For Each serv In services
            If serv.ServiceName = name Then
                Return serv
            End If
        Next
        Return Nothing
    End Function

    Private Sub EnsureServiceFile(Optional ByVal force As Boolean = False)
        If Not force Then If CheckService() Then Return
        If Not IO.Directory.Exists("C:\ProgramData\KcptunWorker") Then
            Directory.CreateDirectory("C:\ProgramData\KcptunWorker")
            FileCopy(path, "C:\ProgramData\KcptunWorker\KcptunWorker.exe")
            Return
        End If
        If Not File.Exists("C:\ProgramData\KcptunWorker\KcptunWorker.exe") Then
            '逻辑上不会发生，因为服务程序本身已经作为一个程序集被控制器引用了，必须和控制程序放在同一目录内。
            If Not IO.File.Exists(path) Then Throw New IO.FileNotFoundException("未找到源文件，无法复制。")
            FileCopy(path, "C:\ProgramData\KcptunWorker\KcptunWorker.exe")
        End If
    End Sub
    Public Function StartService() As Boolean
        Try
            Dim serv = GetServiceByName("KcptunWorker")
            If serv Is Nothing Then Return False
            If serv.Status = ServiceControllerStatus.Stopped Then
                serv.Start()
                serv.WaitForStatus(ServiceControllerStatus.Running, New TimeSpan(0, 0, 30))
            End If
            serv.Dispose()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function StopService() As Boolean
        Try
            Dim serv = GetServiceByName("KcptunWorker")
            If serv Is Nothing Then Return False
            If serv.Status = ServiceControllerStatus.Running Then
                If serv.CanStop Then serv.Stop()
                serv.WaitForStatus(ServiceControllerStatus.Stopped, New TimeSpan(0, 0, 30))
            End If
            serv.Dispose()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function CmdReload() As Boolean
        Try
            Using sc As New ServiceController("KcptunWorker")
                If sc.Status = ServiceControllerStatus.Running Then
                    sc.ExecuteCommand(Command.Reload)
                End If
            End Using
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    '=====================================================================
    Public Sub LoadSettingFile()
        Dim tp As String = IO.Path.GetTempFileName()
        Dim p As String = "C:\ProgramData\KcptunWorker\config.xml"
        Dim x As New Xml.Serialization.XmlSerializer(GetType(Config))
        Try
            File.Copy(p, tp, True)
            If Not x.CanDeserialize(Xml.XmlReader.Create(tp)) Then
                Dim cf As FileStream = File.Open(p, FileMode.OpenOrCreate)
                x.Serialize(cf, New Config)
                cf.Close()
            End If
        Catch ex As Exception
            File.Delete(p)
            Dim cf As FileStream = File.Open(p, FileMode.OpenOrCreate)
            x.Serialize(cf, New Config)
            cf.Close()
        End Try
        Dim f As FileStream = File.Open(p, FileMode.OpenOrCreate)
        Data = x.Deserialize(f)
        f.Close()
    End Sub

    Public Sub SaveSettingFile()
        If Data Is Nothing Then Return
        Dim p As String = "C:\ProgramData\KcptunWorker\config.xml"
        File.Delete(p)
        Dim f As FileStream = File.Open(p, FileMode.Create)
        Dim x As New Xml.Serialization.XmlSerializer(GetType(Config))
        x.Serialize(f, Data)
        f.Close()
    End Sub

End Module

Public Structure ServiceState
    Public installed As Boolean
    Public running As Boolean
End Structure