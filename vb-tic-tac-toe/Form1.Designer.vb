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
        Me.p1 = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.Label()
        Me.p1Score = New System.Windows.Forms.Label()
        Me.p2Score = New System.Windows.Forms.Label()
        Me.gameOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.tl = New System.Windows.Forms.Button()
        Me.t = New System.Windows.Forms.Button()
        Me.tr = New System.Windows.Forms.Button()
        Me.l = New System.Windows.Forms.Button()
        Me.m = New System.Windows.Forms.Button()
        Me.r = New System.Windows.Forms.Button()
        Me.bl = New System.Windows.Forms.Button()
        Me.b = New System.Windows.Forms.Button()
        Me.br = New System.Windows.Forms.Button()
        Me.newGame = New System.Windows.Forms.Button()
        Me.resetScore = New System.Windows.Forms.Button()
        Me.mainTable.SuspendLayout()
        Me.scoreBoard.SuspendLayout()
        Me.gameOptions.SuspendLayout()
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
        Me.mainTable.Controls.Add(Me.tl, 1, 1)
        Me.mainTable.Controls.Add(Me.t, 2, 1)
        Me.mainTable.Controls.Add(Me.tr, 3, 1)
        Me.mainTable.Controls.Add(Me.l, 1, 2)
        Me.mainTable.Controls.Add(Me.m, 2, 2)
        Me.mainTable.Controls.Add(Me.r, 3, 2)
        Me.mainTable.Controls.Add(Me.bl, 1, 3)
        Me.mainTable.Controls.Add(Me.b, 2, 3)
        Me.mainTable.Controls.Add(Me.br, 3, 3)
        Me.mainTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTable.Location = New System.Drawing.Point(0, 0)
        Me.mainTable.Name = "mainTable"
        Me.mainTable.RowCount = 5
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.mainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.scoreBoard.Controls.Add(Me.p1, 1, 0)
        Me.scoreBoard.Controls.Add(Me.p2, 4, 0)
        Me.scoreBoard.Controls.Add(Me.p1Score, 2, 0)
        Me.scoreBoard.Controls.Add(Me.p2Score, 3, 0)
        Me.scoreBoard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scoreBoard.Location = New System.Drawing.Point(3, 3)
        Me.scoreBoard.Name = "scoreBoard"
        Me.scoreBoard.RowCount = 1
        Me.scoreBoard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.scoreBoard.Size = New System.Drawing.Size(474, 51)
        Me.scoreBoard.TabIndex = 0
        '
        'p1
        '
        Me.p1.AutoSize = True
        Me.p1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.p1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.p1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.p1.Location = New System.Drawing.Point(31, 0)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(136, 51)
        Me.p1.TabIndex = 0
        Me.p1.Text = "Player 1"
        Me.p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'p2
        '
        Me.p2.AutoSize = True
        Me.p2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.p2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.p2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.p2.Location = New System.Drawing.Point(305, 0)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(136, 51)
        Me.p2.TabIndex = 1
        Me.p2.Text = "Player 2"
        Me.p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'p1Score
        '
        Me.p1Score.AutoSize = True
        Me.p1Score.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p1Score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p1Score.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.p1Score.Location = New System.Drawing.Point(173, 0)
        Me.p1Score.Name = "p1Score"
        Me.p1Score.Size = New System.Drawing.Size(60, 51)
        Me.p1Score.TabIndex = 2
        Me.p1Score.Text = "00"
        Me.p1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'p2Score
        '
        Me.p2Score.AutoSize = True
        Me.p2Score.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p2Score.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p2Score.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.p2Score.Location = New System.Drawing.Point(239, 0)
        Me.p2Score.Name = "p2Score"
        Me.p2Score.Size = New System.Drawing.Size(60, 51)
        Me.p2Score.TabIndex = 3
        Me.p2Score.Text = "00"
        Me.p2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gameOptions
        '
        Me.gameOptions.ColumnCount = 4
        Me.mainTable.SetColumnSpan(Me.gameOptions, 5)
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.gameOptions.Controls.Add(Me.newGame, 1, 0)
        Me.gameOptions.Controls.Add(Me.resetScore, 2, 0)
        Me.gameOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gameOptions.Location = New System.Drawing.Point(3, 402)
        Me.gameOptions.Name = "gameOptions"
        Me.gameOptions.RowCount = 1
        Me.gameOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gameOptions.Size = New System.Drawing.Size(474, 52)
        Me.gameOptions.TabIndex = 1
        '
        'tl
        '
        Me.tl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tl.Location = New System.Drawing.Point(63, 60)
        Me.tl.Name = "tl"
        Me.tl.Size = New System.Drawing.Size(114, 108)
        Me.tl.TabIndex = 2
        Me.tl.UseVisualStyleBackColor = True
        '
        't
        '
        Me.t.Cursor = System.Windows.Forms.Cursors.Hand
        Me.t.Dock = System.Windows.Forms.DockStyle.Fill
        Me.t.Location = New System.Drawing.Point(183, 60)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(114, 108)
        Me.t.TabIndex = 3
        Me.t.UseVisualStyleBackColor = True
        '
        'tr
        '
        Me.tr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tr.Location = New System.Drawing.Point(303, 60)
        Me.tr.Name = "tr"
        Me.tr.Size = New System.Drawing.Size(114, 108)
        Me.tr.TabIndex = 4
        Me.tr.UseVisualStyleBackColor = True
        '
        'l
        '
        Me.l.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l.Dock = System.Windows.Forms.DockStyle.Fill
        Me.l.Location = New System.Drawing.Point(63, 174)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(114, 108)
        Me.l.TabIndex = 5
        Me.l.UseVisualStyleBackColor = True
        '
        'm
        '
        Me.m.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m.Dock = System.Windows.Forms.DockStyle.Fill
        Me.m.Location = New System.Drawing.Point(183, 174)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(114, 108)
        Me.m.TabIndex = 6
        Me.m.UseVisualStyleBackColor = True
        '
        'r
        '
        Me.r.Cursor = System.Windows.Forms.Cursors.Hand
        Me.r.Dock = System.Windows.Forms.DockStyle.Fill
        Me.r.Location = New System.Drawing.Point(303, 174)
        Me.r.Name = "r"
        Me.r.Size = New System.Drawing.Size(114, 108)
        Me.r.TabIndex = 7
        Me.r.UseVisualStyleBackColor = True
        '
        'bl
        '
        Me.bl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bl.Location = New System.Drawing.Point(63, 288)
        Me.bl.Name = "bl"
        Me.bl.Size = New System.Drawing.Size(114, 108)
        Me.bl.TabIndex = 8
        Me.bl.UseVisualStyleBackColor = True
        '
        'b
        '
        Me.b.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b.Location = New System.Drawing.Point(183, 288)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(114, 108)
        Me.b.TabIndex = 9
        Me.b.UseVisualStyleBackColor = True
        '
        'br
        '
        Me.br.Cursor = System.Windows.Forms.Cursors.Hand
        Me.br.Dock = System.Windows.Forms.DockStyle.Fill
        Me.br.Location = New System.Drawing.Point(303, 288)
        Me.br.Name = "br"
        Me.br.Size = New System.Drawing.Size(114, 108)
        Me.br.TabIndex = 10
        Me.br.UseVisualStyleBackColor = True
        '
        'newGame
        '
        Me.newGame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.newGame.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.newGame.Location = New System.Drawing.Point(31, 3)
        Me.newGame.Name = "newGame"
        Me.newGame.Size = New System.Drawing.Size(202, 46)
        Me.newGame.TabIndex = 0
        Me.newGame.Text = "New Game"
        Me.newGame.UseVisualStyleBackColor = True
        '
        'resetScore
        '
        Me.resetScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resetScore.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.resetScore.Location = New System.Drawing.Point(239, 3)
        Me.resetScore.Name = "resetScore"
        Me.resetScore.Size = New System.Drawing.Size(202, 46)
        Me.resetScore.TabIndex = 1
        Me.resetScore.Text = "Reset Score"
        Me.resetScore.UseVisualStyleBackColor = True
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
        Me.scoreBoard.ResumeLayout(False)
        Me.scoreBoard.PerformLayout()
        Me.gameOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTable As TableLayoutPanel
    Friend WithEvents scoreBoard As TableLayoutPanel
    Friend WithEvents gameOptions As TableLayoutPanel
    Friend WithEvents tl As Button
    Friend WithEvents t As Button
    Friend WithEvents tr As Button
    Friend WithEvents l As Button
    Friend WithEvents m As Button
    Friend WithEvents r As Button
    Friend WithEvents bl As Button
    Friend WithEvents b As Button
    Friend WithEvents br As Button
    Friend WithEvents p1 As Label
    Friend WithEvents p2 As Label
    Friend WithEvents p1Score As Label
    Friend WithEvents p2Score As Label
    Friend WithEvents newGame As Button
    Friend WithEvents resetScore As Button
End Class
