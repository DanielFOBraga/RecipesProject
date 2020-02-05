using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class CostRange
    {
        #region Attributes
        private int _idCostRange;        
        private string _cost;
        #endregion
        #region Properties        
        public int IDcost
        {
            get { return _idCostRange; }
            set { _idCostRange = value; }
        }
        public string Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        #endregion
        #region Constructors
        public CostRange() { }
        /// <summary>
        /// One argument constructor
        /// </summary>
        /// <param name="NewCostLevel">
        /// It's the Cost level</param>
        public CostRange(string NewCostLevel)
        {
            _cost = NewCostLevel;
        }
        public CostRange(int NewId, string NewCostLevel)
        {
            _idCostRange = NewId;
            _cost = NewCostLevel;
        }
        #endregion
        #region Methods
        public bool Insert()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
                    Properties.Settings.Default.cnRecipes;

            SqlCommand cmdInsert = new SqlCommand("Insert_CostRange", sqlConRecipes);
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            cmdInsert.Parameters.Add(new SqlParameter("@CostRange", _cost));

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

            SqlCommand cmdUpdate= new SqlCommand("Update_CostRange", sqlConRecipes);
            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

            cmdUpdate.Parameters.Add(new SqlParameter("@IDCostRange", _idCostRange));
            cmdUpdate.Parameters.Add(new SqlParameter("@CostRange", _cost));

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

            SqlCommand cmdDelete = new SqlCommand("Delete_CostRange", sqlConRecipes);
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;

            cmdDelete.Parameters.Add(new SqlParameter("@idCostRange", _idCostRange));

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
    public class CostRanges
    {
        List<CostRange> _costRanges;
        #region Methods
        public List<CostRange> ListAllCostRanges()
        {
            _costRanges = new List<CostRange>();

            SqlConnection sqlConRecipes = new SqlConnection(
                Properties.Settings.Default.cnRecipes);

            SqlCommand sqlListAllCostRanges = new SqlCommand(
                "List_All_CostRange", sqlConRecipes);

            sqlConRecipes.Open();

            SqlDataReader drCostRanges = sqlListAllCostRanges.ExecuteReader();

            while (drCostRanges.Read())
            {
                CostRange costrange = new CostRange();
                costrange.IDcost = (int)drCostRanges[0];
                costrange.Cost = drCostRanges[1].ToString();

                _costRanges.Add(costrange);
            }

            sqlConRecipes.Close();

            return _costRanges;
        }
        #endregion
    }
}
