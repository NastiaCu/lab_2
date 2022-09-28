using System;

namespace c{

    class Orders{
        private KeyValuePair<string, int> main;
        private KeyValuePair<string, int> sup;
        private KeyValuePair<string, int> drink;

        public KeyValuePair<string, int> pickMain(){
            Random random = new Random();
            Dictionary<string, int> dictionary = new Dictionary<string, int>(){
                                                                                {"chicken", 90},
                                                                                {"steak", 180},
                                                                                {"burger", 85},
                                                                                {"pizza", 140}};

            int index = random.Next(dictionary.Count);

            string key = dictionary.Keys.ElementAt(index);
            int value = dictionary.Values.ElementAt(index);

            KeyValuePair<string, int> main = dictionary.ElementAt(index);
            return main;
            // Console.WriteLine(main);
        }

        public KeyValuePair<string, int> pickSup(){
            Random random = new Random();
            Dictionary<string, int> dictionary = new Dictionary<string, int>(){
                                                                                {"fries", 50},
                                                                                {"placinte cu brinza", 40},
                                                                                {"salad", 60},
                                                                                {"bread", 10}};  

            int index = random.Next(dictionary.Count);

            string key = dictionary.Keys.ElementAt(index);
            int value = dictionary.Values.ElementAt(index);

            KeyValuePair<string, int> sup = dictionary.ElementAt(index);
            return sup;
            // Console.WriteLine(sup);
        }

        public KeyValuePair<string, int> pickDrink(){

            Random random = new Random();
            Dictionary<string, int> dictionary = new Dictionary<string, int>(){
                                                                                {"coca-cola", 25},
                                                                                {"orange juice", 50},
                                                                                {"beer", 50},
                                                                                {"lemonade", 50}};

            int index = random.Next(dictionary.Count);

            string key = dictionary.Keys.ElementAt(index);
            int value = dictionary.Values.ElementAt(index);

            KeyValuePair<string, int> drink = dictionary.ElementAt(index);
            return drink;
            //Console.WriteLine(drink);
        }
    }
}