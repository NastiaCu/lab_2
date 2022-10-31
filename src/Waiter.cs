using System;
using System.Collections.Generic;


namespace c{

    class Waiter: LowLevel{

        protected int Main;
        protected int Sup;
        protected int Drink;
        public int ToPay;
        new public int salary = 4000;
        new private Orders orders;
        new private Client client;
        new public string status;
        new public int rating = 5;

        public Waiter(Client client, Orders orders, string status): base(client, orders, status){
            this.client = client;
            this.orders = orders;
            this.status = status;
        }
        
        public override void speak(){
            base.speak();
            Console.WriteLine("What would you like to order?");
        }
        
        public int bill(){

            KeyValuePair<string, int> MainDish = orders.chosenMain;
            KeyValuePair<string, int> Supplies = orders.chosenSup;
            KeyValuePair<string, int> DrinkM = orders.chosenDrink;

            Main = MainDish.Value;
            Sup = Supplies.Value;
            Drink = DrinkM.Value;
            ToPay = Main + Sup + Drink;
            Console.WriteLine("The total bill is " + ToPay);
            return ToPay;
        }
    }
}
