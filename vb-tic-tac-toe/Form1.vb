Public Class Form1

    Dim p1Turn As Boolean = True
    Dim cells = {
        Me.tl, Me.t, Me.tr,
        Me.l, Me.m, Me.r,
        Me.bl, Me.b, Me.br
    }

    Private Sub newGame_Click(sender As Object, e As EventArgs) Handles newGame.Click
        ' to-do
    End Sub

    Private Sub resetScore_Click(sender As Object, e As EventArgs) Handles resetScore.Click
        ' to-do
    End Sub

    Private Sub cell_Click(sender As Object, e As EventArgs) Handles tr.Click, tl.Click, t.Click, r.Click, m.Click, l.Click, br.Click, bl.Click, b.Click
        Dim button = CType(sender, Button)

        If button.Enabled Then
            button.Text = If(p1Turn, "X", "O")
            p1Turn = Not p1Turn

            button.Enabled = False
            ' checkForWinner()
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
        ElseIf (br = r And r = tr Or br = b And b = bl And Not Me.br.Enabled Then
            result = br

        End If

        ' For tie situation
        If result = Nothing Then
            ' check for tie
        End If

        ' For results
        If result = Not Nothing Then
            ' add score
        End If

    End Sub
End Class
