namespace POO_JOGOS.src.Entities
{
  public abstract class Hero
  {
    public Hero(string name, int level, string heroType)
    {
      Name = name;
      Level = level;
      HeroType = heroType;
    }

    public string Name { get; private set; }
    public int Level { get; private set; }
    public string HeroType { get; private set; }

    public override string ToString()
    {
      return $"Name: {this.Name}, Level: {this.Level}, HeroType:{this.HeroType}";
    }
    public virtual string Attack()
    {
      return $"{this.Name} atacou com a espada";
    }
  }
}