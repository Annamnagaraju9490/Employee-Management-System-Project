<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="disolay.aspx.cs" Inherits="duplicate.disolay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView  ID="gridvw" runat="server" AutoGenerateColumns="false"></asp:GridView>
           
               <asp:BoundField DataField="fname" HeaderText="name" />
         <asp:BoundField DataField="lname" HeaderText="lname" />
                  <asp:BoundField DataField="department" HeaderText="department" />
                  <asp:BoundField DataField="email" HeaderText="email" />
         <asp:BoundField DataField="phoneno" HeaderText="phoneno" />
                  <asp:BoundField DataField="salary" HeaderText="salary" />
          
        </div>
    </form>
</body>
</html>
