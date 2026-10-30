using System.Text.Json;
using ToDo.Entities;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Persistencia.FileProviders
{
    internal class JsonFileProvider : IFileProvider
    {
        public List<T> LeerRegistros<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return [];

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? [];
        }

        public void GuardarRegistros<T>(string filePath, List<T> registros)
        {
            var json = JsonSerializer.Serialize(registros);
            File.WriteAllText(filePath, json);
        }
    }
}
