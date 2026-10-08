namespace ToDo.Entities
{
    public class Nota
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public override string ToString()
        {
            return FechaCreacion.ToString("dd-MM-yyyy") + " - " + Descripcion;
        }
    }
}
