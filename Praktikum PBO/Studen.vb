Public Class Studen
    Inherits Person
    Private mNim As Integer

    Property Nim() As Integer
        Get
            Return mNim
        End Get
        Set(value As Integer)
            mNim = value
        End Set
    End Property
End Class
