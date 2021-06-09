<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ContosoUniversityModelBinding.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

        <asp:Label runat="server" Text="Label">some text here</asp:Label>
        <br />
        <asp:BulletedList runat="server">
            <asp:ListItem>One</asp:ListItem>
            <asp:ListItem Selected="True">Two</asp:ListItem>
            <asp:ListItem>Three</asp:ListItem>
        </asp:BulletedList>
        Your application description page.
    <asp:Button runat="server" Text="Button" ID="SubmitButton" OnClick="SubmitButton_Click"></asp:Button>
    <br />
        <asp:ListBox runat="server" ID="mylistbox">
            <asp:ListItem>One</asp:ListItem>
            <asp:ListItem Selected="True">Two</asp:ListItem>
            <asp:ListItem>Three</asp:ListItem>
        </asp:ListBox>
    




    <p>Use this area to provide additional information.</p>
</asp:Content>
