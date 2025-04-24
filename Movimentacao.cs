namespace Banco;

public class Movimentacao(string descricao, double valor, string tipo)
{
    public override string ToString()
    {
        return $"{descricao} || Valor: {valor:F2} || Tipo: {tipo}";
    }
}