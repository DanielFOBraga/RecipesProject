using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class Ingredient
    {
        #region Constructor
        /// <summary>
        /// It's the constructor with one argument
        /// </summary>
        /// <param name="NewIngredientName">
        /// It's the name of the new ingredient
        /// </param>
        public Ingredient(string NewIngredientName)
        {
            _name = NewIngredientName;
        }
        public Ingredient(int NewIngredientId, string NewIngredientName)
        {
            _id = NewIngredientId;
            _name = NewIngredientName;
        }
        public Ingredient()
        {
        }
        #endregion
        #region Attributes
        private int _id;       
        private string _name; 
        #endregion
        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion
        #region Methods
        public bool Insert()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString = 
                Properties.Settings.Default.cnRecipes; //Usar o setting connectionstring ligação Base de Dados

            SqlCommand cmdInsert = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
            cmdInsert.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdInsert.CommandText = "Insert_Ingredient";
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@IngredientName", _name)); //inserir os parametros para o objeto SqlCommand

            sqlConRecipes.Open();

            int nrlines = cmdInsert.ExecuteNonQuery(); //NonQuery porque o storedprocedure não tem selects (não retorna valores)
          
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
        public bool Update()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
               Properties.Settings.Default.cnRecipes;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdUpdate.CommandText = "Update_Ingredient";
            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@idIngredient";
            parameterID.Value = _id;
            cmdUpdate.Parameters.Add(parameterID);

            SqlParameter parameterName = new SqlParameter();
            parameterName.ParameterName = "@NewName";
            parameterName.Value = _name;
            cmdUpdate.Parameters.Add(parameterName);

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
            cmdDelete.CommandText = "Delete_Ingredient";
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;
            
            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@idIngredient";
            parameterID.Value = _id;
            cmdDelete.Parameters.Add(parameterID);

            sqlConRecipes.Open();

            int nrlines = cmdDelete.ExecuteNonQuery();

            sqlConRecipes.Close();

            if (nrlines >0) //When deleting the stored procedure returns the number of lines deleted
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
    public class Ingredients
    {
        #region Attributes
        List<Ingredient> _ListIngredients; //declarar o objeto
        #endregion
        #region Methods
        public List<Ingredient> ListAll()
        {
            _ListIngredients = new List<Ingredient>(); //criar o objeto
            SqlConnection sqlConnection = new SqlConnection(
                Properties.Settings.Default.cnRecipes); //criar a ligação à base de dados
            SqlCommand sqlListAllIngredients = new SqlCommand(
                "List_All_Ingredients", sqlConnection); //criar o objeto sqlCommand com os parametros nome do storeprocedure
            sqlListAllIngredients.CommandType = System.Data.CommandType.StoredProcedure;

            sqlConnection.Open();

            SqlDataReader drIngredients = sqlListAllIngredients.ExecuteReader();

            while (drIngredients.Read())
            {
                Ingredient ingredient = new Ingredient();
                ingredient.Id = (int)drIngredients[0];
                ingredient.Name = drIngredients[1].ToString();

                _ListIngredients.Add(ingredient);
            }

            sqlConnection.Close();
            return _ListIngredients;
        }
        #endregion
    }
}
