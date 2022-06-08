using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApppLiderAviacao.Interface
{
    public class CalculadoraCustoFinal
    {
        private double valor;

        public double Valor { get => valor; set => valor = value; }
                
        public double calcular(IAddIn addin)
        {
            return addin.Calcular();
        }
    }
}
