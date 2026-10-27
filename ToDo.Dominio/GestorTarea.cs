using ToDo.Entities;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Dominio
{
    public class GestorTarea
    {
        ITareaPersistencia? _persistenciaTarea;

        public GestorTarea()
        {
            _persistenciaTarea = new ToDo.Persistencia.DalArchivos.TareaArchivo();
        }
        public int CrearTarea(Tarea tarea)
        {
            if (_persistenciaTarea == null) throw new InvalidOperationException("Persistencia no inicializada");
            return _persistenciaTarea.CrearTarea(tarea);
        }

        public List<Tarea> ObtenerTareasPorCuenta(Guid cuentaId)
        {
            throw new NotImplementedException();
        }

        public List<Tarea> ObtenerTareasPorUsuario(Guid cuentaId)
        {
            throw new NotImplementedException();

        }

        public bool ActualizarTarea(Tarea tarea)
        {
            throw new NotImplementedException();
        }
    }
}
