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
End Class
