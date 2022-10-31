using System;

namespace c{

    class Restaurant{

        protected string name;

        protected string adress;

        public void setValues(string name, string adress){
            this.name = name;
            this.adress = adress;
        }

        public void printValues(){
            System.Console.WriteLine("Name of the restaurant: " + name );
            System.Console.WriteLine("Adress of the restaurants: " + adress);
        }

        // public void setStatus(){
        //     if (client.happiness > 5){
        //         stars++;
        //     }
        //     else if (client.happiness <= 5){
        //         stars--;
        //     }
        // }
    }
}