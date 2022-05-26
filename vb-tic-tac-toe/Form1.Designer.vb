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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gameOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
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
        Me.mainTable.Controls.Add(Me.Button1, 1, 1)
        Me.mainTable.Controls.Add(Me.Button2, 2, 1)
        Me.mainTable.Controls.Add(Me.Button3, 3, 1)
        Me.mainTable.Controls.Add(Me.Button4, 1, 2)
        Me.mainTable.Controls.Add(Me.Button5, 2, 2)
        Me.mainTable.Controls.Add(Me.Button6, 3, 2)
        Me.mainTable.Controls.Add(Me.Button7, 1, 3)
        Me.mainTable.Controls.Add(Me.Button8, 2, 3)
        Me.mainTable.Controls.Add(Me.Button9, 3, 3)
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
        Me.scoreBoard.Controls.Add(Me.Label1, 1, 0)
        Me.scoreBoard.Controls.Add(Me.Label2, 4, 0)
        Me.scoreBoard.Controls.Add(Me.Label3, 2, 0)
        Me.scoreBoard.Controls.Add(Me.Label4, 3, 0)
        Me.scoreBoard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scoreBoard.Location = New System.Drawing.Point(3, 3)
        Me.scoreBoard.Name = "scoreBoard"
        Me.scoreBoard.RowCount = 1
        Me.scoreBoard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.scoreBoard.Size = New System.Drawing.Size(474, 51)
        Me.scoreBoard.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(31, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(305, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 51)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player 2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(173, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 51)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(239, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 51)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "00"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gameOptions
        '
        Me.gameOptions.ColumnCount = 4
        Me.mainTable.SetColumnSpan(Me.gameOptions, 5)
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.gameOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.gameOptions.Controls.Add(Me.Button10, 1, 0)
        Me.gameOptions.Controls.Add(Me.Button11, 2, 0)
        Me.gameOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gameOptions.Location = New System.Drawing.Point(3, 402)
        Me.gameOptions.Name = "gameOptions"
        Me.gameOptions.RowCount = 1
        Me.gameOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.gameOptions.Size = New System.Drawing.Size(474, 52)
        Me.gameOptions.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(63, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 108)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(183, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 108)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(303, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 108)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Location = New System.Drawing.Point(63, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 108)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.Location = New System.Drawing.Point(183, 174)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 108)
        Me.Button5.TabIndex = 6
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Location = New System.Drawing.Point(303, 174)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 108)
        Me.Button6.TabIndex = 7
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.Location = New System.Drawing.Point(63, 288)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 108)
        Me.Button7.TabIndex = 8
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.Location = New System.Drawing.Point(183, 288)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(114, 108)
        Me.Button8.TabIndex = 9
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.Location = New System.Drawing.Point(303, 288)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(114, 108)
        Me.Button9.TabIndex = 10
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Button10.Location = New System.Drawing.Point(31, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(202, 46)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "New Game"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button11.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Button11.Location = New System.Drawing.Point(239, 3)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(202, 46)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Reset Score"
        Me.Button11.UseVisualStyleBackColor = True
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
End Class
