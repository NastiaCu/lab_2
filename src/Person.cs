using System;

namespace c{
    abstract class Person: Restaurant, IPerson{

        public int workExperience;
        public int grade;
        

        public void workExperienceCheck(){

            Random rand = new Random();
            workExperience = rand.Next(1, 6);

            if (workExperience <= 2){
                grade = rand.Next(1, 3);
            }
            else if (workExperience > 2){
                grade = rand.Next(3, 6);
            }
        }
    }
}