<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEST04_ERP03
    Inherits Base9.Form

    'UserControl1은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame9.ePanel()
        Me.emp_nm = New Frame9.eText()
        Me.rmk = New Frame9.eText()
        Me.sal_dept = New Frame9.eText()
        Me.sal_bs = New Frame9.eCheckCombo()
        Me.sal_dept_nm = New Frame9.eText()
        Me.de_bc = New Frame9.eCombo()
        Me.fr_dt = New Frame9.eDate()
        Me.to_dt = New Frame9.eDate()
        Me.sal_no = New Frame9.eText()
        Me.cust_cd = New Frame9.eText()
        Me.cust_nm = New Frame9.eText()
        Me.sal_rid = New Frame9.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame9.ePanel()
        Me.g10 = New Frame9.eGrid()
        Me.EPanel3 = New Frame9.ePanel()
        Me.g20 = New Frame9.eGrid()
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
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1266, 647)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.rmk)
        Me.EPanel1.Controls.Add(Me.sal_dept)
        Me.EPanel1.Controls.Add(Me.sal_bs)
        Me.EPanel1.Controls.Add(Me.sal_dept_nm)
        Me.EPanel1.Controls.Add(Me.de_bc)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.sal_no)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.sal_rid)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1266, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'emp_nm
        '
        Me.emp_nm.Location = New System.Drawing.Point(12, 76)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 24)
        Me.emp_nm.TabIndex = 123
        Me.emp_nm.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.emp_nm.Title = "사원명"
        Me.emp_nm.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'rmk
        '
        Me.rmk.Location = New System.Drawing.Point(865, 78)
        Me.rmk.Name = "rmk"
        Me.rmk.Size = New System.Drawing.Size(311, 24)
        Me.rmk.TabIndex = 128
        Me.rmk.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.rmk.Title = "본사-->"
        Me.rmk.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.rmk.TitleWidth = 0
        '
        'sal_dept
        '
        Me.sal_dept.Location = New System.Drawing.Point(791, 78)
        Me.sal_dept.Name = "sal_dept"
        Me.sal_dept.Size = New System.Drawing.Size(80, 24)
        Me.sal_dept.TabIndex = 122
        Me.sal_dept.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.sal_dept.Title = "dept_cd"
        Me.sal_dept.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'sal_bs
        '
        Me.sal_bs.Location = New System.Drawing.Point(272, 52)
        Me.sal_bs.Name = "sal_bs"
        Me.sal_bs.Size = New System.Drawing.Size(240, 24)
        Me.sal_bs.TabIndex = 125
        Me.sal_bs.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.sal_bs.Title = "사업장"
        Me.sal_bs.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'sal_dept_nm
        '
        Me.sal_dept_nm.Location = New System.Drawing.Point(272, 76)
        Me.sal_dept_nm.Name = "sal_dept_nm"
        Me.sal_dept_nm.Size = New System.Drawing.Size(240, 24)
        Me.sal_dept_nm.TabIndex = 121
        Me.sal_dept_nm.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.sal_dept_nm.Title = "dept_nm"
        Me.sal_dept_nm.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'de_bc
        '
        Me.de_bc.Location = New System.Drawing.Point(532, 52)
        Me.de_bc.Name = "de_bc"
        Me.de_bc.Size = New System.Drawing.Size(240, 24)
        Me.de_bc.TabIndex = 120
        Me.de_bc.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.de_bc.Title = "지역구분"
        Me.de_bc.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 24)
        Me.fr_dt.TabIndex = 114
        Me.fr_dt.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.fr_dt.Title = "출고일자"
        Me.fr_dt.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(132, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 24)
        Me.to_dt.TabIndex = 115
        Me.to_dt.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.to_dt.Title = "부터"
        Me.to_dt.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.to_dt.TitleWidth = 0
        '
        'sal_no
        '
        Me.sal_no.Location = New System.Drawing.Point(532, 76)
        Me.sal_no.Name = "sal_no"
        Me.sal_no.Size = New System.Drawing.Size(240, 24)
        Me.sal_no.TabIndex = 75
        Me.sal_no.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.sal_no.Title = "매출번호"
        Me.sal_no.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(272, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 24)
        Me.cust_cd.TabIndex = 35
        Me.cust_cd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.cust_cd.Title = "거래처"
        Me.cust_cd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(515, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(257, 24)
        Me.cust_nm.TabIndex = 38
        Me.cust_nm.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.cust_nm.TitleWidth = 0
        '
        'sal_rid
        '
        Me.sal_rid.Location = New System.Drawing.Point(12, 76)
        Me.sal_rid.Name = "sal_rid"
        Me.sal_rid.Size = New System.Drawing.Size(240, 24)
        Me.sal_rid.TabIndex = 124
        Me.sal_rid.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.sal_rid.Title = "사원코드"
        Me.sal_rid.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1266, 539)
        Me.SplitContainer2.SplitterDistance = 268
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1266, 268)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     매출현황"
        '
        'g10
        '
        Me.g10.AllowColumnResizing = True
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 27)
        Me.g10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(1262, 239)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1266, 267)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     매출상세 정보"
        '
        'g20
        '
        Me.g20.AllowColumnResizing = True
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 27)
        Me.g20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.g20.Name = "g20"
        Me.g20.Size = New System.Drawing.Size(1262, 238)
        Me.g20.TabIndex = 2
        '
        'TEST04_ERP03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "TEST04_ERP03"
        Me.Size = New System.Drawing.Size(1266, 647)
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
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame9.ePanel
    Friend WithEvents EPanel2 As Frame9.ePanel
    Friend WithEvents g10 As Frame9.eGrid
    Friend WithEvents cust_nm As Frame9.eText
    Friend WithEvents cust_cd As Frame9.eText
    Friend WithEvents sal_no As Frame9.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame9.ePanel
    Friend WithEvents g20 As Frame9.eGrid
    Friend WithEvents fr_dt As Frame9.eDate
    Friend WithEvents to_dt As Frame9.eDate
    Friend WithEvents sal_dept_nm As Frame9.eText
    Friend WithEvents de_bc As Frame9.eCombo
    Friend WithEvents sal_dept As Frame9.eText
    Friend WithEvents emp_nm As Frame9.eText
    Friend WithEvents sal_rid As Frame9.eText
    Friend WithEvents sal_bs As Frame9.eCheckCombo
    Friend WithEvents rmk As Frame9.eText

End Class
