using System;

namespace c{
    class Table: Restaurant, ITable{
        public int quality ;
        
        public int Quality{
            get { return this.quality; }
            set { this.quality = value; } 
        }

        public int table(Client client){
            Random rand = new Random();
            this.quality = rand.Next(1, 6);
            return  this.quality;
        }

        public void TableQuality(Client client){
            if (this.quality == 0){
                client.Happiness -= 3;
                Console.WriteLine("Client is going to kill someone!");
            }

            else if (quality == 1){
                client.Happiness -= 2;
                Console.WriteLine("Client is really angry");
            }

            else if (quality == 2){
                client.Happiness -= 1;
                Console.WriteLine("Client is mad");
            }

            else if (quality == 3){
                client.Happiness += 1;
                Console.WriteLine("Client is chill");
            }

            if (quality == 4){
                client.Happiness += 2;
                Console.WriteLine("Client is satisfied");
            }

            if (quality == 5){
                client.Happiness += 3;
                Console.WriteLine("Client is really happy!");
            }
        }
    }

}