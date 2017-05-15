Imports KcptunWorker

Public Class ConfigEdit
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        data = New Release
    End Sub

    Sub New(op As Release)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        data = op
    End Sub

    Public data As Release
    Private Sub ConfigEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_name.Text = data.Name
        tb_param.Text = data.Paramenters
        tb_path.Text = data.ExefilePath
        cb_enable.Checked = data.Enabled
        cb_autorestart.Checked = data.AutoRestart
        cb_log.Checked = data.EnableLogging
    End Sub

    Public Shared Function ShowEditer(op As Release) As Boolean
        Dim editor As New ConfigEdit(op)
        Dim ans = editor.ShowDialog
        If ans = DialogResult.Cancel Then Return False
        editor.Close()
        editor.Dispose()
        Return True
    End Function

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        data.AutoRestart = cb_autorestart.Checked
        data.ExefilePath = tb_path.Text
        data.Name = tb_name.Text
        data.Paramenters = tb_param.Text
        data.Enabled = cb_enable.Checked
        data.EnableLogging = cb_log.Checked
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim od As New OpenFileDialog
        If od.ShowDialog = DialogResult.OK Then
            tb_path.Text = od.FileName
        End If
    End Sub
End Class