<%@ Page Title="" Language="C#" MasterPageFile="~/MyOwnSite.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="LookAndFeelDemo.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pageContent" runat="server">
     <asp:TextBox ID="txtcustid" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
