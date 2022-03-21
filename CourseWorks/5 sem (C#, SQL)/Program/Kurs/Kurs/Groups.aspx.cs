using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Kurs
{

    public partial class Groups : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=ANATOLY\SQLEXPRESS;Database=DocumentsDB;
Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            string id = Request.QueryString["id"]; //GET-запрос
            string kurs = Request.QueryString["kurs"]; //GET-запрос

            if (!(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(kurs)))
            {
                        disp_data(id, kurs);
            }
               
        }

        public void disp_data(string id, string kurs)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;            
            cmd.CommandText = "select * from students";

            if (id == "1" || id == "2" || id == "3" || id == "4")
            {

                cmd.CommandText += String.Format(" where Курс like '%{0}'", kurs);
                if (id != "4")
                    cmd.CommandText += String.Format(" and Группа like 'ИКБО-0{0}%'", id);
            }

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}