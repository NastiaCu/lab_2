# lab_3!
> Anastasia Cunev

> FAF-211

The following diagram shows the restaurant system, where `Restaurant` is the root and it has 3 child classes: `Person`, `Menu` and `Table`.
Class `Person` is the intermediate class, which has the properties for all actors in my system. It also has child classes `HighLevel` and `LowLevel`, which inheritate properties and methods of the class `Person`. 

`HighLevel` is the class parent for the classes, that have a value in the system, such as `Administrator`, `Client` and `Security`. The `LowLevel` class is the class parent for the service stuff such as `Waiter`, `Chief`, `Barman` and `Cleaners`.

I used overriding for some methods to make them more speciefic for different classes. Root has a `Menu` child class, which has `Orders` as a child class.

Short description of the system componemts: 

`Waiter` will have methods to `serve the client`, to `take orders`, to `bring the bill` and to `send orders to the chief`.

The `Chief` will have the methods to `cook the meal` and to `send it to the waiter`.

`Barman` has the method to serve drinks.

The `Client` will have the methods to `order` food and drinks and to `pay` for them. Also the client will have the `level of happiness` depending on how satisfied he is of the service or how happy he is because of some drinks. That's why I introduces `Security` and `Administrator` classes, which will help to manage the level of happiness and quietness in the restaurant.

The `Cleaners` will influence client's level of happiness by cleaning the tables.

`Tables` have the raiting, which is randomly distributes. That raiting also influences the client's happiness.

`Menu` class has methods to make menus for main dish, supplies and drinks with prices. It has such functions as `createMain`, `createSup` and `createDrink`.

`Orders` is the class which has such methods as `pickMain`, `pickSup` and `pickDrink`, which create orders randomly. 

<img width="995" alt="Graph" src="https://user-images.githubusercontent.com/96084704/193654810-429213c5-082a-4546-8007-e2ce62ca6dbf.png">
