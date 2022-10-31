using System;

namespace c{
    abstract class LowLevel: Person{

        public int num_orders;
        public int rating;
        new public int grade;
        public int salary;
        public Client client;
        public Orders orders;
        public string status;

        public LowLevel(Client client, Orders orders, string status){
            this.client = client;
            this.orders = orders;
            this.status = status;
        }


        public int Num_orders{ 
            get { return num_orders; }
            set { num_orders = value; } 
        }

        public int Rating{
            get { return rating; }
            set { rating = value; }
        }

        public int Grade{
            get { return grade; }
            set { grade = value; } 
        }

        public int Salary{
            get { return salary; }
            set { salary = value; }
        }

        public void qualityCheck(){
           
            Console.WriteLine("");
            Random rand = new Random();
            rating = rand.Next(1, 3);
            
            if (rating == 1){
                client.Happiness--;
                Console.WriteLine(status + " did his work very bad!");
            }
            
            else if (rating == 2){
                client.Happiness++;
                Console.WriteLine(status + " did his work really nice!");
            }
        }

        public virtual void speak(){
            Console.WriteLine("I am the " + status + " in this restaurant! ");
        }
    }
}