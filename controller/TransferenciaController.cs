using UVV_FINTECH.model;

namespace UVV_FINTECH.controller;

public class TransferenciaController
{
    public static bool VerificaTransferencia(Conta contaEnvia, Conta contaRecebe, decimal valor)
    {
        if (SaqueController.VerificaSaque(contaEnvia, valor) && DepositoController.VerificaDeposito(valor))
            return true;
        throw new Exception("Erro na transação");
    }
}