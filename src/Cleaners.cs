using System;

namespace c{

    class Cleaners: LowLevel{

        private int clean;
        new protected int Salary = 3000;

        public Cleaners(string name, string status): base(name , status){
            setValues(name, status);
        }
        
        public int Clean{
            get { return clean; }
            set { clean = value; } 
        }

        
    }
}