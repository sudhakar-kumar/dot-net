using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;    //SQL
using System.Configuration;     //ConfigurationManager - web.config

public partial class update : System.Web.UI.Page
{
    string id;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        id=Request.QueryString["abc"];
        
        if(!IsPostBack)
        {
            update1();
        }
    }

    public void update1()
    {
        string command = "SELECT * FROM tbl_one WHERE regno = " +id;
        con.Open();
        SqlCommand cmd = new SqlCommand(command, con);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            TextBox1.Text = dr["regno"].ToString();     //['regno']  -> 0
            TextBox2.Text = dr["name"].ToString();      //['name']   -> 1
            TextBox3.Text = dr["dept"].ToString();      //['dept']   -> 2
        }
        
        con.Close();
     }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        string command = "UPDATE tbl_one SET regno='" + TextBox1.Text + "',name='" + TextBox2.Text + "',dept='" + TextBox3.Text + "' WHERE regno='" + TextBox1.Text + "'";
        SqlDataAdapter da = new SqlDataAdapter(command, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        Response.Redirect("Mainpage.aspx");
    }
}
