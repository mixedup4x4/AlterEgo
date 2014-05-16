Imports System
Imports System.Windows.Forms

Namespace AlterEgo
    Friend Class EnterComboBox
        Inherits ComboBox
        ' Methods
        Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean
            Return ((keyData = Keys.Enter) OrElse MyBase.IsInputKey(keyData))
        End Function

    End Class
End Namespace

