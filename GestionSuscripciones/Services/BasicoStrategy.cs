namespace GestionSuscripciones.Services
{
    public class BasicoStrategy : IPlanStrategy
    {
        public readonly decimal CostoBase = 2000;
        public readonly decimal CostoAdicionalPorMinuto = 1.50M;

        public decimal CalcularTotal(int minutosConsumidos)
        {
            decimal total = CostoBase;
            if (minutosConsumidos > 500)
            {
                var minutosExtra = minutosConsumidos - 500;
                total = total + (minutosExtra * CostoAdicionalPorMinuto);
            }

            return total;
        }
    }
}
