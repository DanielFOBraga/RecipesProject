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
        #endregion
    }
    public class Ingredients
    {
        List<Ingredient> _ListIngredients; //criar o objeto
        public List<Ingredient> ListAll()
        {
            _ListIngredients = new List<Ingredient>(); //instanciar o objeto
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
    }
}
