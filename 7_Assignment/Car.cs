class Car
{
    #region variables
    public int price;
    public int lowprice=0;
    public int doors;
    public int topspeed;
    public string constructor;
    public int available;
    public string model;
    public string type; 

    #endregion

    #region constructor

    public Car(string _constructor, string _model, int _price, int _topspeed, int _available, string _type, List<Car> inv ){
        this.price=_price;
        this.constructor=_constructor;
        this.model=_model;
        this.topspeed=_topspeed;
        this.available=_available;
        this.type=_type;
        inv.Add(this);
    }

    public void RemoveFromInventory(List<Car> inv){

    } 

    public void info(){
        Console.WriteLine("Vores " + constructor + " af modellen " + model + " er en rigtig god bil.");
        Console.WriteLine("Den har en topfart på " + topspeed + " og så er det en "+ type + " bil");
        Console.WriteLine("Den kan være din for kun " + price + " dollars. Desværre vil den først være tilgængelig på et tidspunkt i" + available);
    }
    #endregion
}


