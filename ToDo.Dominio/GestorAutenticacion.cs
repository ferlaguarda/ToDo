using ToDo.Entities;
using ToDo.Entities.Enumerados;
using ToDo.Entities.Constantes;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Dominio
{
    public class GestorAutenticacion
    {
        ICuentaPersistencia? _persistenciaCuenta;

        public GestorAutenticacion()
        {
            _persistenciaCuenta = new ToDo.Persistencia.DalArchivos.CuentaArchivo();

        }

        public Cuenta CrearCuenta(string nombre, string correo, string contrasena)
        {
            //Valir datos de entrada.
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrEmpty(correo))
                throw new ArgumentException("El correo no puede estar vacío.");
            if (string.IsNullOrEmpty(contrasena))
                throw new ArgumentException("La contraseña no puede estar vacía.");
            //TODO: Investigar como validar formato de correo y fuerza de contraseña.
            //Expresiones regulares

            //Validar que no exista cuenta con el mismo correo
            var cuenta = _persistenciaCuenta?.BuscarCuentaPorOwner(correo);
            if (cuenta != null)
                throw new InvalidOperationException("Ya existe una cuenta con el mismo correo.");
            //Crear cuenta y devolverla
            var nuevaCuenta = new Cuenta()
            {
                Owner = new Administrador()
                {
                    Nombre = nombre,
                    Email = correo,
                    Password = contrasena
                },
                TipoDeCuenta = TipoCuenta.Personal
            };
            _persistenciaCuenta?.GuardarCuenta(nuevaCuenta);
            return nuevaCuenta; 
        }

        public Dictionary<string, string> Login(string correo, string contrasena)
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
            //Dictionary<string, string> hola = new Dictionary<string, string>();
            //hola.Add("Clave", "valor");
            //if(!hola.ContainsKey("clave1"))
            //      hola.Add("clave1", "valor 2 ");

            return new Dictionary<string, string>
            {
                { ConstantesDeSesion.ID_CUENTA , cuenta.Id.ToString() },
                { ConstantesDeSesion.ID_USUARIO, cuenta.Owner.Id.ToString() },
                { ConstantesDeSesion.NOMBRE_USUARIO, cuenta.Owner.Nombre },
                { ConstantesDeSesion.CORREO_USUARIO, cuenta.Owner.Email },
                { ConstantesDeSesion.TIPO_CUENTA, cuenta.TipoDeCuenta.ToString() }
            };
        }
    }
}
