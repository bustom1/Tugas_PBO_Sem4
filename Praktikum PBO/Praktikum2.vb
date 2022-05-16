Public Class Praktikum2
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        'Deklarasi Variable
        Dim data As New AnggoaSeles
        Dim tulis As String

        Try
            data.nama = Me.tbNama.Text
            data.sales = Decimal.Parse(Me.tbJmlPenjualan.Text)
            data.bonus = data.sales * 0.05
            tulis = "Nama Penjual : " + data.nama + " Jumlah Penjualan " + CStr(data.sales) + Chr(13) + Chr(13) + " Bonus " + CStr(data.bonus)
            MessageBox.Show(tulis, "Pesan", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unlimited", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kosong()
        End Try
    End Sub

    Function kosong()
        tbJmlPenjualan.Text = ""
        tbNama.Text = ""
    End Function
End Class

Public Class AnggoaSeles
    Public nama As String
    Public sales As String
    Public bonus As String
End Class