Imports Frame9
Imports Base9
Imports Base9.Shared

Public Class TEST03_ERP03
    Private arr(1, 0) As String
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g10.Focus()
        Init_Form()
    End Sub

    Public Sub Init_Form()

        If CheckRequired(std_year) = False Then Exit Sub
        '1. 컬럼배열을 만든다
        Dim frDt As Date = std_year.Text & "-01-01"
        Dim toDt As Date = std_year.Text & "-12-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt)
        Dim colNm As String
        For i = 0 To cnt
            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")

            ReDim Preserve arr(1, i)                'Array를 증가시킨다
            arr(0, i) = colNm                       'Key     -> { 2011-01, 2011-02, 2011-03,,,,, }
            arr(1, i) = (i + 1).ToString + "월"     'Title   -> { 1월, 2월, 3월,,,, }
        Next

        g10.InsertArrayColumns(arr)
        '-------+-----+----+-----+-----+-------
        '  …   | 1월 | 2월 | 3월 | 4월 | …       <- Array 컬럼들이 DetailData 컬럼들로 Display
        '-------+-----+----+-----+-----+-------
        ' ex) g10.InsertArrayColumns(arr)
        ' - Array를 DetailData 컬럼들로 Display 
        ' - 마지막 DetailData 로 정의된 컬럼이후에 Arry Band들이 삽입된다, 
        '       마지막 컬럼의 순서를 조정하여 행삽입 위치조정 가능

        Me.Open()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub menubutton_click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New

            Case MenuType.Open
                Init_Form()

            Case MenuType.Save
                Save_Form()

            Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        Try
            If CheckRequired(std_year) = False Then Return False
            If Me.Save() Then
                Init_Form()
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function

    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub G10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName.Substring(0, 4) = std_year.Text Then
            SumCol()
        End If
    End Sub

    Private Sub SumCol()
        Dim SumQty As Double = 0
        For Col As Integer = 0 To 11
            SumQty += g10.ToDec(arr(0, Col))
        Next
        g10.Text("sum_qty") = SumQty
    End Sub
End Class
