using System.Globalization;
using System.Runtime.CompilerServices;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaldoTotal st;

            Console.WriteLine("INSIRA AS INFORMAÇÕES DA CONTA ABAIXO. ");

            Console.Write("DIGITE O NUMERO DA CONTA: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("DIGITE O NOME DO TITULAR: ");
            string titular = Console.ReadLine();

            Console.Write("\nHAVERÁ DEPOSITO INICIAL? (s/n) ");
            char di = char.Parse(Console.ReadLine());
            if (di == 's' || di == 'S')            {
                Console.Write("DIGITE O VALOR DO DEPOSITO INICIAL: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                st = new SaldoTotal(conta, titular, depositoInicial);
            }
            else            {
                st = new SaldoTotal(conta, titular);
            }

            Console.WriteLine("\nDADOS DA CONTA: \n" + st);

            Console.Write("\nINSIRA O VALOR DO DEPOSITO: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            st.Deposito(dep);

            Console.WriteLine("\nDADOS DA CONTA ATUALIZADOS: \n" + st);

            Console.Write("\nINSIRA O VALOR DO SAQUE: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            st.Saque(dep);

            Console.WriteLine("\nDADOS DA CONTA ATUALIZADOS: \n" + st);

        }
    }
}