Public Class Datos
    Dim ID As String

    Public Property G_Id()
        Get
            Return ID
        End Get
        Set(ByVal value)
            ID = value

        End Set
    End Property


    Public Sub New(ByVal Id As String)
        Me.ID = Id

    End Sub
    Public Sub New()

    End Sub
End Class
