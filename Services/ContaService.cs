using Microsoft.EntityFrameworkCore;
using UVV_FINTECH.Data;
using UVV_FINTECH.model;

namespace UVV_FINTECH.Services;

public class ContaService
{
    private readonly FintechContext _context;

    // ✅ Dependency Injection (SOLID: D)
    public ContaService(FintechContext context)
    {
        _context = context;
    }

    // ✅ Single Responsibility (SOLID: S)
    public Conta CriarContaAsync(string nome, string cpf, string senha, decimal depositoInicial)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(senha))
            return null;

        var conta = new Conta
        {
            NomeDono = nome,
            CpfDono = cpf,
            Senha = senha
        };

        _context.Contas.Add(conta);

        _context.SaveChanges();

        return conta;
    }
}
