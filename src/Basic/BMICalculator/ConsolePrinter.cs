namespace BMICalculator
{
    public static class ConsolePrinter
    {
        public static void PrintError()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The input you entered was invalid! Try, again.");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void PrintEnterCentimetersMessage()
        {
            Console.WriteLine("Now enter your centimeters below.");
            Console.Write("Centimeters: ");
        }

        public static void PrintEnterMetersMessage()
        {
            Console.WriteLine("Enter your meters below.");
            Console.Write("Meters: ");
        }

        public static void PrintEnterWeightMessage()
        {
            Console.WriteLine("Enter your weight in kilograms below.");
            Console.Write("Weight: ");
        }

        public static void PrintDashedLine() => Console.WriteLine(new string('-', 50));

        public static void PrintBMIResult(double bmi)
        {
            if (bmi < 16)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You're quite underweight. A health check-up might be a good idea!");
            }
            else if (bmi < 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You're underweight. Consider a balanced diet to gain strength!");
            }
            else if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You're slightly underweight. A little more nutrition could help!");
            }
            else if (bmi < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Great! You have a healthy weight. Keep it up!");
            }
            else if (bmi < 30)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You're a bit above the ideal weight. Staying active can help!");
            }
            else if (bmi < 35)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Carrying extra weight. A healthy routine could make a difference!");
            }
            else if (bmi <= 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Your weight is quite high. Consulting a professional may be helpful!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Health alert! Consider talking to a doctor for guidance.");
            }

            Console.ResetColor();
        }
    }
}
