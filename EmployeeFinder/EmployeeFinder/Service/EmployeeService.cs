using System;
using System.Linq;
using EmployeeDataAccess;
using System.Data;
//using System.Data.DataSetExtensions;

namespace EmployeeFinder.Service
{
    public class EmployeeService
    {
        EmployeeDataSet EmployeeDataSet = new EmployeeDataSet();

        EmployeeDataAccess.EmployeeDataSetTableAdapters.EmployeeTableAdapter EmployeeTableAdapter = new EmployeeDataAccess.EmployeeDataSetTableAdapters.EmployeeTableAdapter();

        public EmployeeService()
        {
            EmployeeTableAdapter.Fill(EmployeeDataSet.Employee);
        }
        // EmployeeDataSet.EmployeeDataTable EmployeeDataTable = new EmployeeDataSet.EmployeeDataTable();

        public EmployeeDataSet.EmployeeDataTable GetAll()
        {
            try
            {
                var data = EmployeeTableAdapter.GetData();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public EmployeeDataSet.EmployeeRow GetEmployeeByID(int empID)
        {
            try
            {
                var result = EmployeeDataSet.Employee.FindByEmpID(empID);

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
