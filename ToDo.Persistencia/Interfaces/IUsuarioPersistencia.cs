using ToDo.Entities;

namespace ToDo.Persistencia.Interfaces
{
    public interface IUsuarioPersistencia
    {
        int CrearUsuario(Usuario usuario);
        List<Usuario> ObtenerUsuariosPorCuenta(Guid cuentaId);
    }
}
