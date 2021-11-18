<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApi4._Default" %>


  

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Products</h2>
    <table style="width: 177px">
    <thead>
        <tr><th>Name </th><th>Price</th></tr>
    </thead>

    <tbody id="products">
    </tbody>
        <div>
            <asp:GridView ID ="gridview" runat="server"></asp:GridView>
        </div>
    </table>
</asp:Content>

