using System;

namespace c{

    class Administrator: HighLevel{

        public Administrator(string name, string status): base(name, status){
            setValues(name, status);
        }
        
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