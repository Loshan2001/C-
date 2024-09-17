using System;
using C_.Tutorial.OOP;

namespace Tutorial{
    class Program
    {
        static void Main(string[] args){
            // Employee emp = new Employee(11,30000.00,"loshan","Jaffna",1,"Expernetic","Colombo");
            // emp.DisplayCompanyDetails();
            // emp.EmployeeCompanyDetails();
            // emp.EmployeeDetails();
            // emp.SalaryDetails();

            // Boss boss = new Boss(01,3000000.00,"yokilan","France",2,"Dip","Colombo");
            // boss.DisplayCompanyDetails();
            // boss.EmployeeCompanyDetails();
            // boss.EmployeeDetails();
            // boss.SalaryDetails();

            // ExternalEmployee exemp = new ExternalEmployee(11,"loshan","Jaffna",30000.00,1,"IFS","Colombo");
            // exemp.ExternalEmployeeDetails();
            // exemp.ExtenalEmployeeCompanyDetails();


            // Claculator c = new Claculator();
            // c.Add(20,20,20);

            // Bus semibus = new SemiBus(8);
            // semibus.BusDetails();
            // semibus.Capacity();

            // Emp e = new Emp(1,"Max","boss","SLIIT" ,"Find Your Future");
            // e.EmpSalaryDetails();
            // e.CompanyDetails();


            // Student stu = new Student(222,"loshan");
            // stu.Id = 666;
            // stu.Name = "Lochan";
            // stu.StudentDetails();

            var video = new Video(){Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); // publisher 
            var mailService = new MailService(); // subscriber 
            // += this is goint to register a handler(MailService Method ) for that event 
            // mailService.OnvideoEncoded this is a reference to that OnvideoEncoded()
            videoEncoder.VideoEncoded += mailService.OnvideoEncoded;
            videoEncoder.Encoder(video);


        }
    }

    class MailService{
        // event handler
        public void OnvideoEncoded(object source, EventArgs args){
            Console.WriteLine("Mail Servce : Sending an email...");

        }
    }
}
