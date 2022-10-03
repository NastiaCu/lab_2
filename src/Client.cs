using System; 

namespace c{

    class Client: HighLevel{
        
        protected int money = 200;
        protected int happiness = 2;
        protected int num = 3;
        

        public Client(string name, string status): base(name , status){
            setValues(name, status);
        }

        public int Money{
            get { return money; }
            set { money = value; }
        }

        public int Happiness{
            get { return happiness; }
            set { happiness = value; }
        }

        public int Num{
            get { return num; }
            set { num = value; }
        }

        public void pay(int bill){
            money -= bill;
            Console.WriteLine("remained cash " + money + "$");
        }

        public void choose(Orders orders){
            Console.WriteLine("");
            Console.WriteLine("The client chose: ");
            orders.randomMain();
            orders.randomSup();
            orders.randomDrink();
           
        }

    }
}