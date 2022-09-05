class CarDealer
{
    public List<Car> inv= new List<Car>();

    
    private void printInv(){
        foreach (var item in this.inv)
        {
            Console.WriteLine("En " + item.constructor +" af modellen " + item.model);
        }
    }

    public void removeCar(Car cartoremove){
         this.inv.Remove(cartoremove);
    }

    public void addCar(Car cartoadd){
    this.inv.Add(cartoadd);
    }
    public Car getCarAnswer(){
        foreach (var item in inv)
        {
            Console.Write("'"+item.model+ "', ");
        }
        string input = Console.ReadLine();
        foreach (var item in this.inv)
        {
            if(input==item.model){
                return item;
            }
        }
        return this.inv[1];
    }


    public Car pitch(){
        Console.WriteLine("Okay, lige nu har jeg: ");
        this.printInv();
        Console.WriteLine("Hvilken model skal vi kigge på?: ");
        Car bil = getCarAnswer();
        bil.info();
        return bil;

    }
}

