class Buyer {
    #region  variabler
    public int budget;
    public List<Car> cars=new List<Car>();

    #endregion
    public Buyer(int _budget){
        this.budget = _budget;
    }

    public bool buy(Car carToBuy){
        if(this.budget>=carToBuy.price){
        this.budget -= carToBuy.price;
        Console.WriteLine("That cost " + carToBuy.price + " dollar.");
        this.cars.Add(carToBuy);
        carToBuy.price=carToBuy.price/2;
        Console.WriteLine("You have just added " + carToBuy.constructor + carToBuy.model + " to your inventory.");
        return true;
        }else{
            Console.WriteLine("You do not have enough money to buy that car.");
            return false;  
        }
    }


    public void printInv(){
        if(this.cars.Count>0){
        Console.WriteLine("You have these cars in your inventory: ");
        foreach (var item in cars)
        {
            Console.WriteLine(item.constructor +item.model);
        }
        Console.WriteLine("And you have " + this.budget+ " in your bank account.");
        }else{
        Console.WriteLine("You have no cars, and " + this.budget+ " in your account");}
    }
    public void testRide(Car car){
        Console.WriteLine("You drive onto the moterway in the "+car.model+". After a while you test the car and drive "+car.topspeed+"km/h");
        Console.WriteLine("When you get back you hand the dealer the keys.");
    }

    public void sell(CarDealer dealer){
        printInv();
        Console.WriteLine("\nWhat would you like to sell?");
        string awnser= Console.ReadLine();
        bool sell = false;
        foreach (Car car in cars)
        {
            if (car.constructor + car.model == awnser){
                sell = true;
                this.budget = this.budget + car.price;
                cars.Remove(car);
                Console.WriteLine("You sold your model "+car.model+" for "+car.price+"!");
                dealer.addCar(car);
                break;
            }
        }
        if (sell == false){
            Console.WriteLine("\nYou stumbled a bit on your words:");
            this.sell(dealer);
        }
    }
}