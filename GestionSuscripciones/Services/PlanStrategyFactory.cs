using GestionSuscripciones.Model;

namespace GestionSuscripciones.Services
{
    public class PlanStrategyFactory
    {
        public IPlanStrategy ObtenerEstrategia(TipoSuscripcion suscripcion)
        {
            return suscripcion switch
            {
                TipoSuscripcion.Basico => new BasicoStrategy(),
                TipoSuscripcion.Estandar => new EstandarStrategy(),
                TipoSuscripcion.Premium => new PremiumStrategy(),

                _ => throw new ArgumentException("Tipo de suscripción no válido.")
            };
        }
    }
}
