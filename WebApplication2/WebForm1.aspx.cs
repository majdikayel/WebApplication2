using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\majdi\source\repos\WebApplication2\WebApplication2\App_Data\learning.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            disp_data();

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table1 values('" + Nom.Text +"', '"+ Prenom.Text +"','"+ City.Text +"')";
            cmd.ExecuteNonQuery();

            Nom.Text = "";
            Prenom.Text = "";
            City.Text = "";

            disp_data();
        }

        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from table1 where Prenom ='" + Prenom.Text + "' ";
            cmd.ExecuteNonQuery();

            Prenom.Text = "";
            disp_data();

        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update table1 set Prenom ='" + Prenom.Text + "' ,Nom='" +Nom.Text+"',City='"+City.Text+"' where id=" + Convert.ToInt32(oldid.Text)+"";
            cmd.ExecuteNonQuery();
            Nom.Text = "";
            Prenom.Text = "";
            City.Text = "";

            disp_data();

        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}