using System;

namespace c{
    class Table{
        private int Quality ;
        
        public int quality{
            get { return Quality; }
            set { Quality = value; } 
        }

        public int table(Client client){
            Random rand = new Random();
            Quality = rand.Next(1, 5);
            return  Quality;
        }

        public void TableQuality(int Quality, Client client){
            if (Quality == 0){
                client.Happiness -= 3;
                Console.WriteLine("Client is going to kill someone!");
            }

            else if (Quality == 1){
                client.Happiness -= 2;
                Console.WriteLine("Client is really angry");
            }

            else if (Quality == 2){
                client.Happiness -= 1;
                Console.WriteLine("Client is mad");
            }

            else if (Quality == 3){
                client.Happiness += 1;
                Console.WriteLine("Client is chill");
            }

            if (Quality == 4){
                client.Happiness += 2;
                Console.WriteLine("Client is satisfied");
            }

            if (Quality == 5){
                client.Happiness += 3;
                Console.WriteLine("Client is really happy!");
            }
        }
    }

}