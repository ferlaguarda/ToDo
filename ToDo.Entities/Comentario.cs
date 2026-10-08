namespace ToDo.Entities
{
    public class Comentario
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public string? Respuesta { get; set; }
        public DateTime? FechaRespuesta { get; set; }

    }
}
