using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using C_.Tutorial.OOP;
using Tutorial;

namespace Tutorial
{
     class  Emp : Com
    {
        public int EmpId{get;set;}
        public string EmpName{get;set;}
        public string EmpType{get;set;}


        public Emp(int empId, string empName,String empType, string companyName , string description) : base(companyName,description)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpType = empType;
        }
        public void EmpSalaryDetails(){
            if(EmpType.ToUpper() == "Boss"){
                    Salary();
            }
            else{
                Console.WriteLine("you are not my Boss");
            }
        }

        private void Salary(){
            Console.WriteLine($"Salary : {100000}");
        }

        public override void CompanyDetails()
        {
            Console.WriteLine($"Company Name : {Name} and Description {Description}");
        }
    }
}