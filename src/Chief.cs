using System;

namespace c{

    class Chief: LowLevel{
        private string main;
        private string supplies;
        new protected int Salary = 5000;

        public string Main{
            get { return main; }
            set { main = value; } 

        }

        public string Supplies{
            get { return supplies; }
            set { supplies = value; } 
        }

        public Chief(string name, string status): base(name, status){
            setValues(name, status);
        }

        public void cook(Orders orders){

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