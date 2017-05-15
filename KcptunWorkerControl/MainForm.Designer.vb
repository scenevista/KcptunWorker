<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_running = New System.Windows.Forms.Label()
        Me.lb_installed = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lb_list = New System.Windows.Forms.ListBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.cb_enable = New System.Windows.Forms.CheckBox()
        Me.cb_autorestart = New System.Windows.Forms.CheckBox()
        Me.cb_log = New System.Windows.Forms.CheckBox()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_sav = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tb_param = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_bro = New System.Windows.Forms.Button()
        Me.tb_path = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(704, 491)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(696, 465)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "服务管理"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(690, 459)
        Me.SplitContainer1.SplitterDistance = 268
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_running)
        Me.GroupBox1.Controls.Add(Me.lb_installed)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 459)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "服务状态"
        '
        'lb_running
        '
        Me.lb_running.AutoSize = True
        Me.lb_running.Location = New System.Drawing.Point(113, 60)
        Me.lb_running.Name = "lb_running"
        Me.lb_running.Size = New System.Drawing.Size(41, 12)
        Me.lb_running.TabIndex = 3
        Me.lb_running.Text = "未运行"
        '
        'lb_installed
        '
        Me.lb_installed.AutoSize = True
        Me.lb_installed.Location = New System.Drawing.Point(113, 34)
        Me.lb_installed.Name = "lb_installed"
        Me.lb_installed.Size = New System.Drawing.Size(41, 12)
        Me.lb_installed.TabIndex = 2
        Me.lb_installed.Text = "未安装"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "服务运行状态："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "服务安装状态："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 459)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "服务控制"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(52, 261)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(318, 23)
        Me.Button10.TabIndex = 5
        Me.Button10.Text = "重载服务"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(295, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "停止服务"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(52, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "启动服务"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(295, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "卸载服务"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "安装服务"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(696, 465)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "配置文件"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lb_list)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_edit)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cb_enable)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cb_autorestart)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cb_log)
        Me.SplitContainer2.Panel2.Controls.Add(Me.tb_name)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_sav)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_del)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_new)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(690, 459)
        Me.SplitContainer2.SplitterDistance = 230
        Me.SplitContainer2.TabIndex = 0
        '
        'lb_list
        '
        Me.lb_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_list.FormattingEnabled = True
        Me.lb_list.ItemHeight = 12
        Me.lb_list.Location = New System.Drawing.Point(0, 0)
        Me.lb_list.Name = "lb_list"
        Me.lb_list.Size = New System.Drawing.Size(230, 459)
        Me.lb_list.TabIndex = 0
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(84, 431)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 10
        Me.btn_edit.Text = "编辑"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'cb_enable
        '
        Me.cb_enable.AutoSize = True
        Me.cb_enable.Enabled = False
        Me.cb_enable.Location = New System.Drawing.Point(78, 346)
        Me.cb_enable.Name = "cb_enable"
        Me.cb_enable.Size = New System.Drawing.Size(60, 16)
        Me.cb_enable.TabIndex = 9
        Me.cb_enable.Text = "已启用"
        Me.cb_enable.UseVisualStyleBackColor = True
        '
        'cb_autorestart
        '
        Me.cb_autorestart.AutoSize = True
        Me.cb_autorestart.Enabled = False
        Me.cb_autorestart.Location = New System.Drawing.Point(78, 324)
        Me.cb_autorestart.Name = "cb_autorestart"
        Me.cb_autorestart.Size = New System.Drawing.Size(96, 16)
        Me.cb_autorestart.TabIndex = 8
        Me.cb_autorestart.Text = "出错自动重启"
        Me.cb_autorestart.UseVisualStyleBackColor = True
        '
        'cb_log
        '
        Me.cb_log.AutoSize = True
        Me.cb_log.Enabled = False
        Me.cb_log.Location = New System.Drawing.Point(78, 302)
        Me.cb_log.Name = "cb_log"
        Me.cb_log.Size = New System.Drawing.Size(84, 16)
        Me.cb_log.TabIndex = 7
        Me.cb_log.Text = "输出到文件"
        Me.cb_log.UseMnemonic = False
        Me.cb_log.UseVisualStyleBackColor = True
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(78, 222)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.ReadOnly = True
        Me.tb_name.Size = New System.Drawing.Size(371, 21)
        Me.tb_name.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "配置名称："
        '
        'btn_sav
        '
        Me.btn_sav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sav.Location = New System.Drawing.Point(378, 431)
        Me.btn_sav.Name = "btn_sav"
        Me.btn_sav.Size = New System.Drawing.Size(75, 23)
        Me.btn_sav.TabIndex = 4
        Me.btn_sav.Text = "保存"
        Me.btn_sav.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_del.Location = New System.Drawing.Point(165, 431)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(75, 23)
        Me.btn_del.TabIndex = 3
        Me.btn_del.Text = "删除"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_new.Location = New System.Drawing.Point(3, 431)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 2
        Me.btn_new.Text = "新建"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tb_param)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(452, 117)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "参数"
        '
        'tb_param
        '
        Me.tb_param.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_param.Location = New System.Drawing.Point(3, 17)
        Me.tb_param.Multiline = True
        Me.tb_param.Name = "tb_param"
        Me.tb_param.ReadOnly = True
        Me.tb_param.Size = New System.Drawing.Size(446, 97)
        Me.tb_param.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btn_bro)
        Me.GroupBox3.Controls.Add(Me.tb_path)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 77)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "程序"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "文件存在。"
        '
        'btn_bro
        '
        Me.btn_bro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_bro.Location = New System.Drawing.Point(369, 47)
        Me.btn_bro.Name = "btn_bro"
        Me.btn_bro.Size = New System.Drawing.Size(75, 23)
        Me.btn_bro.TabIndex = 1
        Me.btn_bro.Text = "打开路径"
        Me.btn_bro.UseVisualStyleBackColor = True
        '
        'tb_path
        '
        Me.tb_path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_path.Location = New System.Drawing.Point(6, 20)
        Me.tb_path.Name = "tb_path"
        Me.tb_path.ReadOnly = True
        Me.tb_path.Size = New System.Drawing.Size(438, 21)
        Me.tb_path.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 491)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(720, 530)
        Me.MinimumSize = New System.Drawing.Size(720, 530)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kcptun服务控制台"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lb_running As Label
    Friend WithEvents lb_installed As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents lb_list As ListBox
    Friend WithEvents cb_enable As CheckBox
    Friend WithEvents cb_autorestart As CheckBox
    Friend WithEvents cb_log As CheckBox
    Friend WithEvents tb_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_sav As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tb_param As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_bro As Button
    Friend WithEvents tb_path As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_edit As Button
End Class
