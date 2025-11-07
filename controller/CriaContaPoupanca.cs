using UVV_FINTECH.model;

namespace UVV_FINTECH.controller;

public class CriaContaPoupancaController
{
    public static bool VerificaConta(decimal saldo, double taxaDeRendimento, int clienteId)
    {
        if (saldo < 0 || taxaDeRendimento < 0)
            throw new ArgumentOutOfRangeException("Saldo ou taxaDeRendimento inválidos");
        return true;
    }
}