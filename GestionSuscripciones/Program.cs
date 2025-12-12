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
        var actividadesAgrupadas = factService.ObtenerActividadesAgrupadas(actividades, usuarios);

        foreach (var item in actividadesAgrupadas)
        {
            Console.WriteLine("----- Usuario -----");
            Console.WriteLine($"Nombre: {item.NombreUsuario}");
            Console.WriteLine($"Email: {item.Email}");
            Console.WriteLine($"Tipo: {item.Tipo}");
            Console.WriteLine($"Total Minutos del Mes: {item.TotalMinutosDelMesActual}");
            Console.WriteLine($"Total Facturado: ${item.TotalFacturado}");
            Console.WriteLine();
        }
    }
}