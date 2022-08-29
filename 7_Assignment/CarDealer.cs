class CarDealer
{
    public List<Car> inv= new List<Car>();

    
    private void printInv(){
        foreach (var item in this.inv)
        {
            Console.WriteLine("En " + item.constructor +" af modellen " + item.model);
        }
    }

    public void buy(){
        Console.WriteLine("Okay, lige nu har jeg: ");
        this.printInv();
        Console.WriteLine("Hvilken model skal vi kigge på?: ");
        foreach (var item in inv)
        {
            Console.Write(item.model+ ", ");
        }
        string input = Console.ReadLine();
        foreach (var item in this.inv)
        {
            if(input==item.model){
                item.info();
            }
        }
    }
}