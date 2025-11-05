using System.Collections.Generic;

namespace UVV.Fintech.domain.entity
{
    public class DetalhesConta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        // relação N:N
        public ICollection<DetalhesContaJuncao> DetalhesContasJuncao { get; set; } = new List<DetalhesContaJuncao>();
    }
}