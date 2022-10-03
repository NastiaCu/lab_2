using System;

namespace c{
    
    class Program{

        static void Main(){

            Restaurant restaurant = new Restaurant();
            Menu menu = new Menu();
            Orders orders = new Orders();
            Table table = new Table();
            Client client = new Client("Client", "client");
            Waiter waiter = new Waiter("John", "Waiter");
            Barman barman = new Barman("Mike", "Barman");
            Chief chief = new Chief("Luidji", "Chief");
            Cleaners cleaners = new Cleaners("Galea", "Cleaner");
            Administrator administrator = new Administrator("IRA", "Administrator");
            Security secutity = new Security("Calin", "Security");

            restaurant.setValues("NK", "Studencheskaya street");
            restaurant.printValues();
            
            menu.createMain();
            menu.createSup();
            menu.createDrink();
            menu.dispMain();
            menu.dispSup();
            menu.dispDrink();

            waiter.speak();
            client.choose(orders);
            chief.cook(orders);
            barman.makeDrink(orders);

            waiter.qualityCheck(client);
            waiter.bill(client, orders);

            barman.speak();
            barman.qualityCheck(client);

            chief.speak();
            chief.qualityCheck(client);

            cleaners.qualityCheck(client);

            administrator.speak();
            administrator.grade(client, waiter);

            Console.WriteLine(client.Happiness);

            client.pay(waiter.ToPay);
            secutity.washDishes(client);
            cleaners.speak();

            administrator.whatSalary("cleaner", table, cleaners);
            administrator.whatSalary("waiter", table, waiter);
            administrator.whatSalary("chief", table, chief);
     
        }

    } 

}