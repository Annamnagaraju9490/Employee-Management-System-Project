<%@ Page Title="" Language="C#" MasterPageFile="~/employee.Master" AutoEventWireup="true" CodeBehind="addeployees.aspx.cs" Inherits="EmployeeManagementSystem.addeployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            color: #33CC33;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Add Employee Details</h2>
    First Name:<asp:TextBox ID ="txtfname" runat="server"></asp:TextBox><br />
    Last Name:<asp:TextBox ID ="txtlname" runat="server"></asp:TextBox><br />
    Department:<asp:DropDownList ID="ddldept" runat="server"></asp:DropDownList><br />
    Email:<asp:TextBox ID ="txtemail1" runat="server"></asp:TextBox><br />
    Phone NO:<asp:TextBox ID ="txtphone" runat="server"></asp:TextBox><br />
    Salary:<asp:TextBox ID="txtsal" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnaddemp" runat="server" Text="add employee" />





</asp:Content>
