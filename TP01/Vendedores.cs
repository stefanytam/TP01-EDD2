using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max;
        private int qtde;

        public int Max { get => max; }
        public int Qtde { get => qtde; }
        public Vendedor[] OsVendedores { get => osVendedores; }

        public Vendedores()
        {
            this.max = 10;
            this.qtde = 0;
            osVendedores = new Vendedor[this.max];
            for (int i = 0; i < this.max; ++i)
            {
                osVendedores[i] = new Vendedor();
            }
        }
        public string mostrar()
        {
            string s = "";
            foreach (Vendedor v in osVendedores)
            {
                s += v.ToString();
            }
            return s;
        }

        public bool addVendedor(Vendedor v)
        {
            bool podeAdicionar = (this.qtde < this.max);
            if (podeAdicionar)
            {
                this.osVendedores[this.qtde] = v;
                this.qtde++;
            }
            return podeAdicionar;
        }

        public Vendedor searchVendedor(Vendedor v)
        {
            Vendedor vendedorAchado = new Vendedor();
            int i = 0;
            while (i < this.max && this.osVendedores[i].Id != v.Id)
            {
                i++;
            }
            if (i < this.max)
            {
                vendedorAchado = this.osVendedores[i];
            }
            return vendedorAchado;
        }

        public bool delVendedor(Vendedor v)
        {
            bool podeRemover;
            int i = 0;
            while (i < this.max && !this.osVendedores[i].Equals(v))
            {
                i++;
            }
            podeRemover = (i < this.max);
            if (podeRemover)
            {
                while (i < this.max - 1)
                {
                    this.osVendedores[i] = this.osVendedores[i + 1];
                    i++;
                }
                this.osVendedores[i] = new Vendedor();
                this.qtde--;
            }
            return podeRemover;
        }
        public double valorVendas()
        {
            double somaVendas = 0;
            foreach (var vendedor in this.osVendedores)
            {
                somaVendas += vendedor.valorVendas();
            }

            return somaVendas;
        }
        public double valorComissao()
        {
            double somaComissao = 0;
            foreach (var vendedor in this.osVendedores)
            {
                somaComissao += vendedor.valorComissao();
            }

            return somaComissao;
        }
    }
}