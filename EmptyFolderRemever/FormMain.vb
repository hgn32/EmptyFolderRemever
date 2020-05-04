Public Class FormMain
    Private FolderRemover As New FolderRemover

    Private Sub listup_emptyfolder(Path As String)
        DataGridViewEmptyFolders.Rows.Clear()
        FolderRemover.RemoveFolders.Clear()
        FolderRemover.CheckFolder(New System.IO.DirectoryInfo(Path))
        Dim Count As Integer = 1
        For Each Directory As System.IO.DirectoryInfo In FolderRemover.RemoveFolders
            Dim NewRow As Integer = DataGridViewEmptyFolders.Rows.Add()
            DataGridViewEmptyFolders.Rows(NewRow).Cells("ColumnNum").Value = Count
            DataGridViewEmptyFolders.Rows(NewRow).Cells("ColumnPath").Value = Directory.FullName.Substring(Path.Length)
            Count = Count + 1
        Next

        If Count = 1 Then
            MessageBox.Show("空のフォルダはありません", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub lockform(Enable As Boolean)
        If Enable Then
            ButtonSelectFolder.Enabled = True
            TextBoxRootFilder.Enabled = True
            ButtonCheckRootFolder.Enabled = True
            DataGridViewEmptyFolders.Enabled = True
            ButtonRemoveFolders.Enabled = True
        Else
            ButtonSelectFolder.Enabled = False
            TextBoxRootFilder.Enabled = False
            ButtonCheckRootFolder.Enabled = False
            DataGridViewEmptyFolders.Enabled = False
            ButtonRemoveFolders.Enabled = False
        End If
    End Sub



    ''' <summary>
    ''' フォルダ選択
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonSelectFolder_Click(sender As Object, e As EventArgs) Handles ButtonSelectFolder.Click
        Try
            lockform(False)
            Dim Path As String = TextBoxRootFilder.Text
            Dim Dialog As New FolderBrowserDialog
            Dialog.Description = "フォルダを指定してください"
            Dialog.RootFolder = Environment.SpecialFolder.Desktop
            If System.IO.Directory.Exists(Path) Then
                Dialog.SelectedPath = Path
            End If
            If Dialog.ShowDialog(Me) = DialogResult.OK Then
                TextBoxRootFilder.Text = Dialog.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            lockform(True)
        End Try
    End Sub









    ''' <summary>
    ''' アプリ実行時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'コマンドライン引数を取得
            Dim CommandLines As String() = System.Environment.GetCommandLineArgs()
            Dim First As Boolean = True
            Dim Exist As Boolean = False
            For Each Command As String In CommandLines
                If First Then
                    First = False
                    Continue For
                End If
                If Command = "" Then
                    Continue For
                End If
                If System.IO.Directory.Exists(Command) Then
                    TextBoxRootFilder.Text = Command
                    Exist = True
                End If
            Next

            Dim Setting As New SettingManager(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "setting.xml"))
            Setting.InitializeSetting()
            Setting.LoadFromFile()
            FolderRemover.IgnoreFiles = Setting.Value.IgnoreFilePatterns

            If Exist Then
                listup_emptyfolder(TextBoxRootFilder.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' フォルダの解析
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonCheckRootFolder_Click(sender As Object, e As EventArgs) Handles ButtonCheckRootFolder.Click
        Try
            lockform(False)
            Dim Path As String = TextBoxRootFilder.Text
            If System.IO.Directory.Exists(Path) = False Then
                Throw New Exception("検索ルートフォルダがありません ")
            End If
            listup_emptyfolder(Path)
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            lockform(True)
        End Try
    End Sub


    ''' <summary>
    ''' 削除の実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonRemoveFolders_Click(sender As Object, e As EventArgs) Handles ButtonRemoveFolders.Click
        Try
            lockform(False)
            For Each Directory As System.IO.DirectoryInfo In FolderRemover.RemoveFolders
                'My.Computer.FileSystem.DeleteDirectory FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                System.IO.Directory.Delete(Directory.FullName, True)
            Next
            Dim Path As String = TextBoxRootFilder.Text
            listup_emptyfolder(Path)
            MessageBox.Show("削除完了", My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            lockform(True)
        End Try
    End Sub
End Class
