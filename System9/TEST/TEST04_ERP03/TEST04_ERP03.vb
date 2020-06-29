Imports Frame9
Imports Base9
Imports Base9.Shared

Public Class TEST04_ERP03


    'Private Sub SDD102_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.Open()

    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                'If Not Parameter.Login.IsDeveloper Then
                '    MessageInfo("전산팀 직원만 변경가능합니다")
                '    Return
                'End If

                'If Not (Parameter.Login.RegId = 12 Or Parameter.Login.RegId = 11 Or Parameter.Login.RegId = 348 Or Parameter.Login.RegId = 5444) Then '강훈묵과장, 백미선과장, 이혜란
                '    MessageInfo("전산팀 직원만 변경가능합니다")
                '    Return
                'End If

                If MyBase.Save() Then
                    MyBase.Open()
                End If

                'End If

                'Case MenuType.Delete
                '    'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

                'Case MenuType.New
                '    ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                Me.Print_sub()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Print_sub()
        Dim bDebug As Boolean = False

#If (DEBUG) Then
        bDebug = True
#End If
        Dim p As OpenParameters = New OpenParameters
        Dim dSet As Data.DataSet
        Dim cnt As Integer = g10.CheckedRows("chk")     'Check된 행의 갯수
        If bDebug = False Then
            If cnt = 0 Then
                Me.PrintForm() '체크박스에 체크없이 인쇄 누르면 기본 출력기능 사용..
                Exit Sub
            End If
        End If
        Dim preview As Boolean
        If cnt = 1 Then             'Check된 행이 하나이면 리포트 미리보기를 하고 아니면 바로 출력한다
            preview = True
        End If
#If (DEBUG) Then
        'EXEC SDD100R_Print1 '20190930020031'
        p.Clear()
        p.Add("@sal_no", "20190930020031")
        dSet = MyBase.OpenDataSet("sdd102_100_print", p)
        PrintForm(dSet, "SDD100") '리포트코드
#End If
        If g10.RowCount - 1 >= 0 Then

            For i As Integer = 0 To g10.RowCount - 1
                If g10.ToBool("chk", i) Then
                    p.Add("@sal_no", g10.Text("sal_no", i))



                End If
            Next

        End If

    End Sub


    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        'Dim menuName As String



        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        'ctr.Open30(g10.Text("sal_bs"), g10.Text("sal_no"))

        '' ctr.Open6(g10.DataSet, sal_bs.Text, g10.Text("sal_dt"), "1")


    End Sub

    'Private Sub btn_jump_Click(sender As System.Object, e As System.EventArgs)
    '    Dim TaxNo As String = g10.Text("tax_no")
    '    If TaxNo = "" Then Exit Sub
    '    Dim menuName As String = "FAC100"
    '    Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    '    ctr.Open2(TaxNo)
    'End Sub

    'Private Sub btn_jump_doc_Click(sender As System.Object, e As System.EventArgs)
    '    Dim DocNo As String = g10.Text("doc_no")
    '    If DocNo = "" Then Exit Sub
    '    Dim menuName As String
    '    menuName = "FAB116"
    '    '화면을 띄운다
    '    Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    '    If ctr IsNot Nothing Then
    '        ctr.Open2(DocNo)
    '    End If
    'End Sub

    Private Sub btn_taxprn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Report()
    End Sub


    Private Sub Report()
        Dim p As OpenParameters = New OpenParameters

        Dim cnt As Integer = g10.CheckedRows("chk")     'Check된 행의 갯수
        If cnt = 0 Then
            Exit Sub
        End If

        Dim preview As Boolean
        If cnt = 1 Then             'Check된 행이 하나이면 리포트 미리보기를 하고 아니면 바로 출력한다
            preview = True
        End If

        For i As Integer = 0 To g10.RowCount - 1
            If g10.ToBool("chk", i) Then
                p.Add("@tax_no", g10.Text("tax_no", i))


                Dim dSet = MyBase.OpenDataSet("fac100_print", p)
                PrintForm(dSet, "TEST04_ERP03") '리포트코드

                'TEST04_ERP03.ReportView.LoadView("TEST04_ERP03", "", "fac100_Print", p, , preview)
                'TEST04_ERP03.ReportView.LoadView(code, "", "fab100_print", p, , preview)     '전표출력(본사)
            End If
        Next


    End Sub

    Private Sub btn_prn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Report_doc()
    End Sub

    Private Sub Report_doc()
        Dim p As OpenParameters = New OpenParameters

        Dim cnt As Integer = g10.CheckedRows("chk")     'Check된 행의 갯수
        If cnt = 0 Then
            Exit Sub
        End If

        Dim preview As Boolean
        If cnt = 1 Then             'Check된 행이 하나이면 리포트 미리보기를 하고 아니면 바로 출력한다
            preview = True
        End If

        For i As Integer = 0 To g10.RowCount - 1
            If g10.ToBool("chk", i) Then

                p.Add("@co_cd", g10.Text("co_cd", i))
                p.Add("@div_cd", g10.Text("div_cd", i))
                p.Add("@doc_no", g10.Text("doc_no", i))
                'Dim dSet = MyBase.OpenDataSet("fac102_Print", p)
                Dim dSet = MyBase.OpenDataSet("sdd102_doc_print", p)
                PrintForm(dSet, "SDD102_D") '리포트코드


                'TEST04_ERP03.ReportView.LoadView("FAB100_1", "", "fab100_print", p, , preview)     '전표출력(본사)
                'TEST04_ERP03.ReportView.LoadView("TEST04_ERP03", "", "fac100_Print", p, , preview)
                'TEST04_ERP03.ReportView.LoadView(code, "", "fab4100_print", p, , preview)     '전표출력(본사)
            End If
        Next


    End Sub



End Class
