# lab_2!
> Anastasia Cunev

> FAF-211

I decided to make a restaurant simulation. For now it contains 10 classes: `Waiter`, `Client`, `Chief`, `Administrator`, `Table`, `Cleaner`, `Security`, `Barman`, `Menu` and `Orders`. 

`Waiter` will have methods to `serve the client`, to `take orders`, to `bring the bill` and to `send orders to the chief`.

The `Chief` will have the methods to `cook the meal` and to `send it to the waiter`.

`Barman` has the method to serve drinks.

The `Client` will have the methods to `order` food and drinks and to `pay` for them. Also the client will have the `level of happiness` depending on how satisfied he is of the service or how happy he is because of some drinks. That's why I introduces `Security` and `Administrator` classes, which will help to manage the level of happiness and quietness in the restaurant.

The `Cleaners` will influence client's level of happiness by cleaning the tables.

`Tables` have the raiting, which is randomly distributes. That raiting also influences the client's happiness.

`Menu` class has methods to make menus for main dish, supplies and drinks with prices. It has such functions as `createMain`, `createSup` and `createDrink`.

`Orders` is the class which has such methods as `pickMain`, `pickSup` and `pickDrink`, which create orders randomly. 

