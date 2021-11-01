<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_book = New System.Windows.Forms.DataGridView()
        Me.kd_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pengarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_masuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_book, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dg_book)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 230)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Buku"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(594, 22)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(175, 23)
        Me.txt_search.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(530, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari Buku"
        '
        'dg_book
        '
        Me.dg_book.AllowUserToAddRows = False
        Me.dg_book.AllowUserToDeleteRows = False
        Me.dg_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_book.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_buku, Me.judul_buku, Me.pengarang, Me.penerbit, Me.jumlah_buku, Me.tgl_masuk})
        Me.dg_book.Location = New System.Drawing.Point(6, 51)
        Me.dg_book.Name = "dg_book"
        Me.dg_book.ReadOnly = True
        Me.dg_book.RowTemplate.Height = 25
        Me.dg_book.Size = New System.Drawing.Size(763, 162)
        Me.dg_book.TabIndex = 0
        '
        'kd_buku
        '
        Me.kd_buku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kd_buku.HeaderText = "Kode"
        Me.kd_buku.Name = "kd_buku"
        Me.kd_buku.ReadOnly = True
        '
        'judul_buku
        '
        Me.judul_buku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.judul_buku.HeaderText = "Judul"
        Me.judul_buku.Name = "judul_buku"
        Me.judul_buku.ReadOnly = True
        '
        'pengarang
        '
        Me.pengarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.pengarang.HeaderText = "Pengarang"
        Me.pengarang.Name = "pengarang"
        Me.pengarang.ReadOnly = True
        '
        'penerbit
        '
        Me.penerbit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.penerbit.HeaderText = "Penerbit"
        Me.penerbit.Name = "penerbit"
        Me.penerbit.ReadOnly = True
        '
        'jumlah_buku
        '
        Me.jumlah_buku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jumlah_buku.HeaderText = "Jumlah"
        Me.jumlah_buku.Name = "jumlah_buku"
        Me.jumlah_buku.ReadOnly = True
        '
        'tgl_masuk
        '
        Me.tgl_masuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tgl_masuk.HeaderText = "Tgl. Masuk"
        Me.tgl_masuk.Name = "tgl_masuk"
        Me.tgl_masuk.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 257)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_book, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dg_book As DataGridView
    Friend WithEvents kd_buku As DataGridViewTextBoxColumn
    Friend WithEvents judul_buku As DataGridViewTextBoxColumn
    Friend WithEvents pengarang As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_buku As DataGridViewTextBoxColumn
    Friend WithEvents tgl_masuk As DataGridViewTextBoxColumn
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
End Class
