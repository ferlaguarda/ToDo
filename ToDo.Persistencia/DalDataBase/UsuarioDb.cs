#region Using
using Microsoft.Data.SqlClient;
using ToDo.Entities;
using ToDo.Persistencia.Interfaces; 
#endregion

namespace ToDo.Persistencia.DalDataBase
{
    public class UsuarioDb : IUsuarioPersistencia
    {
        public int CrearUsuario(Usuario usuario)
        {
            SqlConnection connection = new SqlConnection(Constantes.CONEXION_BD);
            try
            {
                connection.Open();
                string query = "INSERT INTO Usuario (Name, Email, Password) VALUES (@Name, @Email, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", usuario.Nombre);
                command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Password", usuario.Password);
                command.ExecuteNonQuery();
                //Retornar el ID del usuario creado.
                //Para ello, se puede ejecutar una consulta adicional para obtener el ID del último registro insertado.
                command.CommandText = "SELECT MAX(Id) FROM Usuario";
                int usuarioId = Convert.ToInt32(command.ExecuteScalar());
                return usuarioId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el usuario: {ex.Message}");
                return 0;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public List<Usuario> ObtenerUsuariosPorCuenta(Guid cuentaId)
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection connection = new SqlConnection(Constantes.CONEXION_BD);
            try
            {
                connection.Open();
                string query = "SELECT Id, Name, Email, Password FROM Usuario WHERE CuentaId = @CuentaId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CuentaId", cuentaId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario(reader.GetString(1), reader.GetString(2), reader.GetString(3))
                    {
                        Id = reader.GetInt32(0)
                    };
                    usuarios.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los usuarios: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return usuarios;
        }
    }
}
