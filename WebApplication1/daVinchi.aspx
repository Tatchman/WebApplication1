<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="daVinchi.aspx.cs" Inherits="WebApplication1.daVinchi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Ore" HeaderText="Ore" SortExpression="Ore" />
            <asp:BoundField DataField="Tritanium" HeaderText="Tritanium" SortExpression="Tritanium" />
            <asp:BoundField DataField="Pyerite" HeaderText="Pyerite" SortExpression="Pyerite" />
            <asp:BoundField DataField="Mexallon" HeaderText="Mexallon" SortExpression="Mexallon" />
            <asp:BoundField DataField="Isogen" HeaderText="Isogen" SortExpression="Isogen" />
            <asp:BoundField DataField="Nocxium" HeaderText="Nocxium" SortExpression="Nocxium" />
            <asp:BoundField DataField="Zydrine" HeaderText="Zydrine" SortExpression="Zydrine" />
            <asp:BoundField DataField="Megacyte" HeaderText="Megacyte" SortExpression="Megacyte" />
            <asp:BoundField DataField="Morphite" HeaderText="Morphite" SortExpression="Morphite" />
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Ore], [Tritanium], [Pyerite], [Mexallon], [Isogen], [Nocxium], [Zydrine], [Megacyte], [Morphite] FROM [Table]"></asp:SqlDataSource>
</asp:Content>
