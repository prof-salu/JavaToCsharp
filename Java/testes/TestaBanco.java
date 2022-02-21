package testes;

import contas.Conta;
import contas.ContaCorrente;
import contas.ContaPoupanca;

public class TestaBanco {

	public static void main(String[] args) {
		System.out.println("Bem vindos ao Qualquer bank");

		ContaCorrente cc = new ContaCorrente(1234, 4455);
		ContaPoupanca cp = new ContaPoupanca(7890, 6677);

		System.out.println("Total de contas criadas: " + Conta.getTotalDeContas());
		System.out.println();

		cc.exibeConta();
		System.out.println();
		cp.exibeConta();

		cc.depositar(500);
		cp.depositar(500);

		System.out.println();
		System.out.println("Deposito de 500 realizado");
		System.out.println();

		System.out.println("Saldo (CC): " + cc.getSaldo());
		System.out.println("Saldo (CP): " + cp.getSaldo());

		cc.sacar(250);
		cp.sacar(250);

		System.out.println();
		System.out.println("Saque de 250 realizado");
		System.out.println();

		System.out.println("Saldo (CC): " + cc.getSaldo());
		System.out.println("Saldo (CP): " + cp.getSaldo());

		cc.transferir(100, cp);

		System.out.println();
		System.out.println("Transferencia de 100 realizado de CC para CP");
		System.out.println();

		System.out.println("Saldo (cc1): " + cc.getSaldo());
		System.out.println("Saldo (cc2): " + cp.getSaldo());

		System.out.println();
		System.out.println("Atualizando CP com taxa de 10%");
		System.out.println();

		cp.atualizar(0.01);

		System.out.println("Saldo (cc1): " + cc.getSaldo());
		System.out.println("Saldo (cc2): " + cp.getSaldo());

	}

}
