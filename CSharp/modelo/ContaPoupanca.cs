using QualquerBank.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualquerBank.modelo
{
    public class ContaPoupanca : Conta, IRendimento
    {
        public ContaPoupanca(int numero, int agencia) : base(numero, agencia)
        {
        }

        
         public void Atualizar(double taxa)
        {
            Saldo += (Saldo * taxa);
        }

        public override void ExibeConta()
        {
            Console.WriteLine("Conta Poupanca");
            Console.WriteLine("Numero: " + Numero);
            Console.WriteLine("Agencia: " + Agencia);
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
}
