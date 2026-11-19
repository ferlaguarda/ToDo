using ToDo.Entities.Enumerados;

namespace ToDo.Entities
{
    public class Cuenta
    {
        public Guid Id { get; }
        public Administrador Owner { get; set; }
        public TipoCuenta TipoDeCuenta { get; set; } = TipoCuenta.Personal;
        public List<Usuario>? Usuarios { get; set; }
        public List<Tarea>? Tareas { get; set; }


        public Cuenta(Usuario usuario, TipoCuenta? tipo)
        {
            Id = Guid.NewGuid();
            Owner = new Administrador(usuario.Nombre, usuario.Email, usuario.Password)
            {
                Id = usuario.Id,
            };
            TipoDeCuenta = tipo.HasValue ? tipo.Value : TipoCuenta.Personal;
        }

        public Cuenta(Guid id, string nombre, string email, string password, TipoCuenta tipo)
        {
            Id = id;
            Owner = new Administrador(nombre, email, password);
            TipoDeCuenta = tipo;
        }
    }
}
