Public Class Form1
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        findBook()
    End Sub

    Public Sub findBook()
        Dim iterate As Integer = 1

        Me.dg_book.Rows.Clear()

        openConn()
        record.Open("SELECT * FROM tbl_buku WHERE judul_buku LIKE '%" & txt_search.Text & "%'", dbConn, 3, 2)
        Do While Not record.EOF
            Me.dg_book.Rows.Add(record.Fields("kd_buku").Value, record.Fields("judul_buku").Value, record.Fields("pengarang").Value, record.Fields("penerbit").Value, record.Fields("jumlah_buku").Value, record.Fields("tgl_masuk").Value)
            record.MoveNext()
            iterate += 1
        Loop
        closeConn()
    End Sub

    Private Sub db_book_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_book.CellContentClick
        Form2.txt_kode_buku.Text = dg_book.Rows(e.RowIndex).Cells(0).Value
        Form2.txt_judul_buku.Text = dg_book.Rows(e.RowIndex).Cells(1).Value
        Form2.txt_pengarang.Text = dg_book.Rows(e.RowIndex).Cells(2).Value
        Form2.txt_penerbit.Text = dg_book.Rows(e.RowIndex).Cells(3).Value
        Form2.txt_jumlah_buku.Text = dg_book.Rows(e.RowIndex).Cells(4).Value
        Form2.txt_tgl_masuk.Text = dg_book.Rows(e.RowIndex).Cells(5).Value
        Form2.ShowDialog()
    End Sub
End Class
