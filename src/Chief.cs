using System;

namespace c{

    class Chief: LowLevel{
        private string main;
        private string supplies;
        new protected int salary = 5000;
        new private Orders orders;
        new private Client client; 
        new public string status;
        new public int rating = 5;

        public Chief(Client client, Orders orders, string status): base(client, orders, status){
            this.client = client;
            this.orders = orders;
            this.status = status;
        }

        public string Main{
            get { return main; }
            set { main = value; } 

        }

        public string Supplies{
            get { return supplies; }
            set { supplies = value; } 
        }

        public void cook(){

            KeyValuePair<string, int> chiefCookedMain = orders.chosenMain;
            KeyValuePair<string, int> chiefCookedSup = orders.chosenSup;

            Console.WriteLine("");

            Console.WriteLine("Chief cooked ");
            Console.WriteLine(chiefCookedMain);
            Console.WriteLine(chiefCookedSup);

        }

        public override void speak(){
            base.speak();
            
            if (this.rating == 1){
            Console.WriteLine("I've got more Michelin stars than the years you've lived on earth, so eat and don't show off");
            }

            if (this.rating == 2){
                Console.WriteLine("Enjoy your meal!");
            }

        }
    }
}