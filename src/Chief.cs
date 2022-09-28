using System;

namespace c{

    class Chief{
        private Orders orders;
        public int grade;
        private string main;
        private string supplies;

        public int Grade{
            get { return grade; }
            set { grade = value; } 
        }

        public string Main{
            get { return main; }
            set { main = value; } 
        }

        public string Supplies{
            get { return supplies; }
            set { supplies = value; } 
        }

        public void cook(Orders orders){
            KeyValuePair<string, int> main = orders.pickMain();
            KeyValuePair<string, int> sup = orders.pickSup();

            Console.WriteLine("");
            Console.WriteLine("Chief cooked ");
            orders.pickMain();
            Console.WriteLine(main);
            orders.pickSup();
            Console.WriteLine(sup);

        }


       
    }
}