﻿#region Assignment

//Create a CarDealer program
//Minimum requirements:
//The CarDealer must have a list of available cars for sale
//The CarDealer must have public Buy/Sell methods
//These methods must be accessiable via console input/output
//These methods must change the car dealers available cars
//Make use of atleast 5 classes.
//These classes must have atleast 1 Field variable each
//Classes are usually nouns (navneord, en/et foran), f.x.:
//Car, CarDealer, Engine, Person
//Make use of atleast 10 methods
//5 of these methods must use paramaters
//Methods usually describes verbs (udsagnsord, at/jeg foran)
//Buy, Sell, Accelerate, Move


// Suggestion to get started on user interaction in the console


CarDealer dealer = new CarDealer(); //This class you need to create yourself!
Car bmwX5 = new Car("BMW","X5",40000,200,2023,"gas",dealer.inv);
Car bmwX6 = new Car("BMW","X6",50000,300,2023,"gas",dealer.inv);
Car bmwZ4 = new Car("BMW","Z4",30000,150,2023,"gas",dealer.inv);
Car audiA5 = new Car("Audi","A5",55555,400,2023,"gas",dealer.inv);
Car mercedesG63 = new Car("Mercedes","G 63",99999,250,2023,"gas",dealer.inv);
Car jaguarFtype = new Car("Jaguar","F type",123241,180,2023,"gas",dealer.inv);

dealer.buy();
string answer = Console.ReadLine();

/*


while(true){

    Console.WriteLine("Write an action [buy, sell, exit]");
    string input = Console.ReadLine();

    switch (input)
    {
        case "buy":
            //Car myNewCar = dealer.buy(...);
            break;
        case "sell":
            break;
        case "exit":
            return;
        default:
            return;
    }
}*/

#endregion
