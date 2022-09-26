using System;

namespace c{
    
    class Program{

        static void Main(){

            Restaurant Restaurant = new Restaurant("NK", "Studencheskaya street");
            Restaurant.printValues();

            Waiter Waiter = new Waiter();
            Waiter.setValues();



        }

    } 

}