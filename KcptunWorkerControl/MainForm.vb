Imports System.Net
Imports KcptunWorker

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call InstallService()
        Check()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cursor = Cursors.AppStarting
        If Not UninstallService() Then
            MsgBox("服务卸载失败。")
        End If
        Cursor = Cursors.Default
        Check()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not StartService() Then
            MsgBox("服务启动失败。")
        End If
        Check()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not StopService() Then
            MsgBox("出现错误，服务未安装或已停止。")
        End If
        Check()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CmdReload() Then
            MsgBox("服务已重载。")
        Else
            MsgBox("命令发送失败。")
        End If
        Check()
    End Sub

    Private Sub Check()
        Dim state = CheckServiceState()
        lb_installed.Text = If(state.installed, "已安装", "未安装")
        lb_running.Text = If(state.running, "已启动", "未启动")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check()
        LoadList()
    End Sub

    Private Sub LoadList()
        LoadSettingFile()
        lb_list.BeginUpdate()
        lb_list.Items.Clear()
        For i = 0 To Data.Releases.Count - 1
            lb_list.Items.Add(Data.Releases(i).Name)
        Next
        lb_list.EndUpdate()

        If lb_list.Items.Count > 0 Then
            lb_list.SelectedIndex = 0
        End If
    End Sub

    Private Sub AddItem(item As Release)
        If item IsNot Nothing Then
            Data.Releases.Add(item)
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim op As New Release
        Dim a As New ConfigEdit(op)
        If a.ShowDialog = DialogResult.Cancel Then Return
        Data.Releases.Add(op)
        SaveSettingFile()
        LoadList()
    End Sub

    Private Sub lb_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_list.SelectedIndexChanged
        Dim op As Release = Data.Releases(lb_list.SelectedIndex)
        tb_path.Text = op.ExefilePath
        tb_name.Text = op.Name
        tb_param.Text = op.Paramenters
        cb_autorestart.Checked = op.AutoRestart
        cb_enable.Checked = op.Enabled
        cb_log.Checked = op.EnableLogging
    End Sub

    Private Sub btn_sav_Click(sender As Object, e As EventArgs) Handles btn_sav.Click
        SaveSettingFile()
        LoadList()
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Data.Releases.RemoveAt(lb_list.SelectedIndex)
        SaveSettingFile()
        LoadList()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If lb_list.SelectedItems.Count = 0 Then Return
        Dim op As Release = Data.Releases(lb_list.SelectedIndex)
        Dim d As New ConfigEdit(op)
        If d.ShowDialog = DialogResult.Cancel Then Return
        SaveSettingFile()
        LoadList()
    End Sub

    Private Sub btn_bro_Click(sender As Object, e As EventArgs) Handles btn_bro.Click
        If IO.File.Exists(tb_path.Text) Then
            Process.Start("Explorer", "/select, " + tb_path.Text)
        Else
            MsgBox("找不到文件。")
        End If
    End Sub
End Class
