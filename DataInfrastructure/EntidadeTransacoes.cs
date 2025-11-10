using System;

namespace UVV_FINTECH.model
{
    public abstract class Transacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        
        // Chave Estrangeira para Conta Relação 1:N
        public int ContaId { get; set; }
        public Conta Conta { get; set; }
        public Transacao() { }
        public abstract void Executar(); 
    }
    public class Deposito : Transacao
    {
        public override void Executar()
        {
            
            Console.WriteLine("");
        }
    }
    public class Saque : Transacao
    {
        public override void Executar()
        {
            Console.WriteLine("");
        }
    }
    public class Transferencia : Transacao
    {
        public int ContaDestinoId { get; set; }

        public override void Executar()
        {
            Console.WriteLine("");
        }
    }
}