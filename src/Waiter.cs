using System;

namespace c{

    class Waiter{
        public int grade = 10;
        private Orders orders;
        private int num_orders = 0;
        private Chief chief;
        private Client client;


        public int Grade{
            get { return grade; }
            set { grade = value; }
        }

        public int Num_Orders{
            get { return num_orders; }
            set { num_orders = value; }
        }

        // Method to take the orders from the clients
        public void takeOrders(Orders orders){
            orders.pickMain();
            orders.pickSup();
            orders.pickDrink();
            num_orders++;
        }

    }
}