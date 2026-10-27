using ToDo.Entities.Enumerados;

namespace ToDo.Entities
{
    public class Cuenta
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required Administrador Owner { get; set; }
        public TipoCuenta TipoDeCuenta { get; set; } = TipoCuenta.Personal;
        public List<Usuario>? Usuarios { get; set; }
        public List<Tarea>? Tareas { get; set; }
    }
}
