using ToDo.Entities.Enumerados;

namespace ToDo.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaLimite { get; set; }
        public int? DuracionEstimada { get; set; }
        public Estado EstadoTarea { get; set; }
        public Prioridad PrioridadTarea { get; set; }
        public List<Nota>? Notas { get; set; }
        public List<Comentario>? Comentarios { get; set; }
        public Usuario? Responsable { get; set; }
    }
}
