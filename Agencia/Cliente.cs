using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    class Cliente
    {
        private string nome;
        private string cpf;
        public void SetNome(string n)
        {
            nome = n;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetCpf(string c)
        {
            cpf = c;
        }
        public string GetCpf()
        {
            return cpf;
        }
        private Conta[] contas = new Conta[1000];
        private int k = 0;
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
            double saldocontas = 0;
            double Saldo = 0;
            foreach (Conta x in contas)
                saldocontas += Saldo;
            return saldocontas;
        }
        public override string ToString()
        {
            return $"{cpf} - {nome}";
        }
    }
}
