using GestionSuscripciones.Model;

namespace GestionSuscripciones.Infraestructura
{
    public class CargarArchivosCSV
    {
        private readonly string rutaUsuarios = @"Data\usuarios.csv";
        private readonly string rutaActividad = @"Data\actividad.csv";

        public List<Usuario> CargarUsuarios()
        {
            var usuarios = new List<Usuario>();
            var lineas = File.ReadAllLines(rutaUsuarios);
            for (int i = 0; i < lineas.Length; i++)
            {
                var partes = lineas[i].Split(',');
                var usuario = new Usuario
                {
                    IdUsuario = int.Parse(partes[0]),
                    Nombre = partes[1],
                    Email = partes[2],
                    Tipo = Enum.Parse<TipoSuscripcion>(partes[3])
                };

                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public List<Actividad> CargarActividad()
        {
            var actividades = new List<Actividad>();
            var lineas = File.ReadAllLines(rutaActividad);
            for (int i = 0; i < lineas.Length; i++)
            {
                var partes = lineas[i].Split(',');
                var actividad = new Actividad
                {
                    IdUsuario = int.Parse(partes[0]),
                    MinutosReproducidos = int.Parse(partes[1]),
                    Fecha = DateTime.Parse(partes[2])
                };

                actividades.Add(actividad);
            }
            return actividades;
        }
    }
}
