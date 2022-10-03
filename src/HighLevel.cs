using System;

namespace c{
    class HighLevel: Person{

        public HighLevel(string name, string status): base(name, status){
            setValues(name, status);
        }

        public virtual void whatSalary(string status, Table table, LowLevel lowlevel){
            if (table.Quality <= 3){
                lowlevel.Salary -= 100;
            }
            else if (table.Quality > 3){
                lowlevel.Salary +=100;
            }
            Console.WriteLine("The " + status + " got " + lowlevel.Salary);
        } 
        
    }
}