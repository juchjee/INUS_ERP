Imports Frame9
Imports Base9
Imports Base9.Shared

Public Class TEST02_ERP03

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

    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

End Class
