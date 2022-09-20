<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtConta = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtAniversario = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.btnCriar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnSacar = New System.Windows.Forms.Button()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblAniversario = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblSaldo1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtConta
        '
        Me.txtConta.Location = New System.Drawing.Point(121, 27)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(311, 22)
        Me.txtConta.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(121, 87)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(311, 22)
        Me.txtNome.TabIndex = 2
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(121, 146)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(311, 22)
        Me.txtSaldo.TabIndex = 3
        '
        'txtAniversario
        '
        Me.txtAniversario.Location = New System.Drawing.Point(121, 200)
        Me.txtAniversario.Name = "txtAniversario"
        Me.txtAniversario.Size = New System.Drawing.Size(311, 22)
        Me.txtAniversario.TabIndex = 4
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(74, 302)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(99, 22)
        Me.txtValor.TabIndex = 5
        '
        'txtSaldoTotal
        '
        Me.txtSaldoTotal.Location = New System.Drawing.Point(395, 304)
        Me.txtSaldoTotal.Name = "txtSaldoTotal"
        Me.txtSaldoTotal.Size = New System.Drawing.Size(99, 22)
        Me.txtSaldoTotal.TabIndex = 6
        '
        'btnCriar
        '
        Me.btnCriar.Location = New System.Drawing.Point(476, 108)
        Me.btnCriar.Name = "btnCriar"
        Me.btnCriar.Size = New System.Drawing.Size(75, 31)
        Me.btnCriar.TabIndex = 7
        Me.btnCriar.Text = "Criar"
        Me.btnCriar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(231, 261)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(95, 29)
        Me.btnDepositar.TabIndex = 8
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'btnSacar
        '
        Me.btnSacar.Location = New System.Drawing.Point(231, 325)
        Me.btnSacar.Name = "btnSacar"
        Me.btnSacar.Size = New System.Drawing.Size(95, 28)
        Me.btnSacar.TabIndex = 9
        Me.btnSacar.Text = "Sacar"
        Me.btnSacar.UseVisualStyleBackColor = True
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(34, 32)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(45, 17)
        Me.lblConta.TabIndex = 10
        Me.lblConta.Text = "Conta"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(34, 90)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(51, 17)
        Me.lblCliente.TabIndex = 11
        Me.lblCliente.Text = "Cliente"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(35, 152)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(44, 17)
        Me.lblSaldo.TabIndex = 12
        Me.lblSaldo.Text = "Saldo"
        '
        'lblAniversario
        '
        Me.lblAniversario.AutoSize = True
        Me.lblAniversario.Location = New System.Drawing.Point(34, 205)
        Me.lblAniversario.Name = "lblAniversario"
        Me.lblAniversario.Size = New System.Drawing.Size(79, 17)
        Me.lblAniversario.TabIndex = 13
        Me.lblAniversario.Text = "Aniversário"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(75, 273)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(41, 17)
        Me.lblValor.TabIndex = 14
        Me.lblValor.Text = "Valor"
        '
        'lblSaldo1
        '
        Me.lblSaldo1.AutoSize = True
        Me.lblSaldo1.Location = New System.Drawing.Point(398, 272)
        Me.lblSaldo1.Name = "lblSaldo1"
        Me.lblSaldo1.Size = New System.Drawing.Size(44, 17)
        Me.lblSaldo1.TabIndex = 15
        Me.lblSaldo1.Text = "Saldo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 382)
        Me.Controls.Add(Me.lblSaldo1)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblAniversario)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblConta)
        Me.Controls.Add(Me.btnSacar)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.btnCriar)
        Me.Controls.Add(Me.txtSaldoTotal)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtAniversario)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtConta)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtConta As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtAniversario As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtSaldoTotal As TextBox
    Friend WithEvents btnCriar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnSacar As Button
    Friend WithEvents lblConta As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblAniversario As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents lblSaldo1 As Label
End Class
