<%@ Page Title="" Language="C#" MasterPageFile="~/RecipesPortalMaster.Master" AutoEventWireup="true" CodeBehind="RecipesSearchResults.aspx.cs" Inherits="WebPage.RecipesSearchResults" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col text-center">
                <h2>Recipes</h2>
            </div>
        </div>
        <div class="row">
            <div class="col text-center">
                <asp:BulletedList id="BulletedListSearchResults" runat="server" DisplayMode="LinkButton" OnClick="BulletedListSearchResults_Click"></asp:BulletedList>
            </div>
        </div>
    </div>
</asp:Content>
