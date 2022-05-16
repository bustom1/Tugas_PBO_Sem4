Public Class tbTunjanganTetap

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub


    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim objPegawai As New pegawai
        Dim objPegawaiTetap As New PegawaiTetap
        Dim objPegawaiHonorer As New PegawaiHonorer

        With objPegawai
            .NIP = tbNip.Text
            .Nama = tbNamaPegawai.Text
            .Alamat = tbAlamat.Text
            .Status = cmbStatus.Text
            .Jabatan = cmbJabatan.Text
            If cmbJabatan.Text = "" Or cmbStatus.Text = "" Or tbNip.Text = "" Or tbNamaPegawai.Text = "" Or tbAlamat.Text = "" Then
                MessageBox.Show("Lengkapi Semua Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If cmbJabatan.Text = "Direktur" Then
                    tbGajiPokok.Text = "700000"

                ElseIf cmbJabatan.Text = "Manager" Then
                    tbGajiPokok.Text = "350000"

                ElseIf cmbJabatan.Text = "Staff" Then
                    tbGajiPokok.Text = "150000"

                ElseIf cmbJabatan.Text = "Pegawai" Then
                    tbGajiPokok.Text = "100000"
                End If

                If cmbStatus.Text = "Tetap" Then
                    With objPegawaiTetap
                        .Gapok = tbGajiPokok.Text
                        tbTnjTtp.Text = 2 * tbGajiPokok.Text
                        .mTunjanganTetap = tbTnjTtp.Text
                        tbTunjanganTransport.Text = 0
                        tbTotalGaji.Text = .HitungGajiTetap(.mGapok, .mTunjanganTetap)
                    End With

                ElseIf cmbStatus.Text = "Honorer" Then
                    With objPegawaiHonorer
                        .Gapok = tbGajiPokok.Text
                        tbTnjTtp.Text = 0
                        tbTunjanganTransport.Text = 25 * 15000
                        .mTunjanganTransport = tbTunjanganTransport.Text
                        tbTotalGaji.Text = .HitungGajiHonorer(.mGapok, .mTunjanganTransport)
                    End With
                End If
            End If

            
        End With
    End Sub
End Class

Public Class pegawai
    Public mNip$
    Public mNama$
    Public mAlamat$
    Public mStatus$
    Public mJabatan$
    Public mGapok$

    Public Property NIP() As String
        Get
            Return mNip
        End Get
        Set(value As String)
            mNip = value
        End Set
    End Property

    Public Property Nama() As String
        Get
            Return mNama
        End Get
        Set(value As String)
            mNama = value
        End Set
    End Property

    Public Property Alamat() As String
        Get
            Return mAlamat
        End Get
        Set(value As String)
            mAlamat = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return mStatus
        End Get
        Set(value As String)
            mStatus = value
        End Set
    End Property

    Public Property Gapok() As String
        Get
            Return mGapok
        End Get
        Set(value As String)
            mGapok = value
        End Set
    End Property

    Public Property Jabatan() As String
        Get
            Return mJabatan
        End Get
        Set(value As String)
            mJabatan = value
        End Set
    End Property

    Public Function HitungGaji(ByVal mGapok As Integer) As Long
        Return mGapok
    End Function
End Class

Public Class PegawaiTetap
    Inherits pegawai
    Public mTunjanganTetap As Integer

    Public Property TunjanganTetap() As Integer
        Get
            Return mTunjanganTetap
        End Get
        Set(value As Integer)
            mTunjanganTetap = value
        End Set
    End Property

    Public Function HitungGajiTetap(ByVal mGapok As Integer, ByVal mTunjanganTetap As Integer) As Long
        Return mGapok + mTunjanganTetap
    End Function
End Class

Public Class PegawaiHonorer
    Inherits pegawai
    Public mTunjanganTransport As Integer

    Public Property TunjanganTrnasport() As Integer
        Get
            Return mTunjanganTransport
        End Get
        Set(value As Integer)
            mTunjanganTransport = value
        End Set
    End Property

    Public Function HitungGajiHonorer(ByVal mGapok As Integer, ByVal mTunjanganTransport As Integer) As Long
        Return mGapok + mTunjanganTransport
    End Function
End Class