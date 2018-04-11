﻿using System;
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
			MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; port=3306; database=practica; Uid=root; pwd=;");

			return conexion;
		}

		//Nombre del método que nos conectara a la base de datos
			public bool AbrirConexion()
			{
				try
				{
					MySqlConnection con = Conectar();
					con.Open();
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
					MySqlConnection con = Conectar();
					con.Close();
					return true;
				}
				catch (MySqlException ex)
				{
					return false;
					throw ex;		
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
				catch (MySqlException)
				{
					return num;
				}

			}
		#endregion
	}
}