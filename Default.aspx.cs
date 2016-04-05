using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection cn = null;
    SqlCommand cmd = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Helper"].ConnectionString);
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from UserDetails", cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "p");
        GridView1.DataSource = ds.Tables["p"];
        GridView1.DataBind();
        cn.Close();

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //TextBox firstname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtfirstname");
     //   string str = firstname.Text;
       // string firstn = GridView1.DataKeys[e.RowIndex].Values["FIRSTNAME"].ToString();

        //string fn1 = ((Label)GridView1.Rows[e.RowIndex].FindControl("Label1")).Text;
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        TextBox TT = (TextBox)row.Cells[0].FindControl("txtfirstname");
        string fn = TT.Text;

   

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindUserdata();
    }
    private void BindUserdata()
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Helper"].ConnectionString);
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from UserDetails", cn);
        DataSet ds = new DataSet();
        da.Fill(ds, "p");
        GridView1.DataSource = ds.Tables["p"];
        GridView1.DataBind();
        cn.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string fn = GridView1.SelectedRow.Cells[1].Text;
    }
}