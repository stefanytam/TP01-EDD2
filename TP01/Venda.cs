using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Venda
    {
        private int qtde;
        private double valor;
      
        public int Qtde { get => qtde; set => qtde = value; }
        public double Valor { get => valor; set => valor = value; }

        public Venda(int qtd, double valor)
        {
              this.qtde = qtd;
              this.valor = valor;
        }

        public Venda()
        {
            this.qtde = 0;
            this.valor = 0;
        }

        public double valorMedio()
        {
            double media;
            media = valor / qtde;
            return media;
        }

        public override string ToString()
        {
            return $"Valor: {this.Valor:C} - Qtde: {this.Qtde}";
        }
    }
}
