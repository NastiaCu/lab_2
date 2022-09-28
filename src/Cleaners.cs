using System;

namespace c{

    class Cleaners{
        private Table table;
        private Client client;
        private int clean;
        
        public int Clean{
            get { return clean; }
            set { clean = value; } 
        }

        public void cleaning(Client client){
            Console.WriteLine("");
            Random rand = new Random();
            clean = rand.Next(1, 3);
            if (clean == 1){
                client.Happiness--;
                Console.WriteLine("Very bad!");
            }
            else if (clean == 2){
                client.Happiness++;
                Console.WriteLine("Nice!");
            }

        }
       
    }
}