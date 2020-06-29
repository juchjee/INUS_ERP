Public Class Report1
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

        BsNm.DataBindings.Add("Text", dSet.Tables(0), "BsNm")
        cust_cd.DataBindings.Add("Text", dSet.Tables(0), "cust_cd")
        cust_nm.DataBindings.Add("Text", dSet.Tables(0), "cust_nm")
        itm_cd.DataBindings.Add("Text", dSet.Tables(0), "itm_cd")
        itm_nm.DataBindings.Add("Text", dSet.Tables(0), "itm_nm")
        spec.DataBindings.Add("Text", dSet.Tables(0), "spec")

        in_dt.DataBindings.Add("Text", dSet.Tables(0), "in_dt")
        um_bc.DataBindings.Add("Text", dSet.Tables(0), "um_bc")

        'in_qty.DataBindings.Add("Text", dSet.Tables(0), "in_qty")
        'in_up.DataBindings.Add("Text", dSet.Tables(0), "in_up")
        'in_amt.DataBindings.Add("Text", dSet.Tables(0), "in_amt")


        in_qty.DataBindings.Add("Text", dSet.Tables(0), "in_qty", "{0:#,#,###}")
        in_up.DataBindings.Add("Text", dSet.Tables(0), "in_up", "{0:#,#,###}")
        in_amt.DataBindings.Add("Text", dSet.Tables(0), "in_amt", "{0:#,#,###}")


        'po_sq.DataBindings.Add("Text", dSet.Tables(0), "po_sq", "{0:#,#,###}")
        'po_up.DataBindings.Add("Text", dSet.Tables(0), "po_up", "{0:#,#,###}")
        in_amt.DataBindings.Add("Text", dSet.Tables(0), "in_amt", "{0:#,#,###}")

        sum_amt.Text = String.Format("{0:#,#,###}", dSet.Tables(0).Compute("sum(in_amt)", String.Empty))

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
End Class