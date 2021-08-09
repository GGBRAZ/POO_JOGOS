namespace POO_JOGOS.src.Entities
{
  public class Ninja : Hero
  {
    public Ninja(string name, int level, string heroType) : base(name, level, heroType)
    {
    }

    public override string Attack()
    {
      return $"{this.Name} atacou com shurikens!!";
    }

  }
}