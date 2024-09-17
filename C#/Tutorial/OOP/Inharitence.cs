using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial
{
     class Shape
    {
        public int Width{get;set;}
        public int Length{get;set;}
        
       // Virtual property for Area that can be overridden by derived classes
        public virtual int Area{
            get{
                return 0;
            }
        }
    }
    class Rectangle : Shape{
         // Override the Area property to implement specific behavior for Rectangle
        public override int Area {
            get{
                return Width * Length;
            }
        }
    }
}