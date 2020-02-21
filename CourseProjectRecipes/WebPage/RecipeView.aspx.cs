using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class Recipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string recipeId = Request.QueryString["selectedRecipeId"];
            DAL.Recipe recipeToShow = new DAL.Recipe(int.Parse(recipeId));

            LabelRecipeText.Text = recipeToShow.NameRecipe;
            LabelRecipeText2.Text = recipeToShow.NameRecipe;
        }
    }
}