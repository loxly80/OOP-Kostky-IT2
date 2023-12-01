using OOP_Kostky_IT2;

Kostka kostka1 = new Kostka();
Kostka kostka2 = new Kostka();
Kostka kostka3 = new Kostka();
Kostka kostka4 = new Kostka();
Kostka kostka5 = new Kostka();
Kostka kostka6 = new Kostka();


do
{
  kostka1.Hod();
  kostka2.Hod();
  kostka3.Hod();
  kostka4.Hod();
  kostka5.Hod();
  kostka6.Hod();
  Console.WriteLine($"Hozeno: {kostka1.Hodnota} - {kostka2.Hodnota} - {kostka3.Hodnota} - {kostka4.Hodnota} - {kostka5.Hodnota} - {kostka6.Hodnota}");
}while (Console.ReadKey().Key != ConsoleKey.Escape);
