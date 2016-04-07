Public Class frmChecklists

    Private Sub btnBACK_Click(sender As Object, e As EventArgs) Handles btnBACK.Click
        Me.Close()
    End Sub

    Private Sub btnATDB_Click(sender As Object, e As EventArgs) Handles btnATDB.Click
        Me.Hide()
        frmATDBLOCK.Show()
    End Sub
End Class