using Microsoft.EntityFrameworkCore;
using UVV_FINTECH.model;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace UVV_FINTECH.DataInfrastructure
{
    public class FintechContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public FintechContext(DbContextOptions<FintechContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // herança para conta
            modelBuilder.Entity<Conta>()
                .HasDiscriminator<string>("TipoConta")
                .HasValue<ContaCorrente>("CC")
                .HasValue<ContaPoupanca>("CP");

            // herança para transação
            modelBuilder.Entity<Transacao>()
                .HasDiscriminator<string>("TipoTransacao")
                .HasValue<Deposito>("DEPOSITO")
                .HasValue<Saque>("SAQUE")
                .HasValue<Transferencia>("TRANSFERENCIA");

            // Relação 1:N Cliente COnta

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Contas) // Um Cliente tem Muitas Contas
                .WithOne(co => co.Cliente) // Uma Conta pertence a Um Cliente
                .HasForeignKey(co => co.ClienteId); // FK

            // Relação 1:N Conta Transacao

            modelBuilder.Entity<Conta>()
                .HasMany(co => co.Transacoes) // Uma Conta tem Muitas Transacoes
                .WithOne(t => t.Conta) // Uma Transacao pertence a Uma Conta
                .HasForeignKey(t => t.ContaId); // FK

            base.OnModelCreating(modelBuilder);
        }
    }
}