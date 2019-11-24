using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class TimeToMake
    {
        #region Attributes
        private int _idTimeToMake;        
        private string _timeToMake;
        #endregion
        #region Properties
        public int IdTimeToMake
        {
            get { return _idTimeToMake; }
            set { _idTimeToMake = value; }
        }
        public string Time
        {
            get { return _timeToMake; }
            set { _timeToMake = value; }
        }
        #endregion
        #region Constructors
        public TimeToMake() { }
        /// <summary>
        /// One argument constructor
        /// </summary>
        /// <param name="NewTimeToMake">
        /// It's the new duration level</param>
        public TimeToMake(string NewTimeToMake) 
        {
            _timeToMake = NewTimeToMake;
        }
        #endregion
        #region Methods
        public bool Insert()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString = Properties.Settings.Default.cnRecipes;

            SqlCommand cmdInsert = new SqlCommand("Insert_TimeToMake", sqlConRecipes);
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@TimeToMake", _timeToMake));

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
            sqlConRecipes.ConnectionString = Properties.Settings.Default.cnRecipes;

            SqlCommand cmdUpdate = new SqlCommand("Update_TimeToMake", sqlConRecipes);
            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

            cmdUpdate.Parameters.Add(new SqlParameter("@idTimeToMake", _idTimeToMake));
            cmdUpdate.Parameters.Add(new SqlParameter("@TimeToMake", _timeToMake));

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
            sqlConRecipes.ConnectionString = Properties.Settings.Default.cnRecipes;

            SqlCommand cmdDelete = new SqlCommand("Delete_TimeToMake", sqlConRecipes);
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;

            cmdDelete.Parameters.Add(new SqlParameter("@idTimeToMake", _idTimeToMake));

            sqlConRecipes.Open();

            int nrlines = cmdDelete.ExecuteNonQuery();

            sqlConRecipes.Close();

            if (nrlines == -1)
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
    public class TimesToMake
    {
        #region Attributes
        List<TimeToMake> _listTimesToMake;
        #endregion
        #region Methods
        public List<TimeToMake> ListAllTimesToMake()
        {
            _listTimesToMake = new List<TimeToMake>();

            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString = Properties.Settings.Default.cnRecipes;

            SqlCommand sqlListAllTimesToMake = new SqlCommand("List_All_TimeToMake", sqlConRecipes);
            sqlListAllTimesToMake.CommandType = System.Data.CommandType.StoredProcedure;

            sqlConRecipes.Open();

            SqlDataReader drTimesToMake = sqlListAllTimesToMake.ExecuteReader();

            while (drTimesToMake.Read())
            {
                TimeToMake timeToMake = new TimeToMake();
                timeToMake.IdTimeToMake = (int)drTimesToMake[0];
                timeToMake.Time = drTimesToMake[1].ToString();

                _listTimesToMake.Add(timeToMake);
            }

            sqlConRecipes.Close();

            return _listTimesToMake;
        }
        #endregion
    }
}
