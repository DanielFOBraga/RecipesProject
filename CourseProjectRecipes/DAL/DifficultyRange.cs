using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class DifficultyRange
    {
        #region Attributes
        private int _idDifficulty;
        private string _DifficultyRange;
        #endregion
        #region Properties
        public int IdDifficulty
        {
            get { return _idDifficulty; }
            set { _idDifficulty = value; }
        }       

        public string Difficulty
        {
            get { return _DifficultyRange; }
            set { _DifficultyRange = value; }
        }
        #endregion
        #region Constructors
        public DifficultyRange() { }
        /// <summary>
        /// Difficulty Range constructor with one argument
        /// </summary>
        /// <param name="NewDifficultyCategory">
        /// It's the difficulty category</param>
        public DifficultyRange(string NewDifficultyCategory)
        {
            _DifficultyRange = NewDifficultyCategory;
        }
        public DifficultyRange(int idDifficulty)
        {
            _idDifficulty = idDifficulty;
        }
        public DifficultyRange(int idDifficulty, string NewDifficultyCategory)
        {
            _idDifficulty = idDifficulty;
            _DifficultyRange = NewDifficultyCategory;
        }
        #endregion
        #region Methods
        public bool Insert()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
                    Properties.Settings.Default.cnRecipes;

            SqlCommand cmdInsert = new SqlCommand("Insert_DificultyRange", sqlConRecipes);
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@DificultyRange", _DifficultyRange));

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

            SqlCommand cmdUpdate = new SqlCommand("Update_DifficultyRange", sqlConRecipes);
            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

            cmdUpdate.Parameters.Add(new SqlParameter("@idDifficulty", _idDifficulty));
            cmdUpdate.Parameters.Add(new SqlParameter("@DificultyRange", _DifficultyRange));

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

            SqlCommand cmdDelete = new SqlCommand("Delete_DifficultyRange",sqlConRecipes);

            cmdDelete.Parameters.Add(new SqlParameter("@idDifficulty", _idDifficulty));

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
    public class DifficultieRanges
    {
        #region Attributes
        List<DifficultyRange> _listDifficultyRanges;
        #endregion
        #region Methods
        public List<DifficultyRange> ListAllDifficutyRanges()
        {
            _listDifficultyRanges = new List<DifficultyRange>();

            SqlConnection sqlConRecipes = new SqlConnection(
                Properties.Settings.Default.cnRecipes);

            SqlCommand sqlListAllDifficultyRanges = new SqlCommand(
                "List_All_DifficultyRange", sqlConRecipes);

            sqlConRecipes.Open();

            SqlDataReader drDifficultyRanges = sqlListAllDifficultyRanges.ExecuteReader();

            while (drDifficultyRanges.Read())
            {
                DifficultyRange difficultyRange = new DifficultyRange();
                difficultyRange.IdDifficulty = (int)drDifficultyRanges[0];
                difficultyRange.Difficulty = drDifficultyRanges[1].ToString();

                _listDifficultyRanges.Add(difficultyRange);
            }

            sqlConRecipes.Close();

            return _listDifficultyRanges;
        }
        #endregion
    }
}
