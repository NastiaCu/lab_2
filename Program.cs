using System;


namespace c{
    
    class Program{

        static void Main(){

            Random random = new Random();
            int NumOfDays = 0;

            while (true){

                int Count = 0;
                int num = 0;
                
                Orders orders = new Orders();

                NumOfDays++;
                int NumOfClients = random.Next(1, 11);
                int NumOfWaiters = random.Next(1, 7);
                
                List<Client> clients = new List<Client>();
                Restaurant restaurant = new Restaurant();
                Menu menu = new Menu();
                
                restaurant.setValues("NK", "Studencheskaya street");
                restaurant.printValues();  
                Console.WriteLine();
            
                Console.WriteLine("#########################");
                Console.WriteLine("Number of clients: " + NumOfClients);
                Console.WriteLine("In day: " + NumOfDays);
                Console.WriteLine("#########################");
                
                menu.createMain();
                menu.createSup();
                menu.createDrink();
                menu.dispMain();
                menu.dispSup();
                menu.dispDrink();

                for (int i = 0; i < NumOfClients; i++){
                    clients.Add(new Client(orders));
                }

                for (int i = 0; i < clients.Count(); i++){
                    
                    Client client = clients[i];
                    Console.WriteLine();
                    Console.WriteLine("Client number: " + (i+1));

                    Table table = new Table(client);                
                    
                    Waiter waiter = new Waiter(client, orders, "waiter");
                    Barman barman = new Barman(client, orders, "barman");
                    Chief chief = new Chief(client, orders, "chief");
                    Cleaners cleaners = new Cleaners();
                    Administrator administrator = new Administrator(waiter, client);
                    Security secutity = new Security(waiter, client);

                    table.table();

                    administrator.setTable(i);

                    if (administrator.GoHome(i) == 0){
                        break;
                    }

                    waiter.workExperienceCheck();
                    chief.workExperienceCheck();
                    barman.workExperienceCheck();

                    waiter.speak();
                    client.choose();
                    
                    barman.makeDrink();
                    barman.speak();
                    barman.qualityCheck();
                    
                    chief.cook();
                    chief.qualityCheck();
                    chief.speak();
                    
                    waiter.qualityCheck();
                    waiter.bill();

                    administrator.Grade();

                    Console.WriteLine("Client's happiness level: " + client.Happiness);

                    client.pay(waiter.ToPay);
                    secutity.washDishes();

                    administrator.setRaiting(waiter);
                    administrator.setRaiting(chief);
                    administrator.setRaiting(barman);

                    administrator.whatSalary(waiter, "waiter",  waiter.rating);
                    administrator.whatSalary(chief, "chief", chief.rating);
                    administrator.whatSalary(barman, "barman", barman.rating);

                    Console.WriteLine("");

                    table.TableQuality();
                    Console.WriteLine(table.quality);
                    administrator.setStatus();
                    
                    num = administrator.stars;

                    Count += waiter.ToPay;
                    Console.WriteLine("Today's restaurant's profit is: " + Count);
                    Console.WriteLine("Number of stars: " + num);   

                    Console.WriteLine();
                    Console.WriteLine();

                }
            }
        }
    }
} 


