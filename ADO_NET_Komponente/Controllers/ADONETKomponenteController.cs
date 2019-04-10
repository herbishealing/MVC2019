using ADO_NET_Komponente.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Data;

namespace ADO_NET_Komponente.Controllers
{
    public class ADONETKomponenteController : Controller
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["dbAlgebraConnStr"].ConnectionString;

        public ActionResult List()
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandText = "SELECT * FROM tblPolaznici";

            SqlDataReader dr = null;
            List<PolaznikModel> lstPolaznici = new List<PolaznikModel>();

            try
            {
                conn.Open();
                dr = cm.ExecuteReader();

                if (dr != null)
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            PolaznikModel polaznik = new PolaznikModel();
                            polaznik.IdPolaznik = int.Parse(dr["IdPolaznik"].ToString());
                            polaznik.Ime = dr["Ime"].ToString();
                            polaznik.Prezime = dr["Prezime"].ToString();
                            polaznik.Email = dr["Email"].ToString();
                            polaznik.DatumRodjenja = DateTime.Parse(dr["DatumRodjenja"].ToString());
                            lstPolaznici.Add(polaznik);

                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "greska kod dohvacanja popisa polaznika! opis: " + ex.Message;
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
                cm.Dispose();
            }
            return View(lstPolaznici);

        }
    }
}