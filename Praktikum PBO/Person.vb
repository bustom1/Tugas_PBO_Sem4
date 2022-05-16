Public Class Person

    Private strName$

    Sub New()
        strName = "Siapa Saja Boleh"
    End Sub

    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(value As String)
            strName = value
        End Set
    End Property

    Public Sub printInfo()
        MessageBox.Show("Memanggil Objek", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
