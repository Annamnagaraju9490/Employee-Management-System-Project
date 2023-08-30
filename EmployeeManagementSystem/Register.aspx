<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="EmployeeManagementSystem.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h2>ENTER ADMIN DETAILS</h2>
            Eusername:<asp:TextBox ID ="txtename" runat="server"></asp:TextBox><br />
            Epassword:<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox><br />
            Ephoneno:<asp:TextBox ID="txtphno" runat="server"></asp:TextBox><br />
            Email:<asp:TextBox ID="txtemail" runat="server"></asp:TextBox><br />
            <asp:Button ID ="btnreg" runat="serverserver" Text="Register" OnClick="btnreg_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID ="lnkgotologin" runat="" >Go to Login</asp:LinkButton>

        </div>
    </form>
</body>
</html>
