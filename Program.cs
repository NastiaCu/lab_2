using System;

namespace c{
    
    class Program{

        static void Main(){

            Restaurant restaurant = new Restaurant("NK", "Studencheskaya street");
            restaurant.printValues();

            Menu menu = new Menu();
            menu.createMain();
            menu.createSup();
            menu.createDrink();

            Orders orders = new Orders();
            orders.pickMain();
            orders.pickSup();
            orders.pickDrink();

            Client client = new Client();

            Waiter waiter = new Waiter();
            // waiter.takeOrders();

            Barman barman = new Barman();
            barman.makeDrink(orders);

            Chief chief = new Chief();
            chief.cook(orders);

            Cleaners cleaners = new Cleaners();
            cleaners.cleaning(client);

            Administrator administrator = new Administrator();
            administrator.grade(client, waiter);

        }

    } 

}