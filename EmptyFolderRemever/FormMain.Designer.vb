<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSelectFolder = New System.Windows.Forms.Button()
        Me.TextBoxRootFilder = New System.Windows.Forms.TextBox()
        Me.ButtonCheckRootFolder = New System.Windows.Forms.Button()
        Me.DataGridViewEmptyFolders = New System.Windows.Forms.DataGridView()
        Me.ColumnNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRemoveFolders = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridViewEmptyFolders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonRemoveFolders, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridViewEmptyFolders, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSelectFolder, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxRootFilder, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonCheckRootFolder, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(718, 721)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(612, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ルートフォルダ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonSelectFolder
        '
        Me.ButtonSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSelectFolder.Location = New System.Drawing.Point(621, 3)
        Me.ButtonSelectFolder.Name = "ButtonSelectFolder"
        Me.TableLayoutPanel1.SetRowSpan(Me.ButtonSelectFolder, 2)
        Me.ButtonSelectFolder.Size = New System.Drawing.Size(94, 39)
        Me.ButtonSelectFolder.TabIndex = 1
        Me.ButtonSelectFolder.Text = "フォルダ選択"
        Me.ButtonSelectFolder.UseVisualStyleBackColor = True
        '
        'TextBoxRootFilder
        '
        Me.TextBoxRootFilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxRootFilder.Location = New System.Drawing.Point(3, 23)
        Me.TextBoxRootFilder.Name = "TextBoxRootFilder"
        Me.TextBoxRootFilder.Size = New System.Drawing.Size(612, 19)
        Me.TextBoxRootFilder.TabIndex = 0
        '
        'ButtonCheckRootFolder
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonCheckRootFolder, 2)
        Me.ButtonCheckRootFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCheckRootFolder.Location = New System.Drawing.Point(3, 48)
        Me.ButtonCheckRootFolder.Name = "ButtonCheckRootFolder"
        Me.ButtonCheckRootFolder.Size = New System.Drawing.Size(712, 34)
        Me.ButtonCheckRootFolder.TabIndex = 2
        Me.ButtonCheckRootFolder.Text = "解析"
        Me.ButtonCheckRootFolder.UseVisualStyleBackColor = True
        '
        'DataGridViewEmptyFolders
        '
        Me.DataGridViewEmptyFolders.AllowUserToAddRows = False
        Me.DataGridViewEmptyFolders.AllowUserToDeleteRows = False
        Me.DataGridViewEmptyFolders.AllowUserToResizeRows = False
        Me.DataGridViewEmptyFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmptyFolders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNum, Me.ColumnPath})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DataGridViewEmptyFolders, 2)
        Me.DataGridViewEmptyFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewEmptyFolders.Location = New System.Drawing.Point(3, 88)
        Me.DataGridViewEmptyFolders.Name = "DataGridViewEmptyFolders"
        Me.DataGridViewEmptyFolders.ReadOnly = True
        Me.DataGridViewEmptyFolders.RowHeadersVisible = False
        Me.DataGridViewEmptyFolders.RowTemplate.Height = 21
        Me.DataGridViewEmptyFolders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEmptyFolders.Size = New System.Drawing.Size(712, 590)
        Me.DataGridViewEmptyFolders.TabIndex = 4
        '
        'ColumnNum
        '
        Me.ColumnNum.HeaderText = "#"
        Me.ColumnNum.Name = "ColumnNum"
        Me.ColumnNum.ReadOnly = True
        Me.ColumnNum.Width = 20
        '
        'ColumnPath
        '
        Me.ColumnPath.HeaderText = "Path"
        Me.ColumnPath.Name = "ColumnPath"
        Me.ColumnPath.ReadOnly = True
        Me.ColumnPath.Width = 400
        '
        'ButtonRemoveFolders
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ButtonRemoveFolders, 2)
        Me.ButtonRemoveFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRemoveFolders.Location = New System.Drawing.Point(3, 684)
        Me.ButtonRemoveFolders.Name = "ButtonRemoveFolders"
        Me.ButtonRemoveFolders.Size = New System.Drawing.Size(712, 34)
        Me.ButtonRemoveFolders.TabIndex = 3
        Me.ButtonRemoveFolders.Text = "削除実行"
        Me.ButtonRemoveFolders.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 721)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormMain"
        Me.Text = "EmptyFolderRemover"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridViewEmptyFolders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectFolder As System.Windows.Forms.Button
    Friend WithEvents TextBoxRootFilder As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCheckRootFolder As System.Windows.Forms.Button
    Friend WithEvents DataGridViewEmptyFolders As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonRemoveFolders As System.Windows.Forms.Button
    Friend WithEvents ColumnNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPath As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
