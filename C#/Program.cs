using System;

namespace Tutorial{
    class Program
    {
        static void Main(string[] args){
            Employee emp = new Employee(11,30000.00,"loshan","Jaffna",1,"Expernetic","Colombo");
            emp.DisplayCompanyDetails();
            emp.EmployeeCompanyDetails();
            emp.EmployeeDetails();
            emp.SalaryDetails();

        }
    }
}
