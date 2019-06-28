using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeFinder.Model
{

   
    public class Employee
    {
        public string EmployeeName { get; set; }
       
        public int EmpID { get; set; }

        public Gender Gender { get; set; }

        public string EmailID { get; set; }

        public EmployeeBand EmployeeBand { get; set; }

        public int ContactNumber { get; set; }

        public string Address { get; set; }

        public string Manager { get; set; }

        public int ManagerID { get; set; }
    }


    public enum EmployeeBand
    {
        A1,
        A2,
        B1,
        B2,
        B3,
        C1,
        C2
    }

    public enum Gender
    {
        Male,
        Female,
        Others
    }
}
