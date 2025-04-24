namespace Banco;

public class Conta()
{
    private int Id { get; }
    private double Saldo;
    private readonly double LimiteDebito;
    private readonly List<Movimentacao> Historico = [];

    public Conta(double saldo, double limiteDebito) : this()
    {
        Id = (new Random().Next(10000));
        Saldo = saldo;
        LimiteDebito = limiteDebito;
    }

    public bool Sacar(double valor)
    {
        if (valor > LimiteDebito) return false;
        Saldo -= valor;
        Historico.Add(new Movimentacao("Saque", valor, "Débito"));
        return true;
    }
    
    public void Depositar(double valor)
    {
        Saldo += valor;
        Historico.Add(new Movimentacao("Deposito", valor, "Crédito"));
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
    }

    public void Transferir(double valor, Conta conta)
    {
        if (Sacar(valor))
        {
            conta.Depositar(valor);
            Console.WriteLine($"Tranferencia da conta {Id} para conta {conta.Id}" +
                              $" realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Não foi possível realizar a tranferência");
        }
    }

    public void ConsultarExtratos()
    {

        Console.WriteLine(new string('-', 30));
        foreach (var movimentacao in Historico)
        {
            Console.WriteLine(movimentacao.ToString());
        }
        Console.WriteLine(new string('-', 30));
    }
}