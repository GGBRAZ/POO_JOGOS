using System;
using POO_JOGOS.src.Entities;

namespace POO_JOGOS
{
  class Program
  {
    static void Main(string[] args)
    {
      Knight arus = new Knight("Arus", 23, "Knight");
      Wizard jenica = new Wizard("Jenica", 23, "White Wizard");

      Console.WriteLine(arus.Attack());
      Console.WriteLine(jenica.Attack(8));

    }
  }
}
