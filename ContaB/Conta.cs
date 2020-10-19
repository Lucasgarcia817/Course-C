using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace ContaB {
    class Conta {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double ValorConta { get; private set; }
        public int TaxaSaque = 5;

        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial) : this (numero, titular) {
            ValorConta = Deposito(depositoInicial) ;
        }
       
        public double Deposito(double deposito) {
            ValorConta += deposito;
            return ValorConta;
        }

        public double Saque(double saque) {
            ValorConta -= saque + TaxaSaque;
            return ValorConta;
        }

        public override string ToString() {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $" + ValorConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
