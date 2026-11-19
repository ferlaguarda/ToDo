using ToDo.Persistencia.Interfaces;
using ToDo.Entities;

namespace ToDo.Dominio
{
    public class GestorUsuario
    {
        IUsuarioPersistencia? _persistenciaUsuario;

        public GestorUsuario()
        {
            _persistenciaUsuario = new ToDo.Persistencia.DalDataBase.UsuarioDb();
        }

        public Usuario CrearUsuario(string nombre, string correo, string contrasena)
        {
            //Validar que no exista usuario con el mismo correo
            var usuarioExistente = _persistenciaUsuario?.ObtenerUsuariosPorCuenta(Guid.Empty)
                .FirstOrDefault(u => u.Email == correo);
            if (usuarioExistente is not null)
                throw new InvalidOperationException("Ya existe un usuario con el mismo correo.");
            Usuario usuario = new(nombre, correo, contrasena);
            if (!usuario.IsValid())
                throw new ArgumentException("Los datos del usuario no son válidos.");
            //Crear usuario y devolver su ID
            usuario.Id = _persistenciaUsuario?.CrearUsuario(usuario) ?? 0;
            return usuario;
        }

    }
}
