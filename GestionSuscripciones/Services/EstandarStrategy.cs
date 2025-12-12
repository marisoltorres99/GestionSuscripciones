namespace GestionSuscripciones.Services
{
    public class EstandarStrategy : IPlanStrategy
    {
        public readonly decimal CostoBase = 3500;
        public readonly decimal CostoAdicionalPorMinuto = 1;

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
