using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace HolaMundoCompleto.Models
{
	public class Conexion
	{
			#region "Constructor"
			public Conexion()
				{
				
				}
			#endregion

			#region "Metodos Publicos"

			public MySqlConnection Conectar()
			{
				MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; port=3306;" +
					" database=practica; Uid=root; pwd=;");

				try
				{
					conexion.Open();
					return conexion;
				}
				catch (MySqlException ex)
				{
					Console.WriteLine(ex.Message);
					return null;
				}
			}

			public void CerrarConexion(MySqlConnection conector)
			{
				try
				{
					conector.Close();
				}
				catch (MySqlException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			public int Operaracion(string conSQL, MySqlConnection conector)
			{
					int num = 0;

				try
				{
					MySqlCommand comando = new MySqlCommand(conSQL, conector);
					num = comando.ExecuteNonQuery();
					return num;
				}
				catch (MySqlException ex)
				{
					Console.WriteLine(ex.ToString());
					return num;
				}
				finally
				{
					conector.Close();
				}

			}
			#endregion
	}
}