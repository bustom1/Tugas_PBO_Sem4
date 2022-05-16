<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikum1
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
        Me.tbKlingkaran = New System.Windows.Forms.TextBox()
        Me.tbLlingkaran = New System.Windows.Forms.TextBox()
        Me.tbJariLingkaran = New System.Windows.Forms.TextBox()
        Me.BtnHitungL = New System.Windows.Forms.Button()
        Me.BtnClearL = New System.Windows.Forms.Button()
        Me.GbLingkaran = New System.Windows.Forms.GroupBox()
        Me.GbTabung = New System.Windows.Forms.GroupBox()
        Me.BtnClearT = New System.Windows.Forms.Button()
        Me.BtnHitungT = New System.Windows.Forms.Button()
        Me.tbTinggiT = New System.Windows.Forms.TextBox()
        Me.tbJariT = New System.Windows.Forms.TextBox()
        Me.tbVolumeT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.GbLingkaran.SuspendLayout()
        Me.GbTabung.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari - Jari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Luas Lingkaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Keliling Lingkaran"
        '
        'tbKlingkaran
        '
        Me.tbKlingkaran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbKlingkaran.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbKlingkaran.Cursor = System.Windows.Forms.Cursors.No
        Me.tbKlingkaran.Location = New System.Drawing.Point(190, 141)
        Me.tbKlingkaran.Name = "tbKlingkaran"
        Me.tbKlingkaran.ReadOnly = True
        Me.tbKlingkaran.Size = New System.Drawing.Size(140, 29)
        Me.tbKlingkaran.TabIndex = 1
        Me.tbKlingkaran.Text = "    0"
        '
        'tbLlingkaran
        '
        Me.tbLlingkaran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLlingkaran.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbLlingkaran.Cursor = System.Windows.Forms.Cursors.No
        Me.tbLlingkaran.Location = New System.Drawing.Point(189, 88)
        Me.tbLlingkaran.Name = "tbLlingkaran"
        Me.tbLlingkaran.ReadOnly = True
        Me.tbLlingkaran.Size = New System.Drawing.Size(141, 29)
        Me.tbLlingkaran.TabIndex = 1
        Me.tbLlingkaran.Text = "    0"
        '
        'tbJariLingkaran
        '
        Me.tbJariLingkaran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbJariLingkaran.BackColor = System.Drawing.SystemColors.Window
        Me.tbJariLingkaran.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbJariLingkaran.Location = New System.Drawing.Point(190, 39)
        Me.tbJariLingkaran.Name = "tbJariLingkaran"
        Me.tbJariLingkaran.Size = New System.Drawing.Size(140, 29)
        Me.tbJariLingkaran.TabIndex = 1
        '
        'BtnHitungL
        '
        Me.BtnHitungL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHitungL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnHitungL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHitungL.Location = New System.Drawing.Point(47, 205)
        Me.BtnHitungL.Name = "BtnHitungL"
        Me.BtnHitungL.Size = New System.Drawing.Size(97, 34)
        Me.BtnHitungL.TabIndex = 2
        Me.BtnHitungL.Text = "Hitung"
        Me.BtnHitungL.UseVisualStyleBackColor = True
        '
        'BtnClearL
        '
        Me.BtnClearL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnClearL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearL.Location = New System.Drawing.Point(190, 205)
        Me.BtnClearL.Name = "BtnClearL"
        Me.BtnClearL.Size = New System.Drawing.Size(97, 34)
        Me.BtnClearL.TabIndex = 2
        Me.BtnClearL.Text = "Clear"
        Me.BtnClearL.UseVisualStyleBackColor = True
        '
        'GbLingkaran
        '
        Me.GbLingkaran.Controls.Add(Me.BtnClearL)
        Me.GbLingkaran.Controls.Add(Me.BtnHitungL)
        Me.GbLingkaran.Controls.Add(Me.tbJariLingkaran)
        Me.GbLingkaran.Controls.Add(Me.tbLlingkaran)
        Me.GbLingkaran.Controls.Add(Me.tbKlingkaran)
        Me.GbLingkaran.Controls.Add(Me.Label3)
        Me.GbLingkaran.Controls.Add(Me.Label2)
        Me.GbLingkaran.Controls.Add(Me.Label1)
        Me.GbLingkaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbLingkaran.Location = New System.Drawing.Point(24, 51)
        Me.GbLingkaran.Name = "GbLingkaran"
        Me.GbLingkaran.Size = New System.Drawing.Size(375, 280)
        Me.GbLingkaran.TabIndex = 3
        Me.GbLingkaran.TabStop = False
        Me.GbLingkaran.Text = "Lingkaran"
        '
        'GbTabung
        '
        Me.GbTabung.Controls.Add(Me.BtnClearT)
        Me.GbTabung.Controls.Add(Me.BtnHitungT)
        Me.GbTabung.Controls.Add(Me.tbTinggiT)
        Me.GbTabung.Controls.Add(Me.tbJariT)
        Me.GbTabung.Controls.Add(Me.tbVolumeT)
        Me.GbTabung.Controls.Add(Me.Label4)
        Me.GbTabung.Controls.Add(Me.Label5)
        Me.GbTabung.Controls.Add(Me.Label6)
        Me.GbTabung.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbTabung.Location = New System.Drawing.Point(422, 49)
        Me.GbTabung.Name = "GbTabung"
        Me.GbTabung.Size = New System.Drawing.Size(375, 280)
        Me.GbTabung.TabIndex = 3
        Me.GbTabung.TabStop = False
        Me.GbTabung.Text = "Tabung"
        '
        'BtnClearT
        '
        Me.BtnClearT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnClearT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearT.Location = New System.Drawing.Point(190, 205)
        Me.BtnClearT.Name = "BtnClearT"
        Me.BtnClearT.Size = New System.Drawing.Size(97, 34)
        Me.BtnClearT.TabIndex = 2
        Me.BtnClearT.Text = "Clear"
        Me.BtnClearT.UseVisualStyleBackColor = True
        '
        'BtnHitungT
        '
        Me.BtnHitungT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHitungT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnHitungT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHitungT.Location = New System.Drawing.Point(47, 205)
        Me.BtnHitungT.Name = "BtnHitungT"
        Me.BtnHitungT.Size = New System.Drawing.Size(97, 34)
        Me.BtnHitungT.TabIndex = 2
        Me.BtnHitungT.Text = "Hitung"
        Me.BtnHitungT.UseVisualStyleBackColor = True
        '
        'tbTinggiT
        '
        Me.tbTinggiT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTinggiT.BackColor = System.Drawing.SystemColors.Window
        Me.tbTinggiT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTinggiT.Location = New System.Drawing.Point(161, 45)
        Me.tbTinggiT.Name = "tbTinggiT"
        Me.tbTinggiT.Size = New System.Drawing.Size(140, 29)
        Me.tbTinggiT.TabIndex = 1
        '
        'tbJariT
        '
        Me.tbJariT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbJariT.BackColor = System.Drawing.SystemColors.Window
        Me.tbJariT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbJariT.Location = New System.Drawing.Point(161, 93)
        Me.tbJariT.Name = "tbJariT"
        Me.tbJariT.Size = New System.Drawing.Size(141, 29)
        Me.tbJariT.TabIndex = 1
        '
        'tbVolumeT
        '
        Me.tbVolumeT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbVolumeT.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbVolumeT.Cursor = System.Windows.Forms.Cursors.No
        Me.tbVolumeT.Location = New System.Drawing.Point(162, 145)
        Me.tbVolumeT.Name = "tbVolumeT"
        Me.tbVolumeT.ReadOnly = True
        Me.tbVolumeT.Size = New System.Drawing.Size(140, 29)
        Me.tbVolumeT.TabIndex = 1
        Me.tbVolumeT.Text = "    0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Volume Tabung"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jari - Jari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(74, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tinggi"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Red
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnKeluar.Location = New System.Drawing.Point(349, 376)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(134, 40)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'Praktikum1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 494)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.GbTabung)
        Me.Controls.Add(Me.GbLingkaran)
        Me.Name = "Praktikum1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Praktikum 1"
        Me.GbLingkaran.ResumeLayout(False)
        Me.GbLingkaran.PerformLayout()
        Me.GbTabung.ResumeLayout(False)
        Me.GbTabung.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbKlingkaran As System.Windows.Forms.TextBox
    Friend WithEvents tbLlingkaran As System.Windows.Forms.TextBox
    Friend WithEvents tbJariLingkaran As System.Windows.Forms.TextBox
    Friend WithEvents BtnHitungL As System.Windows.Forms.Button
    Friend WithEvents BtnClearL As System.Windows.Forms.Button
    Friend WithEvents GbLingkaran As System.Windows.Forms.GroupBox
    Friend WithEvents GbTabung As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClearT As System.Windows.Forms.Button
    Friend WithEvents BtnHitungT As System.Windows.Forms.Button
    Friend WithEvents tbTinggiT As System.Windows.Forms.TextBox
    Friend WithEvents tbJariT As System.Windows.Forms.TextBox
    Friend WithEvents tbVolumeT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
