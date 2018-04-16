using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundoCompleto.Models
{
	public class Character
	{
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

		public void SetNombre(string nombre)
		{
			this.nombre = nombre;
		}

		public string GetNombre()
		{
			return nombre;
		}

		public void SetAltura(float altura)
		{
			this.altura = altura;
		}

		public float GetAltura()
		{
			return altura;
		}

		public void SetTipo(string tipo)
		{
			this.tipo = tipo;
		} 

		public string GetTipo()
		{
			return tipo;
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