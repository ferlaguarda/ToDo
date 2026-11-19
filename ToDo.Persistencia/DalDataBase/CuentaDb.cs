#region Using
using Microsoft.Data.SqlClient;
using ToDo.Entities;
using ToDo.Entities.Enumerados;
using ToDo.Persistencia.Interfaces; 
#endregion

namespace ToDo.Persistencia.DalDataBase
{
    public class CuentaDb : ICuentaPersistencia
    {
        public Cuenta? BuscarCuentaPorOwner(string ownerEmail)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONEXION_BD);
            try
            {
                connection.Open();
                string query = "SELECT c.Id, c.OwnerId, c.AccountTypeId, u.Name, u.Password " +
                    "FROM Cuenta c JOIN Usuario u ON c.OwnerId = u.Id " +
                    "WHERE u.Email = @OwnerEmail";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerEmail", ownerEmail);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    var cuenta = new Cuenta(reader.GetGuid(0), reader.GetString(3), ownerEmail, reader.GetString(4), (TipoCuenta)reader.GetInt16(2));
                    return cuenta;
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar la cuenta: {ex.Message}");
                return null;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public int GuardarCuenta(Cuenta cuenta)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONEXION_BD);
            try
            {
                connection.Open();
                string query = "INSERT INTO Cuenta (Id, OwnerId, AccountTypeId) VALUES (@Id, @OwnerId, @AccountType)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", cuenta.Id);
                command.Parameters.AddWithValue("@OwnerId", cuenta.Owner.Id);
                command.Parameters.AddWithValue("@AccountType", cuenta.TipoDeCuenta);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la cuenta: {ex.Message}");
                return 0;
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
