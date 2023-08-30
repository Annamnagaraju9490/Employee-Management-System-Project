<%@ Page Title="" Language="C#" MasterPageFile="~/employee.Master" AutoEventWireup="true" CodeBehind="updateemployee.aspx.cs" Inherits="EmployeeManagementSystem.updateemployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>UPDATE EMPLOYEE DETAILS</h2>
    Employee Id:<asp:TextBox ID ="txtid" runat="server"></asp:TextBox>
    <asp:Button ID="btnsearch" runat="server" Text="search" /><br />
     First Name:<asp:TextBox ID ="txtfname" runat="server"></asp:TextBox><br />
    Last Name:<asp:TextBox ID ="txtlname" runat="server"></asp:TextBox><br />
    Department:<asp:DropDownList ID="ddldept" runat="server"></asp:DropDownList><br />
    Email:<asp:TextBox ID ="txtemail1" runat="server"></asp:TextBox><br />
    Phone NO:<asp:TextBox ID ="txtphone" runat="server"></asp:TextBox><br />
    Salary:<asp:TextBox ID="txtsal" runat="server"></asp:TextBox><br />
    <asp:Button ID ="btnupdate" runat="server" Text="update" />
</asp:Content>
