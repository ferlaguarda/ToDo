namespace ToDo.Entities
{
    public class Equipo
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public int MaxIntegrantes { get; set; }
        public Manager? LiderEquipo { get; set; }
        public List<Tarea>? Tareas { get; set; }
        public List<Usuario>? Integrantes { get; set; }
    }
}
