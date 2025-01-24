int number = int.Parse(Console.ReadLine());

bool isPrime = true;

if (number <= 1)
{
	isPrime = false;
}
else
{
	int limit = (int)Math.Sqrt(number);

	for (int i = 2; i <= limit; i++)
	{
		if (number % i == 0)
		{
            isPrime = false;
			break;
        }
	}
}

if (isPrime)
{
    Console.WriteLine("The entered number is a prime number! Goodbye!");
}
else
{
    Console.WriteLine("The entered number is not a prime number! Goodbye!");
}