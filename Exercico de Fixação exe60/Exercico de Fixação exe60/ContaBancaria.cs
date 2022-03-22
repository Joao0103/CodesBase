using System.Globalization;

namespace Exercico_de_Fixação_exe60 {
    class ContaBancaria {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular) {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numereconta, string titular, double depositoInicial) : this(numereconta, titular) { 
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia) {
            Saldo = Saldo - quantia - 5.0;
        }

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}



