﻿using System;
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
            return false;
        } 
        #endregion
    }
}