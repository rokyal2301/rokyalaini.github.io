<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CRUD_Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CRUD_Data))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Ubah = New System.Windows.Forms.ToolStripButton()
        Me.Hapus = New System.Windows.Forms.ToolStripButton()
        Me.Simpan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ubah, Me.Hapus, Me.Simpan})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(531, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Ubah
        '
        Me.Ubah.Image = CType(resources.GetObject("Ubah.Image"), System.Drawing.Image)
        Me.Ubah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ubah.Name = "Ubah"
        Me.Ubah.Size = New System.Drawing.Size(74, 29)
        Me.Ubah.Text = "Ubah"
        '
        'Hapus
        '
        Me.Hapus.Image = CType(resources.GetObject("Hapus.Image"), System.Drawing.Image)
        Me.Hapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(83, 29)
        Me.Hapus.Text = "Hapus"
        '
        'Simpan
        '
        Me.Simpan.Image = CType(resources.GetObject("Simpan.Image"), System.Drawing.Image)
        Me.Simpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(92, 29)
        Me.Simpan.Text = "Simpan"
        '
        'Form_CRUD_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 486)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form_CRUD_Data"
        Me.Text = "Form_CRUD_Data"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Ubah As System.Windows.Forms.ToolStripButton
    Friend WithEvents Hapus As System.Windows.Forms.ToolStripButton
    Friend WithEvents Simpan As System.Windows.Forms.ToolStripButton
End Class
