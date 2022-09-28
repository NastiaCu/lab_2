using System;

namespace c{

    class Administrator{
        private Client client;
        private Waiter waiter;


        public void grade(Client client, Waiter waiter){
            Console.WriteLine("");
            if (client.Happiness <= 2){
                waiter.Grade--;
                Console.WriteLine("The waiter now has a lower salary(");
            }
            else if (client.Happiness > 2){
                waiter.Grade++;
                Console.WriteLine("Good job!");
            }
        }

    }
}