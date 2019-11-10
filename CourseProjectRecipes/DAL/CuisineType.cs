using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class CuisineType
    {
        #region Attributes
        private int _idCuisine;
        private string _cuisineType;
        #endregion
        #region Properties
        public int IdCuisine
        {
            get { return _idCuisine; }
            set { _idCuisine = value; }
        }
        public string CuisineTypeName
        {
            get { return _cuisineType; }
            set { _cuisineType = value; }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// It's the constructor with one argument
        /// </summary>
        /// <param name="NewCuisineType">
        /// It's the name of the new cuisine type
        /// </param>
        public CuisineType(string NewCuisineType)
        {
            _cuisineType = NewCuisineType;
        }
        /// <summary>
        /// It's the constructor with two arguments
        /// </summary>
        /// <param name="IDcuisineType">
        /// It's the ID of the cuisine type</param>
        /// <param name="NewCuisineType">
        /// It's the name of the cuisine type</param>
        public CuisineType(int IDcuisineType, string NewCuisineType)
        {
            _idCuisine = IDcuisineType;
            _cuisineType = NewCuisineType;
        }
        public CuisineType()
        {
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
            cmdInsert.CommandText = "Insert_CuisineType";
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@cuisineType", _cuisineType));

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
            cmdUpdate.CommandText = "Update_CuisineType";
            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@IdCuisineType";
            parameterID.Value = _idCuisine;
            cmdUpdate.Parameters.Add(parameterID);

            SqlParameter parameterName = new SqlParameter();
            parameterName.ParameterName = "@CuisineType";
            parameterName.Value = _cuisineType;
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
            cmdDelete.CommandText = "Delete_CuisineType";
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@idCuisineType";
            parameterID.Value = _idCuisine;
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
    public class CuisineTypes
    {
        #region Attributes
        List<CuisineType> _ListCuisineTypes; //declarar o objeto
        #endregion
        #region Methods
        public List<CuisineType> ListAllCuisineType()
        {
            _ListCuisineTypes = new List<CuisineType>(); //criar o objeto

            SqlConnection sqlConnection = new SqlConnection(
                Properties.Settings.Default.cnRecipes); //criar a ligação à base de dados
            SqlCommand sqlListAllCuisineTypes = new SqlCommand(
                "List_All_CuisineTypes", sqlConnection); //criar o objeto sqlCommand com os parametros nome do storeprocedure
            sqlListAllCuisineTypes.CommandType = System.Data.CommandType.StoredProcedure;

            sqlConnection.Open();

            SqlDataReader drCuisineTypes = sqlListAllCuisineTypes.ExecuteReader();

            while (drCuisineTypes.Read())
            {
                CuisineType cuisinetype = new CuisineType();
                cuisinetype.IdCuisine = (int)drCuisineTypes[0];
                cuisinetype.CuisineTypeName = drCuisineTypes[1].ToString();

                _ListCuisineTypes.Add(cuisinetype);
            }

            sqlConnection.Close();
            return _ListCuisineTypes;
        }
        #endregion
    }
}
