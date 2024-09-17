using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using C_.Tutorial.OOP;


namespace Tutorial
{
     class Employee : Company, IemployeeSalary
    {
        public int EmployeeId{get;set;}
        public string EmployeeName{get;set;}
        public string Address{get;set;}

        public double Salary{get; set;}

        public Employee(int employeeId ,double salary, string employeeName , string address ,int companyId, string companyName, string companyLocation): base( companyId,  companyName,  companyLocation){
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.Address = address;
            this.Salary = salary;
        }

        public void EmployeeDetails(){
            Console.WriteLine("EmployeeId : {0} \nEmployeeName : {1} \nAddress : {2}",EmployeeId,EmployeeName,Address);
        }

        public void EmployeeCompanyDetails(){
            Console.WriteLine("EmployeeName : {0} - CompanyName : {1} and Location : {2}",EmployeeName,CompanyName,CompanyLocation);
        }

        public void SalaryDetails()
        {
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}