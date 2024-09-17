using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial;

namespace Tutorial
{
     class Boss : Employee
    {
        public Boss(int employeeId ,double salary, string employeeName , string address ,int companyId, string companyName, string companyLocation):base(employeeId,salary,employeeName,address, companyId,  companyName,  companyLocation)
        {

        }
    }
}