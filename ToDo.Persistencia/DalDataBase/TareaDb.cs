using ToDo.Entities;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Persistencia.DalDataBase
{
    public class TareaDb : ITareaPersistencia
    {
        public bool ActualizarTarea(Tarea tarea)
        {
            throw new NotImplementedException();
        }

        public Tarea? BuscarTareaPorId(int idTarea)
        {
            throw new NotImplementedException();
        }

        public int CrearTarea(Tarea tarea)
        {
            throw new NotImplementedException();
        }

        public bool EliminarTarea(Tarea tarea)
        {
            throw new NotImplementedException();
        }

        public List<Tarea> LeerTareas()
        {
            throw new NotImplementedException();
        }

        public List<Tarea> ObtenerTareasPorCuenta(Guid cuentaId)
        {
            throw new NotImplementedException();
        }

        public List<Tarea> ObtenerTareasPorUsuario(Guid cuentaId)
        {
            throw new NotImplementedException();
        }
    }
}
