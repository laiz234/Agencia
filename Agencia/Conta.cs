using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    class Conta
    {
        private string numero;
        private string agencia;
        private double saldo;

        public void SetNumero(string n)
        {
            numero = n;
        }
        public void SetAgencia(string a)
        {
            agencia = a;
        }
        public void SetSaldo(double s)
        {
            if (s >= 0) saldo = s;
        }
        public string GetNumero()
        {
            return numero;
        }
        public string GetAutores()
        {
            return agencia;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public override string ToString()
        {
            if (saldo == 0)
                return $"{numero} - {agencia} - {saldo} sem saldo! ";
            return $"{numero} - {agencia} - {saldo} ";
        }
    }
}
