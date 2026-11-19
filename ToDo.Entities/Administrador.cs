namespace ToDo.Entities
{
    public class Administrador : Usuario
    {
        public Administrador(string nombre, string correo, string contrasena)
            : base(nombre, correo, contrasena)
        {
        }
    }
}
