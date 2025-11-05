namespace UVV.Fintech.domain.entity
{
    public class DetalhesContaJuncao
    {
        public int ContaId { get; set; }
        public int DetalheContaID { get; set; }

        public Conta Conta { get; set; }
        public DetalhesConta DetalhesContas { get; set; }
    }
}