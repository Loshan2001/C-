using System;

namespace Tutorial{
    class Program
    {
        static void Main(string[] args){
           Company c=  new Company(1,"Expernetic");
           Company c1 = new Company
           {
                Id =4,
                Name = "IFS"

           };
           c.DisplayCompanyDetails();
           c1.DisplayCompanyDetails();
        }
    }
}
