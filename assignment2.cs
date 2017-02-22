using System;

class paintJobPrice
{
	static void Main()
	{
		//Variables
		string name;
		int rooms;
		double paintPrice;
		
		double paintAmount;
		double wallSpace;
		double paintPriceBTax;
		double paintVat;
		double paintTotal;
		
		double labourHours;
		double labourCost;
		double labourVat;
		double labourTotal;
		
		double total;
		double totalSterling;
		
		//Input
		Console.Clear();
		Console.Write("Please enter your name: ");
		name = Console.ReadLine();
		Console.Write("Please enter the number of rooms: ");
		rooms = int.Parse(Console.ReadLine());
		Console.Write("Now, please, enter the size of room in square feet: ");
		wallSpace = double.Parse(Console.ReadLine());
		Console.Write("Lastly, please enter the price per gallon of paint: ");
		paintPrice = double.Parse(Console.ReadLine());
		
		//Process
			//Date
		//date = dateTime.ToString("dd/MM/yyyy");
		
			//Paint
		paintAmount = wallSpace * rooms / 150;		//Amount of gallons
		paintPriceBTax = paintAmount * paintPrice;	//Cost of paint
		paintVat = paintPriceBTax * 0.2;			//Paint VAT
		paintTotal = paintPriceBTax + paintVat;		//Paint Total
		
			//Labour
		labourHours = paintAmount * 8;				//Labour Hours
		labourCost = labourHours * 20.00;			//Labour Cost without tax
		labourVat = labourCost * 0.10;				//Labour Vat
		labourTotal = labourCost + labourVat;		//Labour total
		
			//Total Cost
		total = paintTotal + labourTotal;			//Total in euro
		totalSterling = total * 0.85;				//Total in sterling
		
			//Output
		Console.WriteLine();
		Console.WriteLine("Job Quote");
		Console.WriteLine("=========");
		Console.WriteLine("{0,-10}{1,7}{2,25}","Date",":", DateTime.Today.ToString("d"));
		Console.WriteLine("{0,-10}{1,4}{2,20}","Customer Name",":", name);
		Console.WriteLine("\nTotal Number of Gallons: {0:f2}", paintAmount);
		Console.WriteLine("Total Hours of Labour: {0:f2}", labourHours);
		Console.WriteLine("-------------------------------------------------");
		Console.WriteLine("Cost of paint: {0:n2}", paintPriceBTax);
		Console.WriteLine("Paint Vat: {0:n2}", paintVat);
		Console.WriteLine("Total Cost of Paint: {0:n2}", paintTotal);
		Console.WriteLine("-------------------------------------------------");
		Console.WriteLine("Labour Cost: {0:n2}", labourCost);
		Console.WriteLine("Labour Vat: {0:n2}", labourVat);
		Console.WriteLine("Total Labour Cost {0:n2}", labourTotal);
		Console.WriteLine("-------------------------------------------------");
		Console.WriteLine("Total Cost of Job: {0:n2}", total);
		Console.WriteLine("Sterling Equivalent: {0:n2}", totalSterling);
	}
}