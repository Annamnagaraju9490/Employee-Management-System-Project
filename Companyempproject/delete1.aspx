<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="delete1.aspx.cs" Inherits="Companyempproject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>DELETE EMPLOYEE DETAILS</h2>
    <table>
        <tr>
            <td>Employee Id:</td>
            <td colspan="3"><asp:TextBox ID ="txtid" runat="server"></asp:TextBox></td>
            <td><asp:Button ID="btnsearch" runat="server" Text="search" OnClick="btnsearch_Click" /></td>
        </tr>
       <tr>
            <td>First Name:</td>
            <td colspan="3"><asp:TextBox ID ="txtfname" runat="server"></asp:TextBox></td>
            <td></td>
       </tr>
       <tr>
            <td>Last Name:</td>
            <td colspan="3"><asp:TextBox ID ="txtlname" runat="server"></asp:TextBox></td>
            <td></td>
      </tr>
      <tr>    
            <td>Department:</td>
            <td colspan="3"><asp:DropDownList ID="ddldept" runat="server"></asp:DropDownList></td>
            <td></td>
      </tr>
      <tr>
            <td>Email:</td>
            <td colspan="3"><asp:TextBox ID ="txtemail1" runat="server"></asp:TextBox></td>
            <td></td>
      </tr>
      <tr>
            <td>Phone NO:</td>
            <td colspan="3"><asp:TextBox ID ="txtphone" runat="server"></asp:TextBox></td>
            <td></td>
      </tr>
      <tr>
            <td>Salary:</td>
            <td colspan="3"><asp:TextBox ID="txtsal" runat="server"></asp:TextBox></td>
            <td></td>
      </tr>
    <tr><td colspan="3" align="center"><asp:Button ID ="btndelete" runat="server" Text="delete" OnClick="btndelete_Click"   /></td></tr>

    </table>
   


</asp:Content>
