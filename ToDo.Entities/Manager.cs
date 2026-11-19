namespace ToDo.Entities
{
    public class Manager : Usuario
    {
        public List<Equipo>? Equipos { get; set; }

        public Manager(string nombre, string correo, string contrasena)
            : base(nombre, correo, contrasena)
        {
            Equipos = new List<Equipo>();
        }
    }
}
