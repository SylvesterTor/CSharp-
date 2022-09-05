class Kvitering{
	public void space(int space){
		for (int i = 0; i < space; i++)
		{
			Console.WriteLine("\n");	
		}
	}
	public void printReceipt(Car car){
		space(2);
		Console.WriteLine("Tillykke!\n Du er nu ejeren af en "+car.model+"!!");
		space(2);
	}
}
