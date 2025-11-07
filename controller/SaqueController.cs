using UVV_FINTECH.model;

namespace UVV_FINTECH.controller;

public class SaqueController
{
    public static bool VerificaSaque(Conta conta, decimal valor)
    {
        if (conta is ContaPoupanca)
        {
            if (valor < 0 || valor > conta.Saldo)
                throw new ArgumentOutOfRangeException("Valor inválido");
            return true;
        }
        else if (conta is ContaCorrente contaCorrente)
        {
            decimal limiteAtual = contaCorrente.Saldo + contaCorrente.Limite;
            if (valor < 0 || valor > limiteAtual)
                throw new ArgumentOutOfRangeException("Valor inválido");
            return true;
        }
        throw new Exception("Tipo de conta inválido");
    }
}