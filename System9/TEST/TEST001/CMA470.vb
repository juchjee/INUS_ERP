Imports Frame9
Imports Base9
Imports Base9.Shared
Imports Base9.Subroutine

Public Class TEST001

#Region " < 화면 Load > "

    Private Sub CMA470_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.sbSetAuth()

            Me.sbInitViewCheck()

            g10.SelectRow = True

        Catch ex As Exception
            MessageInfo(ex.Message & "[CMA470_Load]")
        End Try
    End Sub

#End Region

#Region " < Load시 처리 > "

    ' 본사/현장에 따른 조회조건에 대한 처리
    Private Sub sbSetAuth()
        Try
            Dim CommFn = New CommonClass

            Dim arrObj() As Object = {site_cd}
            Dim arrData() As String = {Parameter.Login.DeptCd}
            CommFn.sbSetAuth(Parameter.Login.FldYn, arrObj, arrData)

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Sub

#End Region

#Region " < 툴바 클릭 이벤트 (공통) > "

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.sbInitViewCheck()

                MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub sbInitViewCheck()
        Try
            Me.dokub_vw.Checked = True
            Me.silhengbs_vw.Checked = True
            Me.silheng_vw.Checked = True
            Me.bimok_vw.Checked = True
        Catch ex As Exception
            MessageInfo(ex.Message & "[sbInitViewCheck]")
        End Try
    End Sub

#End Region

#Region " < Form 컨트롤 관련 함수 > "

    Private Sub dokub_vw_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles dokub_vw.CheckedChanged
        Try
            g10.ColumnVisible("dokub_qn") = Me.dokub_vw.Checked
            g10.ColumnVisible("dokub_up") = Me.dokub_vw.Checked
            g10.ColumnVisible("dokub_am") = Me.dokub_vw.Checked
        Catch ex As Exception
            MessageInfo(ex.Message & "[dokub_vw_CheckedChanged]")
        End Try
    End Sub

    Private Sub silhengbs_vw_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles silhengbs_vw.CheckedChanged
        Try
            g10.ColumnVisible("silhengbs_qn") = Me.silhengbs_vw.Checked
            g10.ColumnVisible("silhengbs_up") = Me.silhengbs_vw.Checked
            g10.ColumnVisible("silhengbs_am") = Me.silhengbs_vw.Checked

            g10.ColumnVisible("silhengbsmm_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsmm_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsla_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsla_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbssm_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbssm_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbseq_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbseq_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsfa_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsfa_am") = Me.bimok_vw.Checked

        Catch ex As Exception
            MessageInfo(ex.Message & "[silhengbs_vw_CheckedChanged]")
        End Try
    End Sub

    Private Sub silheng_vw_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles silheng_vw.CheckedChanged
        Try
            g10.ColumnVisible("silheng_qn") = Me.silheng_vw.Checked
            g10.ColumnVisible("silheng_up") = Me.silheng_vw.Checked
            g10.ColumnVisible("silheng_am") = Me.silheng_vw.Checked

            g10.ColumnVisible("silhengmm_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengmm_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengla_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengla_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengsm_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengsm_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengeq_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengeq_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengfa_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengfa_am") = Me.bimok_vw.Checked

        Catch ex As Exception
            MessageInfo(ex.Message & "[silhengbs_vw_CheckedChanged]")
        End Try
    End Sub

    Private Sub bimok_vw_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles bimok_vw.CheckedChanged
        Try
            g10.ColumnVisible("silhengbsmm_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsmm_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsla_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsla_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbssm_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbssm_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbseq_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbseq_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsfa_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengbsfa_am") = Me.bimok_vw.Checked

            g10.ColumnVisible("silhengmm_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengmm_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengla_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengla_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengsm_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengsm_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengeq_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengeq_am") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengfa_up") = Me.bimok_vw.Checked
            g10.ColumnVisible("silhengfa_am") = Me.bimok_vw.Checked
        Catch ex As Exception
            MessageInfo(ex.Message & "[bimok_vw_CheckedChanged]")
        End Try
    End Sub

#End Region

End Class