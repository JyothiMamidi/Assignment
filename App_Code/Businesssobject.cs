using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for Businesssobject
/// </summary>
public class Businesssobject
{
    public string firstname{get;set;}
    public string Lastname{get;set;}
    public string gender { get; set; }
    public string username { get; set; }
    public string emailid { get; set; }
    public string pswd { get; set; }
    public string cpswd { get; set; }
   public  RadioButton rd { get; set; }
    public GridView grdview { get; set; }
    public GridViewEditEventArgs editargs { get; set; }
    public GridViewDeleteEventArgs delargs { get; set; }
    public GridViewRow grdrow { get; set; }
    public TextBox txt { get; set; }
    public Button btn { get; set; }
    public bool issecond { get; set; }
   
	public Businesssobject()
	{
	
	}
}