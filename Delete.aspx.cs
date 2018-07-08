using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;     //ConfigurationManager - web.config
using System.Data.SqlClient;    //SQL


public partial class Delete : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    string del_id;

    protected void Page_Load(object sender, EventArgs e)
    {
        del_id = Request.QueryString["xyz"];
        delete_it();
    }

    public void delete_it()
    {
        con.Open();
        string command = "DELETE tbl_one WHERE regno=" + del_id;
        SqlCommand cmd = new SqlCommand(command, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Mainpage.aspx");


    }
}
