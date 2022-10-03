using System;

namespace c{
    class Person: Restaurant{

        new protected string name;
        private int workExperience;
        private int grade;
        private string greetings;
        protected string status;
        private int salary;

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public int WorkExperience { 
            get { return workExperience; }
            set { workExperience = value; }
        }

        public int Grade{
            get { return grade; }
            set { grade = value; } 
        }

        public string Greetings{
            get { return greetings; }
            set { greetings = value; }
        }

        public string Status{
            get { return status; }
            set { status = value; }
        }

        public int Salary{
            get { return salary; }
            set { salary = value; }
        }

        public Person(string name, string status){
            setValues(name, status);
        }

        new public void setValues(string name, string status){
            this.name = name;
            this.status = status;
        }

        public void workExperienceCheck(){

            Random rand = new Random();
            workExperience = rand.Next(1, 6);

            if (workExperience <= 2){
                grade = rand.Next(1, 3);
            }
            else if (workExperience >2){
                grade = rand.Next(3, 6);
            }
        }

        public virtual void speak(){
            Console.WriteLine("Hello, my name is " + name + " and I am the " + status + " in this restaurant! ");
        }
    }
}