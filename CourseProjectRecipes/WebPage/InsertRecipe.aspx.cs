using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class InsertRecipe : System.Web.UI.Page
    {
        DAL.Recipe newRecipe;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) //if it has not yet gone to the server
            {
                newRecipe = new DAL.Recipe();
                Session["newRecipe"] = newRecipe;
                LoadDropdowlist();
            }
        }
        private void LoadDropdowlist()
        {
            Ingredients Listingredients = new Ingredients();
            DropDownListIngredient.DataSource = Listingredients.ListAll();
            DropDownListIngredient.DataTextField = "Name";
            DropDownListIngredient.DataValueField = "ID";
            DropDownListIngredient.DataBind();

            MeasurementUnits measurementUnits = new MeasurementUnits();
            DropDownListMeasurementUnit.DataSource = measurementUnits.ListMeasurementUnits();
            DropDownListMeasurementUnit.DataTextField = "Name";
            DropDownListMeasurementUnit.DataValueField = "ID";
            DropDownListMeasurementUnit.DataBind();

            DifficultieRanges difficultieRanges = new DifficultieRanges();
            DropDownListRecipeDifficulty.DataSource = difficultieRanges.ListAllDifficutyRanges();
            DropDownListRecipeDifficulty.DataTextField = "Difficulty";
            DropDownListRecipeDifficulty.DataValueField = "IdDifficulty";
            DropDownListRecipeDifficulty.DataBind();

            TimesToMake timesToMake = new TimesToMake();
            DropDownListTimeToMake.DataSource = timesToMake.ListAllTimesToMake();
            DropDownListTimeToMake.DataTextField = "Time";
            DropDownListTimeToMake.DataValueField = "IdTimeToMake";
            DropDownListTimeToMake.DataBind();

            CostRanges costRanges = new CostRanges();
            DropDownListCostRange.DataSource = costRanges.ListAllCostRanges();
            DropDownListCostRange.DataTextField = "Cost";
            DropDownListCostRange.DataValueField = "IDcost";
            DropDownListCostRange.DataBind();

            CuisineTypes cuisineTypes = new CuisineTypes();
            DropDownListCuisineType.DataSource = cuisineTypes.ListAllCuisineType();
            DropDownListCuisineType.DataTextField = "CuisineTypeName";
            DropDownListCuisineType.DataValueField = "IdCuisine";
            DropDownListCuisineType.DataBind();

            DishCategories dishCategories = new DishCategories();
            CheckBoxListCategory.DataSource = dishCategories.ListAllDishCategories();
            CheckBoxListCategory.DataTextField = "DishCategoryName";
            CheckBoxListCategory.DataValueField = "DishCategoryID";
            CheckBoxListCategory.DataBind();
        }

        protected void ButtonAddIngredientToRecipe_Click(object sender, EventArgs e)
        {
            BulletedListIngredients.Items.Add(new ListItem(TextBoxIngredientQuantity.Text + " " + DropDownListMeasurementUnit.SelectedItem.Text + " of " + DropDownListIngredient.SelectedItem.Text));

            Ingredient newIngredient = new Ingredient(int.Parse(DropDownListIngredient.SelectedValue), DropDownListIngredient.SelectedItem.Text);
            MeasurementUnit newMeasurementUnit = new MeasurementUnit(int.Parse(DropDownListMeasurementUnit.SelectedValue), DropDownListMeasurementUnit.SelectedItem.Text);
            IngredientRecipe newingredientRecipe = new IngredientRecipe(decimal.Parse(TextBoxIngredientQuantity.Text), newIngredient, newMeasurementUnit);

            DAL.Recipe recipe = (DAL.Recipe)Session["newRecipe"];

            recipe.AddIngredientRecipe(newingredientRecipe);

            Session["newRecipe"] = recipe;
        }

        protected void ButtonSubmitRecipe_Click(object sender, EventArgs e)
        {
            DAL.Recipe recipe = (DAL.Recipe)Session["newRecipe"];
            recipe.NameRecipe = TextBoxRecipeName.Text;
            recipe.User = Membership.GetUser();
            recipe.Valid = false;
            recipe.UserRating = 0;
            int x;
            int.TryParse(TextBoxNrofDoses.Text, out x);
            recipe.NrDoses = x;
            recipe.CreationDate = DateTime.Today;
            recipe.TimeToMake = new TimeToMake(int.Parse(DropDownListTimeToMake.SelectedValue), DropDownListTimeToMake.SelectedItem.Text);
            recipe.Cost = new CostRange(int.Parse(DropDownListCostRange.SelectedValue), DropDownListCostRange.SelectedItem.Text);
            recipe.CuisineType = new CuisineType(int.Parse(DropDownListCuisineType.SelectedValue), DropDownListCuisineType.SelectedItem.Text);
            recipe.Dificulty = new DifficultyRange(int.Parse(DropDownListRecipeDifficulty.SelectedValue), DropDownListRecipeDifficulty.SelectedItem.Text); //DropDownListRecipeDifficulty.SelectedValue gives the selected IdDifficulty and then a constructor is used to create new Dificulty object
            
            foreach (ListItem item in CheckBoxListCategory.Items)
            {
                if (item.Selected)
                {
                    recipe.AddDishCategory(new DishCategory(int.Parse(item.Value), item.Text));
                }
            }

            recipe.Insert();
            Session["newRecipe"] = null;
        }

        protected void ButtonAddRecipeStep_Click(object sender, EventArgs e)
        {
            if (Session["newRecipe"] != null)
            {
                DAL.Recipe recipe = (DAL.Recipe)Session["newRecipe"];

                int stepNumber = recipe.Recipesteps.Count + 1;

                BulletedListSteps.Items.Add(new ListItem("Step nr. " + stepNumber.ToString() + ": " + TextBoxRecipeStep.Text));

                RecipeStep newRecipeStep = new RecipeStep(stepNumber, TextBoxRecipeStep.Text);

                recipe.AddStep(newRecipeStep);

                Session["newRecipe"] = recipe;
            }


        }
    }
}