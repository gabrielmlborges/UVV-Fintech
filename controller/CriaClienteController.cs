using UVV_FINTECH.model;

namespace UVV_FINTECH.controller;

public class CriaClienteController
{
    public static bool VerificaCliente(string nome, string email, string senha)
    {
        if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(senha) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException("Nome ou Senha inválidos");
        return true;
    }
}