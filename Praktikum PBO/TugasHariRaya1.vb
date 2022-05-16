Public Class TugasHariRaya1
    'Memanggil clas mahasiswa
    Private mhs As Mahasiswa

    Private Sub TugasHariRaya1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class