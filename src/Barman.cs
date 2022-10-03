using System;

namespace c{

    class Barman: LowLevel{
        private int num_drinks;

        public int Num_Drinks{
            get { return num_drinks; }
            set { num_drinks = value; } 
        }

        public Barman(string name, string status): base(name , status){
            setValues(name, status);
        }

        public void makeDrink(Orders orders){
            KeyValuePair<string, int> BarmanServed = orders.chosenDrink;

            Console.WriteLine("");
            Console.WriteLine("Barman serverd: ");
            Console.WriteLine(BarmanServed);
            num_drinks++;

        }
    }
}