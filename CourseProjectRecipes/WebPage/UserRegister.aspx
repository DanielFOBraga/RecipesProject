<%@ Page Title="" Language="C#" MasterPageFile="~/RecipesPortalMaster.Master" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="WebPage.UserRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col align-self-start"></div>
            <div class="col align-self-center">
                <asp:CreateUserWizard runat="server" ContinueDestinationPageUrl="~/index.aspx">
                    <WizardSteps>
                        <asp:CreateUserWizardStep runat="server" />
                        <asp:CompleteWizardStep runat="server" />
                    </WizardSteps>
                </asp:CreateUserWizard>
            </div>
            <div class="col align-self-end"></div>
        </div>
    </div>
</asp:Content>
