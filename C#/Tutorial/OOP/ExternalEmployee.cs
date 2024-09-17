using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial;

namespace C_.Tutorial.OOP
{
     class ExternalEmployee : Company
    {
        
        public int ExternalEmployeeId{get;set;}
        public string ExternalEmployeeName{get;set;}
        public string ExternalEmployeeAddress{get;set;}

        public double ExternalEmployeeSalary{get; set;}

        public ExternalEmployee(int externalEmployeeId, string externalEmployeeName , string externalEmployeeAddress ,double externalEmployeeSalary,int companyId, string companyName, string companyLocation) : base(companyId,  companyName,  companyLocation)
        {
            this.ExternalEmployeeId = externalEmployeeId;
            this.ExternalEmployeeName = externalEmployeeName;
            this.ExternalEmployeeAddress = externalEmployeeAddress;
            this.ExternalEmployeeSalary = externalEmployeeSalary;
        }

        public void ExternalEmployeeDetails(){
            Console.WriteLine("EmployeeId : {0} \nEmployeeName : {1} \nAddress : {2}",ExternalEmployeeId,ExternalEmployeeName,ExternalEmployeeAddress);
        }

        public void ExtenalEmployeeCompanyDetails(){
            Console.WriteLine("EmployeeName : {0} - CompanyName : {1} and Location : {2}",ExternalEmployeeName,CompanyName,CompanyLocation);
        }
    }
}