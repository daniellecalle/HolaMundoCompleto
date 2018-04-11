using System;
using System.Collections.Generic;
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
    }
}