<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TugasHariRaya1
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
        Me.btnInputNim = New System.Windows.Forms.Button()
        Me.btnAmbilNim = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInputNama = New System.Windows.Forms.Button()
        Me.btnAmbilNama = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.tbNim = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInputNim
        '
        Me.btnInputNim.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnInputNim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInputNim.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInputNim.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputNim.Location = New System.Drawing.Point(42, 113)
        Me.btnInputNim.Name = "btnInputNim"
        Me.btnInputNim.Size = New System.Drawing.Size(83, 28)
        Me.btnInputNim.TabIndex = 0
        Me.btnInputNim.Text = "Input Nim"
        Me.btnInputNim.UseVisualStyleBackColor = False
        '
        'btnAmbilNim
        '
        Me.btnAmbilNim.AutoEllipsis = True
        Me.btnAmbilNim.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnAmbilNim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAmbilNim.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAmbilNim.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmbilNim.Location = New System.Drawing.Point(163, 113)
        Me.btnAmbilNim.Name = "btnAmbilNim"
        Me.btnAmbilNim.Size = New System.Drawing.Size(82, 28)
        Me.btnAmbilNim.TabIndex = 0
        Me.btnAmbilNim.Text = "Ambil Nim"
        Me.btnAmbilNim.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIM"
        '
        'btnInputNama
        '
        Me.btnInputNama.BackColor = System.Drawing.Color.Tan
        Me.btnInputNama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInputNama.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.btnInputNama.FlatAppearance.BorderSize = 0
        Me.btnInputNama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInputNama.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputNama.Location = New System.Drawing.Point(342, 113)
        Me.btnInputNama.Name = "btnInputNama"
        Me.btnInputNama.Size = New System.Drawing.Size(90, 28)
        Me.btnInputNama.TabIndex = 0
        Me.btnInputNama.Text = "Input Nama"
        Me.btnInputNama.UseVisualStyleBackColor = False
        '
        'btnAmbilNama
        '
        Me.btnAmbilNama.BackColor = System.Drawing.Color.Tan
        Me.btnAmbilNama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAmbilNama.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.btnAmbilNama.FlatAppearance.BorderSize = 0
        Me.btnAmbilNama.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAmbilNama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmbilNama.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmbilNama.Location = New System.Drawing.Point(473, 113)
        Me.btnAmbilNama.Name = "btnAmbilNama"
        Me.btnAmbilNama.Size = New System.Drawing.Size(92, 28)
        Me.btnAmbilNama.TabIndex = 0
        Me.btnAmbilNama.Text = "Ambil Nama"
        Me.btnAmbilNama.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(388, 71)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(187, 20)
        Me.tbNama.TabIndex = 2
        '
        'tbNim
        '
        Me.tbNim.Location = New System.Drawing.Point(74, 73)
        Me.tbNim.Name = "tbNim"
        Me.tbNim.Size = New System.Drawing.Size(183, 20)
        Me.tbNim.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(98, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Kelas Turunan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(342, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Kelas Induk"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Brown
        Me.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(227, 317)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(112, 39)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'TugasHariRaya1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 415)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbNim)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAmbilNama)
        Me.Controls.Add(Me.btnInputNama)
        Me.Controls.Add(Me.btnAmbilNim)
        Me.Controls.Add(Me.btnInputNim)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "TugasHariRaya1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tugas Hari Raya"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInputNim As System.Windows.Forms.Button
    Friend WithEvents btnAmbilNim As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInputNama As System.Windows.Forms.Button
    Friend WithEvents btnAmbilNama As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents tbNim As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
End Class
