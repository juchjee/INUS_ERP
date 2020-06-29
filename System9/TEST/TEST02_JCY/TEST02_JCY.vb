Imports Frame9
Imports Base9
Imports Base9.Shared



Public Class TEST02_JCY

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
        tm_no.CodeNo = "TEST02_JCY"
        tm_no.CodeDateField = tmdt
        tm_no.CodeParameterField = tmid

        'g10.SelectRow = True
        'cs_no_new.CodeNo = "ASA010"
        'cs_no_new.CodeDateField = get_dt
        'cs_no_new.CodeParameterField = cid
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty


            Case MenuType.Open      '메뉴바 열기

                'Me.OpenTrigger("asa100_g10")

                Me.Open()
                BtnStyle(False)

            Case MenuType.Save      '메뉴바 저장
                'If Not Me.WorkSet("asa100_f10").DataChanged Then
                '    Exit Sub
                'End If

                If Me.Save() Then

                    'Dim saveID As String = tm_no.Text
                    'Dim tm_nm1 As String = tm_nm.Text       '고객명
                    'Dim hp1 As String = tm_hp.Text         '핸드폰     '
                    'Dim e_mail1 As String = tm_email.Text     '
                    'Dim zip_cd1 As String = tm_zip.Text     '
                    'Dim addr1 As String = addr.Text         '
                    'Dim addr21 As String = addr2.Text       '  


                    'tm_nm.Text = tm_nm1
                    'tm_hp.Text = hp1
                    'tm_email.Text = e_mail1
                    'tm_zip.Text = zip_cd1
                    'addr.Text = addr1
                    'addr2.Text = addr21

                    f_tm_no.Text = tm_no.Text





                    Me.Open()
                    BtnStyle(False)

                    'g10.Find("cs_no=" + saveID)

                End If

            Case MenuType.New       '메뉴바 신규
                New_Form()

                tm_no.Text = ""      '고객ID
                tm_nm.Text = ""      '고객명
                tm_hp.Text = ""        '핸드폰        '
                tm_email.Text = ""     '
                tm_zip.Text = ""     '
                addr.Text = ""         '
                addr2.Text = ""       '
                tmid.Text = ""
                tmdt.Text = ""

            Case MenuType.Delete    '메뉴바 삭제

                Me.WorkSet("test02_jcy_f10").DeleteRow()
                f_tm_no.Text = tm_no.Text



                Me.Open()
                BtnStyle(False)

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다 -- 이게 뭘까.. 인쇄 캡쳐 도움말인가

        End Select

    End Sub

    Public Sub New_Form()
        Dim BsCd As String = f_bs_cd.Text
        f_tm_no.Text = ""
        f_bs_cd.Text = ""

        Me.Open()
        BtnStyle(False)
        f_bs_cd.Text = BsCd
        tm_no.Focus()
    End Sub

    Public Sub Open2(ByVal inNo As String)

        f_tm_no.Text = inNo
        Me.Open()
        BtnStyle(False)
    End Sub

    Private Sub BtnStyle(Optional SetStyle As Boolean = True)


        If SetStyle Then
            'but_copy.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            'but_ok.Font = New Font("Tahoma", 9, FontStyle.Bold)
            'but_copy.ForeColor = Color.Red
        Else
            'but_copy.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
            'but_copy.Font = New Font("Tahoma", 9)
            'but_copy.ForeColor = Color.Black
            '우선 분업 하는 경우는 적으니, 파일 변경 / 추가 시 커밋하고 버전 관리하는거 부터 진행
            ' V1을 사용자1이 변경하고 커밋까지 한 상태에서(V2) 사용자2 가 V1을 가지고 있는 상태로 변경 하고 커밋할 경우 어떻게 표시 되는지? 2를 받고 변경을 진행 해야하는데 변경 하기전에 알려주는지
            ' 아니면 변경 후에 엎어지는지 확인 변경전에 내려받으라고 하면 문제 없이 진행 하고 분기 테스트 진행 하면 될 듯 =============> 다른 노트북 & 다른 경로에 파일로 진행
            '=================================================================> 최신 버전 안받은 상태에서 커밋 할 경우 충돌이 일어나고, 충돌시 병합창에서 - 다른내용 체크를 통해 병합을 진행 할 수 있다.

            '분기 테스트 master / User

            'master 작업 진행 (원격저장소에 업로드 되면 x 그럼 다른 쪽에서 분기든, 수정이든 바로 병합해야함 변경 작업 쭉 진행하다 완료시에만 원격저장소 커밋)
            'master 작업 진행 - 2
            'master 작업 진행 - 3

        End If
    End Sub

End Class
