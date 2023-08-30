<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="Companyempproject.Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <div align="center">
            <h2>ENTER ADMIN DETAILS</h2>
                <table>
           <tr><td> Eusername:</td>
               <td colspan="2" ><asp:TextBox ID ="txtename" runat="server"></asp:TextBox></td></tr>
            <tr><td>Epassword:</td>
                <td colspan="2"><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td></tr>
           <tr><td> Ephoneno:</td>
                <td colspan="2"><asp:TextBox ID="txtphno" runat="server"></asp:TextBox></td></tr>
            <tr><td>Email:</td>
                <td colspan="2"><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td></tr>
         <tr><td colspan="2" align="center"><asp:Button ID ="btnreg" runat="server" Text="Register" OnClick="btnreg_Click" /></td></tr>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <tr><td colspan="2"><asp:LinkButton ID ="lnkgotologin" runat="server" OnClick="lnkgotologin_Click" >Go to Login</asp:LinkButton></td></tr>

            </table>

        </div>
    </form>
</body>
</html>
