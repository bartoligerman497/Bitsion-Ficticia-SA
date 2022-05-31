using Bitsion_Ficticia_S.A.Models.DTO;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Bitsion_Ficticia_S.A.Models.Cliente
{
    public class GBDCliente
    {
        private string conexionString = "Server=localhost;user=root;password=1234;database=bitsion-ficticia-s.a";

        public List<ClienteModel> CargarListadoClientes()
        {
            List<ClienteModel> listadoClientes = new List<ClienteModel>();

            MySqlConnection conexion = new MySqlConnection(conexionString);

            string consulta =
                @"	SELECT
	                              cliente.idCliente AS idCliente,
	                              cliente.nombre AS nombre,
	                              cliente.apellido AS apellido,
	                              cliente.dni AS dni,
	                              cliente.edad AS edad,
	                              genero.idGenero AS idGenero,
	                              genero.descripcion AS genero,
	                              cliente.maneja AS maneja,
	                              cliente.lentes AS lentes,
	                              cliente.diabetico AS diabetico,
	                              cliente.enfermedades AS enfermedades,
	                              cliente.activo AS activoCliente
	                            FROM cliente
	                              INNER JOIN genero
	                                ON cliente.idGenero = genero.idGenero
	                            WHERE cliente.activo = 1;";

            MySqlCommand command = new MySqlCommand(consulta, conexion);
            command.CommandType = CommandType.Text;

            conexion.Open();

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0));

                ClienteModel cliente = new();
                cliente.IdCliente = Convert.IsDBNull(reader.GetValue("idCliente")) ? 0 : reader.GetInt32("idCliente");
                cliente.Nombre = Convert.IsDBNull(reader.GetValue("nombre")) ? string.Empty : reader.GetString("nombre");
                cliente.Apellido = Convert.IsDBNull(reader.GetValue("apellido")) ? string.Empty : reader.GetString("apellido");
                cliente.Dni = Convert.IsDBNull(reader.GetValue("dni")) ? string.Empty : reader.GetString("dni");
                cliente.Edad = Convert.IsDBNull(reader.GetValue("edad")) ? 0 : reader.GetInt32("edad");

                GeneroModel genero = new();
                genero.IdGenero = Convert.IsDBNull(reader.GetValue("idGenero")) ? 0 : reader.GetInt32("idGenero");
                genero.Descripcion = Convert.IsDBNull(reader.GetValue("genero")) ? string.Empty : reader.GetString("genero");
                cliente.Genero = genero;

                cliente.Maneja = Convert.IsDBNull(reader.GetValue("maneja")) ? false : reader.GetBoolean("maneja");
                cliente.UsaLentes = Convert.IsDBNull(reader.GetValue("lentes")) ? false : reader.GetBoolean("lentes");
                cliente.Diabetico = Convert.IsDBNull(reader.GetValue("diabetico")) ? false : reader.GetBoolean("diabetico");
                cliente.Enfermedades = Convert.IsDBNull(reader.GetValue("enfermedades")) ? string.Empty : reader.GetString("enfermedades");
                cliente.ActivoCliente = Convert.IsDBNull(reader.GetValue("activoCliente")) ? false : reader.GetBoolean("activoCliente");

                listadoClientes.Add(cliente);
            }
            reader.Close();
            conexion.Close();

            return listadoClientes;
        }

        public bool AgregarCliente(ClienteModel cliente)
        {
            int filasAfectadas = 0;

            MySqlConnection conexion = new MySqlConnection(conexionString);

            string consulta =
                @"
                        INSERT INTO cliente
                        (
                         nombre
                         ,apellido
                         ,dni
                         ,edad
                         ,idGenero
                         ,maneja
                         ,lentes
                         ,diabetico
                         ,enfermedades
                         ,activo
                        )
                        VALUES
                        (
                         @nombre -- nombre - VARCHAR(255)
                         ,@apellido -- apellido - VARCHAR(255)
                         ,@dni -- dni - VARCHAR(255)
                         ,@edad -- edad - VARCHAR(255)
                         ,@genero -- idGenero - INT
                         ,@maneja -- maneja - VARCHAR(255)
                         ,@lentes -- lentes - VARCHAR(255)
                         ,@diabetico -- diabetico - VARCHAR(255)
                         ,@enfermedades -- enfermedades - VARCHAR(255)
                         ,@activo -- activo - VARCHAR(255)
                        );";

            MySqlCommand command = new MySqlCommand(consulta, conexion);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@dni", cliente.Dni);
            command.Parameters.AddWithValue("@edad", cliente.Edad);
            command.Parameters.AddWithValue("@genero", cliente.Genero.IdGenero);
            command.Parameters.AddWithValue("@maneja", cliente.Maneja);
            command.Parameters.AddWithValue("@lentes", cliente.UsaLentes);
            command.Parameters.AddWithValue("@diabetico", cliente.Diabetico);
            command.Parameters.AddWithValue("@enfermedades", cliente.Enfermedades);

            command.Parameters.AddWithValue("@activo", 1);

            conexion.Open();

            filasAfectadas = command.ExecuteNonQuery();

            conexion.Close();

            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModificarCliente(ClienteModel cliente)
        {
            int filasAfectadas = 0;

            MySqlConnection conexion = new MySqlConnection(conexionString);

            string consulta =
                @"
                        UPDATE cliente
                        SET
                          nombre = @nombre -- nombre - VARCHAR(255)
                         ,apellido = @apellido -- apellido - VARCHAR(255)
                         ,dni = @dni -- dni - VARCHAR(255)
                         ,edad = @edad -- edad - VARCHAR(255)
                         ,idGenero = @genero -- idGenero - INT
                         ,maneja = @maneja -- maneja - VARCHAR(255)
                         ,lentes = @lentes -- lentes - VARCHAR(255)
                         ,diabetico = @diabetico -- diabetico - VARCHAR(255)
                         ,enfermedades = @enfermedades -- enfermedades - VARCHAR(255)
                        WHERE
                          idCliente = @idCliente -- idCliente - INT NOT NULL
                        ";

            MySqlCommand command = new MySqlCommand(consulta, conexion);

            command.Parameters.AddWithValue("@nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@dni", cliente.Dni);
            command.Parameters.AddWithValue("@edad", cliente.Edad);
            command.Parameters.AddWithValue("@genero", cliente.Genero.IdGenero);
            command.Parameters.AddWithValue("@maneja", cliente.Maneja);
            command.Parameters.AddWithValue("@lentes", cliente.UsaLentes);
            command.Parameters.AddWithValue("@diabetico", cliente.Diabetico);
            command.Parameters.AddWithValue("@enfermedades", cliente.Enfermedades);

            command.Parameters.AddWithValue("@idCliente", cliente.IdCliente);

            conexion.Open();

            filasAfectadas = command.ExecuteNonQuery();

            conexion.Close();

            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeshabilitarCliente(int idCliente)
        {
            int filasAfectadas = 0;

            MySqlConnection conexion = new MySqlConnection(conexionString);

            string consulta = @"
                                Update cliente
                                set activo = false
                                where idCliente = @idCliente
                            ";

            MySqlCommand command = new();

            command.Connection = conexion;
            command.CommandText = consulta;

            command.Parameters.AddWithValue("@idCliente", idCliente);

            conexion.Open();

            filasAfectadas = command.ExecuteNonQuery();

            conexion.Close();

            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DTOModel ObtenerClientexIdCliente(int? idCliente)
        {
            DTOModel dto = new();

            String consulta =
                              @"	SELECT
	                              cliente.idCliente AS idCliente,
	                              cliente.nombre AS nombre,
	                              cliente.apellido AS apellido,
	                              cliente.dni AS dni,
	                              cliente.edad AS edad,
	                              genero.idGenero AS idGenero,
	                              genero.descripcion AS genero,
	                              cliente.maneja AS maneja,
	                              cliente.lentes AS lentes,
	                              cliente.diabetico AS diabetico,
	                              cliente.enfermedades AS enfermedades,
	                              cliente.activo AS activoCliente
	                            FROM cliente
	                              INNER JOIN genero
	                                ON cliente.idGenero = genero.idGenero
	                            WHERE cliente.activo = 1 and
                                 cliente.idCliente = @idCliente;";

            MySqlConnection conexion = new MySqlConnection(conexionString);

            MySqlCommand command = new MySqlCommand(consulta, conexion);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@idCliente", idCliente);

            conexion.Open();

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(Convert.IsDBNull(reader.GetValue("idCliente")) ? 0 : reader.GetInt32("idCliente"));

                ClienteModel cliente = new();

                cliente.IdCliente = Convert.IsDBNull(reader.GetValue("idCliente")) ? 0 : reader.GetInt32("idCliente");
                cliente.Nombre = Convert.IsDBNull(reader.GetValue("nombre")) ? string.Empty : reader.GetString("nombre");
                cliente.Apellido = Convert.IsDBNull(reader.GetValue("apellido")) ? string.Empty : reader.GetString("apellido");
                cliente.Dni = Convert.IsDBNull(reader.GetValue("dni")) ? string.Empty : reader.GetString("dni");
                cliente.Edad = Convert.IsDBNull(reader.GetValue("edad")) ? 0 : reader.GetInt32("edad");

                GeneroModel genero = new();
                genero.IdGenero = Convert.IsDBNull(reader.GetValue("idGenero")) ? 0 : reader.GetInt32("idGenero");
                genero.Descripcion = Convert.IsDBNull(reader.GetValue("genero")) ? string.Empty : reader.GetString("genero");
                cliente.Genero = genero;

                cliente.Maneja = Convert.IsDBNull(reader.GetValue("maneja")) ? false : reader.GetBoolean("maneja");
                cliente.UsaLentes = Convert.IsDBNull(reader.GetValue("lentes")) ? false : reader.GetBoolean("lentes");
                cliente.Diabetico = Convert.IsDBNull(reader.GetValue("diabetico")) ? false : reader.GetBoolean("diabetico");
                cliente.Enfermedades = Convert.IsDBNull(reader.GetValue("enfermedades")) ? string.Empty : reader.GetString("enfermedades");
                cliente.ActivoCliente = Convert.IsDBNull(reader.GetValue("activoCliente")) ? false : reader.GetBoolean("activoCliente");

                dto.Cliente = cliente;
            }
            reader.Close();
            conexion.Close();

            return dto;
        }

        public int ObtenerUltimoIDCliente()
        {
            int ultimoIDCliente = 0;

            try
            {
                MySqlConnection conexion = new MySqlConnection(conexionString);

                string consulta =
                    "SELECT " +
                    "MAX(idCliente) " +
                    "FROM Cliente";

                MySqlCommand command = new MySqlCommand(consulta, conexion);
                command.CommandType = CommandType.Text;

                conexion.Open();

                MySqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0));

                    ultimoIDCliente = reader.GetInt32(0);
                }

                reader.Close();
                conexion.Close();
            }
            catch (global::System.Exception)
            {
                throw;
            }
            return ultimoIDCliente;
        }
    }
}