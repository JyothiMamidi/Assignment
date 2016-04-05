<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registrationpage.aspx.cs" Inherits="Registrationpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="Stylesheet"href="style.css" type="text/css" />
    <style type="text/css">
        .style2 {}
    </style>
</head>
<body>
    <form id="form1" runat="server" >
 <!--   <div style="margin-left: 120px">
    
    </div>-->
        <h1 style="margin-left: 40px">REGISTER HERE</h1>
        <asp:Label ID="Label1" runat="server" Text="FirstName"  CssClass="style1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtfn" runat="server" CssClass="style2"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="LastName" CssClass="style1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtln" runat="server" CssClass="style2"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:Label ID="Label7" runat="server" Text="Gender" CssClass="style1"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
             <asp:RadioButton ID="rbfemale" runat="server" Text="Female"  CssClass="style3" GroupName="g1"  />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rbmale" runat="server" Text="Male" CssClass="style3" GroupName="g1" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="UserName" CssClass="style1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtun" runat="server" CssClass="style2"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Password" CssClass="style1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtpswd" runat="server" TextMode="Password" CssClass="style2"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Confirm Password" CssClass="style1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtcpaswd" runat="server" TextMode="Password" CssClass="style2"></asp:TextBox>
        &nbsp;&nbsp;
            <asp:CompareValidator ID="Comparepassword" runat="server" ControlToCompare="txtpswd" ControlToValidate="txtcpaswd" ForeColor="#990000" ErrorMessage="Password not matched"></asp:CompareValidator>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Email Id" CssClass="style1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtemail" runat="server" TextMode="Email" CssClass="style2" Width="176px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnsubmit" runat="server" Text="SUBMIT" CssClass="style4" OnClick="btnsubmit_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btncancel" runat="server" Text="Cancel" CssClass="style4" OnClick="btncancel_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btndisplay" runat="server" Text="Display" CssClass="style4" OnClick="btndisplay_Click"  />
        </p>
    </form>
</body>
</html>
