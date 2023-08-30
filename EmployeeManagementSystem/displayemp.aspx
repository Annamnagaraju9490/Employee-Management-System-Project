<%@ Page Title="" Language="C#" MasterPageFile="~/employee.Master" AutoEventWireup="true" CodeBehind="displayemp.aspx.cs" Inherits="EmployeeManagementSystem.displayemp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Employee Details</h2>
    <asp:GridView ID="grddis" runat="server"></asp:GridView>
</asp:Content>
