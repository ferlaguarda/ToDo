#region Using
using ToDo.Entities;
using ToDo.Entities.Enumerados;
using ToDo.Entities.Constantes;
using ToDo.Persistencia.Interfaces;

#endregion

namespace ToDo.Dominio
{
    public class GestorAutenticacion
    {
        ICuentaPersistencia? _persistenciaCuenta;

        public GestorAutenticacion()
        {
            _persistenciaCuenta = new ToDo.Persistencia.DalDataBase.CuentaDb();

        }

        public Cuenta CrearCuenta(string nombre, string correo, string contrasena)
        {
            //Validar que no exista cuenta con el mismo correo
            var cuenta = _persistenciaCuenta?.BuscarCuentaPorOwner(correo);
            if (cuenta is not null)
                throw new InvalidOperationException("Ya existe una cuenta con el mismo correo.");

            var user = new GestorUsuario().CrearUsuario(nombre, correo, contrasena);

            var auc = user as Administrador;
            //Crear cuenta y devolverla
            var nuevaCuenta = new Cuenta(user, TipoCuenta.Personal);  
            _persistenciaCuenta?.GuardarCuenta(nuevaCuenta);
            return nuevaCuenta; 
        }

        public Cuenta Login(string correo, string contrasena)
        {
            if (string.IsNullOrEmpty(correo))
                throw new ArgumentException("El correo no puede estar vacío.");
            if (string.IsNullOrEmpty(contrasena))
                throw new ArgumentException("La contraseña no puede estar vacía.");

            //Validar que no exista cuenta con el mismo correo
            var cuenta = _persistenciaCuenta?.BuscarCuentaPorOwner(correo);
            if (cuenta is null)
                throw new InvalidOperationException("No se pudo encontrar su usuario. Por favor verifique los datos.");
            else
            {
                if ((cuenta.Owner.Password != contrasena))
                    throw new InvalidOperationException("Las credenciales de acceso no son validas.");
            }

            return cuenta;
        }
    }
}
