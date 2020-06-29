<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TEST_JCY_ASA213
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
        Me.EPanel1 = New Frame9.ePanel()
        Me.EButton1 = New Frame9.eButton()
        Me.bs_cd = New Frame9.eCombo()
        Me.drv_no = New Frame9.eText()
        Me.drv_nm = New Frame9.eText()
        Me.fr_dt = New Frame9.eDate()
        Me.cust_cd = New Frame9.eText()
        Me.cust_nm = New Frame9.eText()
        Me.custcd = New Frame9.eText()
        Me.to_dt = New Frame9.eDate()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame9.ePanel()
        Me.g10 = New Frame9.eGrid()
        Me.EPanel2 = New Frame9.ePanel()
        Me.PrintControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.EButton1)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.drv_no)
        Me.EPanel1.Controls.Add(Me.drv_nm)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.custcd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1200, 103)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'EButton1
        '
        Me.EButton1.Location = New System.Drawing.Point(665, 52)
        Me.EButton1.Name = "EButton1"
        Me.EButton1.Size = New System.Drawing.Size(89, 30)
        Me.EButton1.TabIndex = 9
        Me.EButton1.Text = "인쇄"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(8, 26)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 30)
        Me.bs_cd.TabIndex = 8
        Me.bs_cd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.bs_cd.Title = "사업장"
        Me.bs_cd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'drv_no
        '
        Me.drv_no.Location = New System.Drawing.Point(260, 76)
        Me.drv_no.Name = "drv_no"
        Me.drv_no.Size = New System.Drawing.Size(240, 30)
        Me.drv_no.TabIndex = 6
        Me.drv_no.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.drv_no.Title = "처리자명"
        Me.drv_no.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'drv_nm
        '
        Me.drv_nm.Location = New System.Drawing.Point(384, 76)
        Me.drv_nm.Name = "drv_nm"
        Me.drv_nm.Size = New System.Drawing.Size(240, 30)
        Me.drv_nm.TabIndex = 7
        Me.drv_nm.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.drv_nm.Title = "고객명"
        Me.drv_nm.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 52)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 30)
        Me.fr_dt.TabIndex = 2
        Me.fr_dt.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.fr_dt.Title = "기간"
        Me.fr_dt.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(260, 52)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 30)
        Me.cust_cd.TabIndex = 4
        Me.cust_cd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.cust_cd.Title = "지정대리점"
        Me.cust_cd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(384, 52)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(240, 30)
        Me.cust_nm.TabIndex = 5
        Me.cust_nm.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.cust_nm.Title = "대리점명"
        Me.cust_nm.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'custcd
        '
        Me.custcd.Location = New System.Drawing.Point(630, 76)
        Me.custcd.Name = "custcd"
        Me.custcd.Size = New System.Drawing.Size(15, 30)
        Me.custcd.TabIndex = 5
        Me.custcd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.custcd.Title = "대리점명"
        Me.custcd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.custcd.TitleWidth = 0
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(8, 76)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 30)
        Me.to_dt.TabIndex = 3
        Me.to_dt.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.to_dt.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1200, 636)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 1
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
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1200, 529)
        Me.SplitContainer2.SplitterDistance = 256
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(256, 529)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     검색리스트"
        '
        'g10
        '
        Me.g10.AllowColumnResizing = True
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 31)
        Me.g10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(252, 496)
        Me.g10.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.PrintControl1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(940, 529)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     출력"
        '
        'PrintControl1
        '
        Me.PrintControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintControl1.IsMetric = True
        Me.PrintControl1.Location = New System.Drawing.Point(2, 31)
        Me.PrintControl1.Name = "PrintControl1"
        Me.PrintControl1.SelectedPageBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PrintControl1.Size = New System.Drawing.Size(936, 496)
        Me.PrintControl1.TabIndex = 6
        '
        'TEST_JCY_ASA213
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "TEST_JCY_ASA213"
        Me.Size = New System.Drawing.Size(1200, 636)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame9.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame9.ePanel
    Friend WithEvents fr_dt As Frame9.eDate
    Friend WithEvents cust_cd As Frame9.eText
    Friend WithEvents cust_nm As Frame9.eText
    Friend WithEvents to_dt As Frame9.eDate
    Friend WithEvents drv_no As Frame9.eText
    Friend WithEvents drv_nm As Frame9.eText
    Friend WithEvents g10 As Frame9.eGrid
    Friend WithEvents custcd As Frame9.eText
    Friend WithEvents bs_cd As Frame9.eCombo
    Friend WithEvents EPanel2 As Frame9.ePanel
    Friend WithEvents PrintControl1 As DevExpress.XtraPrinting.Control.PrintControl
    Friend WithEvents EButton1 As Frame9.eButton
End Class
