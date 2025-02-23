Imports System.IO

Public Class Form1
    ' Tombol untuk memilih dan membaca file
    Private Sub btnBacaFile_Click(sender As Object, e As EventArgs) Handles btnBacaFile.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            BacaFile(filePath)
        End If
    End Sub

    ' Prosedur untuk membaca file
    Private Sub BacaFile(ByVal path As String)
        If File.Exists(path) Then
            Dim isiFile As String = File.ReadAllText(path)
            txtOutput.Text = isiFile ' Menampilkan isi file ke dalam TextBox
        Else
            MessageBox.Show("File tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Tombol untuk mencari kata dalam file
    Private Sub btnCariKata_Click(sender As Object, e As EventArgs) Handles btnCariKata.Click
        Dim kataDicari As String = txtCari.Text.Trim()
        Dim isiFile As String = txtOutput.Text

        If String.IsNullOrEmpty(isiFile) Then
            MessageBox.Show("Silakan baca file terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Memeriksa apakah kata ditemukan dalam file
        Dim ditemukan As Boolean = False
        Dim barisArray() As String = isiFile.Split(vbCrLf)

        ' Perulangan untuk mencari kata
        For Each baris As String In barisArray
            If baris.Contains(kataDicari) Then
                ditemukan = True
                Exit For
            End If
        Next

        ' Percabangan untuk menampilkan hasil pencarian
        If ditemukan Then
            MessageBox.Show("Kata '" & kataDicari & "' ditemukan dalam file.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Kata '" & kataDicari & "' tidak ditemukan dalam file.", "Hasil Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
