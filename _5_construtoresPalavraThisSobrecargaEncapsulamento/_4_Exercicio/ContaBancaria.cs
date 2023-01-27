namespace _4_Exercicio
{
    class ContaBancaria
    {
        private string _titular;
        public double Saldo { get; private set; }
        public int Conta { get; private set; }

        public ContaBancaria(string titular, int conta)
        {
            _titular = titular;
            Conta = conta;
        }

        public ContaBancaria(string titular, int conta, double depositoInicial) : this(titular, conta)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Conta: {Conta}, Titular: {_titular}, Saldo: R$ {Saldo:F2}";
        }
    }
}
