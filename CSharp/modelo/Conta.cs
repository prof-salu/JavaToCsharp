using QualquerBank.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualquerBank.modelo
{
    public abstract class Conta
    {
        public static int TotalDeContas {get; private set;}
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; protected set; }

        public Conta(int numero, int agencia)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Saldo = 0;
            Conta.TotalDeContas++;
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                throw new ArgumentException("Valor invalido");
            }
        }
        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }

            return false;
        }
        public bool Transferir(double valor, Conta favorecido)
        {
            if (Sacar(valor))
            {
                favorecido.Depositar(valor);
            }

            return false;
        }

        public abstract void ExibeConta();
    }
}
