Public Class FolderRemover
    Public RemoveFolders As New List(Of System.IO.DirectoryInfo)
    Public IgnoreFiles As New List(Of String)

    Public Function CheckFolder(Directory As System.IO.DirectoryInfo) As Boolean
        Dim Remove As Boolean = True

        'サブフォルダを処理
        For Each SubDirectory As System.IO.DirectoryInfo In Directory.GetDirectories()
            If CheckFolder(SubDirectory) Then
                'サブフォルダ削除する
                'フラグ変更無し
            Else
                'サブフォルダ削除しない
                Remove = False
            End If
        Next

        '持ってるファイルを検証
        If Remove Then
            For Each File As System.IO.FileInfo In Directory.GetFiles("*", IO.SearchOption.TopDirectoryOnly)
                '無条件で無視NG
                If IgnoreFiles.Count <= 0 Then
                    Remove = False
                    Exit For
                End If
                '無視OKリストにいるか
                Dim IgnoreOK As Boolean = False
                For Each Ignore As String In IgnoreFiles
                    If System.Text.RegularExpressions.Regex.IsMatch(File.Name, Ignore, System.Text.RegularExpressions.RegexOptions.IgnoreCase) Then
                        'Match→無視してOK
                        IgnoreOK = True
                        Exit For
                    End If
                Next
                If IgnoreOK Then
                    '無視してOK
                    '何もしない
                Else
                    '無視NG->フラグ下ろす
                    Remove = False
                    Exit For
                End If
            Next
        End If

        '削除対象へ登録
        If Remove Then
            RemoveFolders.Add(Directory)
        End If
        '削除するかフラグを返す
        Return Remove
    End Function
End Class
