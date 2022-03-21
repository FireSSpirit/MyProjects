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
    public partial class Kurs : System.Web.UI.Page
    {
        public static bool s = false;
        SqlConnection con = new SqlConnection(@"Data Source=ANATOLY\SQLEXPRESS;Database=DocumentsDB;
Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            if (DropDownList1.SelectedIndex == 4)
            disp_data();
        }

        public bool Words(String s1)
        {
            if (!int.TryParse(s1, out var a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Digits(String s1)
        {
            if (int.TryParse(s1, out var a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from students";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = Convert.ToInt32(DropDownList1.SelectedValue);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label10.Visible = true;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from students";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            bool s2 = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (TextBox1.Text == dt.Rows[i][0].ToString())
                {
                    s2 = true;
                    break;
                }
            }

            if (s2)
            {               
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "delete from students where ID = " + TextBox1.Text;
                cmd2.ExecuteNonQuery();
                Label10.Text = String.Format("Был удален студент с ID = {0}", TextBox1.Text);
                disp_data();
                TextBox1.Text = "";
            }
            else
                Label10.Text = String.Format("Студента с ID = {0} нет или ID не указано", TextBox1.Text);
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedIndex == 0)
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("ИКБО-01-20");
                DropDownList3.Items.Add("ИКБО-02-20");
                DropDownList3.Items.Add("ИКБО-03-20");
            }

            if (DropDownList2.SelectedIndex == 1)
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("ИКБО-01-19");
                DropDownList3.Items.Add("ИКБО-02-19");
                DropDownList3.Items.Add("ИКБО-03-19");
            }

            if (DropDownList2.SelectedIndex == 2)
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("ИКБО-01-18");
                DropDownList3.Items.Add("ИКБО-02-18");
                DropDownList3.Items.Add("ИКБО-03-18");
            }

            if (DropDownList2.SelectedIndex == 3)
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("ИКБО-01-17");
                DropDownList3.Items.Add("ИКБО-02-17");
                DropDownList3.Items.Add("ИКБО-03-17");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label10.Visible = true;
            if (Words(TextBox2.Text) && Digits(TextBox3.Text) && Digits(TextBox4.Text))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("insert into students values('" + TextBox2.Text + "{0}" + DropDownList3.SelectedValue + "{0}" + DropDownList2.SelectedValue
                    + "{0}" + DropDownList5.SelectedValue + "{0}" + DropDownList4.SelectedValue + "{0}" + CheckBox1.Checked + "{0}" + TextBox3.Text + "{0}" + TextBox4.Text + "')", "','");
                cmd.ExecuteNonQuery();
                Label10.Text = String.Format("Был добавлен студент: {0}", TextBox2.Text);
                disp_data();
                TextBox2.Text = "";
            }
            else
            {
                Label10.Text = String.Format("Введены не корректные данные");
            }
        }
        
        protected void Button3_Click(object sender, EventArgs e)
        {
            Label10.Visible = true;
            s = true;
            MultiView1.ActiveViewIndex = 4;
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from students where ID = " + TextBox1.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            bool s2 = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (TextBox1.Text == dt.Rows[i][0].ToString())
                {
                    s2 = true;
                    break;
                }
            }
            if (s2)
            {
                Label10.Text = String.Format("Выбран для изменения данных студент с ID = {0}", TextBox1.Text);
                TextBox2.Text = GridView1.Rows[0].Cells[1].Text;
                DropDownList2.SelectedValue = GridView1.Rows[0].Cells[3].Text;

                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("ИКБО-01-20");
                DropDownList3.Items.Add("ИКБО-02-20");
                DropDownList3.Items.Add("ИКБО-03-20");
                DropDownList3.Items.Add("ИКБО-01-19");
                DropDownList3.Items.Add("ИКБО-02-19");
                DropDownList3.Items.Add("ИКБО-03-19");
                DropDownList3.Items.Add("ИКБО-01-18");
                DropDownList3.Items.Add("ИКБО-02-18");
                DropDownList3.Items.Add("ИКБО-03-18");
                DropDownList3.Items.Add("ИКБО-01-17");
                DropDownList3.Items.Add("ИКБО-02-17");
                DropDownList3.Items.Add("ИКБО-03-17");


                DropDownList3.SelectedValue = GridView1.Rows[0].Cells[2].Text;
                DropDownList5.SelectedValue = GridView1.Rows[0].Cells[4].Text;
                DropDownList4.SelectedValue = GridView1.Rows[0].Cells[5].Text;
                if (dt.Rows[0][6].Equals(true))
                    CheckBox1.Checked = true;
                else
                    CheckBox1.Checked = false;
                TextBox3.Text = GridView1.Rows[0].Cells[7].Text;
                TextBox4.Text = GridView1.Rows[0].Cells[8].Text;
            }
            else
            {
                Label10.Text = String.Format("Студента с ID = {0} нет или ID не указано", TextBox1.Text);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label10.Visible = true;
            if (s && Words(TextBox2.Text) && Digits(TextBox3.Text) && Digits(TextBox4.Text))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("update students set ФИО='" + TextBox2.Text + "{0} Группа='" + DropDownList3.SelectedValue + "{0} Курс='" + DropDownList2.SelectedValue
                    + "{0} [Вид возмещения затрат]='" + DropDownList5.SelectedValue + "{0} [Форма обучения]='" + DropDownList4.SelectedValue + "{0} [Студентический билет продлен]='" + 
                    CheckBox1.Checked + "{0} [Количество долгов]='" + TextBox3.Text + "{0} [Количество взятых книг из библиотеки]='" + TextBox4.Text + "' where ID = " + Convert.ToInt32(TextBox1.Text), "',");
                cmd.ExecuteNonQuery();
                Label10.Text = String.Format("Были изменены данные о студенте: {0}", TextBox2.Text);
                disp_data();
                TextBox1.Text = "";
                s = false;
            }
            else
                Label10.Text = String.Format("Не корректно изменены данные о студенте");            
        }
    }
}