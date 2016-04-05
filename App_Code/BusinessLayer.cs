using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for BusinessLayer
/// </summary>
public class BusinessLayer
{
    DataAccessLayer da = null;
    public string insert(Businesssobject bo)
    {
        da = new DataAccessLayer();
        try
        {
           return  da.InsertUser(bo);
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            da = null;
        }
    }
    public void Edit(Businesssobject bo)
    {
        da = new DataAccessLayer();
        da.RowEdit(bo);
    }

    public string Update(Businesssobject bo)
    {
        da = new DataAccessLayer();
   return   da.RowUpdate(bo);
    }
    public void Delete(Businesssobject bo)
    {
        da = new DataAccessLayer();
        da.RowDelete(bo);
    }
	public BusinessLayer()
	{

	}
}