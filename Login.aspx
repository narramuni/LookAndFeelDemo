﻿<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LookAndFeelDemo.Login" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="pageContent" runat="server">--%>

<!Doctype html>
<html>
    <head>

    </head>
    <body>
        <form runat="server">
    <asp:Label ID="Label2" runat="server" Text="Enter UserID:"></asp:Label>
<asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
<br />
<asp:Label ID="Label3" runat="server" Text="Enter Password:"></asp:Label>
<asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
<br /></form>
        </body>
        </html>
<%--</asp:Content>--%>