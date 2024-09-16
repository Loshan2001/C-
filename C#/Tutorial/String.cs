using System;

namespace Tutorial
{
    class Strings{
        public static void StringManipulation(){

       // convert String to integer
        
            Console.WriteLine("Enter numbers");

           string num1 =  Console.ReadLine();
           string num2 =  Console.ReadLine();
           int a = int.Parse(num1);
           int b = int.Parse(num2);
           Console.WriteLine(a+b);


        //concatenation
        string name = "loshan";
        int age = 23;
        string location = "Jaffna";
        Console.WriteLine("Hi, i am "+ name + ", i'm "+age+ " years old," + " i'm from "+location);

        // formating 
        Console.WriteLine("Hi, i am {0}, i am {1} years old, i am from {2}.",name,age,location);

        // interpolation 
        Console.WriteLine($"Hi, i am {name}, i am {age} years old, i am from {location}.");

        // Verbatim
        Console.WriteLine(@"Hi, i am {0}, \n i am {1} years old, i am from {2}.",name,age,location);

        // String Methods 
        string firstName = "Loshan";
        string lastName = "Saravanaperumal";
        Console.WriteLine(firstName.ToLower() + " " + lastName.ToUpper());

        // concate method
        string fullName = String.Concat(" "+ firstName,lastName+" "); 
        Console.WriteLine(fullName);

        // trim method used for remove spaces
        Console.WriteLine(fullName.Trim());

        // Substring
        // firstName = Loshan
        // o/p = shan
        Console.WriteLine(firstName.Substring(2));



        // String Operation 
        // lastName = Saravanaperumal 
        // o/p = 1
        Console.WriteLine(lastName.IndexOf('a'));


        // fullName = String.Concat(" "+ firstName,lastName + " "); // LoshanSaravanaperumal
        // if the fullname have data then it will return flase, if the fullName doesnt have data(only have null ot space) it will return true
        bool values = String.IsNullOrWhiteSpace(fullName);
        Console.WriteLine(values);


        // Console Methods 

        // here we get ASCII value
        int data = Console.Read(); 
        Console.WriteLine(data);


        }  

    }
}