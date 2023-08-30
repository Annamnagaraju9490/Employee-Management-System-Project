<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lgin.aspx.cs" Inherits="Companyempproject.lgin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h2>ADMIN LOGIN</h2>
            <table>
           <tr><td> Eusername:</td>
               <td colspan="4"><asp:TextBox ID ="txtname" runat="server"></asp:TextBox></td></tr>
           <tr><td> Epassword:</td>
               <td colspan="4"><asp:TextBox ID="txtpswd" runat="server"></asp:TextBox></td></tr>          
            <tr><td colspan="4" align="center"><asp:Button ID ="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"/></td></tr>
            <tr><td colspan="4" align="center"><asp:LinkButton ID="lnksignup" runat="server" OnClick="lnksignup_Click">Sign Up</asp:LinkButton></td></tr>
            </table>
        </div>
    </form>
</body>
</html>
