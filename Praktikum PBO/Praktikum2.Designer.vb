<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikum2
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
        Me.tbJmlPenjualan = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jumlah Penjualan :"
        '
        'tbJmlPenjualan
        '
        Me.tbJmlPenjualan.Location = New System.Drawing.Point(249, 145)
        Me.tbJmlPenjualan.Name = "tbJmlPenjualan"
        Me.tbJmlPenjualan.Size = New System.Drawing.Size(160, 20)
        Me.tbJmlPenjualan.TabIndex = 1
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(174, 88)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(235, 20)
        Me.tbNama.TabIndex = 1
        '
        'btnSimpan
        '
        Me.btnSimpan.AutoEllipsis = True
        Me.btnSimpan.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(116, 219)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(111, 36)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.AutoEllipsis = True
        Me.btnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(298, 219)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(111, 36)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'Praktikum2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 393)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.tbJmlPenjualan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Praktikum2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Praktikum 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbJmlPenjualan As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
