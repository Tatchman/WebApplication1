<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication1.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="rightDiv" style="float:right">
        <div id="wform">
            <ul>
                <li>Username:<div style="margin-left:20px;" class="input"><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></div></li>
                <li>Password:<div style="margin-left:20px;" class="input"><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></div></li>
                <li><asp:Button ID="btnLogin" runat="server" Text="Login" style="height:20px; width:80px" OnClick="btnLogin_Click" /></li>
            </ul>
        </div>
    </div>
</asp:Content>
