package contas;

public class ContaCorrente extends Conta {
	private final double TAXA_DE_OPERACAO = 0.10;
	
	public ContaCorrente(int numero, int agencia) {
		super(numero, agencia);
	}

	@Override
	public boolean sacar(double valor) {
		return super.sacar(valor + TAXA_DE_OPERACAO);
	}

	@Override
	public void exibeConta() {
		System.out.println("Conta Corrente");
		System.out.println("Numero: " + getNumero());
		System.out.println("Agencia: " + getAgencia());
		System.out.println("Saldo: " + getSaldo());
		System.out.println("Taxa: " + TAXA_DE_OPERACAO);		
	}	
}
