Public Class TugasHariRaya1
    'Memanggil clas mahasiswa
    Private mhs As Mahasiswa

    Private Sub TugasHariRaya1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mengisi data nim & nama ketika form di jalankan
        mhs = New Mahasiswa(120230066, "Akhmad Yazid Bustomi")
    End Sub

    Private Sub btnInputNama_Click(sender As Object, e As EventArgs) Handles btnInputNama.Click
        mhs.Nama = Me.tbNama.Text
    End Sub

    Private Sub btnAmbilNama_Click(sender As Object, e As EventArgs) Handles btnAmbilNama.Click
        MessageBox.Show("Nama : " & mhs.Nama)
    End Sub

    Private Sub btnInputNim_Click(sender As Object, e As EventArgs) Handles btnInputNim.Click
        mhs.Nim = Integer.Parse(Me.tbNim.Text)
    End Sub

    Private Sub btnAmbilNim_Click(sender As Object, e As EventArgs) Handles btnAmbilNim.Click
        MessageBox.Show("Nim : " & mhs.Nim)
    End Sub

    'Tugas ke 2 hari raya
    Dim studen As New Studen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        studen.Nim = 120230066
        MessageBox.Show("NIM : " & studen.Nim)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        studen.Name = "Akhmad Yazid Bustomi"
        MessageBox.Show("Nama : " & studen.Name)

        'Memanggil Kelas Induk
        studen.printInfo()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
End Class