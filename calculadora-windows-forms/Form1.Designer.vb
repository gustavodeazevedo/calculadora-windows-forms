<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblX = New Label()
        lblY = New Label()
        lblTotal = New Label()
        txtX = New TextBox()
        txtY = New TextBox()
        txtTotal = New TextBox()
        grpAritmetica = New GroupBox()
        rdbDividir = New RadioButton()
        rdbMultiplicar = New RadioButton()
        rdbSubtrair = New RadioButton()
        rdbSomar = New RadioButton()
        btnLimpar = New Button()
        btnCalcular = New Button()
        btnFechar = New Button()
        grpAritmetica.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblX
        ' 
        lblX.AutoSize = True
        lblX.Location = New Point(34, 22)
        lblX.Name = "lblX"
        lblX.Size = New Size(18, 20)
        lblX.TabIndex = 0
        lblX.Text = "X"
        ' 
        ' lblY
        ' 
        lblY.AutoSize = True
        lblY.Location = New Point(34, 72)
        lblY.Name = "lblY"
        lblY.Size = New Size(17, 20)
        lblY.TabIndex = 1
        lblY.Text = "Y"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(34, 127)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(42, 20)
        lblTotal.TabIndex = 2
        lblTotal.Text = "Total"
        ' 
        ' txtX
        ' 
        txtX.Location = New Point(104, 19)
        txtX.Name = "txtX"
        txtX.Size = New Size(112, 27)
        txtX.TabIndex = 3
        ' 
        ' txtY
        ' 
        txtY.Location = New Point(104, 69)
        txtY.Name = "txtY"
        txtY.Size = New Size(112, 27)
        txtY.TabIndex = 4
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(104, 120)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(112, 27)
        txtTotal.TabIndex = 5
        ' 
        ' grpAritmetica
        ' 
        grpAritmetica.Controls.Add(rdbDividir)
        grpAritmetica.Controls.Add(rdbMultiplicar)
        grpAritmetica.Controls.Add(rdbSubtrair)
        grpAritmetica.Controls.Add(rdbSomar)
        grpAritmetica.Location = New Point(34, 177)
        grpAritmetica.Name = "grpAritmetica"
        grpAritmetica.Size = New Size(150, 163)
        grpAritmetica.TabIndex = 8
        grpAritmetica.TabStop = False
        grpAritmetica.Text = "Operações"
        ' 
        ' rdbDividir
        ' 
        rdbDividir.AutoSize = True
        rdbDividir.Location = New Point(16, 126)
        rdbDividir.Name = "rdbDividir"
        rdbDividir.Size = New Size(74, 24)
        rdbDividir.TabIndex = 10
        rdbDividir.TabStop = True
        rdbDividir.Text = "Dividir"
        rdbDividir.UseVisualStyleBackColor = True
        ' 
        ' rdbMultiplicar
        ' 
        rdbMultiplicar.AutoSize = True
        rdbMultiplicar.Location = New Point(16, 96)
        rdbMultiplicar.Name = "rdbMultiplicar"
        rdbMultiplicar.Size = New Size(101, 24)
        rdbMultiplicar.TabIndex = 10
        rdbMultiplicar.TabStop = True
        rdbMultiplicar.Text = "Multiplicar"
        rdbMultiplicar.UseVisualStyleBackColor = True
        ' 
        ' rdbSubtrair
        ' 
        rdbSubtrair.AutoSize = True
        rdbSubtrair.Location = New Point(16, 66)
        rdbSubtrair.Name = "rdbSubtrair"
        rdbSubtrair.Size = New Size(82, 24)
        rdbSubtrair.TabIndex = 10
        rdbSubtrair.TabStop = True
        rdbSubtrair.Text = "Subtrair"
        rdbSubtrair.UseVisualStyleBackColor = True
        ' 
        ' rdbSomar
        ' 
        rdbSomar.AutoSize = True
        rdbSomar.Checked = True
        rdbSomar.Location = New Point(16, 36)
        rdbSomar.Name = "rdbSomar"
        rdbSomar.Size = New Size(73, 24)
        rdbSomar.TabIndex = 9
        rdbSomar.TabStop = True
        rdbSomar.Text = "Somar"
        rdbSomar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.Location = New Point(12, 346)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(78, 28)
        btnLimpar.TabIndex = 9
        btnLimpar.Text = "Limpar"
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(125, 346)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(78, 28)
        btnCalcular.TabIndex = 10
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnFechar
        ' 
        btnFechar.Location = New Point(64, 380)
        btnFechar.Name = "btnFechar"
        btnFechar.Size = New Size(78, 28)
        btnFechar.TabIndex = 11
        btnFechar.Text = "Fechar"
        btnFechar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(256, 450)
        Controls.Add(btnFechar)
        Controls.Add(btnCalcular)
        Controls.Add(btnLimpar)
        Controls.Add(grpAritmetica)
        Controls.Add(txtTotal)
        Controls.Add(txtY)
        Controls.Add(txtX)
        Controls.Add(lblTotal)
        Controls.Add(lblY)
        Controls.Add(lblX)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Opacity = 0.5R
        Text = "Calculadora"
        grpAritmetica.ResumeLayout(False)
        grpAritmetica.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents grpAritmetica As GroupBox
    Friend WithEvents rdbSomar As RadioButton
    Friend WithEvents rdbDividir As RadioButton
    Friend WithEvents rdbMultiplicar As RadioButton
    Friend WithEvents rdbSubtrair As RadioButton
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnFechar As Button

End Class
