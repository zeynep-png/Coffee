
List<string> coffee = new List<string>();

Console.WriteLine("---- Favori Kahve Listenizi Oluşturun ---- ");


for (int i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\nKahve " + (i + 1) + ": ");
    Console.ForegroundColor = ConsoleColor.Green;
    coffee.Add(Console.ReadLine());
    Console.ResetColor();

}


Console.WriteLine("\n\n---- Favori Kahve Listeniz ---- ");

for (int i = 0; i < coffee.Count; i++)
{
    Console.WriteLine((i + 1) + "- " + coffee[i]);
}