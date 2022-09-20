Public Class Form1
    Private valor As Decimal
    Private quantia As Decimal
    Private saldoTotal As Decimal
    Private _TxtCliente As Object

    Public ReadOnly Property TxtCliente As Object
        Get
            Return _TxtCliente
        End Get
    End Property

    Public Sub SetTxtCliente(AutoPropertyValue As Object)
        _TxtCliente = AutoPropertyValue
    End Sub

    Private Sub btnCriar_Click(sender As Object, e As EventArgs) Handles btnCriar.Click
        Dim obj_conta As New Poupanca("101005", "Thais", "100,00", "24/09/1991")
        Dim pconta As Integer = obj_conta.pconta
        txtConta.Text = pconta
        Dim pnome As String = obj_conta.pnome
        txtNome.Text = pnome
        txtSaldo.Text = obj_conta.psaldo
        txtAniversario.Text = obj_conta.pAniversario

    End Sub

    Private Sub coversor(sender As Object, e As EventArgs) Handles btnDepositar.Click
        valor = Decimal.Parse(txtValor.Text)
        quantia = Decimal.Parse(txtSaldo.Text)
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        saldoTotal = quantia + valor
        txtSaldoTotal.Text = saldoTotal
    End Sub

    Private Sub btnSacar_Click(sender As Object, e As EventArgs) Handles btnSacar.Click
        saldoTotal = quantia - valor
        txtSaldoTotal.Text = saldoTotal
    End Sub

    Private Sub txtSaldo1_TextChanged(sender As Object, e As EventArgs) Handles txtSaldoTotal.TextChanged

    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged

    End Sub

    Private Sub TxtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged, txtNome.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
