using ToDo.Entities;

namespace ToDo.Persistencia.Interfaces
{
    public interface ICuentaPersistencia
    {
        Cuenta? BuscarCuentaPorOwner(string ownerEmail);

        int GuardarCuenta(Cuenta cuenta);

    }
}
