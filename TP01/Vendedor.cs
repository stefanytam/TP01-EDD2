using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas =new Venda[31];

        private const int qtdDia = 31;
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double PercComissao { get => percComissao; set => percComissao = value; }
        public Venda[] AsVendas { get => asVendas; set => asVendas = value; }

        public Vendedor(int id,  string nome, double percComissao,  Venda v)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;

            this.asVendas = new Venda[qtdDia];
            for (int i = 0; i < qtdDia; i++)
            {
                asVendas[i] = new Venda();
            }
        }
        public Vendedor (int id) 
        {
            this.id = id;
        }

        public Vendedor()
        {
            this.id = 0;
            this.nome = "";
            this.percComissao = 0.10;
            asVendas = new Venda[31];
            for (int i = 0; i < qtdDia; i++)
            {
                asVendas[i] = new Venda();
            }
        }
    


        public void registrarVenda(int dia, Venda venda)
        {
           
                asVendas[dia - 1] = venda;
        }
        public double valorVendas()
        {
            double somaValorVendas = 0;

            foreach (var venda in asVendas)
            {
                somaValorVendas += venda.Valor;
            }

            return somaValorVendas;
        }
        public double valorComissao() => valorVendas() * this.percComissao;

        public override string ToString()
        {
            if (id != 0)
            {
                return $"Id: {id}\nNome: {nome}\nValor total das vendas: {valorVendas():C}\nValor comissão: {valorComissao():C}";
            }
            else
            {
                return "";
            }
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Vendedor)obj).id);
        }

    }
}
