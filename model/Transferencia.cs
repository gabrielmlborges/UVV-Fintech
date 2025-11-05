namespace UVV_FINTECH.model;

public class Transferencia
{
    public int Id { get; protected set; }
    public int ContaDestinoId { get; protected set; }

    public void SetId(int id)
    {
        if (id < 0)
            throw new ArgumentOutOfRangeException("Id inválido");
        Id = id;
    }
    public void SetContaDestinoId(int contaDestinoId)
    {
        if (contaDestinoId < 0)
            throw new ArgumentOutOfRangeException("ContaDestinoId inválido");
        ContaDestinoId = contaDestinoId;
    }
}