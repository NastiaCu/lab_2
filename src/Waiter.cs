using System;
using System.Collections.Generic;


namespace c{

    class Waiter: LowLevel{

        protected int Main;
        protected int Sup;
        protected int Drink;
        public int ToPay;
        new public int Salary = 4000;


        public Waiter(string name, string status): base(name, status){
            name = this.name;
            setValues(name, status);
        }

        public override void speak(){
            base.speak();
            Console.WriteLine("What would you like to order?");
        }
        

        public void bill(Client client, Orders orders){

            KeyValuePair<string, int> MainDish = orders.chosenMain;
            KeyValuePair<string, int> Supplies = orders.chosenSup;
            KeyValuePair<string, int> DrinkM = orders.chosenDrink;

            Main = MainDish.Value;
            Sup = Supplies.Value;
            Drink = DrinkM.Value;
            ToPay = Main + Sup + Drink;
            Console.WriteLine("The total bill is " + ToPay);

        }

    }
}
