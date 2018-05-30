<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="containerBox" style="display:inline;">
        <br />
        <div id="leftDiv" style="float:left">
            <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d10054.52159106645!2d-2.637528!3d50.949048!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xe18d316b641b265b!2sYeovil+College!5e0!3m2!1sen!2suk!4v1527696561162" width="400" height="400" frameborder="0" style="border:0" allowfullscreen></iframe>
            <br /><small><a href="https://goo.gl/maps/j6dcdR7AsYK2" style="color:0000FF;text-align:left">View Larger Map</a></small>
        </div>
        <div id="rightDiv" style="float:right">
            <!-- comment = start of form div -->
            <div id="wform">
                <ul>
                    <li>Name:<div style="margin-left:20px;"class="input"><asp:TextBox ID="txtName" runat="server"></asp:TextBox></div></li>
                    <li>Email:<div style="margin-left:20px;"class="input"><asp:TextBox ID="txtMail" runat="server"></asp:TextBox></div></li>
                    <li>Message:<div style="margin-left:20px;"class="input"><asp:TextBox ID="txtMessage" TextMode="MultiLine" runat="server"></asp:TextBox></div></li>
                    <li><asp:Button ID="btnReset" runat="server" Text="RESET" style="height:20px;width:80px" OnClick="btnReset_Click" />
                        <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" style="margin-left:190px; height:20px; width:80px" OnClick="btnSubmit_Click" />
                    </li>
                    <li><asp:Label ID="lblError" runat="server"></asp:Label></li>
                </ul>
            </div>
            <%-- end of form div --%>
        </div>
    </div>
</asp:Content>