Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Module Management
    Public Property Config As Config
    Private Property Conns As IList(Of ConnectionCase)

    ''' <summary>
    ''' 装载配置文件。这将覆盖内存中的配置设置。
    ''' </summary>
    Public Sub ReloadConfig()
        CheckConfigFile()
        Dim xml As New XmlSerializer(GetType(Config))
        Dim f = File.Open("C:\ProgramData\KcptunWorker\config.xml", FileMode.Open)
        Config = xml.Deserialize(f)
        f.Close()
    End Sub

    ''' <summary>
    ''' 停止所有的任务，重新装载配置文件并应用新的设置。
    ''' </summary>
    Public Sub ReloadClients()
        KillAll()
        For Each c In Config.Releases
            If c.Enabled Then
                Dim ca As New ConnectionCase(c)
                Conns.Add(ca)
                ca.Start()
            End If
        Next
        GC.Collect()
    End Sub

    ''' <summary>
    ''' 停止所有的任务。
    ''' </summary>
    Public Sub KillAll()
        For Each c In Conns
            c.Stop()
        Next
        Conns.Clear()
    End Sub

    ''' <summary>
    ''' 检查配置文件，如果损坏则创建新的文件并将已存在的文件备份。
    ''' </summary>
    Private Sub CheckConfigFile()
        If File.Exists("C:\ProgramData\KcptunWorker\config.xml") Then
            Dim f = File.Open("C:\ProgramData\KcptunWorker\config.xml", FileMode.Open)
            Dim x As New XmlSerializer(GetType(Config))
            If Not x.CanDeserialize(XmlReader.Create(f)) Then
                Rename("C:\ProgramData\KcptunWorker\config.xml", "C:\ProgramData\KcptunWorker\config.xml." & Date.Now.Ticks.ToString)
                CreateConfigFile()
            End If
            f.Close()
        Else
            CreateConfigFile()
        End If
    End Sub

    ''' <summary>
    ''' 创建新的空白配置文件
    ''' </summary>
    Private Sub CreateConfigFile()
        Dim f = File.Open("C:\ProgramData\KcptunWorker\config.xml", FileMode.Create)
        Dim c = New Config
        Dim x As New XmlSerializer(GetType(Config))
        x.Serialize(f, c)
        f.Close()
    End Sub

    ''' <summary>
    ''' 初始化服务
    ''' </summary>
    Public Sub Init()
        Conns = New List(Of ConnectionCase)
        ReloadConfig()
        ReloadClients()
    End Sub

    ''' <summary>
    ''' 反初始化服务
    ''' </summary>
    Public Sub UnInit()
        KillAll()
        Conns.Clear()
    End Sub
End Module
