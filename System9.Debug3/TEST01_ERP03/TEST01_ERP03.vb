Imports Frame9
Imports Base9
Imports Base9.Shared

Public Class TEST01_ERP03
    Private Sub TEST01_ERP03_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Open("test01_erp03_g10")
    End Sub

    Private Sub EButton1_Click(sender As Object, e As EventArgs) Handles EButton1.Click
        [FTPShared].FileDownLoad("43c74e10-fa1b-46fe-88ae-5dbe08ff73e2", "½ºÅ©¸°¼¦(1).png", , True, "HRA100")
    End Sub
End Class
