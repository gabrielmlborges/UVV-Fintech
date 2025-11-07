namespace UVV_FINTECH.model;

public class Saque : Transacao
{
    public void Sacar()
    {
        if (Valor < 0 || Valor < ContaId.Saldo)
            return;
    }
}