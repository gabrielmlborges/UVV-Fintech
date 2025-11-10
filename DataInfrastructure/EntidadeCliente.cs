using System;
using System.Collections.Generic;

namespace UVV_FINTECH.model
{
    // relacionamento 1:N com Conta
    public class Cliente
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Senha { get; protected set; }
        
        public ICollection<Conta> Contas { get; set; } = new List<Conta>();
        public Cliente() { }
        public Cliente(string nome, string email, string senha)
        {
            SetNome(nome);
            SetEmail(email);
            SetSenha(senha);
        }

        public void SetId(int id)
        {
            if (id < 0) throw new ArgumentOutOfRangeException(nameof(id), "Id inválido");
            Id = id;
        }
        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                throw new ArgumentNullException(nameof(nome), "Nome inválido");
            Nome = nome;
        }
        public void SetEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException(nameof(email), "Email inválido");
            Email = email;
        }
        public void SetSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha) || string.IsNullOrWhiteSpace(senha))
                throw new ArgumentNullException(nameof(senha), "Senha inválida");
            Senha = senha;
        }
    }
}