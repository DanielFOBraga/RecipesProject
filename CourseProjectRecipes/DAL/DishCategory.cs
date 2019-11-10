using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class DishCategory
    {
        #region Attributes
        private int _idDishCategory;
        private string _DishCategoryName;
        #endregion
        #region Properties
        public int DishCategoryID
        {
            get { return _idDishCategory; }
            set { _idDishCategory = value; }
        }
        public string DishCategoryName
        {
            get { return _DishCategoryName; }
            set { _DishCategoryName = value; }
        }
        #endregion
        #region Contructors
        public DishCategory()
        {
        }
        /// <summary>
        /// It's the constructor with one argument
        /// </summary>
        /// <param name="NewDishCategory">
        /// It's the name of the dish category</param>
        public DishCategory(string NewDishCategory)
        {
            _DishCategoryName = NewDishCategory;
        }
        /// <summary>
        /// It's the constructor with two arguments
        /// </summary>
        /// <param name="DishCategoryID">
        /// It's the ID of the dish category</param>
        /// <param name="DishCategoryName">
        /// It's the name of the dish category</param>
        public DishCategory(int DishCategoryID, string DishCategoryName)
        {
            _idDishCategory = DishCategoryID;
            _DishCategoryName = DishCategoryName;
        }
        #endregion
        #region Methods
        public bool Insert()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
                    Properties.Settings.Default.cnRecipes;

            SqlCommand cmdInsert = new SqlCommand("Insert_DishCategory", sqlConRecipes);
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@DishCateogry", _DishCategoryName));

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

            SqlCommand cmdUpdate = new SqlCommand("Update_DishCategory", sqlConRecipes);

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@DishCategoryID";
            parameterID.Value = _idDishCategory;
            cmdUpdate.Parameters.Add(parameterID);

            SqlParameter parameterName = new SqlParameter();
            parameterName.ParameterName = "@DishCategoryName";
            parameterName.Value = _DishCategoryName;
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

            SqlCommand cmdDelete = new SqlCommand("Delete_DishCategory", sqlConRecipes);

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@DishCategoryID";
            parameterID.Value = _idDishCategory;
            cmdDelete.Parameters.Add(parameterID);

            sqlConRecipes.Open();

            int nrlines = cmdDelete.ExecuteNonQuery();

            sqlConRecipes.Close();

            if (nrlines > 0) //Quando se usa um storeprocedure devolve um nr de linhas -1
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
    public class DishCategories
    {
        #region Attributes
        List<DishCategory> _ListDishCategories; //declarar o objeto
        #endregion
        #region Constructors
        #endregion
        #region Methods
        public List<DishCategory> ListAllDishCategories()
        {
            _ListDishCategories = new List<DishCategory>();

            SqlConnection sqlConRecipes = new SqlConnection(
                Properties.Settings.Default.cnRecipes);
            SqlCommand sqlListAllDishCategories = new SqlCommand(
                "List_All_DishCategories", sqlConRecipes);

            sqlConRecipes.Open();

            SqlDataReader drDishCategories = sqlListAllDishCategories.ExecuteReader();

            while (drDishCategories.Read())
            {
                DishCategory dishCategory = new DishCategory((int)drDishCategories[0], drDishCategories[1].ToString());

                _ListDishCategories.Add(dishCategory);
            }

            sqlConRecipes.Close();

            return _ListDishCategories;            
        }
        #endregion
    }
}
