using System;

class Adventure
{
	static void Main()
	{
		// Input
		double budget = double.Parse(Console.ReadLine());
		string season = Console.ReadLine();

		string destination = "";
		string type = "";
		double spent = 0;

		// Logic
		if (budget <= 100)
		{
			destination = "Bulgaria";
			if (season == "summer")
			{
				type = "Camp";
				spent = 0.3 * budget;
			}
			else
			{
				type = "Hotel";
				spent = 0.7 * budget;
			}
		}
		else if (budget <= 1000)
		{
			destination = "Balkans";
			if (season == "summer")
			{
				type = "Camp";
				spent = 0.4 * budget;
			}
			else
			{
				type = "Hotel";
				spent = 0.8 * budget;
			}
		}
		else
		{
			destination = "Europe";
			type = "Hotel";
			spent = 0.9 * budget;
		}
		Console.WriteLine("Somewhere in {0}", destination);
		Console.WriteLine("{0} - {1:f2}", type, spent);
	}
}
