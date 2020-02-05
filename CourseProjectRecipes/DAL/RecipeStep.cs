using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RecipeStep
    {
        #region Attributes
        private int _idRecipeStep;		
		private int _idRecipe;		
		private int _StepNr;		
		private string _stepDescription;
		#endregion
		#region Properties
		public int IdRecipeStep
		{
			get { return _idRecipeStep; }
			set { _idRecipeStep = value; }
		}
		public int IdRecipe
		{
			get { return _idRecipe; }
			set { _idRecipe = value; }
		}
		public int StepNr
		{
			get { return _StepNr; }
			set { _StepNr = value; }
		}
		public string StepDescription
		{
			get { return _stepDescription; }
			set { _stepDescription = value; }
		}
        #endregion
        #region Constructors
		public RecipeStep()
		{

		}
		public RecipeStep(int stepNumber, string stepDescription)
		{
			_StepNr = stepNumber;
			_stepDescription = stepDescription;
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

			cmdInsert.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));
			cmdInsert.Parameters.Add(new SqlParameter("@StepNr", _StepNr));
			cmdInsert.Parameters.Add(new SqlParameter("@StepDescription", _stepDescription));
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
			cmdUpdate.CommandText = "Update_RecipeStep";
			cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

			cmdUpdate.Parameters.Add(new SqlParameter("@idStep", _idRecipeStep));
			cmdUpdate.Parameters.Add(new SqlParameter("@idRecipe", _idRecipe));
			cmdUpdate.Parameters.Add(new SqlParameter("@StepNr", _StepNr));
			cmdUpdate.Parameters.Add(new SqlParameter("@StepDescription", _stepDescription));

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
			cmdDelete.CommandText = "Delete_RecipeSteps";
			cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;

			cmdDelete.Parameters.Add(new SqlParameter("@idStep", _idRecipeStep));

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
