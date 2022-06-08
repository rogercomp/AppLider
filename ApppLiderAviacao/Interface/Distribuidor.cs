using System;

namespace ApppLiderAviacao.Interface
{
    public class Distribuidor : IAddIn
    {

        private double valor;
        public Distribuidor(double valor)
        {
            this.valor = valor;
        }

        public double Calcular()
        {
            if (valor <= 28000)
            {
                return this.valor * 0.05;
            }
            else if (valor > 28000 && valor <= 45000)
            {
                return this.valor * 0.10;
            }
            else
            {
                return this.valor * 0.15;
            }
        }
    }
}
