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

            table.table(client);

            // table.TableQuality(client);
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
            
            barman.makeDrink(orders);
            barman.speak();
            barman.qualityCheck(client, "Barman");
            
            chief.cook(orders);
            chief.qualityCheck(client, "Chief");
            chief.speak();
            
            waiter.qualityCheck(client, "Waiter");
            waiter.bill(client, orders);

            cleaners.qualityCheck(client, "Cleaner");

            administrator.speak();
            administrator.grade(client, waiter);

            Console.WriteLine(client.Happiness);

            client.pay(waiter.ToPay);
            secutity.washDishes(client);
            cleaners.speak();

            administrator.whatSalary("cleaner", cleaners, cleaners.rating);
            administrator.whatSalary("waiter", waiter, waiter.rating);
            administrator.whatSalary("chief", chief, chief.rating);
            administrator.whatSalary("barman", barman, barman.rating);


            Console.WriteLine("");

            table.TableQuality(client);
            Console.WriteLine(table.quality);

            
        
    
        }

    } 

}