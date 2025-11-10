using System;
using System.Collections.Generic;

namespace UVV_FINTECH.model
{

    // relacionamento 1:N com Transacao.

    public abstract class Conta
    {
        public int Id { get; protected set; }
        public decimal Saldo { get; protected set; }
        
        // Relação 1:N
        public int ClienteId { get; protected set; } 
        public Cliente Cliente { get; set; }
        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
        public Conta() { }
        protected Conta(decimal saldo, int clienteId)
        {
            SetSaldo(saldo);
            SetClienteId(clienteId);
        }
        public void SetId(int id)
        {
            if (id < 0) throw new ArgumentOutOfRangeException(nameof(id), "Id inválido");
            Id = id;
        }
        public void SetSaldo(decimal saldo)
        {
            if (saldo < 0) throw new ArgumentOutOfRangeException(nameof(saldo), "Saldo inválido");
            Saldo = saldo;
        }
        public void SetClienteId(int clienteId)
        {
            if (clienteId < 0) throw new ArgumentOutOfRangeException(nameof(clienteId), "ClienteId inválido");
            ClienteId = clienteId;
        }
    }

    public class ContaCorrente : Conta
    {
        public decimal Limite { get; protected set; }

        public ContaCorrente() : base() { }

        public ContaCorrente(decimal saldo, int clienteId, decimal limite) : base(saldo, clienteId)
        {
            SetLimite(limite);
        }

        public void SetLimite(decimal limite)
        {
            if (limite < 0) throw new ArgumentOutOfRangeException(nameof(limite), "Limite inválido");
            Limite = limite;
        }
    }

    public class ContaPoupanca : Conta
    {
        public double TaxaDeRendimento { get; protected set; }

        public ContaPoupanca() : base() { }

        public ContaPoupanca(decimal saldo, int clienteId, double taxaDeRendimento) : base(saldo, clienteId)
        {
            SetTaxaDeRendimento(taxaDeRendimento);
        }

        public void SetTaxaDeRendimento(double taxaDeRendimento)
        {
            if (taxaDeRendimento <= 0) 
                throw new ArgumentOutOfRangeException(nameof(taxaDeRendimento), "TaxaDeRendimento inválida");
            TaxaDeRendimento = taxaDeRendimento;
        }
    }
}