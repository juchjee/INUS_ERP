Imports Frame9
Imports Base9
Imports Base9.Shared
Imports System.Data
Imports DevExpress.XtraPrinting.Preview

Public Class TEST_JCY_ASA213
    Private Sub Form_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim barManager As New PrintBarManager()
        barManager.Form = PrintControl1
        barManager.Initialize(PrintControl1)

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open
                If cust_cd.Text <> "" Then custcd.Text = cust_cd.Text
                Me.Open("test_jcy_asa213_g10")

            Case MenuType.Print

                Print_g10(cust_cd.Text, drv_no.Text)

                'Dim p As OpenParameters = New OpenParameters
                'p.Add("@bs_cd", bs_cd.Text)
                'p.Add("@fr_dt", fr_dt.Text)
                'p.Add("@to_dt", to_dt.Text)
                'p.Add("@cust_cd", cust_cd.Text)
                'p.Add("@drv_no", drv_no.Text)
                'p.Add("@as_no", "")

                ''TEST_JCY_ASA2131.ReportView.LoadView("TEST_JCY_ASA2131", "", "ASA213_print", p, CrystalReportViewer, True)

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub Print_g10(CustCd As String, DrvNo As String, Optional AsNo As String = "")
        Dim Rpt1 As Object = Nothing
        Try
            Dim p As OpenParameters = New OpenParameters
            p.Add("@bs_cd", bs_cd.Text)
            p.Add("@fr_dt", fr_dt.Text)
            p.Add("@to_dt", to_dt.Text)
            p.Add("@cust_cd", CustCd)
            p.Add("@drv_no", DrvNo)
            p.Add("@as_no", AsNo)

            Dim dSet1 As DataSet = OpenDataSet("test_jcy_asa213_print", p)       ' SP명, SP적용할 P(판넬명) p 판넬에 sp 실행해 값 넣어라!? 
            'PrintForm(dSet1, "TEST_JCY_ASA2131") '리포트코드
            'TEST_JCY_ASA2131.ReportView.LoadView("TEST_JCY_ASA2131", "", "ASA213_print", p, CrystalReportViewer, True)
            If IsEmpty(dSet1) Then
                MessageInfo("출력할 자료가 없습니다.")
                Exit Sub
            End If
            Rpt1 = New ASA213R(dSet1)   '리포트 형식은 ASA213R            입력된 정보로 sp  호출 해서 sp에 select 된 결과를 ASA213R에 붙이는데 어떤항목이 무슨 값인지 어떻게 알고 매치를 시켜주지??
            PrintControl1.PrintingSystem = Rpt1.PrintingSystem
            Rpt1.CreateDocument()       ' 값 입력된 상태로 문서 생성
        Catch ex As Exception
            MessageError(ex.Message)
        End Try

    End Sub

    Private Shared Function ReportView() As Object
        Throw New NotImplementedException
    End Function

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Me.Print_g10(g10.Text("cust_cd"), g10.Text("drv_no"), g10.Text("as_no"))
        Print_g10(cust_cd.Text, drv_no.Text)
    End Sub

    Private Sub EButton1_Click(sender As Object, e As EventArgs) Handles EButton1.Click
        'Me.Print_g10(g10.Text("cust_cd"), g10.Text("drv_no"), g10.Text("as_no"))
        Me.Print_g10(g10.Text(), g10.Text(), g10.Text("as_no"))
        '  Print_g10(cust_cd.Text, drv_no.Text)
    End Sub
End Class
