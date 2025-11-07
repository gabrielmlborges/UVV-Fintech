using UVV_FINTECH.model;

namespace UVV_FINTECH.controller;

public class CriaContaCorrenteController
{
    public static bool VerificaConta(decimal saldo, decimal limite, int clienteId)
    {
        if (saldo < 0 || limite < 0)
            throw new ArgumentOutOfRangeException("Saldo ou Limite inválidos");
        return true;
    }
}