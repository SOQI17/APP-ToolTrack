using System.Collections.Generic;

namespace ToolTrack.Models
{
    public static class DataStore
    {
        public static List<Herramienta> Herramientas { get; set; } = new();
        public static List<Movimiento> Movimientos { get; set; } = new();
    }
}
