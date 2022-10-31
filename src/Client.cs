using System; 

namespace c{

    class Client{

        private Orders orders;
        
        protected int money = 200;
        public int happiness = 2;
        protected int num = 3;
        

        public Client(Orders orders){
            this.orders = orders;
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

        public void choose(){
            Console.WriteLine("");
            Console.WriteLine("The client chose: ");
            orders.randomMain();
            orders.randomSup();
            orders.randomDrink();
           
        }

    }
}