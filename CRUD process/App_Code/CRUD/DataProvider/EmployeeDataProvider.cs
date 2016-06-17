using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Check.SQL.Utilities;
using CRUD.Info;

namespace CRUD.DataProvider
{
    public class EmployeeDataProvider
    {
        public List<EmployeeInfo> EmployeeGetAll()
        {
            SQLHandler objSQL = new SQLHandler();
            return objSQL.ExecuteAsList<EmployeeInfo>("employeeSelect");
        }
    }
}