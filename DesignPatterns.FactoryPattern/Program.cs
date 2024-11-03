

BoardOfDirectors BoardOfDirectors = new CTO();

IHire hire1 = BoardOfDirectors.FindEmployee("developer");
IHire hire2 = BoardOfDirectors.FindEmployee("designer");

public interface IHire
{
  string GetPosition(string type);
  void Work();
}

public class Developer : IHire
{
  public string GetPosition(string type)
  {
    return "Developer";
  }

  public void Work()
  {
    Console.WriteLine("Developing...");
  }
}

public class Designer : IHire
{
  public string GetPosition(string type)
  {
    return "Designer";
  }

  public void Work()
  {
    Console.WriteLine("Making Design ....");
  }
}

public abstract class BoardOfDirectors
{
  protected abstract IHire MakePosition(string type);

  public IHire FindEmployee(string type)
  {
    IHire hire = MakePosition(type);

    hire.GetPosition(type);
    hire.Work();

    return hire;
  }
}

public class CTO : BoardOfDirectors
{
  protected override IHire MakePosition(string type)
  {
    return type switch
    {
      "developer" => new Developer(),
      "designer" => new Designer(),
      _ => throw new ArgumentException("Invalid", nameof(type))
    };
  }
}

public class CEO : BoardOfDirectors
{
  protected override IHire MakePosition(string type)
  {
    return type switch
    {
      "developer" => new Developer(),
      "designer" => new Designer(),
      _ => throw new ArgumentException("Invalid", nameof(type))
    }; throw new NotImplementedException();
  }
}