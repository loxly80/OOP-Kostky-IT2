using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kostky_IT2
{
  public class Kostka
  {
    private Random random = new Random();
    public int Hodnota = 1;

    public void Hod()
    {
      Hodnota = random.Next(1, 7);
    }
  }
}
