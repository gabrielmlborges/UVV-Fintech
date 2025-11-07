namespace UVV_FINTECH.model;

public interface ITransacao
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int ContaId { get; set; }
    public void Executar();

}