namespace Tutorial
{
    class SemiBus : Bus
    {
        public SemiBus(int wheel) : base(wheel){

        }
        
        // this new keyword hide the superclass Capacity method and get this derived class Capacity method
         public new void Capacity(){
            Console.WriteLine("Bus capacity : 30");
        }
        // if you dont wanna override a method again then we use sealed meathod
        public sealed override void BusDetails()
        {
            Console.WriteLine($"This semibus has {Wheels} wheels");
        }
    }
    class SchoolBus: SemiBus{
         public SchoolBus(int wheel) : base(wheel){

        }
        // we cannot execute the method because its sealed method
    //    public  override void BusDetails()
    //     {
    //         Console.WriteLine($"This semibus has {Wheels} wheels");
    //     }
    }
}