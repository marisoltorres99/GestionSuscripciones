using GestionSuscripciones.Infraestructura;
using GestionSuscripciones.Services;

public class Program 
{
    static void Main(string[] args)
    {
        var cargar = new CargarArchivosCSV();
        var actividades = cargar.CargarActividad();
        var usuarios = cargar.CargarUsuarios();

        var factService = new CalcularFacturacionService();
        factService.ObtenerActividadesAgrupadas(actividades, usuarios);
    }
}