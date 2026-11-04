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
            if (_persistenciaTarea == null) 
                throw new InvalidOperationException("Persistencia no inicializada");
            var tareas = _persistenciaTarea.LeerTareas();
            int ultimoId = tareas.Any() ? tareas.Max(t => t.Id) : 0;
            tarea.Id = ultimoId + 1;
            return _persistenciaTarea.CrearTarea(tarea);
        }

        public List<Tarea> ObtenerTareasPorCuenta(Guid cuentaId)
        {
            if (_persistenciaTarea == null)
                throw new InvalidOperationException("Persistencia no inicializada");

            var todasLasTareas = _persistenciaTarea.LeerTareas();
            var tareasCuenta = todasLasTareas
                .Where(t => t.IdCuenta == cuentaId)
                .ToList();
            
            return tareasCuenta;
        }

        public List<Tarea> ObtenerTareasPorUsuario(Guid cuentaId)
        {
            throw new NotImplementedException();

        }

        public bool ActualizarTarea(Tarea tarea)
        {
            throw new NotImplementedException();
        }

        public bool EliminarTarea(int tareaId)
        {
            if (_persistenciaTarea == null)
                throw new InvalidOperationException("Persistencia no inicializada");

            var tarea = _persistenciaTarea.BuscarTareaPorId(tareaId);
            if (tarea == null)
                throw new Exception("Tarea no encontrada");

            return _persistenciaTarea.EliminarTarea(tarea);
        }
    }
}
