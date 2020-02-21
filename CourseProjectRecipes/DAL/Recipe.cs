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
        private Guid _userID;
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
        public Recipe(int recipeId)
        {
            _idRecipe = recipeId;

            _recipesteps = new List<RecipeStep>();
            _ingredientRecipe = new List<IngredientRecipe>();
            _dishCategories = new List<DishCategory>();

            SqlConnection sqlConRecipes = new SqlConnection(
                Properties.Settings.Default.cnRecipes);

            SqlCommand cmdRetrieveRecipe = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
            cmdRetrieveRecipe.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdRetrieveRecipe.CommandText = "List_Recipe_From_Id";
            cmdRetrieveRecipe.CommandType = System.Data.CommandType.StoredProcedure;

            cmdRetrieveRecipe.Parameters.Add(new SqlParameter("@recipeId", _idRecipe));

            sqlConRecipes.Open();

            SqlDataReader drRecipe = cmdRetrieveRecipe.ExecuteReader();

            while (drRecipe.Read())
            {
                _nameRecipe = drRecipe[1].ToString();
                _nrDoses = (int)drRecipe[2];
                _valid = (bool)drRecipe[3];
                _userID = (Guid)drRecipe[4];               
                _creationDate = (DateTime)drRecipe[5];                 
                _cuisineType = new CuisineType((int)drRecipe[6]);
                _dificulty = new DifficultyRange((int)drRecipe[7]); //repair in DifficultyRange
                _cost = (CostRange)drRecipe[8];
                _timeToMake = (TimeToMake)drRecipe[9];
                _UserRating = (decimal)drRecipe[10];
            }

            //Retrieve Ingredientline

            SqlCommand cmdRetrieveIngredientLine = new SqlCommand();
            cmdRetrieveIngredientLine.Connection = sqlConRecipes;
            cmdRetrieveIngredientLine.CommandText = "List_All_IngredientRecipeFromRecipe";
            cmdRetrieveIngredientLine.CommandType = System.Data.CommandType.StoredProcedure;

            cmdRetrieveIngredientLine.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));

            SqlDataReader drIngredientLine = cmdRetrieveIngredientLine.ExecuteReader();

            while (drIngredientLine.Read())
            {
                IngredientRecipe newIngredientRecipe = new IngredientRecipe();
                newIngredientRecipe.IdIngredientRecipe = (int)drIngredientLine[0];
                newIngredientRecipe.Ingredient = new Ingredient((int)drIngredientLine[1]); //creating new ingredient with constructor using StoredProcedure result                
                newIngredientRecipe.IdRecipe = (int)drIngredientLine[2];
                newIngredientRecipe.Quantity = (decimal)drIngredientLine[3];
                newIngredientRecipe.MeasurementUnit = new MeasurementUnit((int)drIngredientLine[4]); //creating new ingredient with constructor using StoredProcedure result

                SqlCommand cmdRetrieveIngredientName = new SqlCommand();
                cmdRetrieveIngredientName.Connection = sqlConRecipes;
                cmdRetrieveIngredientName.CommandText = "List_Ingredient_wIngredientId";
                cmdRetrieveIngredientName.CommandType = System.Data.CommandType.StoredProcedure;
                cmdRetrieveIngredientName.Parameters.Add(new SqlParameter("@idIngredient", newIngredientRecipe.Ingredient.Id));

                SqlDataReader drIngredientName = cmdRetrieveIngredientName.ExecuteReader();

                while (drIngredientName.Read())
                {
                    newIngredientRecipe.Ingredient.Name = drIngredientName[0].ToString();
                }

                SqlCommand cmdRetrieveMeasurementUnit = new SqlCommand();
                cmdRetrieveMeasurementUnit.Connection = sqlConRecipes;
                cmdRetrieveMeasurementUnit.CommandText = "List_MeasurementUnit_wMeasurementUnitId";
                cmdRetrieveMeasurementUnit.CommandType = System.Data.CommandType.StoredProcedure;
                cmdRetrieveMeasurementUnit.Parameters.Add(new SqlParameter("@MeasurementId", newIngredientRecipe.MeasurementUnit.Id));

                SqlDataReader drMeasurementUnit = cmdRetrieveMeasurementUnit.ExecuteReader();

                while (drMeasurementUnit.Read())
                {
                    newIngredientRecipe.MeasurementUnit.Name = drMeasurementUnit[0].ToString();
                }

                _ingredientRecipe.Add(newIngredientRecipe);
            }

            //Retrieve recipe steps in the recipe

            SqlCommand cmdRetrieveRecipeStep = new SqlCommand();
            cmdRetrieveRecipeStep.Connection = sqlConRecipes;
            cmdRetrieveRecipeStep.CommandText = "List_All_RecipeStepsInRecipe";
            cmdRetrieveRecipeStep.CommandType = System.Data.CommandType.StoredProcedure;

            cmdRetrieveRecipeStep.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));

            SqlDataReader drRecipeSteps = cmdRetrieveRecipeStep.ExecuteReader();

            while (drRecipeSteps.Read())
            {
                RecipeStep newRecipeStep = new RecipeStep();
                newRecipeStep.IdRecipeStep = (int)drRecipeSteps[1];
                newRecipeStep.StepNr = (int)drRecipeSteps[2];
                newRecipeStep.StepDescription = drRecipeSteps[3].ToString();

                _recipesteps.Add(newRecipeStep);
            }

            //Retrieve dish categories in recipe

            SqlCommand cmdRetrieveDishCategories = new SqlCommand();
            cmdRetrieveDishCategories.Connection = sqlConRecipes;
            cmdRetrieveDishCategories.CommandText = "List_RecipeCategories_wIdRecipe";
            cmdRetrieveDishCategories.CommandType = System.Data.CommandType.StoredProcedure;

            cmdRetrieveDishCategories.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));

            SqlDataReader drRecipeCategories = cmdRetrieveDishCategories.ExecuteReader();

            while (drRecipeCategories.Read())
            {
                DishCategory newDishCategory = new DishCategory();
                newDishCategory.DishCategoryID = (int)drRecipeCategories[0];
                newDishCategory.DishCategoryName = drRecipeCategories[1].ToString();

                _dishCategories.Add(newDishCategory);
            }

            sqlConRecipes.Close();
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
                objTrans.Commit();
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
    public class RecipeSearch
    {
        #region attributes
        private int _idRecipe;
        private string _recipeTitle;
        #endregion
        #region Properties
        public int IdRecipe
        {
            get { return _idRecipe; }
            set { _idRecipe = value; }
        }
        public string RecipeTitle
        {
            get { return _recipeTitle; }
            set { _recipeTitle = value; }
        }
        #endregion
        #region contructors
        public RecipeSearch() { }
        public RecipeSearch(int idRecipeSearch, string recipeTitleSearch)
        {
            _idRecipe = idRecipeSearch;
            _recipeTitle = recipeTitleSearch;
        }
        #endregion
        #region methods
        //doing this as a Constructor in Recipe with the recipeId
        //public Recipe BuildRecipeFromRecipeSearch(RecipeSearch selectedRecipeSearch)
        //{
        //    recipe selectedrecipe = new recipe();
        //selectedrecipe.idrecipe = selectedrecipesearch.idrecipe;
        //    selectedrecipe.namerecipe = selectedrecipesearch.recipetitle;

        //    sqlconnection sqlconrecipes = new sqlconnection();
        //    sqlconrecipes.connectionstring =
        //            properties.settings.default.cnrecipes;

        //    SqlCommand cmdRetrieveRecipe = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
        //    cmdRetrieveRecipe.Connection = sqlConRecipes; // definir a propriedade do objeto
        //        cmdRetrieveRecipe.CommandText = "List_Recipe_From_Id";
        //        cmdRetrieveRecipe.CommandType = System.Data.CommandType.StoredProcedure;

        //        cmdRetrieveRecipe.Parameters.Add(new SqlParameter("@recipeId", selectedRecipe.IdRecipe));

        //        sqlConRecipes.Open();

        //        SqlDataReader drRecipe = cmdRetrieveRecipe.ExecuteReader();

        //        while (drRecipe.Read())
        //        {
        //            selectedRecipe.NameRecipe = drRecipe[2].ToString();
        //}

        //sqlConRecipes.Close();

        //    return selectedRecipe;
        //}
        #endregion
    }
    public static class RecipeSearchs
    {
        public static List<RecipeSearch> ListSearchResults(string recipeNameToSearch)
        {
            List<RecipeSearch> _listRecipeSearchs = new List<RecipeSearch>();
            SqlConnection sqlConnection = new SqlConnection(
                Properties.Settings.Default.cnRecipes); //criar a ligação à base de dados
            SqlCommand sqlListRecipesByName = new SqlCommand(
                "List_All_Recipes_by_Name", sqlConnection);
            sqlListRecipesByName.Parameters.Add(new SqlParameter("@nameRecipe", recipeNameToSearch));

            sqlListRecipesByName.CommandType = System.Data.CommandType.StoredProcedure;

            sqlConnection.Open();

            SqlDataReader drRecipeSearch = sqlListRecipesByName.ExecuteReader();

            while (drRecipeSearch.Read())
            {
                RecipeSearch recipeSearch = new RecipeSearch();
                recipeSearch.IdRecipe = (int)drRecipeSearch[0];
                recipeSearch.RecipeTitle = drRecipeSearch[1].ToString();

                _listRecipeSearchs.Add(recipeSearch);
            }

            sqlConnection.Close();
            return _listRecipeSearchs;
        }
    }
}
