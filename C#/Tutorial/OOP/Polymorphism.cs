using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial
{
     class Claculator

    {
        // compile time/static polymorphism => overloading same function name but different parameters
        public void Add(int x, int y){
            Console.WriteLine(x + y);
        }

         public void Add(int x, int y, int z){
            Console.WriteLine(x + y + z);
        }
        
    }
}