Imports System.Data
Imports DevExpress.XtraReports.UI

Public Class TEST_REPORTR
    Dim FIRST_PAGE As Integer = 1
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal dSet As DataSet)
        InitializeComponent()
        Me.SetDateSet(dSet)
    End Sub

    Public Sub SetDateSet(ByVal dSet As DataSet)

        Me.DataSource = dSet

        title.DataBindings.Add("Text", dSet.Tables(1), "title")
        cust_nm.DataBindings.Add("Text", dSet.Tables(1), "cust_nm")
        nm.DataBindings.Add("Text", dSet.Tables(1), "nm")

        po_sq.DataBindings.Add("Text", dSet.Tables(0), "po_sq")
        itm_cd.DataBindings.Add("Text", dSet.Tables(0), "itm_cd")
        itm_nm.DataBindings.Add("Text", dSet.Tables(0), "itm_nm")

        rmks.DataBindings.Add("Text", dSet.Tables(0), "rmks")


        po_sq.DataBindings.Add("Text", dSet.Tables(0), "po_sq", "{0:#,#,###}")
        po_up.DataBindings.Add("Text", dSet.Tables(0), "po_up", "{0:#,#,###}")
        po_amt.DataBindings.Add("Text", dSet.Tables(0), "po_amt", "{0:#,#,###}")

        sum_amt.Text = String.Format("{0:#,#,###}", dSet.Tables(0).Compute("sum(po_amt)", String.Empty))

        '##########################################################################################
        ' 1. Tables.Count > 1 ��� Table(0)�� Detail Report���� ���ȴ�.
        ' DataSet ���ε�
        '   ���ڿ� 
        '          ObjName.DataBindings.Add("Text", dSet.Tables(0), "column_name") -- ���ڿ�  텍스트 박스 이름 ..   컬럼명...detail영역은 table(0)로 본다.  나머지 table 1번 영역은 footter또는 다른 영억으로 지정한다.

        '   ���ڿ� 
        '          ObjName.DataBindings.Add("Text", dSet.Tables(0), "column_name", "{0:#,#,###}")  ' 숫자를 지정..  숫자 포멧도 지정.
        '     �հ�
        '          ObjName.Text = String.Format("{0:#,#,###}", dSet.Tables(0).Compute("sum(column_name)", String.Empty)) ' Compute 기능.

        '   ���� ImageBinding(dSet.Tables(0), ObjName, "column_name")
        '##########################################################################################

        'Export FileName
        'Me.ExportOptions.PrintPreview.DefaultFileName = "File Name"

    End Sub

    Private Sub ImageBinding(ByVal dTable As DataTable, ByVal PictureBoxControl As DevExpress.XtraReports.UI.XRPictureBox, ByVal ImageField As String)
        If IsDBNull(dTable.Rows(0)(ImageField)) Then
            PictureBoxControl.Image = Nothing
        Else
            Dim photo() As Byte = dTable.Rows(0)(ImageField)
            Dim ms As New System.IO.MemoryStream(photo)
            PictureBoxControl.Image = New Bitmap(ms)
            PictureBoxControl.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze '����ǥ�����
        End If
    End Sub

    'Group_Header�� ù��° Page�� ����ϵ��� ó��
    'Private Sub GroupHeader_Main_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader_Main.BeforePrint
    '    If FIRST_PAGE > 1 Then
    '        e.Cancel = True
    '    End If
    '    FIRST_PAGE += 1
    'End Sub
End Class