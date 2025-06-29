using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ToolTrack.API.Models
{
    public class Herramienta
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;

        public string Codigo { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;
    }
}
