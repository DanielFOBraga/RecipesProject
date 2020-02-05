using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IngredientRecipe
    {
        #region Attributes
        private int _idIngredientRecipe;
        private int _idRecipe;
        private decimal _quantity;
        private Ingredient _ingredient;
        private MeasurementUnit _measurementUnit;

        #endregion
        #region Properties
        public int IdIngredientRecipe
        {
            get { return _idIngredientRecipe; }
            set { _idIngredientRecipe = value; }
        }
        public int IdRecipe
        {
            get { return _idRecipe; }
            set { _idRecipe = value; }
        }
        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public Ingredient Ingredient
        {
            get { return _ingredient; }
            set { _ingredient = value; }
        }
        public MeasurementUnit MeasurementUnit
        {
            get { return _measurementUnit; }
            set { _measurementUnit = value; }
        }
        #endregion
        #region Constructors
        public IngredientRecipe(decimal Quantity, Ingredient ingredient, MeasurementUnit measurementUnit)
        {
            _quantity = Quantity;
            _ingredient = ingredient;
            _measurementUnit = measurementUnit;
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
            cmdInsert.CommandText = "Insert_IngredientRecipe";
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@idIngredient", Ingredient.Id));
            cmdInsert.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));
            cmdInsert.Parameters.Add(new SqlParameter("@Quantity", _quantity));
            cmdInsert.Parameters.Add(new SqlParameter("@idMeasurementUnit", MeasurementUnit.Id));

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
            cmdUpdate.CommandText = "Update_IngredientRecipe";
            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            
            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@IdIngredientRecipe";
            parameterID.Value = _idIngredientRecipe;
            cmdUpdate.Parameters.Add(parameterID);

            SqlParameter ParameterIDIngredient = new SqlParameter();
            ParameterIDIngredient.ParameterName = "@idIngredient";
            ParameterIDIngredient.Value = Ingredient.Id;
            cmdUpdate.Parameters.Add(ParameterIDIngredient);

            SqlParameter ParameterIDRecipe = new SqlParameter();
            ParameterIDRecipe.ParameterName = "@idRecipe";
            ParameterIDRecipe.Value = _idRecipe;
            cmdUpdate.Parameters.Add(ParameterIDRecipe);

            SqlParameter ParameterIDQuantity = new SqlParameter();
            ParameterIDQuantity.ParameterName = "@Quantity";
            ParameterIDQuantity.Value = _quantity;
            cmdUpdate.Parameters.Add(ParameterIDQuantity);

            SqlParameter ParameterIDMeasurementUnit = new SqlParameter();
            ParameterIDMeasurementUnit.ParameterName = "@idMeasurementUnit";
            ParameterIDMeasurementUnit.Value = MeasurementUnit.Id;
            cmdUpdate.Parameters.Add(ParameterIDMeasurementUnit);

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
            cmdDelete.CommandText = "Delete_IngredientRecipe";
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@IdIngredientRecipe";
            parameterID.Value = _idIngredientRecipe;
            cmdDelete.Parameters.Add(parameterID);

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
