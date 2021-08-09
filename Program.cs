using System;
using POO_JOGOS.src.Entities;

namespace POO_JOGOS
{
  class Program
  {
    static void Main(string[] args)
    {
      Arus arus = new Arus("Arus", 23, "Knight");
      Jenica jenica = new Jenica("Jenica", 23, "White Wizard");

      Console.WriteLine(arus.Attack());
      Console.WriteLine(jenica.Attack());

    }
  }
}
