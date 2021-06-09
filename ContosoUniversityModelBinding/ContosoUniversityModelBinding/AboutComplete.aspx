<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AboutComplete.aspx.cs" Inherits="ContosoUniversityModelBinding.AboutComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>sample</h1>
    <asp:ListBox runat="server" ID="mylistbox"
        OnSelectedIndexChanged="mylistbox_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem>Three</asp:ListItem>
        <asp:ListItem Selected="True">Two</asp:ListItem>
        <asp:ListItem>One</asp:ListItem>
    </asp:ListBox>.
    <hr />
    <asp:Button runat="server" Text="Submit selection" ID="MyButton" OnClick="MyButton_Click"></asp:Button>
    
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">selected item:</asp:Label> 
        <asp:Label ID="LabelSelectedValue" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <asp:Label ID="LabelSubmitted" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
