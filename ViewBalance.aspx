<%@ Page Title="" Language="C#" MasterPageFile="~/MyOwnSite.Master" AutoEventWireup="true"
    CodeBehind="ViewBalance.aspx.cs" Inherits="LookAndFeelDemo.ViewBalance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pageContent" runat="server">
     Hi,
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
     <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="YourBalance" />
    Balance : Rs: <asp:Label ID="lblAvailableBalance" runat="server" Text="Label"></asp:Label>
</asp:Content>
