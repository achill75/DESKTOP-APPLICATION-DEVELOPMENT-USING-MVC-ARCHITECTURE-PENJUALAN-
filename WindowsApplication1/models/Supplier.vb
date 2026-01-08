Imports MySql.Data.MySqlClient

Public Module Supplier
    Public Function GenerateKodeSupplier() As String
        Dim kodeBaru As String = "SUP0001"

        Try
            Using conn = Koneksi.OpenConnection()
                Dim cmd As New MySqlCommand("SELECT kode_supplier FROM supplier ORDER BY kode_supplier DESC LIMIT 1", conn)
                Dim rd = cmd.ExecuteReader()

                If rd.Read() Then
                    Dim kodeLama As String = rd("kode_supplier").ToString() 'contoh: SUP0007
                    Dim nomor As Integer = CInt(kodeLama.Substring(3)) + 1
                    kodeBaru = "SUP" & nomor.ToString("0000")
                End If
            End Using
        Catch ex As Exception
            'kalau tabel kosong/error, tetap pakai SUP0001
        End Try

        Return kodeBaru
    End Function
End Module
