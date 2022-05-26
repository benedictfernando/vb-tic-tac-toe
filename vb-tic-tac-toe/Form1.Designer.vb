<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mainTable = New System.Windows.Forms.TableLayoutPanel()
        Me.scoreBoard = New System.Windows.Forms.TableLayoutPanel()
        Me.gameOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.mainTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTable
        '
        Me.mainTable.ColumnCount = 5
        Me.mainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.mainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.mainTable.Controls.Add(Me.scoreBoard, 0, 0)
        Me.mainTable.Controls.Add(Me.gameOptions, 0, 4)
        Me.mainTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTable.Location = New System.Drawing.Point(0, 0)
        Me.mainTable.Name = "mainTable"
        Me.mainTable.RowCount = 5
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.mainTable.Size = New System.Drawing.Size(480, 457)
        Me.mainTable.TabIndex = 0
        '
        'scoreBoard
        '
        Me.scoreBoard.ColumnCount = 6
        Me.mainTable.SetColumnSpan(Me.scoreBoard, 5)
        Me.scoreBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.scoreBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.scoreBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.scoreBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.scoreBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.scoreBoard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.scoreBoard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scoreBoard.Location = New System.Drawing.Point(3, 3)
        Me.scoreBoard.Name = "scoreBoard"
        Me.scoreBoard.RowCount = 1
        Me.scoreBoard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.scoreBoard.Size = New System.Drawing.Size(474, 51)
        Me.scoreBoard.TabIndex = 0
        '
        'gameOptions
        '
        Me.gameOptions.ColumnCount = 4
        Me.mainTable.SetColumnSpan(Me.gameOptions, 5)
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.gameOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gameOptions.Location = New System.Drawing.Point(3, 402)
        Me.gameOptions.Name = "gameOptions"
        Me.gameOptions.RowCount = 1
        Me.gameOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gameOptions.Size = New System.Drawing.Size(474, 52)
        Me.gameOptions.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(480, 457)
        Me.Controls.Add(Me.mainTable)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic-Tac-Toe"
        Me.mainTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTable As TableLayoutPanel
    Friend WithEvents scoreBoard As TableLayoutPanel
    Friend WithEvents gameOptions As TableLayoutPanel
End Class
