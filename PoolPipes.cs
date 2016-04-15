using System;

class PoolPipes
{
	static void Main()
	{
		// Input
		int volume = int.Parse(Console.ReadLine());
		int p1 = int.Parse(Console.ReadLine());
		int p2 = int.Parse(Console.ReadLine());
		double time = double.Parse(Console.ReadLine());

		double result;
		double overflow;

		// Logic
		double pipe1Volume = p1 * time;
		double pipe2Volume = p2 * time;
		double total = pipe1Volume + pipe2Volume;
		double filled = total / volume * 100;
		double pipe1Total = pipe1Volume / total * 100;
		double pipe2Total = pipe2Volume / total * 100;

		overflow = total - volume;

		if (overflow > 0)
		{
			Console.WriteLine("For {0} hours the pool overflows with {1} liters.", time, overflow);
        } 
		else
		{
			Console.WriteLine("The pool is {0:f0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", (int)filled, (int)pipe1Total, (int)pipe2Total);
        }
	}
}
