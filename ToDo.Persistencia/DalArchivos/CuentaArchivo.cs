using ToDo.Entities;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Persistencia.DalArchivos
{
    public class CuentaArchivo : ICuentaPersistencia
    {
        private string _filePath = 
            Path.Combine(Constantes.CARPETA_ARCHIVOS, $"{Constantes.ARCHIVO_CUENTAS}.json");
        
        public Cuenta? BuscarCuentaPorOwner(string ownerEmail)
        {
            List<Cuenta> cuentas = LeerCuentas();
            foreach (var cuenta in cuentas)
            {
                if (cuenta.Owner.Email == ownerEmail)
                {
                    return cuenta;
                }
            }
            return null;
        }

        public int GuardarCuenta(Cuenta cuenta)
        {
            List<Cuenta> cuentas = LeerCuentas();
            cuentas.Add(cuenta);
            var json = System.Text.Json.JsonSerializer.Serialize(cuentas);
            File.WriteAllText(_filePath, json);
            return 0;
        }
        
        private List<Cuenta> LeerCuentas()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Cuenta>();
            }
            var json = File.ReadAllText(_filePath);
            return System.Text.Json.JsonSerializer.Deserialize<List<Cuenta>>(json) 
                ?? new List<Cuenta>();
        }

    }
}
