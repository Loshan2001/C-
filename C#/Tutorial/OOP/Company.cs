
namespace Tutorial{
    class Company{


        // Simplify version of getter and setter
        public int Id{get; set;}
        public string Name{get; set;}

        public Company(){
            
        }
        public Company(int id, string name){
            this.Id = id;
            this.Name = name;
        }

        // public void SetId(int id){
        //     this.id = id;
        // }

        // public int GetId(){
        //     return this.id;
        // }


        // public void SetName(string name){
        //     this.name = name;
        // }

        // public string GetName(){
        //     return this.name;
        // }

        // Simplify version of getter and setter
        // public int ID{
        //     set{
        //         this.id = value;
        //     }
        //     get{
        //         return ID;
        //     }     
        // }
        // public string Name{
        //     get{
        //         return name;
        //     }
        //     set{
        //         this.name = value;
        //     }
        // }
        public void DisplayCompanyDetails(){
            Console.WriteLine($"Company ID : {Id} \nCompany Name : {Name}");
        }
    }
}