using System;

namespace c{

    class Barman{
        private int grade;
        private Waiter waiter;
        private Orders orders;
        private int num_drinks;

        public int Grade{
            get { return grade; }
            set { grade = value; } 
        }

        public int Num_Drinks{
            get { return num_drinks; }
            set { num_drinks = value; } 
        }

        public void makeDrink(Orders orders){
            KeyValuePair<string, int> drink = orders.pickDrink();
            Console.WriteLine("");
            Console.WriteLine("Barman served a ");
            orders.pickDrink();
            Console.WriteLine(drink);
            num_drinks++;

        }


       
    }
}