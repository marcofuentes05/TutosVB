Public Class Form1
    Dim contador = 0
    Dim totalN As Integer
    Dim siCuenta As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If siCuenta = True Then
            totalN = 0
            If SO1.Checked Then
                totalN = totalN + 1
            End If
            If SO2.Checked Then
                totalN = totalN + 1
            End If
            If SO3.Checked Then
                totalN = totalN + 1
            End If
            If V1.Checked Then
                totalN = totalN + 1
            End If
            If V2.Checked Then
                totalN = totalN + 1
            End If
            If V3.Checked Then
                totalN = totalN + 1
            End If
            If V4.Checked Then
                totalN = totalN + 1
            End If

            If rd1.Text = "CPU" Then
                totalN = totalN + 1
            End If

            If rd2.Text = "bajo" Then
                totalN = totalN + 1
            End If
            total.Text = "Total: " + CStr(totalN) + "/9"
        End If
        


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        contador = contador + 1
        If contador < 5 Then
            OpcionMultiple.Enabled = True
        Else
            OpcionMultiple.Enabled = False
        End If

        If contador >= 5 And contador < 10 Then
            VF.Enabled = True
        Else
            VF.Enabled = False
        End If

        If contador >= 10 And contador < 15 Then
            RD.Enabled = True
        Else
            RD.Enabled = False
        End If
    End Sub

    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        Timer1.Start()
        Timer1.Interval = 1000
        siCuenta = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox1.Enabled = False
        CheckBox3.Enabled = False
        SO1.Enabled = False
    End Sub

    Private Sub SO1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SO1.CheckedChanged
        CheckBox1.Enabled = False
        CheckBox3.Enabled = False
        SO1.Enabled = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox1.Enabled = False
        CheckBox3.Enabled = False
        SO1.Enabled = False
    End Sub


    Private Sub SO2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SO2.CheckedChanged
        CheckBox5.Enabled = False
        CheckBox4.Enabled = False
        SO2.Enabled = False
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        CheckBox5.Enabled = False
        CheckBox4.Enabled = False
        SO2.Enabled = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        CheckBox5.Enabled = False
        CheckBox4.Enabled = False
        SO2.Enabled = False
    End Sub

    Private Sub SO3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SO3.CheckedChanged
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        SO3.Enabled = False
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        SO3.Enabled = False
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        SO3.Enabled = False
    End Sub

    Private Sub rd1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd1.TextChanged
        rd1.Enabled = False
    End Sub

    Private Sub rd2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd2.TextChanged
        rd2.Enabled = False
    End Sub

    Private Sub V1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V1.CheckedChanged
        V1.Enabled = False
        CheckBox11.Enabled = False

    End Sub
    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        V1.Enabled = False
        CheckBox11.Enabled = False
    End Sub
    Private Sub V2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V2.CheckedChanged
        V2.Enabled = False
        CheckBox12.Enabled = False
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        V2.Enabled = False
        CheckBox12.Enabled = False
    End Sub

    Private Sub V3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V3.CheckedChanged
        V3.Enabled = False
        CheckBox14.Enabled = False
    End Sub
    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        V3.Enabled = False
        CheckBox14.Enabled = False
    End Sub
    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        V4.Enabled = False
        CheckBox17.Enabled = False
    End Sub
    Private Sub V4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles V4.CheckedChanged
        V4.Enabled = False
        CheckBox17.Enabled = False
    End Sub
End Class
