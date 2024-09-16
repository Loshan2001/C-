using System;
using System.Collections;
using System.Globalization;

namespace Tutorial{
    class Collection{
        public static void HandleCollection(){
            // Array 
            // int[] num = new int[]{10,20,30,40,50};
            // num[0] = 10;
            // num[1] = 20;
            // num[2] = 30;
            // num[3] = 40;
            // num[4] = 50;

            // foreach(int x in num){
            //     Console.WriteLine(x);
            // }

            // // Two type of Generic Collections
            // // Generic Collection = List, Dictionary, Stack, Queue  => store only one type
            // // Non Generic Collection = HashTable, ArrayList  => store any type
             

            //  ArrayList 
            // we can store any type of objects inside the arrayList
            ArrayList bookData = new ArrayList();
            bookData.Add(50);
            bookData.Add(60);
            bookData.Add("loshan");
            bookData.Add(23.30f);
            bookData.Add(true);
            bookData.Add(50);
            bookData.Add(60);
            foreach(var item in bookData){
                    Console.WriteLine(item);
            }
            bookData.Remove(50);
             bookData.Remove(50);
             bookData.RemoveAt(3); //remove using index
            Console.WriteLine("------------after removed an item");
            foreach(var item in bookData){
                    Console.WriteLine(item);
            }


            // List 
            List<int> list = new List<int>();
            list.Add(20);
            list.Add(30);
            Console.WriteLine("-------List-------");
            foreach(int item in list){
                Console.WriteLine(item);
            }


            // HashTable 
            Hashtable data= new Hashtable();
            data.Add(1,"loshan");
            data.Add(2,"Yoki"); 
            data.Add(3,"Hiro");
            data.Add(4,null); // key is must but value can be null or something
            data.Add("A1",300);
            Console.WriteLine(data[1]);
            Console.WriteLine(data["A1"]);

            foreach(DictionaryEntry item in data){
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            data.Remove(1);

            foreach(DictionaryEntry item in data){
                 Console.WriteLine($"{item.Key} : {item.Value}");
            }




            // Dictionary 
            Dictionary<int,String> dict = new Dictionary<int,String>();
            dict.Add(2,"Lenin");
            dict.Add(1,"kirusanth");
            dict.Add(3,"shangeeth");
            // use only for loop
            for(int i=0; i<dict.Count; i++){
                Console.WriteLine($"{dict.Keys.ElementAt(i)} : {dict.Values.ElementAt(i)}");
            }

            dict.Remove(3);

              for(int i=0; i<dict.Count; i++){
                Console.WriteLine($"{dict.Keys.ElementAt(i)} : {dict.Values.ElementAt(i)}");
            }


            // Stack = Pop() , Push(), Peek()
            Stack<int> stack = new Stack<int>();
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            while(stack.Count() > 0){
                Console.WriteLine(stack.Pop());
            }

            // Queue  = Enqueue(), Dequeue() , Peek()

            Queue<String> q = new Queue<String>();
            q.Enqueue("Hello");
            q.Enqueue("World");

            while(q.Count()>0){
                Console.WriteLine(q.Dequeue());
            }
            
        }
    }
}