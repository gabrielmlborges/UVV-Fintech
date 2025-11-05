using System.Collections.Generic;

namespace UVV.Fintech.domain.entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        // relação 1:1
        public int ClienteDetalhesID { get; set; }
        public DetalhesCliente DetalheCliente { get; set; }

        // relação 1:N 
        public ICollection<Conta> Contas { get; set; } = new List<Conta>();
    }
}