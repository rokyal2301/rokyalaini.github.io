<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Utama
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
        Me.NIP = New System.Windows.Forms.Label()
        Me.Nama_Lengkap = New System.Windows.Forms.Label()
        Me.Jenis_Kelamin = New System.Windows.Forms.Label()
        Me.Jabatan = New System.Windows.Forms.Label()
        Me.Gaji = New System.Windows.Forms.Label()
        Me.Status_Menikah = New System.Windows.Forms.Label()
        Me.tbl_nip = New System.Windows.Forms.TextBox()
        Me.tbl_nama = New System.Windows.Forms.TextBox()
        Me.tbl_jabatan = New System.Windows.Forms.TextBox()
        Me.tbl_gaji = New System.Windows.Forms.TextBox()
        Me.Perempuan = New System.Windows.Forms.RadioButton()
        Me.Laki_laki = New System.Windows.Forms.RadioButton()
        Me.Menikah = New System.Windows.Forms.CheckBox()
        Me.Belum_Menikah = New System.Windows.Forms.CheckBox()
        Me.Simpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NIP
        '
        Me.NIP.AutoSize = True
        Me.NIP.Location = New System.Drawing.Point(44, 54)
        Me.NIP.Name = "NIP"
        Me.NIP.Size = New System.Drawing.Size(35, 20)
        Me.NIP.TabIndex = 0
        Me.NIP.Text = "NIP"
        '
        'Nama_Lengkap
        '
        Me.Nama_Lengkap.AutoSize = True
        Me.Nama_Lengkap.Location = New System.Drawing.Point(44, 114)
        Me.Nama_Lengkap.Name = "Nama_Lengkap"
        Me.Nama_Lengkap.Size = New System.Drawing.Size(122, 20)
        Me.Nama_Lengkap.TabIndex = 1
        Me.Nama_Lengkap.Text = "Nama_Lengkap"
        '
        'Jenis_Kelamin
        '
        Me.Jenis_Kelamin.AutoSize = True
        Me.Jenis_Kelamin.Location = New System.Drawing.Point(44, 173)
        Me.Jenis_Kelamin.Name = "Jenis_Kelamin"
        Me.Jenis_Kelamin.Size = New System.Drawing.Size(111, 20)
        Me.Jenis_Kelamin.TabIndex = 2
        Me.Jenis_Kelamin.Text = "Jenis_Kelamin"
        '
        'Jabatan
        '
        Me.Jabatan.AutoSize = True
        Me.Jabatan.Location = New System.Drawing.Point(44, 234)
        Me.Jabatan.Name = "Jabatan"
        Me.Jabatan.Size = New System.Drawing.Size(67, 20)
        Me.Jabatan.TabIndex = 3
        Me.Jabatan.Text = "Jabatan"
        '
        'Gaji
        '
        Me.Gaji.AutoSize = True
        Me.Gaji.Location = New System.Drawing.Point(44, 289)
        Me.Gaji.Name = "Gaji"
        Me.Gaji.Size = New System.Drawing.Size(37, 20)
        Me.Gaji.TabIndex = 4
        Me.Gaji.Text = "Gaji"
        '
        'Status_Menikah
        '
        Me.Status_Menikah.AutoSize = True
        Me.Status_Menikah.Location = New System.Drawing.Point(44, 341)
        Me.Status_Menikah.Name = "Status_Menikah"
        Me.Status_Menikah.Size = New System.Drawing.Size(125, 20)
        Me.Status_Menikah.TabIndex = 5
        Me.Status_Menikah.Text = "Status_Menikah"
        '
        'tbl_nip
        '
        Me.tbl_nip.Location = New System.Drawing.Point(238, 52)
        Me.tbl_nip.Name = "tbl_nip"
        Me.tbl_nip.Size = New System.Drawing.Size(100, 26)
        Me.tbl_nip.TabIndex = 6
        '
        'tbl_nama
        '
        Me.tbl_nama.Location = New System.Drawing.Point(238, 114)
        Me.tbl_nama.Name = "tbl_nama"
        Me.tbl_nama.Size = New System.Drawing.Size(100, 26)
        Me.tbl_nama.TabIndex = 7
        '
        'tbl_jabatan
        '
        Me.tbl_jabatan.Location = New System.Drawing.Point(238, 234)
        Me.tbl_jabatan.Name = "tbl_jabatan"
        Me.tbl_jabatan.Size = New System.Drawing.Size(100, 26)
        Me.tbl_jabatan.TabIndex = 8
        '
        'tbl_gaji
        '
        Me.tbl_gaji.Location = New System.Drawing.Point(238, 289)
        Me.tbl_gaji.Name = "tbl_gaji"
        Me.tbl_gaji.Size = New System.Drawing.Size(100, 26)
        Me.tbl_gaji.TabIndex = 9
        '
        'Perempuan
        '
        Me.Perempuan.AutoSize = True
        Me.Perempuan.Location = New System.Drawing.Point(250, 189)
        Me.Perempuan.Name = "Perempuan"
        Me.Perempuan.Size = New System.Drawing.Size(116, 24)
        Me.Perempuan.TabIndex = 10
        Me.Perempuan.TabStop = True
        Me.Perempuan.Text = "Perempuan"
        Me.Perempuan.UseVisualStyleBackColor = True
        '
        'Laki_laki
        '
        Me.Laki_laki.AutoSize = True
        Me.Laki_laki.Location = New System.Drawing.Point(401, 189)
        Me.Laki_laki.Name = "Laki_laki"
        Me.Laki_laki.Size = New System.Drawing.Size(97, 24)
        Me.Laki_laki.TabIndex = 11
        Me.Laki_laki.TabStop = True
        Me.Laki_laki.Text = "Laki-Laki"
        Me.Laki_laki.UseVisualStyleBackColor = True
        '
        'Menikah
        '
        Me.Menikah.AutoSize = True
        Me.Menikah.Location = New System.Drawing.Point(240, 351)
        Me.Menikah.Name = "Menikah"
        Me.Menikah.Size = New System.Drawing.Size(95, 24)
        Me.Menikah.TabIndex = 12
        Me.Menikah.Text = "Menikah"
        Me.Menikah.UseVisualStyleBackColor = True
        '
        'Belum_Menikah
        '
        Me.Belum_Menikah.AutoSize = True
        Me.Belum_Menikah.Location = New System.Drawing.Point(382, 351)
        Me.Belum_Menikah.Name = "Belum_Menikah"
        Me.Belum_Menikah.Size = New System.Drawing.Size(149, 24)
        Me.Belum_Menikah.TabIndex = 13
        Me.Belum_Menikah.Text = "Belum_Menikah"
        Me.Belum_Menikah.UseVisualStyleBackColor = True
        '
        'Simpan
        '
        Me.Simpan.Location = New System.Drawing.Point(69, 450)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Simpan.TabIndex = 14
        Me.Simpan.Text = "Simpan"
        Me.Simpan.UseVisualStyleBackColor = True
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 522)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.Belum_Menikah)
        Me.Controls.Add(Me.Menikah)
        Me.Controls.Add(Me.Laki_laki)
        Me.Controls.Add(Me.Perempuan)
        Me.Controls.Add(Me.tbl_gaji)
        Me.Controls.Add(Me.tbl_jabatan)
        Me.Controls.Add(Me.tbl_nama)
        Me.Controls.Add(Me.tbl_nip)
        Me.Controls.Add(Me.Status_Menikah)
        Me.Controls.Add(Me.Gaji)
        Me.Controls.Add(Me.Jabatan)
        Me.Controls.Add(Me.Jenis_Kelamin)
        Me.Controls.Add(Me.Nama_Lengkap)
        Me.Controls.Add(Me.NIP)
        Me.Name = "Form_Utama"
        Me.Text = "Form_Utama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NIP As System.Windows.Forms.Label
    Friend WithEvents Nama_Lengkap As System.Windows.Forms.Label
    Friend WithEvents Jenis_Kelamin As System.Windows.Forms.Label
    Friend WithEvents Jabatan As System.Windows.Forms.Label
    Friend WithEvents Gaji As System.Windows.Forms.Label
    Friend WithEvents Status_Menikah As System.Windows.Forms.Label
    Friend WithEvents tbl_nip As System.Windows.Forms.TextBox
    Friend WithEvents tbl_nama As System.Windows.Forms.TextBox
    Friend WithEvents tbl_jabatan As System.Windows.Forms.TextBox
    Friend WithEvents tbl_gaji As System.Windows.Forms.TextBox
    Friend WithEvents Perempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Laki_laki As System.Windows.Forms.RadioButton
    Friend WithEvents Menikah As System.Windows.Forms.CheckBox
    Friend WithEvents Belum_Menikah As System.Windows.Forms.CheckBox
    Friend WithEvents Simpan As System.Windows.Forms.Button

End Class
