Imports System
Imports System.Windows.Forms

Namespace AlterEgo
    Friend Class EnterTextBox
        Inherits TextBox
        ' Methods
        Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean
            Return ((keyData = Keys.Enter) OrElse MyBase.IsInputKey(keyData))
        End Function

    End Class
End Namespace

