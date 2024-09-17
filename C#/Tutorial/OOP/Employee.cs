using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace Tutorial
{
     class Employee : Company
    {
        public int EmployeeId{get;set;}
        public string EmployeeName{get;set;}
        public string Address{get;set;}

        public Employee(int companyId, string companyName, string companyLocation): base( companyId,  companyName,  companyLocation){

        }
    }
}