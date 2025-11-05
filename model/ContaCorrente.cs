namespace UVV_FINTECH.model;

public class ContaCorrente : Conta
{
    public decimal Limite { get; protected set; }
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

    public void SetLimite(decimal limite)
    {
        if (limite < 0)
            throw new ArgumentOutOfRangeException("Limite inválido");
        Limite = limite;
    }

    public ContaCorrente(int id, decimal saldo, int clienteId, decimal limite) : base(id, saldo, clienteId)
    {
        SetLimite(limite);
    }
}