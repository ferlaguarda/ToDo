using ToDo.Entities;

namespace ToDo.Persistencia.Interfaces
{
    public interface ITareaPersistencia
    {
        int CrearTarea(Tarea tarea);
        List<Tarea> ObtenerTareasPorCuenta(Guid cuentaId);
        List<Tarea> ObtenerTareasPorUsuario(Guid cuentaId);
        bool ActualizarTarea(Tarea tarea);
    }
}
