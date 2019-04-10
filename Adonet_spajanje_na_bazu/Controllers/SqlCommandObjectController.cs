using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adonet_spajanje_na_bazu.Controllers
{
    public class SqlCommandObjectController : Controller
    {
        // GET: SqlCommandObject
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            string connString = ConfigurationManager.ConnectionStrings["AlgebraDBConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdText = "";
                cmdText += "INSERT INTO [dbo].[tbltecajevi] ( [naziv], [opis]) " + "VALUES ('Web design','Naucite kreirati web stranice')";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                int brojRedaka = cmd.ExecuteNonQuery();
                if (brojRedaka > 0)
                {
                    ViewBag.Message = "Zapis je upisan u bazu!";
                }
                else
                {
                    ViewBag.Message = "Dogodila se greška!";
                }
            }

            return View("Index");
        }
    }
}