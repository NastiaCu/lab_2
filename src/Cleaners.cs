using System;

namespace c{

    class Cleaners{
        string name;
        int age;
        int work_experience;

        public void setValues(){
            Console.WriteLine("Enter the data of the cleaner: ");
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the work experience: ");
            work_experience = Convert.ToInt32(Console.ReadLine());
        }

        public void printValues(){
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Work experience " + work_experience);
        }
    }
}