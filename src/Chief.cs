using System;

namespace c{

    class Chief{
        private string name;
        private int age;
        private int work_experience;
        private int num_of_awards;


        public void setValues(){
            Console.WriteLine("Enter the data of the Chief: ");
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the work experience: ");
            work_experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Michelin stars: ");
            num_of_awards = Convert.ToInt32(Console.ReadLine());
        }

        public void printValues(){
            System.Console.WriteLine(" name: " + name);
            Console.WriteLine(" Number of Michelin stars: " + num_of_awards);
        }
    }
}