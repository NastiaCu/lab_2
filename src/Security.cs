using System;

namespace c{

    class Security{
        private string name;
        private int age;
        private int work_experience;


        public void setValues(){
            Console.WriteLine("Enter the data of the bodyguard: ");
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the work experience: ");
            work_experience = Convert.ToInt32(Console.ReadLine());
        }

        public void printValues(){
            System.Console.WriteLine(" name: " + name);
            System.Console.WriteLine(" Work experience: " + work_experience);
        }

    }
}