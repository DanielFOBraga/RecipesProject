<%@ Page Title="" Language="C#" MasterPageFile="~/RecipesPortalMaster.Master" AutoEventWireup="true" CodeBehind="LoginUser.aspx.cs" Inherits="WebPage.LoginUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col align-self-start">
            </div>
            <div class="col align-self-center">
                <asp:Login runat="server" DestinationPageUrl="~/index.aspx">
                </asp:Login>
            </div>
            <div class="col align-self-end">
            </div>
        </div>
    </div>
</asp:Content>
