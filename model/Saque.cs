using UVV_FINTECH.controller;

namespace UVV_FINTECH.model;

// Liskov aplicada!
public class Saque : ITransacao
{
    // Esse campo é meramente de testes, trocaremos ele por um BD real!
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

        if (SaqueController.VerificaSaque(conta, Valor))
        {
            decimal saldo = conta.Saldo - Valor;
            conta.SetSaldo(saldo);
            Console.WriteLine($"SUCESSO! Seu saldo agora é de {conta.Saldo:c}!");
        }
    }
}