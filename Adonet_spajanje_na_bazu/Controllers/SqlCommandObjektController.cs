using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adonet_spajanje_na_bazu.Controllers
{
    public class SqlCommandObjektController : Controller
    {
        // GET: SqlCommandObjekt
        public ActionResult Index()
        {
            return View("Create");
        }
        public ActionResult Create()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdText = "";
                cmdText += "INSERT INTO [dbo].[tbltecajevi] ([naziv], [opis]) " +
                    "VALUES ('Web desing', 'naucite kreirati web stranice')";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                int brojRedaka = cmd.ExecuteNonQuery();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "zapis je u bazi!";
                }
                else
                {
                    ViewBag.Message = "zapis nije u bazi!";
                }
            }
            return View();
        }
    }
}