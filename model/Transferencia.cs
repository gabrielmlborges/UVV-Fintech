using UVV_FINTECH.controller;

namespace UVV_FINTECH.model;

public class Transferencia : ITransacao
{
    List<Conta> contas = [];
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int ContaId { get; set; }
    public int ContaDestinoId { get; protected set; }

    public void Executar()
    {
        var contaEnvio = contas.Where(c => c.Id == ContaId).FirstOrDefault();
        var contaRecebe = contas.Where(c => c.Id == ContaDestinoId).FirstOrDefault();
        if (contaEnvio is null || contaRecebe is null)
            throw new Exception("Conta inválida");
        if (TransferenciaController.VerificaTransferencia(contaEnvio, contaRecebe, Valor))
        {
            decimal saldoEnvio = contaEnvio.Saldo - Valor;
            decimal saldoRecebe = contaRecebe.Saldo + Valor;
            contaEnvio.SetSaldo(saldoEnvio);
            contaRecebe.SetSaldo(saldoRecebe);

            Console.WriteLine($"SUCESSO NA TRANSAÇÃO!");
        }
    }

    public void SetContaDestinoId(int contaDestinoId)
    {
        if (contaDestinoId < 0)
            throw new ArgumentOutOfRangeException("ContaDestinoId inválido");
        ContaDestinoId = contaDestinoId;
    }
}