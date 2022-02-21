package contas;

public abstract class Conta {
	private static int totalDeContas = 0;
	private int numero;
	private int agencia;
	protected double saldo;

	public Conta(int numero, int agencia) {
		this.numero = numero;
		this.agencia = agencia;
		this.saldo = 0;
		Conta.totalDeContas++;
	}

	public int getNumero() {
		return numero;
	}

	public void setNumero(int numero) {
		this.numero = numero;
	}

	public int getAgencia() {
		return agencia;
	}

	public void setAgencia(int agencia) {
		this.agencia = agencia;
	}

	public double getSaldo() {
		return saldo;
	}

	public static int getTotalDeContas() {
		return Conta.totalDeContas;
	}

	public boolean sacar(double valor) {
		if (valor > 0 && valor <= getSaldo()) {
			saldo -= valor;
			return true;
		} else {
			throw new IllegalArgumentException("Valor invalido");
		}
	}

	public boolean depositar(double valor) {
		if (valor > 0) {
			saldo = saldo + valor;
			return true;
		} else {
			throw new IllegalArgumentException("Valor invalido.");
		}
	}

	public boolean transferir(double valor, Conta favorecido) {
		if (sacar(valor) == true) {
			favorecido.depositar(valor);
			return true;
		}

		return false;
	}
	
	public abstract void exibeConta();
}
