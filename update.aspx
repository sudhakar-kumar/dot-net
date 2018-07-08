<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label><u>Update Form</u></label><br />
    <br />
    <table>
    <tr>
    <td>Reg No</td><td>
        <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
     <td>Name</td><td>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
    </tr>

     <tr><td>Dept</td><td>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
    </tr>

    </table>
        <asp:Button ID="Button1" runat="server" Text="Update" onclick="Button1_Click" />

    </div>
    </form>
</body>
</html>
