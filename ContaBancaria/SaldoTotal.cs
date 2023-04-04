using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ContaBancaria
{
    internal class SaldoTotal
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public SaldoTotal(int conta, string titular)        {
            Conta = conta;
            Titular = titular;
        }
        public SaldoTotal(int conta, string titular, double depositoInicial) : this(conta, titular)        {
            Deposito(depositoInicial);
        }
        public void Deposito(double saldo)        {
            Saldo += saldo;
        }

        public void Saque(double saldo)        {
            Saldo -= (saldo + 5.0);
        }
        public override string ToString()        {
            return "Conta: " + Conta
                + ", Titular: " + Titular
                + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
