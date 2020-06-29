<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEST001
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
        Me.pnlSearch = New Frame9.ePanel()
        Me.site_cd = New Frame9.eText()
        Me.site_ds = New Frame9.eText()
        Me.pnlResult = New Frame9.ePanel()
        Me.g10 = New Frame9.eGrid()
        Me.sq_sn = New Frame9.eText()
        Me.dokub_vw = New Frame9.eCheck()
        Me.silhengbs_vw = New Frame9.eCheck()
        Me.silheng_vw = New Frame9.eCheck()
        Me.bimok_vw = New Frame9.eCheck()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pnlSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        CType(Me.pnlResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResult.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlSearch)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlResult)
        Me.SplitContainer1.Size = New System.Drawing.Size(977, 563)
        Me.SplitContainer1.SplitterDistance = 52
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.sq_sn)
        Me.pnlSearch.Controls.Add(Me.site_cd)
        Me.pnlSearch.Controls.Add(Me.site_ds)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(977, 52)
        Me.pnlSearch.TabIndex = 0
        Me.pnlSearch.Text = "     조회조건"
        '
        'site_cd
        '
        Me.site_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.site_cd.Location = New System.Drawing.Point(28, 26)
        Me.site_cd.Name = "site_cd"
        Me.site_cd.Size = New System.Drawing.Size(130, 21)
        Me.site_cd.TabIndex = 2
        Me.site_cd.Title = "현장코드"
        Me.site_cd.TitleWidth = 70
        '
        'site_ds
        '
        Me.site_ds.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.site_ds.Location = New System.Drawing.Point(161, 26)
        Me.site_ds.Name = "site_ds"
        Me.site_ds.Size = New System.Drawing.Size(240, 21)
        Me.site_ds.TabIndex = 3
        Me.site_ds.Title = "현장명"
        Me.site_ds.TitleWidth = 0
        '
        'pnlResult
        '
        Me.pnlResult.Controls.Add(Me.bimok_vw)
        Me.pnlResult.Controls.Add(Me.silheng_vw)
        Me.pnlResult.Controls.Add(Me.silhengbs_vw)
        Me.pnlResult.Controls.Add(Me.g10)
        Me.pnlResult.Controls.Add(Me.dokub_vw)
        Me.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResult.Location = New System.Drawing.Point(0, 0)
        Me.pnlResult.Name = "pnlResult"
        Me.pnlResult.Size = New System.Drawing.Size(977, 507)
        Me.pnlResult.TabIndex = 0
        Me.pnlResult.Text = "     실행내역조회"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(973, 482)
        Me.g10.TabIndex = 2
        '
        'sq_sn
        '
        Me.sq_sn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sq_sn.Location = New System.Drawing.Point(404, 26)
        Me.sq_sn.Name = "sq_sn"
        Me.sq_sn.Size = New System.Drawing.Size(30, 21)
        Me.sq_sn.TabIndex = 4
        Me.sq_sn.Title = "실행차수"
        Me.sq_sn.TitleWidth = 0
        '
        'dokub_vw
        '
        Me.dokub_vw.BackColor = System.Drawing.Color.Transparent
        Me.dokub_vw.Caption = "도급금액"
        Me.dokub_vw.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dokub_vw.Location = New System.Drawing.Point(120, 1)
        Me.dokub_vw.Name = "dokub_vw"
        Me.dokub_vw.Size = New System.Drawing.Size(80, 21)
        Me.dokub_vw.TabIndex = 3
        Me.dokub_vw.TitleWidth = 1
        '
        'silhengbs_vw
        '
        Me.silhengbs_vw.BackColor = System.Drawing.Color.Transparent
        Me.silhengbs_vw.Caption = "실행금액(기본형)"
        Me.silhengbs_vw.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.silhengbs_vw.Location = New System.Drawing.Point(200, 1)
        Me.silhengbs_vw.Name = "silhengbs_vw"
        Me.silhengbs_vw.Size = New System.Drawing.Size(125, 21)
        Me.silhengbs_vw.TabIndex = 4
        Me.silhengbs_vw.TitleWidth = 1
        '
        'silheng_vw
        '
        Me.silheng_vw.BackColor = System.Drawing.Color.Transparent
        Me.silheng_vw.Caption = "실행금액(확장형)"
        Me.silheng_vw.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.silheng_vw.Location = New System.Drawing.Point(325, 1)
        Me.silheng_vw.Name = "silheng_vw"
        Me.silheng_vw.Size = New System.Drawing.Size(125, 21)
        Me.silheng_vw.TabIndex = 5
        Me.silheng_vw.TitleWidth = 1
        '
        'bimok_vw
        '
        Me.bimok_vw.BackColor = System.Drawing.Color.Transparent
        Me.bimok_vw.Caption = "구성항목"
        Me.bimok_vw.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bimok_vw.Location = New System.Drawing.Point(450, 1)
        Me.bimok_vw.Name = "bimok_vw"
        Me.bimok_vw.Size = New System.Drawing.Size(80, 21)
        Me.bimok_vw.TabIndex = 6
        Me.bimok_vw.TitleWidth = 1
        '
        'TEST001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "TEST001"
        Me.Size = New System.Drawing.Size(977, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pnlSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        CType(Me.pnlResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResult.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlSearch As Frame9.ePanel
    Friend WithEvents site_cd As Frame9.eText
    Friend WithEvents pnlResult As Frame9.ePanel
    Friend WithEvents g10 As Frame9.eGrid
    Friend WithEvents site_ds As Frame9.eText
    Friend WithEvents sq_sn As Frame9.eText
    Friend WithEvents dokub_vw As Frame9.eCheck
    Friend WithEvents silhengbs_vw As Frame9.eCheck
    Friend WithEvents bimok_vw As Frame9.eCheck
    Friend WithEvents silheng_vw As Frame9.eCheck

End Class
