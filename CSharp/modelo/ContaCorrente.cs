using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualquerBank.modelo
{
    public class ContaCorrente : Conta
    {
        private const double TaxaDeOperacao = 0.10;

        public ContaCorrente(int numero, int agencia) : base(numero, agencia) { }

        public override bool Sacar(double valor)
        {
           return base.Sacar(valor + TaxaDeOperacao);
        }

        public override void ExibeConta()
        {
            Console.WriteLine("Conta Corrente");
            Console.WriteLine("Numero: " + Numero);
            Console.WriteLine("Agencia: " + Agencia);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("Taxa: " + TaxaDeOperacao);
        }
    }
}
