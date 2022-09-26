using System;

namespace c{
    
    class Program{

        static void Main(){

            Restaurant restaurant = new Restaurant("NK", "Studencheskaya street");
            restaurant.printValues();

            Waiter waiter = new Waiter();
            waiter.setValues();
            waiter.printValues();
            waiter.takeOrders();

            Chief chief = new Chief();
            chief.setValues();
            chief.printValues();

            Barman barman = new Barman();
            barman.setValues();
            barman.printValues();

            Administrator administrator = new Administrator();
            administrator.setValues();
            administrator.printValues();

            Cleaners cleaners = new Cleaners();
            cleaners.setValues();
            cleaners.printValues();


            Security security = new Security();
            security.setValues();
            security.printValues();

            Reception reception = new Reception();
            reception.setValues();
            reception.printValues();

            Menu menu = new Menu();
            menu.setValues();
            menu.printValues();

            Orders orders = new Orders();
            orders.setValues("pizza", 100);
            orders.printValues();


        }

    } 

}