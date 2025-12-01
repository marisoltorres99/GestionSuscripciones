using GestionSuscripciones.Model;

namespace GestionSuscripciones.Services
{
    public class ActividadesAgrupadasPorUsuario
    {
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public TipoSuscripcion Tipo { get; set; }
        public int TotalMinutosDelMesActual { get; set; }
        public decimal TotalFacturado { get; set; }
    }
}
