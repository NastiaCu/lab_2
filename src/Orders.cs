using System;

namespace c{

    class Orders{

        private string name;
        private int price;

        public void setValues(string _name, int _price){
            name = _name;
            price = _price;
        }

        public void printValues(){
            System.Console.WriteLine(" Name: " + name);
            Console.WriteLine(" Price: " + price);
        }

        public void Bill(){
            price += price;
        }
    }
}