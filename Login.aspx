<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PicnicRUS.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" >
        <div>
            <strong>UserName:
            <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="Txtpassword" runat="server" BorderStyle="None" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Btnlogin" runat="server" OnClick="Btnlogin_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblerrorMsg" runat="server" Text="Error Message" Visible="False"></asp:Label>
            </strong>
        </div>
    </form>
</asp:Content>
