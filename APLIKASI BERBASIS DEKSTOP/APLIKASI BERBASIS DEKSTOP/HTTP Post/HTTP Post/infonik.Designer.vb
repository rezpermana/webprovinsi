<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class infonik
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(infonik))
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.kotak_provinsi1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kotak_namaprovinsi = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.kotak_namaibukota = New System.Windows.Forms.TextBox()
        Me.kotak_makanankhas = New System.Windows.Forms.TextBox()
        Me.kotak_namaprov = New System.Windows.Forms.TextBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kotak_wisata = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(350, 103)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(74, 29)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'kotak_provinsi1
        '
        Me.kotak_provinsi1.Location = New System.Drawing.Point(119, 106)
        Me.kotak_provinsi1.Name = "kotak_provinsi1"
        Me.kotak_provinsi1.Size = New System.Drawing.Size(215, 20)
        Me.kotak_provinsi1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kode Provinsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "DATA"
        '
        'kotak_namaprovinsi
        '
        Me.kotak_namaprovinsi.AutoSize = True
        Me.kotak_namaprovinsi.BackColor = System.Drawing.Color.Transparent
        Me.kotak_namaprovinsi.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kotak_namaprovinsi.Location = New System.Drawing.Point(12, 181)
        Me.kotak_namaprovinsi.Name = "kotak_namaprovinsi"
        Me.kotak_namaprovinsi.Size = New System.Drawing.Size(53, 17)
        Me.kotak_namaprovinsi.TabIndex = 8
        Me.kotak_namaprovinsi.Text = "Provinsi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ibu Kota"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Makanan Khas"
        '
        'kotak_namaibukota
        '
        Me.kotak_namaibukota.Location = New System.Drawing.Point(119, 210)
        Me.kotak_namaibukota.Name = "kotak_namaibukota"
        Me.kotak_namaibukota.Size = New System.Drawing.Size(215, 20)
        Me.kotak_namaibukota.TabIndex = 13
        '
        'kotak_makanankhas
        '
        Me.kotak_makanankhas.Location = New System.Drawing.Point(119, 270)
        Me.kotak_makanankhas.Name = "kotak_makanankhas"
        Me.kotak_makanankhas.Size = New System.Drawing.Size(215, 20)
        Me.kotak_makanankhas.TabIndex = 15
        '
        'kotak_namaprov
        '
        Me.kotak_namaprov.Location = New System.Drawing.Point(119, 180)
        Me.kotak_namaprov.Name = "kotak_namaprov"
        Me.kotak_namaprov.Size = New System.Drawing.Size(215, 20)
        Me.kotak_namaprov.TabIndex = 21
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_reset.ForeColor = System.Drawing.Color.White
        Me.btn_reset.Location = New System.Drawing.Point(350, 380)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(73, 31)
        Me.btn_reset.TabIndex = 22
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tempat Wisata"
        '
        'kotak_wisata
        '
        Me.kotak_wisata.Location = New System.Drawing.Point(119, 240)
        Me.kotak_wisata.Name = "kotak_wisata"
        Me.kotak_wisata.Size = New System.Drawing.Size(215, 20)
        Me.kotak_wisata.TabIndex = 14
        '
        'infonik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 422)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.kotak_namaprov)
        Me.Controls.Add(Me.kotak_makanankhas)
        Me.Controls.Add(Me.kotak_wisata)
        Me.Controls.Add(Me.kotak_namaibukota)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.kotak_namaprovinsi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.kotak_provinsi1)
        Me.Controls.Add(Me.btn_ok)
        Me.Name = "Aplikasi Dekstop"
        Me.Text = "Aplikasi Dekstop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ok As Button
    Friend WithEvents kotak_provinsi1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents kotak_namaprovinsi As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents kotak_namaibukota As TextBox
    Friend WithEvents kotak_makanankhas As TextBox
    Friend WithEvents kotak_namaprov As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents kotak_wisata As TextBox
End Class
