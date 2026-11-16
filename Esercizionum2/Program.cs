Console.WriteLine("Inserisci una temperatura in gradi Celsius:");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine ($"{celsius} gradi corrispondo a {fahrenheit} gradi Fahrenheit.");
