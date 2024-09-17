using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial;

namespace Tutorial
{
     class Student
    {
        private int id {get;set;}
        private string name{get;set;}

        public int Id{
            get{
                return id;
            }
            set{
                this.id = value;
            }
        }

        public string Name{
            get{
                return name;
            }
            set{
                this.name = value;
            }
        }
        public void StudentDetails(){
            Console.WriteLine($"ID : {id} \nName : {name}");
        }
            
        public Student(int id, string name){
            this.Id = id;
            this.Name = name;
        }

        
    }
}