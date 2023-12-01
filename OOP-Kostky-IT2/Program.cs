using OOP_Kostky_IT2;

Kostka kostka = new Kostka();

do
{
  kostka.Hod();
  Console.WriteLine($"Hozeno: {kostka.Hodnota}");
}while (Console.ReadKey().Key != ConsoleKey.Escape);
