using System;

namespace ToolTrack.Models
{
    public class Movimiento
    {
        public string HerramientaNombre { get; set; }
        public string Responsable { get; set; }
        public string Ubicacion { get; set; }
        public string Tipo { get; set; } // Ingreso o Egreso
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
