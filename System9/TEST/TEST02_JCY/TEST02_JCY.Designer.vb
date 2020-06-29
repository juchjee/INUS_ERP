<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TEST02_JCY
    Inherits Base9.Form

    'UserControl1은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame9.ePanel()
        Me.f_bs_cd = New Frame9.eCombo()
        Me.f_tm_no = New Frame9.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame9.ePanel()
        Me.g10 = New Frame9.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame9.ePanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tm_login_ip = New Frame9.eText()
        Me.bs_cd = New Frame9.eCombo()
        Me.tm_no = New Frame9.eText()
        Me.tm_nm = New Frame9.eText()
        Me.tm_hp = New Frame9.eText()
        Me.addr2 = New Frame9.eText()
        Me.addr = New Frame9.eText()
        Me.tmid = New Frame9.eText()
        Me.tm_zip = New Frame9.eText()
        Me.tm_email = New Frame9.eText()
        Me.tmdt = New Frame9.eDate()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1380, 800)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.f_bs_cd)
        Me.EPanel1.Controls.Add(Me.f_tm_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1380, 80)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'f_bs_cd
        '
        Me.f_bs_cd.Location = New System.Drawing.Point(12, 28)
        Me.f_bs_cd.Name = "f_bs_cd"
        Me.f_bs_cd.Size = New System.Drawing.Size(240, 30)
        Me.f_bs_cd.TabIndex = 26
        Me.f_bs_cd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.f_bs_cd.Title = "사업장"
        Me.f_bs_cd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'f_tm_no
        '
        Me.f_tm_no.Location = New System.Drawing.Point(12, 52)
        Me.f_tm_no.Name = "f_tm_no"
        Me.f_tm_no.Size = New System.Drawing.Size(240, 30)
        Me.f_tm_no.TabIndex = 2
        Me.f_tm_no.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.f_tm_no.Title = "사원번호"
        Me.f_tm_no.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1380, 716)
        Me.SplitContainer2.SplitterDistance = 433
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(433, 716)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     사원정보"
        '
        'g10
        '
        Me.g10.AllowColumnResizing = True
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 31)
        Me.g10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(429, 683)
        Me.g10.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        Me.SplitContainer3.Panel1MinSize = 40
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(943, 716)
        Me.SplitContainer3.SplitterDistance = 251
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.Panel1)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(943, 716)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     사원등록"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tm_login_ip)
        Me.Panel1.Controls.Add(Me.bs_cd)
        Me.Panel1.Controls.Add(Me.tm_no)
        Me.Panel1.Controls.Add(Me.tm_nm)
        Me.Panel1.Controls.Add(Me.tm_hp)
        Me.Panel1.Controls.Add(Me.addr2)
        Me.Panel1.Controls.Add(Me.addr)
        Me.Panel1.Controls.Add(Me.tmid)
        Me.Panel1.Controls.Add(Me.tm_zip)
        Me.Panel1.Controls.Add(Me.tm_email)
        Me.Panel1.Controls.Add(Me.tmdt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 683)
        Me.Panel1.TabIndex = 27
        '
        'tm_login_ip
        '
        Me.tm_login_ip.Location = New System.Drawing.Point(8, 216)
        Me.tm_login_ip.Name = "tm_login_ip"
        Me.tm_login_ip.Size = New System.Drawing.Size(492, 20)
        Me.tm_login_ip.TabIndex = 27
        Me.tm_login_ip.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tm_login_ip.Title = "사용자 IP"
        Me.tm_login_ip.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(512, 69)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 30)
        Me.bs_cd.TabIndex = 25
        Me.bs_cd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.bs_cd.Title = "사업장"
        Me.bs_cd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'tm_no
        '
        Me.tm_no.Location = New System.Drawing.Point(8, 6)
        Me.tm_no.Name = "tm_no"
        Me.tm_no.Size = New System.Drawing.Size(240, 30)
        Me.tm_no.TabIndex = 6
        Me.tm_no.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tm_no.Title = "사용자 ID"
        Me.tm_no.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'tm_nm
        '
        Me.tm_nm.Location = New System.Drawing.Point(8, 32)
        Me.tm_nm.Name = "tm_nm"
        Me.tm_nm.Size = New System.Drawing.Size(240, 30)
        Me.tm_nm.TabIndex = 7
        Me.tm_nm.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tm_nm.Title = "사용자 명"
        Me.tm_nm.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'tm_hp
        '
        Me.tm_hp.Location = New System.Drawing.Point(8, 56)
        Me.tm_hp.Name = "tm_hp"
        Me.tm_hp.Size = New System.Drawing.Size(240, 30)
        Me.tm_hp.TabIndex = 8
        Me.tm_hp.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tm_hp.Title = "핸드폰"
        Me.tm_hp.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'addr2
        '
        Me.addr2.Location = New System.Drawing.Point(8, 176)
        Me.addr2.Name = "addr2"
        Me.addr2.Size = New System.Drawing.Size(492, 20)
        Me.addr2.TabIndex = 13
        Me.addr2.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.addr2.Title = "상세주소"
        Me.addr2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'addr
        '
        Me.addr.Location = New System.Drawing.Point(8, 152)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(492, 20)
        Me.addr.TabIndex = 12
        Me.addr.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.addr.Title = "주소"
        Me.addr.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'tmid
        '
        Me.tmid.Location = New System.Drawing.Point(512, 105)
        Me.tmid.Name = "tmid"
        Me.tmid.Size = New System.Drawing.Size(240, 30)
        Me.tmid.TabIndex = 24
        Me.tmid.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tmid.Title = "등록자"
        Me.tmid.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'tm_zip
        '
        Me.tm_zip.Location = New System.Drawing.Point(8, 128)
        Me.tm_zip.Name = "tm_zip"
        Me.tm_zip.Size = New System.Drawing.Size(240, 30)
        Me.tm_zip.TabIndex = 11
        Me.tm_zip.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tm_zip.Title = "우편번호"
        Me.tm_zip.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'tm_email
        '
        Me.tm_email.Location = New System.Drawing.Point(8, 104)
        Me.tm_email.Name = "tm_email"
        Me.tm_email.Size = New System.Drawing.Size(374, 20)
        Me.tm_email.TabIndex = 10
        Me.tm_email.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tm_email.Title = "E-Mail"
        Me.tm_email.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'tmdt
        '
        Me.tmdt.Location = New System.Drawing.Point(512, 129)
        Me.tmdt.Name = "tmdt"
        Me.tmdt.Size = New System.Drawing.Size(240, 30)
        Me.tmdt.TabIndex = 22
        Me.tmdt.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.tmdt.Title = "등록일자"
        Me.tmdt.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Size = New System.Drawing.Size(150, 46)
        Me.SplitContainer4.SplitterDistance = 121
        Me.SplitContainer4.TabIndex = 1
        '
        'TEST02_JCY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "TEST02_JCY"
        Me.Size = New System.Drawing.Size(1380, 800)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame9.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame9.ePanel
    Friend WithEvents g10 As Frame9.eGrid
    Friend WithEvents f_tm_no As Frame9.eText
    Friend WithEvents EPanel3 As Frame9.ePanel
    Friend WithEvents tmdt As Frame9.eDate
    Friend WithEvents addr2 As Frame9.eText
    Friend WithEvents addr As Frame9.eText
    Friend WithEvents tm_zip As Frame9.eText
    Friend WithEvents tm_email As Frame9.eText
    Friend WithEvents tm_hp As Frame9.eText
    Friend WithEvents tm_nm As Frame9.eText
    Friend WithEvents tm_no As Frame9.eText
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents tmid As Frame9.eText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_bs_cd As Frame9.eCombo
    Friend WithEvents tm_login_ip As Frame9.eText
    Friend WithEvents bs_cd As Frame9.eCombo
End Class
