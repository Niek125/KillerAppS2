﻿using ModelLayer.General_Interfaces;
using System;

namespace DataLayer.DataBase.QueryBuilder
{
    public interface IQueryBuilder
    {
        void Insert(Type _type, object[] _parameters);
        void StoredProcedure(string _procedureName, object[] _parameters);
    }
}