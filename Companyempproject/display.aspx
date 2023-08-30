<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="display.aspx.cs" Inherits="Companyempproject.dis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>Employee Details</h2>
 <asp:GridView ID="employeeGridView" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="employeeGridView_SelectedIndexChanged" >
     <Columns>         
         <asp:BoundField DataField="em_id" HeaderText="employee_id" />
          <asp:BoundField DataField="fname" HeaderText="name" />
         <asp:BoundField DataField="lname" HeaderText="lname" />
                  <asp:BoundField DataField="department" HeaderText="department" />
                  <asp:BoundField DataField="email" HeaderText="email" />
         <asp:BoundField DataField="phoneno" HeaderText="phoneno" />
                  <asp:BoundField DataField="salary" HeaderText="salary" />


     </Columns>
 </asp:GridView>
   
    </asp:Content>
