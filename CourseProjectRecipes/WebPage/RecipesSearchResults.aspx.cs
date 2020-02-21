using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class RecipesSearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nameRecipe = Request.QueryString["nameRecipe"];
            List<RecipeSearch> recipeSearches = RecipeSearchs.ListSearchResults(nameRecipe);
            Session["recipeSearches"] = recipeSearches;

            BulletedListSearchResults.DataSource = recipeSearches;
            BulletedListSearchResults.DataTextField = "RecipeTitle";
            BulletedListSearchResults.DataValueField = "IdRecipe";
            BulletedListSearchResults.DataBind();
        }

        protected void BulletedListSearchResults_Click(object sender, BulletedListEventArgs e)
        {
            List<RecipeSearch> recipeSearches = (List<RecipeSearch>)Session["recipeSearches"];
            RecipeSearch selectedRecipe = recipeSearches[e.Index];

            Response.Redirect(@"~\RecipeView.aspx?selectedRecipeId=" + selectedRecipe.IdRecipe.ToString());
        }
    }
}