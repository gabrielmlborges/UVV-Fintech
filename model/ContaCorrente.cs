namespace UVV_FINTECH.model;

public class ContaCorrente : Conta
{
    public decimal Limite { get; protected set; }
    public void SetLimite(decimal limite)
    {
        if (limite < 0)
            throw new ArgumentOutOfRangeException("Limite inválido");
        Limite = limite;
    }

    public ContaCorrente(decimal saldo, int clienteId, decimal limite) : base(saldo, clienteId)
    {
        SetLimite(limite);
    }
}