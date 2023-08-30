<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Addemp.aspx.cs" Inherits="Companyempproject.Addemp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Add Employee Details</h2>
    <table>
   <tr><td> First Name:</td>
       <td colspan="3"><asp:TextBox ID ="txtfname" runat="server"></asp:TextBox></td></tr>
    <tr><td>Last Name:</td>
        <td colspan="3"><asp:TextBox ID ="txtlname" runat="server"></asp:TextBox></td></tr>
    <tr><td>Department:</td>
        <td colspan="3"><asp:DropDownList ID="ddldept" runat="server"></asp:DropDownList></td></tr>
      <tr><td>Email:</td>
          <td colspan="3"><asp:TextBox ID ="txtemail1" runat="server"></asp:TextBox></td></tr>
   <tr><td> Phone NO:</td>
      <td colspan="3"> <asp:TextBox ID ="txtphone" runat="server"></asp:TextBox></td></tr>
     <tr><td>Salary:</td>
        <td colspan="3"><asp:TextBox ID="txtsal" runat="server"></asp:TextBox></td></tr>
     <tr><td colspan="3" align="center"><asp:Button ID="btnaddemp" runat="server" Text="add employee" OnClick="btnaddemp_Click" /></td></tr>

    </table>
    
        
        
    

</asp:Content>
