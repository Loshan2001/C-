using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace C_.Tutorial.OOP
{
    public abstract class Com
    {
        public  string Name{get;set;}
        public  string Description{get;set;}
        public Com(string name,string description){
            this.Name = name;
            this.Description = description;
        }
        public abstract void CompanyDetails();

    }
}