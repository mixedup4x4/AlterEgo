Imports AlterEgo
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace AlterEgo.My
    <StandardModule, HideModuleName, GeneratedCode("MyTemplate", "8.0.0.0")> _
    Friend NotInheritable Class MyProject
        ' Properties
        <HelpKeyword("My.Application")> _
        Friend Shared ReadOnly Property Application As MyApplication
            <DebuggerHidden> _
            Get
                Return MyProject.m_AppObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.Computer")> _
        Friend Shared ReadOnly Property Computer As MyComputer
            <DebuggerHidden> _
            Get
                Return MyProject.m_ComputerObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.Forms")> _
        Friend Shared ReadOnly Property Forms As MyForms
            <DebuggerHidden> _
            Get
                Return MyProject.m_MyFormsObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.User")> _
        Friend Shared ReadOnly Property User As User
            <DebuggerHidden> _
            Get
                Return MyProject.m_UserObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.WebServices")> _
        Friend Shared ReadOnly Property WebServices As MyWebServices
            <DebuggerHidden> _
            Get
                Return MyProject.m_MyWebServicesObjectProvider.GetInstance
            End Get
        End Property


        ' Fields
        Private Shared ReadOnly m_AppObjectProvider As ThreadSafeObjectProvider(Of MyApplication) = New ThreadSafeObjectProvider(Of MyApplication)
        Private Shared ReadOnly m_ComputerObjectProvider As ThreadSafeObjectProvider(Of MyComputer) = New ThreadSafeObjectProvider(Of MyComputer)
        Private Shared m_MyFormsObjectProvider As ThreadSafeObjectProvider(Of MyForms) = New ThreadSafeObjectProvider(Of MyForms)
        Private Shared ReadOnly m_MyWebServicesObjectProvider As ThreadSafeObjectProvider(Of MyWebServices) = New ThreadSafeObjectProvider(Of MyWebServices)
        Private Shared ReadOnly m_UserObjectProvider As ThreadSafeObjectProvider(Of User) = New ThreadSafeObjectProvider(Of User)

        ' Nested Types
        <MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)> _
        Friend NotInheritable Class MyForms
            ' Methods
            <DebuggerHidden> _
            Private Shared Function Create__Instance__(Of T As { Form, New })(ByVal Instance As T) As T
                Dim local As T
                If ((Not Instance Is Nothing) AndAlso Not Instance.IsDisposed) Then
                    Return Instance
                End If
                If (Not MyForms.m_FormBeingCreated Is Nothing) Then
                    If MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
                        Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(0  - 1) {}))
                    End If
                Else
                    MyForms.m_FormBeingCreated = New Hashtable
                End If
                MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
                Try 
                    local = Activator.CreateInstance(Of T)
                Catch obj1 As Object When (?)
                    Dim exception As TargetInvocationException
                    Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { exception.InnerException.Message }), exception.InnerException)
                Finally
                    MyForms.m_FormBeingCreated.Remove(GetType(T))
                End Try
                Return local
            End Function

            <DebuggerHidden> _
            Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
                instance.Dispose
                instance = CType(Nothing, T)
            End Sub

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function Equals(ByVal o As Object) As Boolean
                Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Friend Function [GetType]() As Type
                Return GetType(MyForms)
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function ToString() As String
                Return MyBase.ToString
            End Function


            ' Properties
            Public Property frmAdminTK As frmAdminTK
                Get
                    Me.m_frmAdminTK = MyForms.Create__Instance__(Of frmAdminTK)(Me.m_frmAdminTK)
                    Return Me.m_frmAdminTK
                End Get
                Set(ByVal Value As frmAdminTK)
                    If (Not Value Is Me.m_frmAdminTK) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmAdminTK)(Me.m_frmAdminTK)
                    End If
                End Set
            End Property

            Public Property frmBatchResults As frmBatchResults
                Get
                    Me.m_frmBatchResults = MyForms.Create__Instance__(Of frmBatchResults)(Me.m_frmBatchResults)
                    Return Me.m_frmBatchResults
                End Get
                Set(ByVal Value As frmBatchResults)
                    If (Not Value Is Me.m_frmBatchResults) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmBatchResults)(Me.m_frmBatchResults)
                    End If
                End Set
            End Property

            Public Property frmChangePW As frmChangePW
                Get
                    Me.m_frmChangePW = MyForms.Create__Instance__(Of frmChangePW)(Me.m_frmChangePW)
                    Return Me.m_frmChangePW
                End Get
                Set(ByVal Value As frmChangePW)
                    If (Not Value Is Me.m_frmChangePW) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmChangePW)(Me.m_frmChangePW)
                    End If
                End Set
            End Property

            Public Property frmChangePWSingle As frmChangePWSingle
                Get
                    Me.m_frmChangePWSingle = MyForms.Create__Instance__(Of frmChangePWSingle)(Me.m_frmChangePWSingle)
                    Return Me.m_frmChangePWSingle
                End Get
                Set(ByVal Value As frmChangePWSingle)
                    If (Not Value Is Me.m_frmChangePWSingle) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmChangePWSingle)(Me.m_frmChangePWSingle)
                    End If
                End Set
            End Property

            Public Property frmCommandeer As frmCommandeer
                Get
                    Me.m_frmCommandeer = MyForms.Create__Instance__(Of frmCommandeer)(Me.m_frmCommandeer)
                    Return Me.m_frmCommandeer
                End Get
                Set(ByVal Value As frmCommandeer)
                    If (Not Value Is Me.m_frmCommandeer) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmCommandeer)(Me.m_frmCommandeer)
                    End If
                End Set
            End Property

            Public Property frmCool As frmCool
                Get
                    Me.m_frmCool = MyForms.Create__Instance__(Of frmCool)(Me.m_frmCool)
                    Return Me.m_frmCool
                End Get
                Set(ByVal Value As frmCool)
                    If (Not Value Is Me.m_frmCool) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmCool)(Me.m_frmCool)
                    End If
                End Set
            End Property

            Public Property frmIconChange As frmIconChange
                Get
                    Me.m_frmIconChange = MyForms.Create__Instance__(Of frmIconChange)(Me.m_frmIconChange)
                    Return Me.m_frmIconChange
                End Get
                Set(ByVal Value As frmIconChange)
                    If (Not Value Is Me.m_frmIconChange) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmIconChange)(Me.m_frmIconChange)
                    End If
                End Set
            End Property

            Public Property frmNag As frmNag
                Get
                    Me.m_frmNag = MyForms.Create__Instance__(Of frmNag)(Me.m_frmNag)
                    Return Me.m_frmNag
                End Get
                Set(ByVal Value As frmNag)
                    If (Not Value Is Me.m_frmNag) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmNag)(Me.m_frmNag)
                    End If
                End Set
            End Property

            Public Property frmNetworkInfo As frmNetworkInfo
                Get
                    Me.m_frmNetworkInfo = MyForms.Create__Instance__(Of frmNetworkInfo)(Me.m_frmNetworkInfo)
                    Return Me.m_frmNetworkInfo
                End Get
                Set(ByVal Value As frmNetworkInfo)
                    If (Not Value Is Me.m_frmNetworkInfo) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmNetworkInfo)(Me.m_frmNetworkInfo)
                    End If
                End Set
            End Property

            Public Property frmRegister As frmRegister
                Get
                    Me.m_frmRegister = MyForms.Create__Instance__(Of frmRegister)(Me.m_frmRegister)
                    Return Me.m_frmRegister
                End Get
                Set(ByVal Value As frmRegister)
                    If (Not Value Is Me.m_frmRegister) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmRegister)(Me.m_frmRegister)
                    End If
                End Set
            End Property

            Public Property frmRun As frmRun
                Get
                    Me.m_frmRun = MyForms.Create__Instance__(Of frmRun)(Me.m_frmRun)
                    Return Me.m_frmRun
                End Get
                Set(ByVal Value As frmRun)
                    If (Not Value Is Me.m_frmRun) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmRun)(Me.m_frmRun)
                    End If
                End Set
            End Property

            Public Property frmSettings As frmSettings
                Get
                    Me.m_frmSettings = MyForms.Create__Instance__(Of frmSettings)(Me.m_frmSettings)
                    Return Me.m_frmSettings
                End Get
                Set(ByVal Value As frmSettings)
                    If (Not Value Is Me.m_frmSettings) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmSettings)(Me.m_frmSettings)
                    End If
                End Set
            End Property

            Public Property frmSplash As frmSplash
                Get
                    Me.m_frmSplash = MyForms.Create__Instance__(Of frmSplash)(Me.m_frmSplash)
                    Return Me.m_frmSplash
                End Get
                Set(ByVal Value As frmSplash)
                    If (Not Value Is Me.m_frmSplash) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmSplash)(Me.m_frmSplash)
                    End If
                End Set
            End Property

            Public Property frmTreeMenu As frmTreeMenu
                Get
                    Me.m_frmTreeMenu = MyForms.Create__Instance__(Of frmTreeMenu)(Me.m_frmTreeMenu)
                    Return Me.m_frmTreeMenu
                End Get
                Set(ByVal Value As frmTreeMenu)
                    If (Not Value Is Me.m_frmTreeMenu) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of frmTreeMenu)(Me.m_frmTreeMenu)
                    End If
                End Set
            End Property


            ' Fields
            <ThreadStatic> _
            Private Shared m_FormBeingCreated As Hashtable
            Public m_frmAdminTK As frmAdminTK
            Public m_frmBatchResults As frmBatchResults
            Public m_frmChangePW As frmChangePW
            Public m_frmChangePWSingle As frmChangePWSingle
            Public m_frmCommandeer As frmCommandeer
            Public m_frmCool As frmCool
            Public m_frmIconChange As frmIconChange
            Public m_frmNag As frmNag
            Public m_frmNetworkInfo As frmNetworkInfo
            Public m_frmRegister As frmRegister
            Public m_frmRun As frmRun
            Public m_frmSettings As frmSettings
            Public m_frmSplash As frmSplash
            Public m_frmTreeMenu As frmTreeMenu
        End Class

        <MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)> _
        Friend NotInheritable Class MyWebServices
            ' Methods
            <DebuggerHidden> _
            Private Shared Function Create__Instance__(Of T As New)(ByVal instance As T) As T
                If (instance Is Nothing) Then
                    Return Activator.CreateInstance(Of T)
                End If
                Return instance
            End Function

            <DebuggerHidden> _
            Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
                instance = CType(Nothing, T)
            End Sub

            <DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function Equals(ByVal o As Object) As Boolean
                Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
            End Function

            <EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden> _
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode
            End Function

            <EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden> _
            Friend Function [GetType]() As Type
                Return GetType(MyWebServices)
            End Function

            <EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden> _
            Public Overrides Function ToString() As String
                Return MyBase.ToString
            End Function

        End Class

        <EditorBrowsable(EditorBrowsableState.Never), ComVisible(False)> _
        Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
            ' Properties
            Friend ReadOnly Property GetInstance As T
                <DebuggerHidden> _
                Get
                    If (ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing) Then
                        ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)
                    End If
                    Return ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
                End Get
            End Property


            ' Fields
            <ThreadStatic, CompilerGenerated> _
            Private Shared m_ThreadStaticValue As T
        End Class
    End Class
End Namespace

