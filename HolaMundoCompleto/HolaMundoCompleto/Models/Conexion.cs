using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace HolaMundoCompleto.Models
{
	public class Conexion
	{
		public MySqlConnection conexion;

		public Conexion()
		{
			conexion = new MySqlConnection("server=127.0.0.1; port=3306; database=practica; Uid=root; pwd=;");
		}

		//Nombre del método que nos conectara a la base de datos
		public bool AbrirConexion()
		{
			try
			{
				conexion.Open();
				return true;
			}
			catch(MySqlException ex)
			{
				return false;
				throw ex;
			}
		}

		public bool CerrarConexion()
		{
			try
			{
				conexion.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				return false;
				throw ex;		
			}
		}
	}
}