using OOP_Kostky_IT2;

Kostka[] kostky = new Kostka[6];

for (int i = 0; i < kostky.Length; i++)
{
  kostky[i] = new Kostka();
}

do
{
  for (int i = 0; i < kostky.Length; i++)
  {
    kostky[i].Hod();
  }

  Console.WriteLine($"Hozeno: {string.Join<Kostka>(" - ", kostky)}");
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);
