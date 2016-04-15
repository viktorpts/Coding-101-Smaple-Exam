using System;

class Butterfly
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		string row1 = "";

		for (int rows = 0; rows < (n - 2); rows++)
		{
			for (int cols = 0; cols < 2 * n - 1; cols++)
			{
				string symbol = "";
				if (rows % 2 == 0) symbol = "*";
				else symbol = "-";
				if (cols <= n - 3 || cols > n) row1 += symbol;
				else if (cols == n - 2) row1 += "\\";
				else if (cols == n - 1) row1 += " ";
				else if (cols == n) row1 += "/";
			}
			Console.WriteLine(row1);
			row1 = "";
		}

		for (int i = 0; i < n - 1; i++)
		{
			row1 += " ";
		}
		row1 += "@";
		Console.WriteLine(row1);
		row1 = "";

		for (int rows = 0; rows < (n - 2); rows++)
		{
			for (int cols = 0; cols < 2 * n - 1; cols++)
			{
				string symbol = "";
				if (rows % 2 == 0) symbol = "*";
				else symbol = "-";
				if (cols <= n - 3 || cols > n) row1 += symbol;
				else if (cols == n - 2) row1 += "/";
				else if (cols == n - 1) row1 += " ";
				else if (cols == n) row1 += "\\";
			}
			Console.WriteLine(row1);
			row1 = "";
		}
	}
}