using ToDo.Entities.Enumerados;

namespace ToDo.Entities
{
    public class CuentaEmpresa : Cuenta
    {
        public CuentaEmpresa(Usuario usuario, TipoCuenta? tipo) : base(usuario, tipo)
        {
        }

        public List<Equipo>? Equipos { get; set; }
    }
}
