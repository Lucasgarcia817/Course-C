using System;

namespace ContaB {
    class Program {
        static void Main(string[] args) {
            Conta c1;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito incial (s/n)?");
            char sn = char.Parse(Console.ReadLine());
            if (sn=='S' || sn=='s') {
                Console.Write("Entre o valor inicial:");
                double valorInicial = double.Parse(Console.ReadLine());
                c1 = new Conta(numero, titular, valorInicial);
            }
            else {
                c1 = new Conta(numero, titular);
            }
            
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito:");
            double deposito = double.Parse(Console.ReadLine());
            c1.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.Write("Entre um valor para saque:");
            double saque = double.Parse(Console.ReadLine());
            c1.Saque(saque);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(c1);
        }
    }
}
