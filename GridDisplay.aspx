<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridDisplay.aspx.cs" Inherits="GridDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
          <link rel="Stylesheet"href="style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" BackColor="#99FF99" Width="247px" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"  AutoGenerateColumns="false" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:TemplateField HeaderText="FIRSTNAME">
                    <EditItemTemplate>
                        <asp:TextBox  ID="TextBox1"  runat="server"  Text='<%# Eval("Firstname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Firstname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="LASTNAME">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server"  ReadOnly="true"  Text='<%# Eval("Lastname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Lastname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="GENDER">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("Gender") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="USERNAME">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("Username") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Username") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EMAILID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("Emailid") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Emailid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField HeaderText="Operation" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
            <HeaderStyle BackColor="#FF9933" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Names="Verdana" Font-Size="Small" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
