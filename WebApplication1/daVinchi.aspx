<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="daVinchi.aspx.cs" Inherits="WebApplication1.daVinchi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">      <%--Defines the location of the data for the table and the setup params --%>
        <Columns>                                                                                               <%--Opens the column definition section --%>
            <asp:BoundField DataField="Ore" HeaderText="Ore" SortExpression="Ore" />                            <%--Defines the column for "Ore" --%>
            <asp:BoundField DataField="Tritanium" HeaderText="Tritanium" SortExpression="Tritanium" />          <%--Defines the column for "Tritanium" --%>
            <asp:BoundField DataField="Pyerite" HeaderText="Pyerite" SortExpression="Pyerite" />                <%--Defines the column for "Pyreite" --%>
            <asp:BoundField DataField="Mexallon" HeaderText="Mexallon" SortExpression="Mexallon" />             <%--Defines the column for "Mexallon" --%>
            <asp:BoundField DataField="Isogen" HeaderText="Isogen" SortExpression="Isogen" />                   <%--Defines the column for "Isogen" --%>
            <asp:BoundField DataField="Nocxium" HeaderText="Nocxium" SortExpression="Nocxium" />                <%--Defines the column for "Nocxium" --%>
            <asp:BoundField DataField="Zydrine" HeaderText="Zydrine" SortExpression="Zydrine" />                <%--Defines the column for "Zydrine" --%>
            <asp:BoundField DataField="Megacyte" HeaderText="Megacyte" SortExpression="Megacyte" />             <%--Defines the column for "Megacyte" --%>
            <asp:BoundField DataField="Morphite" HeaderText="Morphite" SortExpression="Morphite" />             <%--Defines the column for "Morphite" --%>
        </Columns>                                                                                              <%--Closes the column definition section--%>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Ore], [Tritanium], [Pyerite], [Mexallon], [Isogen], [Nocxium], [Zydrine], [Megacyte], [Morphite] FROM [Table]"></asp:SqlDataSource>
                                               <!--Defines the datasource and the connectionstring for it.                       The Select Command part defines the sql query for the data headings that will be taken from the selected table. -->
</asp:Content>
