namespace UVV_FINTECH.controller;

public class SaqueController
{
    public static bool VerificaSaque(decimal saldo, decimal valor)
    {
        if (valor < 0 || valor > saldo)
            throw new ArgumentOutOfRangeException("Valor inválido");
        return true;
    }
}