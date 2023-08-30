<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="EmployeeManagementSystem.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align ="center">
            <h2>ADMIN LOGIN</h2>
           
            Eusername:<asp:TextBox ID ="txtname" runat="server"></asp:TextBox><br />
            Epassword:<asp:TextBox ID="txtpswd" runat="server"></asp:TextBox><br />           
            <asp:Button ID ="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID ="lnksignup" runat="server">Signup</asp:LinkButton>

        </div>
    </form>
</body>
</html>
