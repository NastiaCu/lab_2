using System;

namespace c{
    abstract class HighLevel: Person{

        public HighLevel(string name, string status): base(name, status){
            setValues(name, status);
        }
        
        public virtual void whatSalary(string status, LowLevel lowlevel, int rating){
            if (rating == 1){
                lowlevel.Salary -= 100;
            }
            else if (rating == 2){
                lowlevel.Salary +=100;
            }
            Console.WriteLine("The " + status + " got " + lowlevel.Salary);
        } 
        
    }
}