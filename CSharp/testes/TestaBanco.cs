using QualquerBank.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualquerBank.testes
{
    class TestaBanco
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindos ao Qualquer bank");

			ContaCorrente cc = new ContaCorrente(1234, 4455);
			ContaPoupanca cp = new ContaPoupanca(7890, 6677);

			Console.WriteLine("Total de contas criadas: " + Conta.TotalDeContas);
			Console.WriteLine();

			cc.ExibeConta();
			Console.WriteLine();
			cp.ExibeConta();

			cc.Depositar(500);
			cp.Depositar(500);

			Console.WriteLine();
			Console.WriteLine("Deposito de 500 realizado");
			Console.WriteLine();

			Console.WriteLine("Saldo (CC): " + cc.Saldo);
			Console.WriteLine("Saldo (CP): " + cp.Saldo);

			cc.Sacar(250);
			cp.Sacar(250);

			Console.WriteLine();
			Console.WriteLine("Saque de 250 realizado");
			Console.WriteLine();

			Console.WriteLine("Saldo (CC): " + cc.Saldo);
			Console.WriteLine("Saldo (CP): " + cp.Saldo);

			cc.Transferir(100, cp);

			Console.WriteLine();
			Console.WriteLine("Transferencia de 100 realizado de CC para CP");
			Console.WriteLine();

			Console.WriteLine("Saldo (cc1): " + cc.Saldo);
			Console.WriteLine("Saldo (cc2): " + cp.Saldo);

			Console.WriteLine();
			Console.WriteLine("Atualizando CP com taxa de 10%");
			Console.WriteLine();

			cp.Atualizar(0.01);

			Console.WriteLine("Saldo (cc1): " + cc.Saldo);
			Console.WriteLine("Saldo (cc2): " + cp.Saldo);
		}
    }
}
