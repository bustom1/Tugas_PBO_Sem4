Public Class Praktikum1
    Private Sub BtnHitungL_Click(sender As Object, e As EventArgs) Handles BtnHitungL.Click
        'Deklarasi dan memanggil clas lingkaran 
        Dim objLingkaran As New lingkaran

        'jika textbox jari-jari kosong, maka menampilkan pesan di bawah, jika tidak maka langsung di hitung
        If tbJariLingkaran.Text = "" Then
            MessageBox.Show("Lengkapi dulu jari-jari", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            With objLingkaran
                .jari_jari = tbJariLingkaran.Text
                tbLlingkaran.Text = .luas_lingkaran
                tbKlingkaran.Text = .keliling_lingkaran
            End With
        End If
    End Sub

    Private Sub BtnClearL_Click(sender As Object, e As EventArgs) Handles BtnClearL.Click
        'jika button clear di klik, maka akan menghasilkan text di bawah ini (kosong)
        tbJariLingkaran.Text = ""
        tbLlingkaran.Text = "    0"
        tbKlingkaran.Text = "    0"
    End Sub

    Private Sub BtnHitungT_Click(sender As Object, e As EventArgs) Handles BtnHitungT.Click
        'Deklarasi dan memanggil clas tabung 
        Dim objTabung As New tabung

        'jika salah satu kolom jari-jari tabung atau tinggi tabung kosong, maka menampilkan pesan
        If tbTinggiT.Text = "" Or tbJariT.Text = "" Then
            MessageBox.Show("Isi semua data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            With objTabung
                .tinggi = tbTinggiT.Text
                .jari_jari = tbJariT.Text
                tbVolumeT.Text = .volume_tabung
            End With
        End If
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub BtnClearT_Click(sender As Object, e As EventArgs) Handles BtnClearT.Click
        tbVolumeT.Text = "    0"
        tbJariT.Text = ""
        tbTinggiT.Text = ""
    End Sub
End Class

'Membuat class untuk lingkaran
Public Class lingkaran
    'Deklarasi Variable
    Public jari_jari As Single
    Const phi = 3.14

    'Membuat function menghitung luas lingkaran 
    Public Function luas_lingkaran() As Double
        Return phi * jari_jari * jari_jari
    End Function

    'Membuat function menghitung keliling lingkaran
    Public Function keliling_lingkaran() As Double
        Return 2 * phi * jari_jari
    End Function

End Class

'Membuat Class untuk tabung
Public Class tabung
    'Deklarasi Variable
    Public tinggi As Single
    Public jari_jari As Single
    Const phi = 3.14

    'Membuat Function menghitung volume tabung
    Public Function volume_tabung() As Double
        Return phi * jari_jari * jari_jari * tinggi
    End Function
End Class