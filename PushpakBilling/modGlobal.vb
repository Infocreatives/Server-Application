Module modGlobal
    Friend Const ServerDetails As String = "server=184.168.194.55;database=pushpaktraders;user id=dbUserPlesk;password=qwxn9040;"
    Public Function FloatKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then
            FloatKey = False
        Else
            FloatKey = True
        End If
    End Function
    Public Function RestrictKey(ByVal KCode As String) As Boolean
        If KCode = 126 Or KCode = 124 Or KCode = 36 Or KCode = 94 Then
            RestrictKey = True
        Else
            RestrictKey = False
        End If
    End Function
    Public Function NumericKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            NumericKey = False
        Else
            NumericKey = True
        End If
    End Function
    Friend Function CheckInternetConnection() As Boolean
        Return InternetGetConnectedState(lngFlags, 0)
    End Function
    Friend Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef lpSFlags As Int32, ByVal dwReserved As Int32) As Boolean
    Friend lngFlags As Long
    Friend Sub InterNetError()
        MessageBox.Show("Please check your internet connection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Module
