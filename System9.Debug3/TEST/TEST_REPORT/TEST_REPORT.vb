Imports Frame9
Imports Base9
Imports Base9.Shared
Imports Base9.Parameter
Imports DevExpress.XtraPrinting.Preview
Imports System.Data
Imports DevExpress.XtraReports.UI

Public Class TEST_REPORT

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    '    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

    '        Select Case mty

    '            Case MenuType.New

    '            Case MenuType.Save

    '            Case MenuType.Delete

    '            Case Else

    '                MyBase.MenuButton_Click(mty)

    '        End Select

    '    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Public Overrides Sub NewForm()
        Try
            MyBase.NewForm()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Public Overrides Sub Open()
        Try
            MyBase.Open()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Public Overrides Sub PrintForm()
        MyBase.PrintForm()
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################
    Public Overrides Function Save() As Boolean

        Try
            Return MyBase.Save()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function

    Private Sub EButton1_Click(sender As Object, e As EventArgs) Handles EButton1.Click

        Try

            Dim Cnt As Integer = 0
            Dim Rpt1 As Object = Nothing
            Dim p As OpenParameters = New OpenParameters

            p.Add("@app_year", "")

            Dim dSet As DataSet = MyBase.OpenDataSet("test_report_2", p)


            If Not IsEmpty(dSet) Then

                '2.데이터셋 보내기
                Rpt1 = New Report1(dSet)
                Rpt1.CreateDocument()

                Dim ReportPrintTool As New DevExpress.XtraReports.UI.ReportPrintTool(Rpt1)
                '미리보기
                ReportPrintTool.ShowPreviewDialog()
                '출력
                'ReportPrintTool.Print()
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

End Class
