''' <summary>
''' 設定を管理するクラス
''' 例）設定の書き込み・読み出し・初期化
''' </summary>
''' <remarks></remarks>
Public Class SettingManager
    ''' <summary>
    ''' 設定ファイルのパス
    ''' </summary>
    ''' <remarks></remarks>
    Property FilePath As String
    ''' <summary>
    ''' 設定ファイルのクラス
    ''' </summary>
    ''' <remarks></remarks>
    Property Value As New SettingValue

    ''' <summary>
    ''' コンストラクタ
    ''' パス : strFilePath
    ''' </summary>
    ''' <param name="strFilePath">ファイルパス</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal strFilePath As String)
        Me.FilePath = strFilePath
    End Sub

    ''' <summary>
    ''' 設定の値を初期化する
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitializeSetting()
        Value = New SettingValue
    End Sub

    ''' <summary>
    ''' 設定ファイルが存在するか
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExistSettingFile() As Boolean
        If System.IO.File.Exists(FilePath) = False Then
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' 設定を書き出す
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SaveToFile()
        Dim serializer = New System.Xml.Serialization.XmlSerializer(Me.Value.GetType)
        Using stream As New System.IO.FileStream(FilePath, System.IO.FileMode.Create)
            serializer.Serialize(stream, Me.Value)
        End Using
    End Sub

    ''' <summary>
    ''' 設定を読み込む
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadFromFile()
        If System.IO.File.Exists(FilePath) = False Then
            SaveToFile()
        Else
            Dim serializer As New System.Xml.Serialization.XmlSerializer(Me.Value.GetType)
            Using stream = New System.IO.FileStream(FilePath, System.IO.FileMode.Open)
                ' ClassTarget = CType(serializer.Deserialize(stream), ClassTarget.GetType())
                Me.Value = serializer.Deserialize(stream)
            End Using
        End If
    End Sub
End Class
