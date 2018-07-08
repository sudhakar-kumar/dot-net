<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mainpage.aspx.cs" Inherits="Mainpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <div align="center">
    
    <table>

        <tr><td>Regno</td><td>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
        <tr><td>Name</td><td>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
        <tr><td>Dept</td><td>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
        
   </table>

        <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click"/>
        <asp:Label ID="Label4" runat="server"></asp:Label>    
       
    </div>


    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="514px" Height="243px" CellPadding="4" 
            Font-Names="Calibri" Font-Size="Medium" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
        <asp:TemplateField HeaderText="Reg No">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%#Eval("regno") %>' ></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Name">
        <ItemTemplate>
            <asp:Label ID="Label2" runat="server" Text='<%#Eval("name") %>' ></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Department">
        <ItemTemplate>
            <asp:Label ID="Label3" runat="server" Text='<%#Eval("dept") %>' ></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>

      <asp:HyperLinkField  DataNavigateUrlFields="regno" DataNavigateUrlFormatString="Delete.aspx?xyz={0}" Text="Delete" />
       <asp:HyperLinkField DataNavigateUrlFields="regno" DataNavigateUrlFormatString="update.aspx?abc={0}" Text="Edit" />
       </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
     </asp:GridView>
    
        </div>
    
        </form>

    </body>
</html>
