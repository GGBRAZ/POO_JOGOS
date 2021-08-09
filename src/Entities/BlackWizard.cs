namespace POO_JOGOS.src.Entities
{
  public class BlackWizard : Hero
  {
    public BlackWizard(string name, int level, string heroType) : base(name, level, heroType)
    {
    }

    public override string Attack()
    {
      return $"{this.Name} atacou com magia negra forte";
    }
  }
}