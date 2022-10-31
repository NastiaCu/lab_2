using System;

namespace c{

    class Barman: LowLevel{
        private int num_drinks;
        new private Orders orders;
        new private Client client;
        new public string status;
        new public int rating = 5;
        new public int salary = 4000;

        public Barman(Client client, Orders orders, string status): base(client, orders, status){
            this.client = client;
            this.orders = orders;
            this.status = status;
        }

        public int Num_Drinks{
            get { return num_drinks; }
            set { num_drinks = value; } 
        }

        public override void speak(){
            base.speak();
            Console.WriteLine("ОФИЦИАНТ!!!!!!!!!");
        }

        public void makeDrink(){
            KeyValuePair<string, int> BarmanServed = orders.chosenDrink;

            Console.WriteLine("");
            Console.WriteLine("Barman serverd: ");
            Console.WriteLine(BarmanServed);
            num_drinks++;

        }
    }
}