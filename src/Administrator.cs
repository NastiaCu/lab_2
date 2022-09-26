using System;

namespace c{

    class Administrator{
        private string name;
        private int age;
        private int work_experience;
        private int grade;


        public void setValues(){
            Console.WriteLine("Enter the data of the administrator: ");
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the work experience: ");
            work_experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the grade: ");
            grade = Convert.ToInt32(Console.ReadLine());
        }

        public void printValues(){
            System.Console.WriteLine(" name: " + name);
            Console.WriteLine(" Work experience: " + work_experience);
        }
    }
}