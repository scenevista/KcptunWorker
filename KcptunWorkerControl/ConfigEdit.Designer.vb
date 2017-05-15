<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigEdit))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_log = New System.Windows.Forms.CheckBox()
        Me.cb_autorestart = New System.Windows.Forms.CheckBox()
        Me.tb_param = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.tb_path = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_enable = New System.Windows.Forms.CheckBox()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_ok, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(379, 506)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.cb_log)
        Me.Panel1.Controls.Add(Me.cb_autorestart)
        Me.Panel1.Controls.Add(Me.tb_param)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_browse)
        Me.Panel1.Controls.Add(Me.tb_path)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cb_enable)
        Me.Panel1.Controls.Add(Me.tb_name)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 440)
        Me.Panel1.TabIndex = 0
        '
        'cb_log
        '
        Me.cb_log.AutoSize = True
        Me.cb_log.Location = New System.Drawing.Point(81, 317)
        Me.cb_log.Name = "cb_log"
        Me.cb_log.Size = New System.Drawing.Size(84, 16)
        Me.cb_log.TabIndex = 31
        Me.cb_log.Text = "输出到文件"
        Me.cb_log.UseVisualStyleBackColor = True
        '
        'cb_autorestart
        '
        Me.cb_autorestart.AutoSize = True
        Me.cb_autorestart.Location = New System.Drawing.Point(81, 358)
        Me.cb_autorestart.Name = "cb_autorestart"
        Me.cb_autorestart.Size = New System.Drawing.Size(120, 16)
        Me.cb_autorestart.TabIndex = 30
        Me.cb_autorestart.Text = "返回非零自动重启"
        Me.cb_autorestart.UseVisualStyleBackColor = True
        '
        'tb_param
        '
        Me.tb_param.Location = New System.Drawing.Point(81, 129)
        Me.tb_param.Multiline = True
        Me.tb_param.Name = "tb_param"
        Me.tb_param.Size = New System.Drawing.Size(219, 138)
        Me.tb_param.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "运行参数"
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(306, 75)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(31, 21)
        Me.btn_browse.TabIndex = 27
        Me.btn_browse.Text = "..."
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'tb_path
        '
        Me.tb_path.Location = New System.Drawing.Point(81, 75)
        Me.tb_path.Name = "tb_path"
        Me.tb_path.Size = New System.Drawing.Size(219, 21)
        Me.tb_path.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "程序路径"
        '
        'cb_enable
        '
        Me.cb_enable.AutoSize = True
        Me.cb_enable.Location = New System.Drawing.Point(81, 396)
        Me.cb_enable.Name = "cb_enable"
        Me.cb_enable.Size = New System.Drawing.Size(48, 16)
        Me.cb_enable.TabIndex = 24
        Me.cb_enable.Text = "启用"
        Me.cb_enable.UseVisualStyleBackColor = True
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(81, 25)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(219, 21)
        Me.tb_name.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "配置名称"
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_ok.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_ok.Location = New System.Drawing.Point(19, 458)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(150, 36)
        Me.btn_ok.TabIndex = 1
        Me.btn_ok.Text = "保存"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(209, 458)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(150, 36)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "取消"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'ConfigEdit
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancel
        Me.ClientSize = New System.Drawing.Size(379, 506)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConfigEdit"
        Me.Text = "自定义"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents cb_enable As CheckBox
    Friend WithEvents tb_name As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_param As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_browse As Button
    Friend WithEvents tb_path As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_autorestart As CheckBox
    Friend WithEvents cb_log As CheckBox
End Class
