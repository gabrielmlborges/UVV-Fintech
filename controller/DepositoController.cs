namespace UVV_FINTECH.controller;

public class DepositoController
{
    public static bool VerificaDeposito(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentOutOfRangeException("Valor inválido");
        return true;
    }
}