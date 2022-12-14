using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    class Cliente
    {
        private string nome;
        private string cpf;
        private Conta[] contas = new Conta[1000];
        private int k = 0;
        private double saldo;
        public void Inserir(Conta c)
        {
            contas[k] = c;
            k++;
        }
        public Conta[] Listar()
        {
            Conta[] vetor = new Conta[k];
            Array.Copy(contas, vetor, k);
            return vetor;
        }
        public double SaldoTotal()
        {
            foreach (Conta x in contas)
                SaldoTotal += saldo;
            return SaldoTotal;
        }
    }

}
