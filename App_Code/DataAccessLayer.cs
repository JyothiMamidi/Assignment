using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for DataAccessLayer
/// </summary>`
public class DataAccessLayer
{
    SqlConnection cn = null;
    SqlCommand cmd = null;
    string strsqlcommand = String.Empty;
	public DataAccessLayer()
	{
      
	}
    public string InsertUser(Businesssobject bo)
    {
       cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Helper"].ConnectionString);
        cn.Open();
      SqlCommand  cmd = new SqlCommand("InsertUsers",cn);

        cmd.CommandType = CommandType.StoredProcedure;
        if (cn.State != ConnectionState.Open)
            cn.Open();
        cmd.Parameters.Add("@Firstname", bo.firstname);
        cmd.Parameters.Add("@Lastname", bo.Lastname);
        cmd.Parameters.Add("@Gender", bo.gender);
        cmd.Parameters.Add("@Username", bo.username);
        cmd.Parameters.Add("@Emailid", bo.emailid);
      int result=  cmd.ExecuteNonQuery();
        cn.Close();
        return result.ToString();
        
      
    }
    public void RowEdit(Businesssobject bo)
    {
       
        bo.grdview.EditIndex = bo.editargs.NewEditIndex;
        BindUserdata(bo);
    }

    public string RowUpdate(Businesssobject bo)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Helper"].ConnectionString);
        cn.Open();
        cmd = new SqlCommand("UpdateUser", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("Firstname", bo.firstname);
        cmd.Parameters.Add("Gender", bo.gender);
        cmd.Parameters.Add("Username", bo.username);
        cmd.Parameters.Add("Emailid", bo.emailid);
        cmd.Parameters.Add("Lastname", bo.Lastname);
     int result =  cmd.ExecuteNonQuery();
     
        BindUserdata(bo);
        bo.grdview.EditIndex = -1;
        cn.Close();
        return result.ToString();
        
    }
    public void RowDelete(Businesssobject bo)
    {
          cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Helper"].ConnectionString);
          cn.Open();
          cmd = new SqlCommand("DeleteUser", cn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.Add("Lastname",bo.Lastname);
          cmd.ExecuteNonQuery();
         cn.Close();
         BindUserdata(bo);
    }
    public void BindUserdata( Businesssobject bo)
    {
        cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Helper"].ConnectionString);
        cn.Open();
        SqlCommand cmd = new SqlCommand("SelectUserdetails",cn);
        cmd.CommandType = CommandType.StoredProcedure;
        bo.grdview.DataSource = cmd.ExecuteReader();
        bo.grdview.DataBind();
        cn.Close();
    }
}