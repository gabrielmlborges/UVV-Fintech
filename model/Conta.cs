namespace UVV_FINTECH.model;

public abstract class Conta
{
    public int Id { get; protected set; }
    public decimal Saldo { get; protected set; }
    public int ClienteId { get; protected set; }
    public void SetId(int id)
    {
        if (id < 0)
            throw new ArgumentOutOfRangeException("Id inválido");
        Id = id;
    }
    public void SetSaldo(decimal saldo)
    {
        if (saldo < 0)
            throw new ArgumentOutOfRangeException("Saldo inválido");
        Saldo = saldo;
    }
    public void SetClienteId(int clienteId)
    {
        if (clienteId < 0)
            throw new ArgumentOutOfRangeException("ClienteId inválido");
        ClienteId = clienteId;
    }

    protected Conta(decimal saldo, int clienteId)
    {
        SetSaldo(saldo);
        SetClienteId(clienteId);
    }

}