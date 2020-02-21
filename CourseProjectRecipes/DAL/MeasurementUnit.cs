using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class MeasurementUnit
    {
        #region Attributes
        private int _measurementUnitid;
        private string _mesurementUnitName;
        #endregion
        #region Properties
        public int Id
        {
            get { return _measurementUnitid; }
            set { _measurementUnitid = value; }
        }
        public string Name
        {
            get { return _mesurementUnitName; }
            set { _mesurementUnitName = value; }
        }
        #endregion
        #region Constructors
        public MeasurementUnit()
        {            
        }
        public MeasurementUnit(string Name)
        {            
            _mesurementUnitName = Name;
        }
        public MeasurementUnit(int newId, string Name)
        {
            _measurementUnitid = newId;
            _mesurementUnitName = Name;
        }
        public MeasurementUnit(int newId)
        {
            _measurementUnitid = newId;
        }
        #endregion
        #region Methods
        public bool InsertMeasurementUnit()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
                Properties.Settings.Default.cnRecipes;

            SqlCommand cmdInsert = new SqlCommand(); //criar e instanciar objeto do tipo SqlCommand
            cmdInsert.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdInsert.CommandText = "Insert_MeasurementUnit";
            cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@MeasurementUnit";
            parameterID.Value = _mesurementUnitName;
            cmdInsert.Parameters.Add(parameterID);

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
        public bool UpdatedMeasurementUnit()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
               Properties.Settings.Default.cnRecipes;

            SqlCommand cmdUpdateMeasurementUnit = new SqlCommand();
            cmdUpdateMeasurementUnit.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdUpdateMeasurementUnit.CommandText = "Update_MeasurementUnit";
            cmdUpdateMeasurementUnit.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@idMeasurementUnit";
            parameterID.Value = _measurementUnitid;
            cmdUpdateMeasurementUnit.Parameters.Add(parameterID);

            SqlParameter parameterName = new SqlParameter();
            parameterName.ParameterName = "@MeasurementUnit";
            parameterName.Value = _mesurementUnitName;
            cmdUpdateMeasurementUnit.Parameters.Add(parameterName);

            sqlConRecipes.Open();

            int nrlines = cmdUpdateMeasurementUnit.ExecuteNonQuery();

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
        public bool DeleteMeasurementUnit()
        {
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
               Properties.Settings.Default.cnRecipes;

            SqlCommand cmdDeleteMeasurementUnit = new SqlCommand();
            cmdDeleteMeasurementUnit.Connection = sqlConRecipes; // definir a propriedade do objeto
            cmdDeleteMeasurementUnit.CommandText = "Delete_MeasurementUnit";
            cmdDeleteMeasurementUnit.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameterID = new SqlParameter();
            parameterID.ParameterName = "@idMeasurementUnit";
            parameterID.Value = _measurementUnitid;
            cmdDeleteMeasurementUnit.Parameters.Add(parameterID);

            sqlConRecipes.Open();

            int nrlines = cmdDeleteMeasurementUnit.ExecuteNonQuery();

            sqlConRecipes.Close();

            if (nrlines < 0) //for some reason it returns -1 when deleting
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
    public class MeasurementUnits
    {
        #region Attributes
        List<MeasurementUnit> _ListMeasurementUnits;
        #endregion
        #region Methods
        public List<MeasurementUnit> ListMeasurementUnits()
        {
            _ListMeasurementUnits = new List<MeasurementUnit>();
            SqlConnection sqlConRecipes = new SqlConnection();
            sqlConRecipes.ConnectionString =
                Properties.Settings.Default.cnRecipes;
            SqlCommand sqlListAllMeasurementUnits = new SqlCommand(
                "List_All_MeasurementUnits", sqlConRecipes); //criar o objeto sqlCommand com os parametros nome do storeprocedure
            sqlListAllMeasurementUnits.CommandType = System.Data.CommandType.StoredProcedure;

            sqlConRecipes.Open();

            SqlDataReader drMeasurementUnits = sqlListAllMeasurementUnits.ExecuteReader();

            while (drMeasurementUnits.Read())
            {
                MeasurementUnit measurementUnit = new MeasurementUnit();
                measurementUnit.Id = (int)drMeasurementUnits[0];
                measurementUnit.Name = drMeasurementUnits[1].ToString();

                _ListMeasurementUnits.Add(measurementUnit);
            }

            sqlConRecipes.Close();
            return _ListMeasurementUnits;
        }
        #endregion

    }
}
