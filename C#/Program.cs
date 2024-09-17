using System;
using C_.Tutorial.OOP;

namespace Tutorial{
    class Program
    {
        static void Main(string[] args){
            Employee emp = new Employee(11,30000.00,"loshan","Jaffna",1,"Expernetic","Colombo");
            emp.DisplayCompanyDetails();
            emp.EmployeeCompanyDetails();
            emp.EmployeeDetails();
            emp.SalaryDetails();

            Boss boss = new Boss(01,3000000.00,"yokilan","France",2,"Dip","Colombo");
            boss.DisplayCompanyDetails();
            boss.EmployeeCompanyDetails();
            boss.EmployeeDetails();
            boss.SalaryDetails();

        }
    }
}
