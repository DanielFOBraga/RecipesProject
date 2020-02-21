<%@ Page Title="" Language="C#" MasterPageFile="~/RecipesPortalMaster.Master" AutoEventWireup="true" CodeBehind="InsertRecipe.aspx.cs" Inherits="WebPage.InsertRecipe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col text-center">
                <br />
                <h2>Insert Recipe</h2>
                <br />
                <br />
            </div>
        </div>
        <div class="container-fluid">
            <div class="row justify-content-between">
                <div class="col-8">
                    <div class="row my-3">
                        <div class="col-md-3 offset-2">
                            <asp:Label Text="Recipe title" runat="server" />
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="TextBoxRecipeName" runat="server" Width="200px"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-md-3 offset-2">
                            <asp:Label Text="Number of doses" runat="server" />
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="TextBoxNrofDoses" runat="server" TextMode="Number" min="1" Width="50px"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-md-3 offset-2">
                            <asp:Label runat="server" Text="Recipe difficulty"></asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="DropDownListRecipeDifficulty" Width="200px" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-md-3 offset-2">
                            <asp:Label runat="server" Text="Recipe preparation time"></asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="DropDownListTimeToMake" Width="200px" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-md-3 offset-2">
                            <asp:Label runat="server" Text="Recipe Cost"></asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="DropDownListCostRange" Width="200px" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-md-3 offset-2">
                            <asp:Label runat="server" Text="Cuisine type"></asp:Label>
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="DropDownListCuisineType" Width="200px" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <div class="row my-3">
                        <asp:Label runat="server" Text="Recipe categories"></asp:Label>
                    </div>
                    <div class="row my-3">
                        <asp:CheckBoxList ID="CheckBoxListCategory" RepeatColumns="2" runat="server" CssClass="checkboxlist" RepeatLayout="table"></asp:CheckBoxList>
                    </div>
                </div>

            </div>

            <%--<div class="row my-2 offset-3">
                <asp:Label runat="server" Text="Recipe categories"></asp:Label>
            </div>
            <div class="row my-2 offset-3">
                
            </div>--%>
        </div>

        <div class="row">
            <div class="col text-md-left">
                <br />
                <asp:Label Text="Add Ingredient" runat="server" />
            </div>
        </div>
        <div class="container">
            <div class="row align-items-center justify-content-center">
                <div class="col-1 mx-auto text-left">
                    <asp:Label Text="Qt." runat="server"></asp:Label>
                </div>
                <div class="col-2 mx-auto text-left">
                    <asp:TextBox ID="TextBoxIngredientQuantity" runat="server" Width="100px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\d+\.{0,1}\d*"
                        ToolTip="Please enter valid decimal number with any decimal places." ControlToValidate="TextBoxIngredientQuantity" Text="*"> 
                    </asp:RegularExpressionValidator>
                </div>
                <div class="col-3 mx-auto text-left">
                    <asp:DropDownList ID="DropDownListMeasurementUnit" runat="server" Width="150px"></asp:DropDownList>
                </div>
                <div class="col-3 mx-auto text-left">
                    <asp:DropDownList ID="DropDownListIngredient" runat="server" Width="150px"></asp:DropDownList>
                </div>
                <div class="col-3 mx-auto text-left">
                    <asp:Button ID="ButtonAddIngredientToRecipe" class="btn" runat="server" Text="Add" OnClick="ButtonAddIngredientToRecipe_Click" />
                </div>
            </div>
            <%--<div class="row align-items-start">
                <div class="col-5 align-self-start text-left">
                    <asp:RegularExpressionValidator ID="Regex2" runat="server" ValidationExpression="\d+\.{0,1}\d*" ToolTip="Required"
                        ErrorMessage="Please enter valid decimal number with any decimal places." ControlToValidate="TextBoxIngredientQuantity" />
                </div>
            </div>--%>
        </div>
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-6 text-left">
                    <asp:BulletedList ID="BulletedListIngredients" runat="server"></asp:BulletedList>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col text-md-left">
                <br />
                <asp:Label Text="Add Step" CssClass="asp-textbox" runat="server" />
            </div>
        </div>
        <div class="container-fluid">
            <div class="row align-items-center">
                <div class="col-md-9">
                    <asp:TextBox ID="TextBoxRecipeStep" runat="server" CssClass="asp-textbox" TextMode="MultiLine" Width="500px" Height="150px"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Button ID="ButtonAddRecipeStep" class="btn" runat="server" Text="Add Step" OnClick="ButtonAddRecipeStep_Click" />
                </div>
            </div>
        </div>
        <div class="container-fluid">
            <div class="row justify-content-center">
                <div class="col-md-6 text-left">
                    <asp:BulletedList ID="BulletedListSteps" Style="list-style-type: none;" runat="server"></asp:BulletedList>
                </div>
            </div>
        </div>
        <div class="container-fluid">
            <div class="row justify-content-center">
                <div class="col-4 my-4">
                    <asp:Button ID="ButtonSubmitRecipe" class="btn" runat="server" Text="Create Recipe" OnClick="ButtonSubmitRecipe_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
