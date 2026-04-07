Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblX.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtX.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSomar.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMultiplicar.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDividir.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtTotal.Clear()
        txtX.Clear()
        txtY.Clear()
        txtX.Focus()
        rdbSomar.Checked = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim x As Double
        Dim y As Double
        Dim total As Double

        If Double.TryParse(txtX.Text, x) = False Then
            MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtX.Clear()
            txtX.Focus()
            Return
        End If

        If Double.TryParse(txtY.Text, y) = False Then
            MessageBox.Show("Informe um valor válido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtY.Clear()
            txtY.Focus()
            Return
        End If

        If rdbSomar.Checked Then
            total = x + y
        ElseIf rdbSubtrair.Checked Then
            total = x - y
        ElseIf rdbMultiplicar.Checked Then
            total = x * y
        Else
            If y = 0 Then
                txtTotal.Text = "Divisão por zero"
                Return
            End If

            total = x / y
        End If

        txtTotal.Text = total.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.7R
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub
End Class
