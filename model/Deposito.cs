
using System.Printing;
using UVV_FINTECH.controller;

namespace UVV_FINTECH.model;

public class Deposito : ITransacao
{
    List<Conta> ContasDB = [];
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int ContaId { get; set; }

    public void Executar()
    {
        var conta = ContasDB.Where(c => c.Id == ContaId).FirstOrDefault();
        if (conta is null)
            throw new Exception("Conta inexiste");
        if (DepositoController.VerificaDeposito(Valor))
        {
            decimal saldo = conta.Saldo + Valor;
            conta.SetSaldo(saldo);
            Console.WriteLine($"SUCESSO! Seu saldo agora é de {conta.Saldo:c}!");
        }
    }
}