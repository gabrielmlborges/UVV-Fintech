namespace UVV_FINTECH.model;

public interface ISaque
{
    public int Id { get; protected set; }

    public void SetId(int id)
    {
        if (id < 0)
            throw new ArgumentOutOfRangeException("Id inválido");
        Id = id;
    }
}