using System;

class VeggieMarket
{
	static void Main()
	{
		// Input
		decimal veggiePrice = decimal.Parse(Console.ReadLine());
		decimal fruitPrice = decimal.Parse(Console.ReadLine());
		decimal veggies = decimal.Parse(Console.ReadLine());
		decimal fruit = decimal.Parse(Console.ReadLine());

		decimal result;
		decimal rate = 1.94m;

		// Logic
		result = veggiePrice * veggies + fruitPrice * fruit;
		result /= rate;

		// Output
		Console.WriteLine(result);
	}
}
