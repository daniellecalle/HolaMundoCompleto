using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HolaMundoCompleto.Models;
using MySql.Data.MySqlClient;

namespace HolaMundoCompleto.Controllers
{
	public class CharacterController : Controller
    {
		Conexion con = new Conexion();
		MySqlConnection a;
		Character objCh;

        // GET: Character
        public ActionResult Index()
        {
			return View("FormCharacter");
		}

		[HttpPost]
		public ActionResult CreateCharacter()
		{
			//Capturamos la informaicon de Character
			string nombre = Request["txtName"];
			float altura = float.Parse(Request["txtHeigth"], CultureInfo.InvariantCulture.NumberFormat);
			string tipo = Request["opcion1"];
			objCh = new Character(nombre,altura,tipo);

			if (!objCh.ValidarCampos())
			{
				return View("ErrorMessage1");
			}
			else
			{
				a = con.Conectar();
				string sql = "insert into personaje (nombre, altura, tipo) values ('" + objCh.GetNombre()
					+ "', '" + objCh.GetAltura() + "', '" + objCh.GetTipo() + "')";		
				int n = con.Operaracion(sql, a);

				if (n != 0)
				{					
					return View("SuccessMessage");
				}
				else
				{
					return View("DangerMessage");
				}
			}

		}

		



	}
}
 