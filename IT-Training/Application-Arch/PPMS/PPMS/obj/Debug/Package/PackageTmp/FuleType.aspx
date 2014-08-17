﻿<%@ Page Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="FuleType.aspx.cs" Inherits="PPMS.FuleType" %>

<asp:Content ContentPlaceHolderID="head" ID="head_content" runat="server">
    
</asp:Content>

<asp:Content ContentPlaceHolderID="main_body" runat="server" id ="main_body_content">

    <div class="container">

        <%
            string act = "";
            if (!string.IsNullOrEmpty(Request.QueryString["act"])) { 
                act = Request.QueryString["act"];
            }
            else
            {
                act = "list";
            }
             %>
    <% if(act=="list"){  %>
    <div class="row">
        <div class="col-md-6">
            <asp:Label ID="lblTable" runat="server"></asp:Label>
        </div>
        <div class="col-md-6">
            <asp:GridView ID="gvTable" runat="server" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
        </div>

    </div>
    <% } %>
    <% else if (act.Equals("add") || act == "edit"){ %>
        <div class="row">  
            <div class="col-sm-12">
                Give details
                <hr />
                <table>
                    <tr>
                        <td>Fuel Type Name </td>
                        <td>
                            <asp:TextBox ID="txtFuelTypeName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>

                        </td>
                        <td>
                            <asp:Button ID ="btnSave" Text="Save"  runat="server" OnClick="btnSave_Click"/>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    <% } %>



         </div>
    

    
</asp:Content>