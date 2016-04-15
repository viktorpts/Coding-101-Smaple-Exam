using System;

class Division
{
	static void Main()
	{
		// Input
		int n = int.Parse(Console.ReadLine());

		int counter1 = 0;
		int counter2 = 0;
		int counter3 = 0;

		double p1;
		double p2;
		double p3;

		// Logic
		for (int i = 0; i < n; i++)
		{
			int current = int.Parse(Console.ReadLine());

			if (current % 2 == 0)
			{
				counter1++;
			}
			if (current % 3 == 0)
			{
				counter2++;
			}
			if (current % 4 == 0)
			{
				counter3++;
			}
		}

		p1 = (double)counter1 / (double)n * 100;
		p2 = (double)counter2 / (double)n * 100;
		p3 = (double)counter3 / (double)n * 100;

		Console.WriteLine("{0:f2}%", p1);
		Console.WriteLine("{0:f2}%", p2);
		Console.WriteLine("{0:f2}%", p3);
	}
}