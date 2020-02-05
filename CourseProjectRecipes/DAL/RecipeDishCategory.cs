using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RecipeDishCategory
    {
        #region attributes
        private int _idRecipeCategory;
        private int _idRecipe;
        private DishCategory _dishCategory;
        #endregion
        #region Properties
        public int IdRecipeCategory
        {
            get { return _idRecipeCategory; }
            set { _idRecipeCategory = value; }
        }
        public int IdRecipe
        {
            get { return _idRecipe; }
            set { _idRecipe = value; }
        }
        public DishCategory DishCategory
        {
            get { return _dishCategory; }
            set { _dishCategory = value; }
        }
        #endregion
        #region Constructors
        public RecipeDishCategory()
        {

        }
        public RecipeDishCategory(DishCategory newDishCategory)
        {
            _dishCategory = newDishCategory;
        }
        #endregion
        #region Methods
        public bool Insert()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
                    Properties.Settings.Default.cnRecipes;

            SqlCommand cmdInsert = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
            cmdInsert.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdInsert.CommandText = "Insert_RecipesCategory";
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));
            cmdInsert.Parameters.Add(new SqlParameter("@idCategory", _dishCategory.DishCategoryID));

            sqlConRecipes.Open();

            int nrlines = cmdInsert.ExecuteNonQuery(); //NonQuery porque o storedprocedure não tem selects (não retorna valores)

            sqlConRecipes.Close();

            if (nrlines == -1) //Quando se usa um storeprocedure com SET NOCOUNT ON devolve um nr de linhas -1
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
                    Properties.Settings.Default.cnRecipes;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = sqlConRecipes;
            cmdUpdate.CommandText = "Update_RecipeCategory";
            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterIdRecipeCategory = new SqlParameter();
            parameterIdRecipeCategory.ParameterName = "@idRecipeCategory";
            parameterIdRecipeCategory.Value = _idRecipeCategory;
            cmdUpdate.Parameters.Add(parameterIdRecipeCategory);

            SqlParameter parameterIdRecipe = new SqlParameter();
            parameterIdRecipe.ParameterName = "@idRecipe";
            parameterIdRecipe.Value = _idRecipe;
            cmdUpdate.Parameters.Add(parameterIdRecipe);

            SqlParameter parameterIdCategory = new SqlParameter();
            parameterIdCategory.ParameterName = "@idCategory";
            parameterIdCategory.Value = _dishCategory;
            cmdUpdate.Parameters.Add(parameterIdCategory);

            sqlConRecipes.Open();

            int nrlines = cmdUpdate.ExecuteNonQuery();

            sqlConRecipes.Close();

            if (nrlines == -1) //Quando se usa um storeprocedure devolve um nr de linhas -1
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
               Properties.Settings.Default.cnRecipes;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdDelete.CommandText = "Delete_RecipeCategory";
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterIdRecipeCategory = new SqlParameter();
            parameterIdRecipeCategory.ParameterName = "@idRecipeCategory";
            parameterIdRecipeCategory.Value = _idRecipeCategory;
            cmdDelete.Parameters.Add(parameterIdRecipeCategory);

            sqlConRecipes.Open();

            int nrlines = cmdDelete.ExecuteNonQuery();

            sqlConRecipes.Close();

            if (nrlines > 0) //When deleting the stored procedure returns the number of lines deleted
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
