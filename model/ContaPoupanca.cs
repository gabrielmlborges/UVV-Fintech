namespace UVV_FINTECH.model;

public class ContaPoupanca : Conta
{
    public double TaxaDeRendimento { get; protected set; }
    public override void Depositar(decimal valor)
    {
        // Falta codar o método
        throw new NotImplementedException();
    }

    public override void Sacar(decimal valor)
    {
        // Falta codar o método
        throw new NotImplementedException();
    }

    public override void Tranferir(decimal valor, Conta contaDestino)
    {
        // Falta codar o método
        throw new NotImplementedException();
    }

    public void SetTaxaDeRendimento(double taxaDeRendimento)
    {
        if (taxaDeRendimento <= 0)
            throw new ArgumentOutOfRangeException("TaxaDeRendimento inválida");
        TaxaDeRendimento = taxaDeRendimento;
    }

    public ContaPoupanca(decimal saldo, int clienteId, double taxaDeRendimento) : base(saldo, clienteId)
    {
        SetTaxaDeRendimento(taxaDeRendimento);
    }
}