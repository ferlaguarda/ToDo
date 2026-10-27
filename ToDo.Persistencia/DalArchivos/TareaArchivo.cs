using ToDo.Entities;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Persistencia.DalArchivos
{
    public class TareaArchivo : ITareaPersistencia
    {
        public bool ActualizarTarea(Tarea tarea)
        {
            throw new NotImplementedException();
        }

        public int CrearTarea(Tarea tarea)
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

        private List<Tarea> LeerTareas()
        {
            var directorio = "C:\\Temporales\\ToDo.Files";
            var filePath = Path.Combine(directorio, $"{Constantes.ARCHIVO_TAREAS}.json");
            if (!File.Exists(filePath))
            {
                return new List<Tarea>();
            }
            var json = File.ReadAllText(filePath);
            return System.Text.Json.JsonSerializer.Deserialize<List<Tarea>>(json)
                ?? new List<Tarea>();
        }
    }
}
