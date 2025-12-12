namespace GestionSuscripciones.Services
{
    public interface IPlanStrategy
    {
        decimal CalcularTotal(int minutosConsumidos);
    }
}
