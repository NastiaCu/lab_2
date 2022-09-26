using System;

namespace c{

    class Menu{
        private string name;
        private int price;
        private int weight;
        private string description;


        public void setValues(){
            name = Console.ReadLine();
            price = Convert.ToInt32(Console.ReadLine());
            weight = Convert.ToInt32(Console.ReadLine());
            description = Console.ReadLine();
        }

        public void printValues(){
            System.Console.WriteLine(" Name: " + name);
            System.Console.WriteLine(" Price: " + price);
        }
    }
}