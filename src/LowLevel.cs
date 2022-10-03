using System;

namespace c{
    class LowLevel: Person{

        public int num_orders;
        public int rating;

        public LowLevel(string name, string status): base(name, status){
            setValues(name, status);
        }

        public int Num_orders{ 
            get { return num_orders; }
            set { num_orders = value; } 
        }

        public int Rating{
            get { return rating; }
            set { rating = value; }
        }

        public void qualityCheck(Client client){
           
            Console.WriteLine("");
            Random rand = new Random();
            rating = rand.Next(1, 3);
            
            if (rating == 1){
                client.Happiness--;
                Console.WriteLine("Very bad!");
            }
            
            else if (rating == 2){
                client.Happiness++;
                Console.WriteLine("Nice!");
            }
        }
    }
}