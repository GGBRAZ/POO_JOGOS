namespace POO_JOGOS.src.Entities
{
  public class Wizard : Hero
  {
    public Wizard(string name, int level, string heroType) : base(name, level, heroType)
    {

    }

    public override string Attack()
    {
      return $"{this.Name} atacou com magia!";
    }
    public string Attack(int bonus)
    {
      if (bonus > 6)
      {
        return $"{this.Name} atacou com magia forte bonus:{bonus}!";
      }
      else
      {
        return $"{this.Name} atacou com magia fraca bonus: {bonus}!";
      }
    }


  }
}