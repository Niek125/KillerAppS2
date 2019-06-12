﻿using DataLayer.DataBase;
using ModelLayer.General_Interfaces;
using ModelLayer.General_Models;
using ModelLayer.Structural_Interfaces;
using System.Collections.Generic;

namespace DataAccessLayer.Repository
{
    public class CategoryRepository : ICategoryRepo
    {
        IDataBase dataBase;

        public CategoryRepository()
        {
            dataBase = Factory.GetDataBase();
        }

        public IEnumerable<ICategory> GetAllCategories()
        {
            object[] param = new object[0];
            dataBase.QueryBuilder.StoredProcedure("GetAllCategories", param);
            return dataBase.ExecuteSelectQuery<ICategory>(typeof(Category));
        }
    }
}
