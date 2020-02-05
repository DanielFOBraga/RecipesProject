using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace DAL
{
    public class Recipe
    {
        #region Attributes 
        private int _idRecipe;
        private string _nameRecipe;
        private int _nrDoses;
        private bool _valid;
        private MembershipUser _user;
        private DateTime _creationDate;
        private CuisineType _cuisineType;
        private List<DishCategory> _dishCategories;
        private DifficultyRange _dificulty;
        private CostRange _cost;
        private TimeToMake _timeToMake;
        private decimal _UserRating;
        private List<IngredientRecipe> _ingredientRecipe;
        private List<RecipeStep> _recipesteps;

        #endregion
        #region Properties
        public int IdRecipe
        {
            get { return _idRecipe; }
            set { _idRecipe = value; }
        }
        public string NameRecipe
        {
            get { return _nameRecipe; }
            set { _nameRecipe = value; }
        }
        public int NrDoses
        {
            get { return _nrDoses; }
            set { _nrDoses = value; }
        }
        public bool Valid
        {
            get { return _valid; }
            set { _valid = value; }
        }
        public MembershipUser User
        {
            get { return _user; }
            set { _user = value; }
        }
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public CuisineType CuisineType
        {
            get { return _cuisineType; }
            set { _cuisineType = value; }
        }
        public List<DishCategory> DishCategories
        {
            get { return _dishCategories; }
            set { _dishCategories = value; }
        }
        public CostRange Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public DifficultyRange Dificulty
        {
            get { return _dificulty; }
            set { _dificulty = value; }
        }
        public TimeToMake TimeToMake
        {
            get { return _timeToMake; }
            set { _timeToMake = value; }
        }
        public decimal UserRating
        {
            get { return _UserRating; }
            set { _UserRating = value; }
        }
        public List<IngredientRecipe> IngredientRecipe
        {
            get { return _ingredientRecipe; }
            set { _ingredientRecipe = value; }
        }
        public List<RecipeStep> Recipesteps
        {
            get { return _recipesteps; }
            set { _recipesteps = value; }
        }
        #endregion
        #region Constructors
        public Recipe()
        {
            _recipesteps = new List<RecipeStep>();
            _ingredientRecipe = new List<IngredientRecipe>();
            _dishCategories = new List<DishCategory>();
        }
        #endregion
        #region Methods
        public bool Insert()
        {
            //add transaction here!!
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
                    Properties.Settings.Default.cnRecipes;

            SqlTransaction objTrans = null;

            sqlConRecipes.Open();
            objTrans = sqlConRecipes.BeginTransaction();

            SqlCommand cmdInsertRecipeHead = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
            cmdInsertRecipeHead.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdInsertRecipeHead.CommandText = "Insert_Recipes";
            cmdInsertRecipeHead.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@RecipeName", _nameRecipe));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@NrDoses", _nrDoses));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@Valid", _valid));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@idUserCreator", _user.ProviderUserKey));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@CreationDate", _creationDate));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@idCuisineType", _cuisineType.IdCuisine));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@idDifficulty", _dificulty.IdDifficulty));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@idCost", _cost.IDcost));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@idTimetoMake", _timeToMake.IdTimeToMake));
            cmdInsertRecipeHead.Parameters.Add(new SqlParameter("@UserRating", _UserRating));


            try
            {
                cmdInsertRecipeHead.Transaction = objTrans;
                int nrlines = cmdInsertRecipeHead.ExecuteNonQuery();

                SqlCommand cmdSelectMaxID = new SqlCommand("Select_Max_RecipeID", sqlConRecipes);
                cmdSelectMaxID.CommandType = System.Data.CommandType.StoredProcedure;
                cmdSelectMaxID.Transaction = objTrans;
                int _idRecipe = (int)cmdSelectMaxID.ExecuteScalar();


                SqlCommand cmdInsertIngredientRecipe = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
                cmdInsertIngredientRecipe.Connection = sqlConRecipes; // definir a propriedade do objeto
                cmdInsertIngredientRecipe.CommandText = "Insert_IngredientRecipe";
                cmdInsertIngredientRecipe.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (IngredientRecipe ingredientLine in _ingredientRecipe)
                {
                    ingredientLine.IdRecipe = _idRecipe;
                    cmdInsertIngredientRecipe.Parameters.Clear();
                    cmdInsertIngredientRecipe.Parameters.Add(new SqlParameter("@idIngredient", ingredientLine.Ingredient.Id));
                    cmdInsertIngredientRecipe.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));
                    cmdInsertIngredientRecipe.Parameters.Add(new SqlParameter("@Quantity", ingredientLine.Quantity));
                    cmdInsertIngredientRecipe.Parameters.Add(new SqlParameter("@idMeasurementUnit", ingredientLine.MeasurementUnit.Id));

                    cmdInsertIngredientRecipe.Transaction = objTrans;
                    cmdInsertIngredientRecipe.ExecuteNonQuery();
                }

                SqlCommand cmdInsertRecipeStep = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
                cmdInsertRecipeStep.Connection = sqlConRecipes; // definir a propriedade do objeto
                cmdInsertRecipeStep.CommandText = "Insert_RecipeSteps";
                cmdInsertRecipeStep.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (RecipeStep recipeStep in _recipesteps)
                {
                    recipeStep.IdRecipe = _idRecipe;
                    cmdInsertRecipeStep.Parameters.Clear();
                    cmdInsertRecipeStep.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));
                    cmdInsertRecipeStep.Parameters.Add(new SqlParameter("@StepNr", recipeStep.StepNr));
                    cmdInsertRecipeStep.Parameters.Add(new SqlParameter("@StepDescription", recipeStep.StepDescription));

                    cmdInsertRecipeStep.Transaction = objTrans;
                    cmdInsertRecipeStep.ExecuteNonQuery();
                }

                SqlCommand cmdInsertRecipeDishCategory = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
                cmdInsertRecipeDishCategory.Connection = sqlConRecipes; // definir a propriedade do objeto
                cmdInsertRecipeDishCategory.CommandText = "Insert_RecipesCategory";
                cmdInsertRecipeDishCategory.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (DishCategory dishCategory in _dishCategories)
                {                    
                    cmdInsertRecipeDishCategory.Parameters.Clear();
                    cmdInsertRecipeDishCategory.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));
                    cmdInsertRecipeDishCategory.Parameters.Add(new SqlParameter("@idCategory", dishCategory.DishCategoryID));

                    cmdInsertRecipeDishCategory.Transaction = objTrans;
                    cmdInsertRecipeDishCategory.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                objTrans.Rollback();
            }
            finally
            {
                sqlConRecipes.Close();
            }

            return false;
        }


        public void AddStep(RecipeStep newStep)
        {
            //add step to step list
            _recipesteps.Add(newStep);
        }
        public void AddIngredientRecipe(IngredientRecipe newIngredientRecipe)
        {
            //add ingredientRecipe to ingredientRecipe list
            _ingredientRecipe.Add(newIngredientRecipe);
        }
        public void AddDishCategory(DishCategory newDishCategory)
        {
            //add dishcategory to the list
            _dishCategories.Add(newDishCategory);
        }
        #endregion
    }
    public static class Recipes
    {
        #region Methods
        static public Dictionary<int, String> SearchRecipeByName(string _name)
        {
            Dictionary<int, String> ListOfRecipes = new Dictionary<int, String>();

            SqlConnection sqlConnection = new SqlConnection(
               Properties.Settings.Default.cnRecipes); //criar a ligação à base de dados

            SqlCommand sqlListRecipesByName = new SqlCommand(
                "List_All_Recipes_by_Name", sqlConnection); //criar o objeto sqlCommand com os parametros nome do storeprocedure
            sqlListRecipesByName.CommandType = System.Data.CommandType.StoredProcedure;

            sqlListRecipesByName.Parameters.Add(new SqlParameter("@nameRecipe", _name));

            sqlConnection.Open();

            SqlDataReader drRecipeByName = sqlListRecipesByName.ExecuteReader();

            while (drRecipeByName.Read())
            {
                ListOfRecipes.Add((int)drRecipeByName[0], drRecipeByName[1].ToString());
            }

            sqlConnection.Close();
            return ListOfRecipes;
        }
        #endregion
    }
}
