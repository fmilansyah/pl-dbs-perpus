<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txt_kode_buku = New System.Windows.Forms.TextBox()
        Me.txt_judul_buku = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pengarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_penerbit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_jumlah_buku = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_tgl_masuk = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Buku"
        '
        'txt_kode_buku
        '
        Me.txt_kode_buku.Location = New System.Drawing.Point(13, 32)
        Me.txt_kode_buku.Name = "txt_kode_buku"
        Me.txt_kode_buku.Size = New System.Drawing.Size(200, 23)
        Me.txt_kode_buku.TabIndex = 1
        '
        'txt_judul_buku
        '
        Me.txt_judul_buku.Location = New System.Drawing.Point(13, 85)
        Me.txt_judul_buku.Name = "txt_judul_buku"
        Me.txt_judul_buku.Size = New System.Drawing.Size(200, 23)
        Me.txt_judul_buku.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Judul Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pengarang"
        '
        'txt_pengarang
        '
        Me.txt_pengarang.Location = New System.Drawing.Point(13, 139)
        Me.txt_pengarang.Name = "txt_pengarang"
        Me.txt_pengarang.Size = New System.Drawing.Size(200, 23)
        Me.txt_pengarang.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Penerbit"
        '
        'txt_penerbit
        '
        Me.txt_penerbit.Location = New System.Drawing.Point(13, 193)
        Me.txt_penerbit.Name = "txt_penerbit"
        Me.txt_penerbit.Size = New System.Drawing.Size(200, 23)
        Me.txt_penerbit.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jumlah Buku"
        '
        'txt_jumlah_buku
        '
        Me.txt_jumlah_buku.Location = New System.Drawing.Point(13, 246)
        Me.txt_jumlah_buku.Name = "txt_jumlah_buku"
        Me.txt_jumlah_buku.Size = New System.Drawing.Size(200, 23)
        Me.txt_jumlah_buku.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tgl. Masuk"
        '
        'txt_tgl_masuk
        '
        Me.txt_tgl_masuk.Location = New System.Drawing.Point(13, 302)
        Me.txt_tgl_masuk.Name = "txt_tgl_masuk"
        Me.txt_tgl_masuk.Size = New System.Drawing.Size(200, 23)
        Me.txt_tgl_masuk.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_tgl_masuk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_jumlah_buku)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_penerbit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_pengarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_judul_buku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_kode_buku)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_kode_buku As TextBox
    Friend WithEvents txt_judul_buku As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_pengarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_penerbit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_jumlah_buku As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_tgl_masuk As TextBox
End Class
