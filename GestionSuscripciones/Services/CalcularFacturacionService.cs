using GestionSuscripciones.Model;

namespace GestionSuscripciones.Services
{
    public class CalcularFacturacionService
    {
        public List<ActividadesAgrupadasPorUsuario> ObtenerActividadesAgrupadas(List<Actividad> actividades, List<Usuario> usuarios) 
        {
            var pe = new PlanStrategyFactory();
            var actividadesAgrupadas = from u in usuarios
                              join a in actividades on u.IdUsuario equals a.IdUsuario
                              where (a.Fecha.Month == DateTime.Now.Month) && (a.Fecha.Year == DateTime.Now.Year)
                                       group a by new { u.Nombre, u.Email, u.Tipo, u.IdUsuario } into grupo
                              select new ActividadesAgrupadasPorUsuario
                              {
                                  NombreUsuario = grupo.Key.Nombre,
                                  Email = grupo.Key.Email,
                                  Tipo = grupo.Key.Tipo,
                                  TotalMinutosDelMesActual = grupo.Sum(a => a.MinutosReproducidos),
                                  TotalFacturado = pe.ObtenerEstrategia(grupo.Key.Tipo).CalcularTotal(grupo.Sum(a => a.MinutosReproducidos))
                              };

            return actividadesAgrupadas.ToList();
        }
    }
}
