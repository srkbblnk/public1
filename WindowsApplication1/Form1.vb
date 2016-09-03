Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("ssss" & GetFileSize("c:\test.bgh"))
    End Sub
    Public Function GetFileSize(file_path As String) As Double
        ' vraci velikost souboru na disku
        Dim gfsfi As New IO.FileInfo(file_path)
        Dim gfssize As Long = gfsfi.Length
        GetFileSize = gfssize
    End Function
End Class
