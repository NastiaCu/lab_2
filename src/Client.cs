using System; 

namespace c{

    class Client{
        private Waiter water;
        private int money;
        private int happiness = 2;
        private int num = 3;

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

        public int pay(int bill){
            money -= bill;
            return bill;
        }
        /*public void choose(Orders orders){
            KeyValuePair<string, int> drink = orders.pickDrink();
            Console.WriteLine("");
            Console.WriteLine("Client chose a ");
            orders.pickDrink();
            Console.WriteLine(drink);
        }*/

    }
}