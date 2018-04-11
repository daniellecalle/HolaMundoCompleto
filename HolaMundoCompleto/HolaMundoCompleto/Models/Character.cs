using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundoCompleto.Models
{
	public class Character
	{
		private int id;
		private string nombre;
		private float altura;
		private string tipo;

		public Character()
		{

		}

		public Character(string nombre, float altura, string tipo)
		{
			this.nombre = nombre;
			this.altura = altura;
			this.tipo = tipo;
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public float Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		public bool ValidarCampos()
		{
			if (!String.IsNullOrEmpty(nombre) || !String.IsNullOrEmpty(Convert.ToString(altura).ToString())
					|| !String.IsNullOrEmpty(tipo))
			{
				return true;
			}
			else
			{
				return false;
			}
		}


	}
}