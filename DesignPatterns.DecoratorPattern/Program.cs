




ICoffe coffe1 = new BlackCoffe();
Console.WriteLine($"{coffe1.Description}: {coffe1.Price()} TL");

coffe1 = new MilkDecorator(coffe1);
Console.WriteLine($"{coffe1.Description}: {coffe1.Price()} TL");




public interface ICoffe
{
  string Description { get; }
  double Price();
}

public class BlackCoffe : ICoffe
{
  public string Description => "Black Coffe";

  public double Price()
  {
    return 100.0;
  }
}

public abstract class CoffeDecorator : ICoffe
{

  public ICoffe _coffe { get; set; }

  public CoffeDecorator(ICoffe coffe)
  {
    _coffe = coffe;
  }
  public virtual string Description => _coffe.Description;

  public virtual double Price()
  {
    return _coffe.Price();
  }
}

public class MilkDecorator : CoffeDecorator
{
  public MilkDecorator(ICoffe coffe) : base(coffe)
  {
  }

  public override string Description => _coffe.Description+" Milk";

  public override double Price()
  {
    return _coffe.Price() + 52;
  }


}