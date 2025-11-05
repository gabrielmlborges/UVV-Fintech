namespace UVV_FINTECH.model;

public class Cliente
{
    public int Id { get; protected set; }
    public string Nome { get; protected set; }
    public string Email { get; protected set; }
    public string Senha { get; protected set; }

    public void SetId(int id)
    {
        if (id < 0)
            throw new ArgumentOutOfRangeException("Id inválido");
        Id = id;
    }
    public void SetNome(string nome)
    {
        if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
            throw new ArgumentNullException("Nome inválido");
        Nome = nome;
    }
    public void SetEmail(string email)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException("Email inválido");
        Email = email;
    }
    public void SetSenha(string senha)
    {
        if (string.IsNullOrEmpty(senha) || string.IsNullOrWhiteSpace(senha))
            throw new ArgumentNullException("Senha inválida");
        Senha = senha;
    }

    public Cliente(int id, string nome, string email, string senha)
    {
        SetId(id);
        SetNome(nome);
        SetEmail(email);
        SetSenha(senha);
    }
}