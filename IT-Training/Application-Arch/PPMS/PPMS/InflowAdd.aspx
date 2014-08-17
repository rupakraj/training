<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="InflowAdd.aspx.cs" Inherits="PPMS.InflowAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content_left" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="main_body" runat="server">
    <label>Fuel Type</label>
    <asp:DropDownList ID="ddlFuelTypes" runat="server"> 
    </asp:DropDownList>

    <br />
    <hr />
    <asp:Button ID="btnSave" runat ="server" OnClick="btnSave_Click" />
    <asp:Label ID="lblSelectedValue" runat="server"></asp:Label>
</asp:Content>
