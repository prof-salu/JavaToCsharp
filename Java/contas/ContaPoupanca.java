package contas;

import interfaces.IRendimento;

public class ContaPoupanca extends Conta implements IRendimento{

	public ContaPoupanca(int numero, int agencia) {
		super(numero, agencia);
	}

	@Override
	public void exibeConta() {
		System.out.println("Conta Poupanca");
		System.out.println("Numero: " + getNumero());
		System.out.println("Agencia: " + getAgencia());
		System.out.println("Saldo: " + getSaldo());		
	}

	@Override
	public void atualizar(double taxa) {
		saldo += (saldo * taxa);		
	}
}