using System;

namespace c{

    class Waiter{
        private string name;
        private int age;
        private int work_experience;
        private float grade;


        public void setValues(int _age, int _work_experience, float _grade){
            name = Console.ReadLine();
            age = _age;
            work_experience = _work_experience;
            grade = _grade;
        }

        public void printValues(){
            System.Console.WriteLine(" name: " + name + " Work experience: " + work_experience);
        }

        // Method to take the orders from the clients
        public void takeOrders(){
            System.Console.ReadLine();
        }

    }
}