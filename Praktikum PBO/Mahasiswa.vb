Public Class Mahasiswa
    'Membuat Variable Nama & Nim
    Private mNama As String
    Private mNim As Integer

    'Konstruktor
    Sub New(ByVal Nim As Integer, ByVal Nama As String)
        Me.mNama = Nama
        Me.mNim = Nim
        'Menampilkan Message
        Console.WriteLine("Memanggil Konstruktor")
    End Sub

    'Property Nim, Stter / Getter
    Public Property Nim() As Integer
        Get
            Return mNim
        End Get
        Set(value As Integer)
            mNama = value
        End Set
    End Property

    'Property Nama, Stter / Getter
    Public Property Nama() As String
        Get
            Return mNama
        End Get
        Set(value As String)
            mNama = value
        End Set
    End Property

End Class
