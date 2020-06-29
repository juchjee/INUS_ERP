Imports System.Windows.Forms

'Imports System9.MainForm
'Imports Base9


Friend NotInheritable Class Program

    Private Sub New()
    End Sub

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread>
    Shared Sub Main(ByVal arguments() As String)
        'AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf CurrentDomain_AssemblyResolve
        'AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim frm As MainForm = New System9.MainForm()
        '개발자 프로그램 테스트용: True 이면 로긴창이 안 보이고 로긴되어 개발시간을 단축할 수 있다

        If arguments.Length > 0 Then frm.LoginID = arguments(0)
        If arguments.Length > 1 Then frm.LoginPWD = arguments(1)

        frm.HideLoginForm = True
        frm.HideStartForm = True
        System.Windows.Forms.Application.Run(frm)


        '아래 와 위가 같음
        ''프로그램 테스트용: True 이면 로긴창이 안 보인다
        ''                 : True 이면 로긴창이 안 보인다
        'Parameter.System.HideLoginForm = True
        'Parameter.System.HideStartForm = True
        'Parameter.System.HideLoginForm = False
        'Parameter.System.HideStartForm = False
        'Application.Run(New MainForm())

    End Sub

    'Shared Function CurrentDomain_AssemblyResolve(ByVal sender As Object, args As ResolveEventArgs) As System.Reflection.Assembly

    '    MsgBox(args.Name)
    '    Return Nothing

    'End Function





    '{
    '    return EmbeddedAssembly.Get(args.Name);
    '}
End Class
