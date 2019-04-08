using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adonet_spajanje_na_bazu.Controllers
{
    public class SqlConnectionObjektController : Controller
    {
        // GET: SqlConnectionObjekt direktno
        public ActionResult Index()
        {
            //prvo kreiramo conn string
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            //nakon toga instanciramo sqlconnection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela");
                }
            }
            catch (SqlException sqex)
            {
                Response.Write("greska spajanja na bazu" + sqex.ToString());
            }
            catch (Exception ex)
            {
                Response.Write("neka greska" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return View();
        }
        //preko web configa
        public ActionResult PrekoWebConfig()
        {
            //prvo kreiramo conn string
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            string connString = ConfigurationManager.ConnectionStrings["dbAlgerbraconnString"].ConnectionString;
            //nakon toga instanciramo sqlconnection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela");
                }
            }
            catch (SqlException sqex)
            {
                Response.Write("greska spajanja na bazu" + sqex.ToString());
            }
            catch (Exception ex)
            {
                Response.Write("neka greska" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return View();
        }

    }
}