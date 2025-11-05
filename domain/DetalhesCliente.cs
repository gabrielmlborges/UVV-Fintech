namespace UVV.Fintech.Dominio.Entidades
{
    public class DetalhesCliente
    {
        public int Id { get; set; }
        public string Cpf { get; set; } 
        public string Telefone { get; set; }
        
        // Relação 1:1 
        public Cliente Cliente { get; set; }
    }
}