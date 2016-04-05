using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registrationpage : System.Web.UI.Page
{
   
    Businesssobject bo = new Businesssobject();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["object"] != null)
        {
            bo = (Businesssobject)Session["object"];
            getvalues(bo);
        }
    }
    public void getvalues(Businesssobject bo)
    {

        if (bo == null)
            return;
            
            txtfn.Text = bo.firstname;
            txtln.Text = bo.Lastname;
            txtun.Text = bo.username;
            txtemail.Text = bo.emailid;
            txtln.ReadOnly = true;
            txtpswd.ReadOnly = true;
            txtcpaswd.ReadOnly = true;
            if (bo.gender == "Female")
            {
                rbfemale.Checked = true;
                bo.rd = rbfemale;
            }
            else
            {
                rbmale.Checked = true;
                bo.rd = rbmale;
            }
            btnsubmit.Text = "UPDATE";
            Session["grid"] = bo.grdview;
          Session["object"] = null;
         
    }
  
    public string GetGender()
    {
        if (rbfemale.Checked == true)
        {
            bo.rd = rbfemale; ;
            return "Female";
        }
        else if (rbmale.Checked == true)
        {
            bo.rd=rbmale;
            return "Male";
        }
        else
        {
            Response.Write("please seelct your gender");
            return null;
        }
    }
   
    protected void btncancel_Click(object sender, EventArgs e)
    {
        ClearAll();
        btnsubmit.Text = "SUBMIT";
        txtln.ReadOnly = false;
        txtpswd.ReadOnly = false;
        txtcpaswd.ReadOnly = false;
       

    }
   private void ClearAll()
    {
        txtfn.Text = String.Empty;
        txtln.Text = String.Empty;
        rbfemale.Checked = false;
        rbmale.Checked = false;
        txtpswd.Text = String.Empty;
        txtcpaswd.Text = String.Empty;
        txtemail.Text = String.Empty;
        txtun.Text = String.Empty;
    }
    protected void btnsubmit_Click1(object sender, EventArgs e)
    {
        if (btnsubmit.Text.ToString() == "SUBMIT")
        {
            AssignUserDetails();
            BusinessLayer bl = new BusinessLayer();
            {
                try
                {
                    string result = bl.insert(bo);
                    if (result != null)
                    {
                        Response.Write("Record Inserted Successfully");
                        ClearAll();
                }

                    else
                        Response.Write("please try again");
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message + "" + ex.StackTrace);
                }

            }
        }
        if(btnsubmit.Text=="UPDATE")
        {
          
            AssignUserDetails();
           
            BusinessLayer bl = new BusinessLayer();
            {
                try
                {
                    string result= bl.Update(bo);
                  

                     if (result != null)
                     {
                         btnsubmit.Text = "SUBMIT";
                         txtln.ReadOnly = false;
                         txtpswd.ReadOnly = false;
                         txtcpaswd.ReadOnly = false;
                         Session["grid"] = null;
                         Response.Write("Record updated Successfully");
                         ClearAll();
                     }

                     else
                         Response.Write("please try again");


                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message + "" + ex.StackTrace);
                }
            }
        }
        
    }
    protected void btndisplay_Click(object sender, EventArgs e)
    {
        Response.Redirect("GridDisplay.aspx");
    }
    private void AssignUserDetails()
    {
        bo.firstname = txtfn.Text;
        bo.Lastname = txtln.Text;
        bo.gender = GetGender();
        bo.username = txtun.Text;
        bo.emailid = txtemail.Text;
        bo.pswd = txtpswd.Text;
        bo.cpswd = txtcpaswd.Text;
        bo.grdview = (GridView)Session["grid"];
     
            
    }
}