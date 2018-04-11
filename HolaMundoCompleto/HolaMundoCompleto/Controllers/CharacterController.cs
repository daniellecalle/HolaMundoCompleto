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
			try
			{
				if (!con.AbrirConexion())
				{
					return View("ErrorMessage");
				}
				else
				{
				    return View("FormCharacter");
				}
			}
			catch(Exception)
			{
				con.CerrarConexion();
				return View("ErrorMessage");
			}
        }

		[HttpPost]
		[ActionName("CreateCharacter")]
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
				try
				{
					a = con.Conectar();
				}
				catch (Exception)
				{
					return View("ErrorMessage");
				}

				string sql = "insert into character values ('"+objCh.Nombre +"', '"+objCh.Altura 
					+"', '"+objCh.Tipo+"')";

				if (con.Operaracion(sql, a) == 0)
				{
					return View("DangerMessage");
				}
				else
				{
					return View("SuccessMessage");
				}
			}

		}



	}
}