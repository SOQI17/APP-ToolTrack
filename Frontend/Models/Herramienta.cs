namespace ToolTrack.Models
{
    public class Herramienta
    {
        public string Nombre { get; set; }
        public string Serial { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Disponible { get; set; } = true;
    }
}
