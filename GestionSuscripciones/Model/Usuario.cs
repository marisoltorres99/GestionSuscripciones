namespace GestionSuscripciones.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

    }

    public enum TipoSuscripcion
    {
        Basico,
        Estandar,
        Premium
    }
}
