using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities;
using ToDo.Persistencia.Interfaces;

namespace ToDo.Persistencia.DalArchivos
{
    public class CuentaArchivo : ICuentaPersistencia
    {
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
            var directorio = "C:\\Temporales\\ToDo.Files";
            var filePath = Path.Combine(directorio, $"{Constantes.ARCHIVO_CUENTAS}.json");
            var json = System.Text.Json.JsonSerializer.Serialize(cuentas);
            File.WriteAllText(filePath, json);
            return 0;
        }
        
        private List<Cuenta> LeerCuentas()
        {
            var directorio = "C:\\Temporales\\ToDo.Files";
            var filePath = Path.Combine(directorio, $"{Constantes.ARCHIVO_CUENTAS}.json");
            if (!File.Exists(filePath))
            {
                return new List<Cuenta>();
            }
            var json = File.ReadAllText(filePath);
            return System.Text.Json.JsonSerializer.Deserialize<List<Cuenta>>(json) 
                ?? new List<Cuenta>();
        }

    }
}
