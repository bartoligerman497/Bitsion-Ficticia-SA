using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace BitsionFicticiaSA.Models.Cliente.Genero;

public class GBDGenero
{
    public List<GeneroModel> CargarComboGenero()
    {
        List<GeneroModel> comboGenero = new();

        MySqlConnection conexion = new MySqlConnection(GestorBDConexion.ConexionString);

        String consulta =
                                        @"SELECT
                                          genero.idGenero,
	                                      genero.descripcion
                                        FROM genero
                                        order by 2; ";

        MySqlCommand command = new MySqlCommand(consulta, conexion);
        command.CommandType = CommandType.Text;

        conexion.Open();

        MySqlDataReader reader;
        reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(reader.GetInt32(0));

            GeneroModel genero = new();
            genero.IdGenero = reader.GetInt32(0);
            genero.Descripcion = reader.GetString(1);

            comboGenero.Add(genero);
        }
        reader.Close();
        conexion.Close();

        return comboGenero;
    }
}