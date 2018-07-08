using System;
using System.Collections;
using System.Configuration; //ConfigurationManager - web.config
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient; //SQL

public partial class Mainpage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    
    protected void Page_Load(object sender, EventArgs e)
    {  
        display_grid();
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
       // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        con.Open();
        string command = "INSERT INTO tbl_one VALUES('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"')";
        SqlCommand cmd = new SqlCommand(command,con);
        cmd.ExecuteReader();

        GridView1.DataSource = dataset_print();
        GridView1.DataBind();
        
        con.Close();
    }


    public DataSet dataset_print()
    {
        string command = "SELECT * FROM tbl_one";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(command,con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }


    protected void display_grid()
    {
        int no_of_rows = 0;
        DataSet dss = new DataSet();
        dss = dataset_print();
        no_of_rows = dss.Tables[0].Rows.Count;

        if (no_of_rows > 0)
        {
            GridView1.DataSource = dataset_print();
            GridView1.DataBind();
        }
        else
        {
            Label4.Text = "Data Not Available!";
        }
     }

  
}
