<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEST_REPORT
    Inherits Base9.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.EPanel1 = New Frame9.ePanel()
        Me.EButton1 = New Frame9.eButton()
        Me.EText1 = New Frame9.eText()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.EText1)
        Me.EPanel1.Controls.Add(Me.EButton1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 690)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     EPanel1"
        '
        'EButton1
        '
        Me.EButton1.Location = New System.Drawing.Point(23, 44)
        Me.EButton1.Name = "EButton1"
        Me.EButton1.Size = New System.Drawing.Size(102, 43)
        Me.EButton1.TabIndex = 2
        Me.EButton1.Text = "발주서 출력"
        '
        'EText1
        '
        Me.EText1.Location = New System.Drawing.Point(144, 54)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(240, 24)
        Me.EText1.TabIndex = 3
        Me.EText1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.EText1.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'TEST_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "TEST_REPORT"
        Me.Size = New System.Drawing.Size(1000, 690)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EPanel1 As Frame9.ePanel
    Friend WithEvents EButton1 As Frame9.eButton
    Friend WithEvents EText1 As Frame9.eText
End Class
