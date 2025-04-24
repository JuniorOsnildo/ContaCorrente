using Banco;

var conta1 = new Conta(1000, 200);
var conta2 = new Conta( 500, 100);

conta1.Depositar(100);
conta1.Sacar(50);
conta1.Sacar(300);

conta2.Depositar(300);
conta2.Sacar(70);
conta2.Sacar(120);

conta1.Transferir(150, conta2);

conta1.ConsultarExtratos();
conta2.ConsultarExtratos();