namespace GestionSuscripciones.Services
{
    public class PremiumStrategy : IPlanStrategy
    {
        public readonly decimal CostoBase = 5000;
        public readonly decimal CostoAdicionalPorMinuto = 0.50M;

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
