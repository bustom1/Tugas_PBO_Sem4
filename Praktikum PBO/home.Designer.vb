<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.lblTugasPraktikum = New System.Windows.Forms.Label()
        Me.btnPrak1 = New System.Windows.Forms.Button()
        Me.btnPrak2 = New System.Windows.Forms.Button()
        Me.btnTgsHRY = New System.Windows.Forms.Button()
        Me.btnInherit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTugasPraktikum
        '
        Me.lblTugasPraktikum.AutoSize = True
        Me.lblTugasPraktikum.BackColor = System.Drawing.Color.LimeGreen
        Me.lblTugasPraktikum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTugasPraktikum.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTugasPraktikum.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTugasPraktikum.Location = New System.Drawing.Point(77, 28)
        Me.lblTugasPraktikum.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTugasPraktikum.Name = "lblTugasPraktikum"
        Me.lblTugasPraktikum.Size = New System.Drawing.Size(377, 49)
        Me.lblTugasPraktikum.TabIndex = 0
        Me.lblTugasPraktikum.Text = "Tugas Praktikum PBO"
        '
        'btnPrak1
        '
        Me.btnPrak1.BackColor = System.Drawing.Color.DarkOrange
        Me.btnPrak1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrak1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrak1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrak1.Font = New System.Drawing.Font("Adobe Gothic Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPrak1.Location = New System.Drawing.Point(68, 139)
        Me.btnPrak1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnPrak1.Name = "btnPrak1"
        Me.btnPrak1.Size = New System.Drawing.Size(139, 47)
        Me.btnPrak1.TabIndex = 1
        Me.btnPrak1.Text = "Praktikum 1"
        Me.btnPrak1.UseVisualStyleBackColor = False
        '
        'btnPrak2
        '
        Me.btnPrak2.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnPrak2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrak2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrak2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrak2.Font = New System.Drawing.Font("Adobe Gothic Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPrak2.Location = New System.Drawing.Point(306, 139)
        Me.btnPrak2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnPrak2.Name = "btnPrak2"
        Me.btnPrak2.Size = New System.Drawing.Size(139, 47)
        Me.btnPrak2.TabIndex = 1
        Me.btnPrak2.Text = "Praktikum 2"
        Me.btnPrak2.UseVisualStyleBackColor = False
        '
        'btnTgsHRY
        '
        Me.btnTgsHRY.BackColor = System.Drawing.Color.CadetBlue
        Me.btnTgsHRY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTgsHRY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTgsHRY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTgsHRY.Font = New System.Drawing.Font("Adobe Gothic Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTgsHRY.Location = New System.Drawing.Point(306, 255)
        Me.btnTgsHRY.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnTgsHRY.Name = "btnTgsHRY"
        Me.btnTgsHRY.Size = New System.Drawing.Size(139, 47)
        Me.btnTgsHRY.TabIndex = 1
        Me.btnTgsHRY.Text = "TGS Hari Raya"
        Me.btnTgsHRY.UseVisualStyleBackColor = False
        '
        'btnInherit
        '
        Me.btnInherit.BackColor = System.Drawing.Color.Olive
        Me.btnInherit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnInherit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInherit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInherit.Font = New System.Drawing.Font("Adobe Gothic Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnInherit.Location = New System.Drawing.Point(68, 255)
        Me.btnInherit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnInherit.Name = "btnInherit"
        Me.btnInherit.Size = New System.Drawing.Size(139, 47)
        Me.btnInherit.TabIndex = 1
        Me.btnInherit.Text = "Inheritance"
        Me.btnInherit.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(505, 361)
        Me.Controls.Add(Me.btnInherit)
        Me.Controls.Add(Me.btnTgsHRY)
        Me.Controls.Add(Me.btnPrak2)
        Me.Controls.Add(Me.btnPrak1)
        Me.Controls.Add(Me.lblTugasPraktikum)
        Me.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTugasPraktikum As System.Windows.Forms.Label
    Friend WithEvents btnPrak1 As System.Windows.Forms.Button
    Friend WithEvents btnPrak2 As System.Windows.Forms.Button
    Friend WithEvents btnTgsHRY As System.Windows.Forms.Button
    Friend WithEvents btnInherit As System.Windows.Forms.Button

End Class
