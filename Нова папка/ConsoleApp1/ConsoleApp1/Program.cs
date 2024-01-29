Console.WriteLine("Въведете числа, разделени с точка:");
string inputNumbers = Console.ReadLine();

List<double> numbers = inputNumbers.Split('.').Select(double.Parse).ToList();

double average = numbers.Average();
double mode = numbers.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
double median = numbers.OrderBy(n => n).ElementAt(numbers.Count / 2);

Console.WriteLine($"Средно аритметично: {average}");
Console.WriteLine($"Мода: {mode}");
Console.WriteLine($"Медиана: {median}");