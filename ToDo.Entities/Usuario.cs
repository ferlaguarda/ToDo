namespace ToDo.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Tarea>? Tareas { get; set; }

        public Usuario(string nombre, string correo, string contrasena)
        {
            Nombre = nombre;
            Email = correo;
            Password = contrasena;
            Tareas = [];
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrEmpty(Email))
                throw new ArgumentException("El correo no puede estar vacío.");
            if (string.IsNullOrEmpty(Password))
                throw new ArgumentException("La contraseña no puede estar vacía.");

            return true;
        }
    }
}
