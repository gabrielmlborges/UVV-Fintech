namespace UVV_FINTECH.model;

public class Transacao
{
    public int Id { get; protected set; }
    public DateTime Data { get; protected set; }
    public string Descricao { get; protected set; }
    public decimal Valor { get; protected set; }
    public int ContaId { get; protected set; }

    public void SetId(int id)
    {
        if (id < 0)
            throw new ArgumentOutOfRangeException("Id inválido");
        Id = id;
    }
    public void SetData(DateTime data)
    {
        if (data.Equals(DateTime.MinValue))
            throw new Exception("Data inválida");
        Data = data;
    }
    public void SetDescricao(string descricao)
    {
        if (string.IsNullOrEmpty(descricao) || string.IsNullOrWhiteSpace(descricao))
            throw new ArgumentNullException("Descrição inválida");
        Descricao = descricao;
    }
    public void SetValor(decimal valor)
    {
        if (valor < 0)
            throw new ArgumentOutOfRangeException("Valor inválido");
        Valor = valor;
    }
    public void SetContaId(int contaId)
    {
        if (contaId < 0)
            throw new ArgumentOutOfRangeException("ContaId inválido");
        ContaId = contaId;
    }

    public Transacao(int id, DateTime data, string descricao, decimal valor, int contaId)
    {
        SetId(id);
        SetData(data);
        SetDescricao(descricao);
        SetValor(valor);
        SetContaId(contaId);
    }


}