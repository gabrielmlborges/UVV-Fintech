using System;

namespace UVV.Fintech.domain.entity
{
    public abstract class Transacao
    {
        public int Id { get; set; }
        public DateTime Hora { get; set; } = DateTime.Now;
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        // relação N:1 
        public int ContaId { get; set; }
        public Conta Conta { get; set; }
    }

    public class Saque : Transacao
    {
        
        public string CanalSaque { get; set; } 
    }

    public class Deposito : Transacao
    {
        public string Origem { get; set; } 
    }

    public class Transferencia : Transacao
    {
        public int ContaDestinoId { get; set; }
        
        // relação N:1 
        public Conta ContaDestino { get; set; }
    }
}