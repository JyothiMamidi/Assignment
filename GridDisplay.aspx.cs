using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class GridDisplay : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

      if(!Page.IsPostBack)
       {
           bo = new Businesssobject();
           bo.grdview = GridView1;
           DataAccessLayer dl = new DataAccessLayer();
         dl.BindUserdata(bo);
       }
    }
    Businesssobject bo = null;
    BusinessLayer bl = null;
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        bo = new Businesssobject();
        bl = new BusinessLayer();
        bo.grdview = GridView1;
        bo.editargs = e;
       // Session["object"] = bo;
        bo.grdrow = bo.grdview.Rows[e.NewEditIndex];
        bl.Edit(bo);
        bo.grdview = GridView1;
        bo.grdrow = bo.grdview.Rows[e.NewEditIndex];
        string ln = ((TextBox)bo.grdrow.FindControl("TextBox2")).Text;
        bo.Lastname = ln;
        String fn = ((TextBox)bo.grdrow.FindControl("TextBox1")).Text;
        bo.firstname = fn;
        String gen = ((TextBox)bo.grdrow.FindControl("TextBox3")).Text;
        bo.gender = gen;
        String un = ((TextBox)bo.grdrow.FindControl("TextBox4")).Text;
        bo.username = un;
        String email = ((TextBox)bo.grdrow.FindControl("TextBox5")).Text;
        bo.emailid = email;
        bo.grdview = GridView1;
        bo.issecond = true;
        Session["object"] = bo;
        Session.Timeout = 5;
        Response.Redirect("Registrationpage.aspx");
     
    }
  
  
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        bo = new Businesssobject();
        bl = new BusinessLayer();
        bo.grdview = GridView1;
        bo.delargs = e;
    
       bo.grdrow  = bo.grdview.Rows[e.RowIndex];
       string ln = ((Label)bo.grdrow.FindControl("Label2")).Text;
        bo.Lastname = ln;
          bl.Delete(bo);

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //GridView1.EditIndex = -1;
        //BindUserdata();
    }
}