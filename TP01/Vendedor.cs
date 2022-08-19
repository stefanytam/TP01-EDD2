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

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double PercComissao { get => percComissao; set => percComissao = value; }
        public Venda[] AsVendas { get => asVendas; set => asVendas = value; }

        public void registrarVenda(int dia, Venda venda)
        {
            
          
        }

    }
}
