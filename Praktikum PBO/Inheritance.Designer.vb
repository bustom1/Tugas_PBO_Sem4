<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tbTunjanganTetap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbNip = New System.Windows.Forms.TextBox()
        Me.tbNamaPegawai = New System.Windows.Forms.TextBox()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.tbGajiPokok = New System.Windows.Forms.TextBox()
        Me.tbTnjTtp = New System.Windows.Forms.TextBox()
        Me.tbTunjanganTransport = New System.Windows.Forms.TextBox()
        Me.tbTotalGaji = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbJabatan = New System.Windows.Forms.ComboBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Pegawai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jabatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Gaji Pokok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tunjangan Tetap"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tunjangan Transport"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 455)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total Gaji"
        '
        'tbNip
        '
        Me.tbNip.Location = New System.Drawing.Point(203, 33)
        Me.tbNip.Name = "tbNip"
        Me.tbNip.Size = New System.Drawing.Size(228, 20)
        Me.tbNip.TabIndex = 1
        '
        'tbNamaPegawai
        '
        Me.tbNamaPegawai.Location = New System.Drawing.Point(203, 84)
        Me.tbNamaPegawai.Name = "tbNamaPegawai"
        Me.tbNamaPegawai.Size = New System.Drawing.Size(228, 20)
        Me.tbNamaPegawai.TabIndex = 1
        '
        'tbAlamat
        '
        Me.tbAlamat.Location = New System.Drawing.Point(203, 135)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(228, 20)
        Me.tbAlamat.TabIndex = 1
        '
        'tbGajiPokok
        '
        Me.tbGajiPokok.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbGajiPokok.Cursor = System.Windows.Forms.Cursors.No
        Me.tbGajiPokok.Location = New System.Drawing.Point(203, 291)
        Me.tbGajiPokok.Name = "tbGajiPokok"
        Me.tbGajiPokok.ReadOnly = True
        Me.tbGajiPokok.Size = New System.Drawing.Size(228, 20)
        Me.tbGajiPokok.TabIndex = 1
        '
        'tbTnjTtp
        '
        Me.tbTnjTtp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTnjTtp.Cursor = System.Windows.Forms.Cursors.No
        Me.tbTnjTtp.Location = New System.Drawing.Point(203, 347)
        Me.tbTnjTtp.Name = "tbTnjTtp"
        Me.tbTnjTtp.ReadOnly = True
        Me.tbTnjTtp.Size = New System.Drawing.Size(228, 20)
        Me.tbTnjTtp.TabIndex = 1
        '
        'tbTunjanganTransport
        '
        Me.tbTunjanganTransport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTunjanganTransport.Cursor = System.Windows.Forms.Cursors.No
        Me.tbTunjanganTransport.Location = New System.Drawing.Point(203, 401)
        Me.tbTunjanganTransport.Name = "tbTunjanganTransport"
        Me.tbTunjanganTransport.ReadOnly = True
        Me.tbTunjanganTransport.Size = New System.Drawing.Size(228, 20)
        Me.tbTunjanganTransport.TabIndex = 1
        '
        'tbTotalGaji
        '
        Me.tbTotalGaji.BackColor = System.Drawing.Color.PaleGreen
        Me.tbTotalGaji.Cursor = System.Windows.Forms.Cursors.No
        Me.tbTotalGaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalGaji.Location = New System.Drawing.Point(203, 455)
        Me.tbTotalGaji.Name = "tbTotalGaji"
        Me.tbTotalGaji.ReadOnly = True
        Me.tbTotalGaji.Size = New System.Drawing.Size(228, 23)
        Me.tbTotalGaji.TabIndex = 1
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Honorer", "Tetap"})
        Me.cmbStatus.Location = New System.Drawing.Point(203, 187)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(228, 21)
        Me.cmbStatus.TabIndex = 2
        '
        'cmbJabatan
        '
        Me.cmbJabatan.FormattingEnabled = True
        Me.cmbJabatan.Items.AddRange(New Object() {"Direktur", "Manager", "Staff", "Pegawai"})
        Me.cmbJabatan.Location = New System.Drawing.Point(203, 236)
        Me.cmbJabatan.Name = "cmbJabatan"
        Me.cmbJabatan.Size = New System.Drawing.Size(228, 21)
        Me.cmbJabatan.TabIndex = 2
        '
        'btnHitung
        '
        Me.btnHitung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(259, 511)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(106, 42)
        Me.btnHitung.TabIndex = 3
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Red
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnKeluar.Location = New System.Drawing.Point(106, 511)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(106, 42)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'tbTunjanganTetap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 652)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.cmbJabatan)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.tbTotalGaji)
        Me.Controls.Add(Me.tbTunjanganTransport)
        Me.Controls.Add(Me.tbTnjTtp)
        Me.Controls.Add(Me.tbGajiPokok)
        Me.Controls.Add(Me.tbAlamat)
        Me.Controls.Add(Me.tbNamaPegawai)
        Me.Controls.Add(Me.tbNip)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tbTunjanganTetap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inheritance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbNip As System.Windows.Forms.TextBox
    Friend WithEvents tbNamaPegawai As System.Windows.Forms.TextBox
    Friend WithEvents tbAlamat As System.Windows.Forms.TextBox
    Friend WithEvents tbGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents tbTnjTtp As System.Windows.Forms.TextBox
    Friend WithEvents tbTunjanganTransport As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalGaji As System.Windows.Forms.TextBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
