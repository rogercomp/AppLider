namespace ApppLiderAviacao.Interface
{
    public class Imposto : IAddIn
    {
        private double valor;
        public Imposto(double valor)
        {
            this.valor = valor;
        }

        public double Calcular()
        {
            if(valor <= 28000)
            {
                return 0;
            }
            else if(valor > 28000 && valor <= 45000)
            {
                return this.valor * 0.15;
            }
            else
            {
                return this.valor * 0.20;
            }
        }
    }
}
