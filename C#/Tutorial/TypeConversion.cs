using System;
namespace Variables{
    class TypeConversion{
        public static void DefineOverflow(){
        // Implicit Type Conversion 
        byte b=1;
        int a = b;
        Console.WriteLine(a);

        // Explicit Type Conversion
        float f = 1.0f;
        int i = (int)f;
        Console.WriteLine(i);

        // Non-Compatible 
        string s = "1";
        int t = int.Parse(s);
         Console.WriteLine(t);
        }
    }
}