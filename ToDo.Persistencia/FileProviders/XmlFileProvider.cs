using System.Xml.Serialization;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Persistencia.FileProviders
{
    internal class XmlFileProvider : IFileProvider
    {
        public List<T> LeerRegistros<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return [];

            var content = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            var serializer = new XmlSerializer(typeof(List<T>));
            return (List<T>?)serializer.Deserialize(content) ?? new List<T>();
        }

        public void GuardarRegistros<T>(string filePath, List<T> registros)
        {
            var content = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            var serializer = new XmlSerializer(typeof(List<T>));
            serializer.Serialize(content, registros);
        }

    }
}
