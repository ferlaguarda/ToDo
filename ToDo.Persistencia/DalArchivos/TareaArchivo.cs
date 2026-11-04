using ToDo.Entities;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Persistencia.DalArchivos
{
    public class TareaArchivo : ITareaPersistencia
    {
        private string _filePath =
            Path.Combine(Constantes.CARPETA_ARCHIVOS, $"{Constantes.ARCHIVO_TAREAS}.json");

        private IFileProvider _fileProvider = new FileProviders.JsonFileProvider();


        public bool ActualizarTarea(Tarea tarea)
        {
            throw new NotImplementedException();
        }

        public int CrearTarea(Tarea tarea)
        {
            List<Tarea> tareas = _fileProvider.LeerRegistros<Tarea>(_filePath);
            tareas.Add(tarea);
            _fileProvider.GuardarRegistros<Tarea>(_filePath, tareas);
            return tarea.Id;
        }

        public List<Tarea> ObtenerTareasPorCuenta(Guid cuentaId)
        {
            throw new NotImplementedException();
        }

        public List<Tarea> ObtenerTareasPorUsuario(Guid cuentaId)
        {
            throw new NotImplementedException();
        }

        public List<Tarea> LeerTareas()
        {
            return _fileProvider.LeerRegistros<Tarea>(_filePath);
        }

        public Tarea? BuscarTareaPorId(int idTarea)
        {
            List<Tarea> tareas = _fileProvider.LeerRegistros<Tarea>(_filePath);
            var tarea = tareas.Where(t => t.Id == idTarea).FirstOrDefault();
            return tarea is null ? null : tarea;
        }

        public bool EliminarTarea(Tarea tarea)
        {
            List<Tarea> tareas = _fileProvider.LeerRegistros<Tarea>(_filePath);
            tareas.Remove(tarea);
            _fileProvider.GuardarRegistros<Tarea>(_filePath, tareas);
            return true;
        }
    }
}
