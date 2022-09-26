using System;

namespace c{

    class Restaurant{

        private string name;

        private string adress;


        public Restaurant(string _name, string _adress){
            System.Console.WriteLine("Object has been created");
            setValues(_name, _adress);
        }
        

        public void setValues(string _name, string _adress){
            name = _name;
            adress = _adress;
        }

        public void printValues(){
            System.Console.WriteLine(" name: " + name + " adress: " + adress);
        }
    }
}