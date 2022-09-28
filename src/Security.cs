using System;

namespace c{

    class Security{
       private Client client;

       public void goHome(Client client){
            if (client.Happiness < -5){
                client.Num--;
            }
            
            else if (client.Happiness > 10){
                client.Num--;
            }
       }
    }
}