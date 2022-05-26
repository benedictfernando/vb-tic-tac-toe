Public Class Form1
    Dim cells(9) As Button
    Dim p1Turn As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to C#'s Tic-Tac-Toe Game!")
        cells = {Me.tl, Me.t, Me.tr, Me.l, Me.m, Me.r, Me.bl, Me.b, Me.br}
    End Sub

    Private Sub newGame_Click(sender As Object, e As EventArgs) Handles newGame.Click
        p1Turn = True

        For Each cell As Button In cells
            cell.Text = ""
            cell.Enabled = True
        Next
    End Sub

    Private Sub resetScore_Click(sender As Object, e As EventArgs) Handles resetScore.Click
        If MessageBox.Show("Accepting will also start a new game. " &
                "Continue?", "Reset Score", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) = DialogResult.Yes Then
            p1Score.Text = "00" : p2Score.Text = "00" : newGame.PerformClick()
        End If
    End Sub

    Private Sub cell_Click(sender As Object, e As EventArgs) Handles tr.Click, tl.Click, t.Click, r.Click, m.Click, l.Click, br.Click, bl.Click, b.Click
        Dim button = CType(sender, Button)

        If button.Enabled Then
            button.Text = If(p1Turn, "X", "O")
            p1Turn = Not p1Turn

            button.Enabled = False
            checkForWinner()
        End If
    End Sub

    Private Sub checkForWinner()
        Dim result As String = Nothing

        Dim tl As String = Me.tl.Text,
            t As String = Me.t.Text,
            tr As String = Me.tr.Text,
            l As String = Me.l.Text,
            m As String = Me.m.Text,
            r As String = Me.r.Text,
            bl As String = Me.bl.Text,
            b As String = Me.b.Text,
            br As String = Me.br.Text

        ' For trios with 'middle' button as their common cell
        If (tl = m And m = br Or t = m And m = b Or tr = m And m = bl Or r = m And m = l) And Not Me.m.Enabled Then
            result = m

            ' For trios with 'top-left' button as their common cell
        ElseIf (tl = t And t = tr Or tl = l And l = bl) And Not Me.tl.Enabled Then
            result = tl

            ' For trios with 'bottom-right' button as their common cell
        ElseIf (br = r And r = tr Or br = b And b = bl) And Not Me.br.Enabled Then
            result = br

        End If

        ' For tie situation
        If result = Nothing Then
            Dim tie As Boolean = True

            ' Check for any enabled cells
            For Each cell As Button In cells
                If cell.Enabled Then tie = False : Exit For
            Next

            If tie Then result = "Tie"
        End If

        ' For results
        If Not result = Nothing Then
            addScore(result)

            If result = "X" Then
                result = "Player 1 wins!"
            ElseIf result = "O" Then
                result = "Player 2 wins!"
            End If

            ' Start new game
            If MessageBox.Show(result) = DialogResult.OK Then
                newGame.PerformClick()
            End If
        End If
    End Sub

    Private Sub addScore(value As String)
        Dim score As Integer

        If value = "X" Then
            score = CInt(p1Score.Text)
            score += 1
            p1Score.Text = score.ToString("D2")
        ElseIf value = "O" Then
            score = CInt(p2Score.Text)
            score += 1
            p2Score.Text = score.ToString("D2")
        End If
    End Sub

    Private Sub labelChange(sender As Object, e As EventArgs) Handles tr.EnabledChanged, tl.EnabledChanged, t.EnabledChanged, r.EnabledChanged, m.EnabledChanged, l.EnabledChanged, br.EnabledChanged, bl.EnabledChanged, b.EnabledChanged
        If p1Turn Then
            p1.BackColor = SystemColors.InactiveCaption
            p2.BackColor = SystemColors.ControlDarkDark
        Else
            p1.BackColor = SystemColors.ControlDarkDark
            p2.BackColor = SystemColors.InactiveCaption
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you really sure to exit?",
                "Exit Program", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) = DialogResult.Yes Then
            MessageBox.Show("Thanks for playing with us~ " &
                "'til we meet again :)")
        Else e.Cancel = True : End If
    End Sub
End Class
