Public Class Form1
    Dim cuenta As Double
    Dim estado As Boolean
    Private Sub tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tt.Click
        cuenta = 0
        If c1.Checked Then
            cuenta = cuenta + 22.25
        End If
        If c2.Checked Then
            cuenta = cuenta + 26.5
        End If
        If c3.Checked Then
            cuenta = cuenta + 29.75
        End If
        cuenta = cuenta + 14.5 * h.Value
        cuenta = cuenta + 17 * q.Value
        cuenta = cuenta + 19.5 * ql.Value
        cuenta = cuenta + 5 * g.Value
        cuenta = cuenta + 3.5 * r.Value
        cuenta = cuenta + 5.25 * pf.Value

        tcuenta.Text = "Total a pagar: " + CStr(cuenta)
    End Sub

    Private Sub a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.CheckedChanged
        estado = a.Checked
        h.Enabled = estado
        q.Enabled = estado
        ql.Enabled = estado
        g.Enabled = estado
        r.Enabled = estado
        pf.Enabled = estado

    End Sub

    Private Sub vuelto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vuelto.Click
        cambio.Text = "Cambio: " + CStr(CInt(numeroP.Text) - cuenta)
    End Sub

    Private Sub e_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e.Click
        End
    End Sub
End Class
