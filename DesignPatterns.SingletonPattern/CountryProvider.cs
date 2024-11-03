using DesignPatterns.SingletonPattern.Models;

namespace DesignPatterns.SingletonPattern;

public class CountryProvider
{
  private static CountryProvider instance = null;
  public static CountryProvider Instance => instance ?? (new CountryProvider());
  private new List<Country> Countries { get; set; }

  private CountryProvider()
  {
    // Retrieving data from db
    Task.Delay(2000).GetAwaiter().GetResult();

    Countries = new List<Country>()
        {
            new Country(){ Name = "Türkiye" },
            new Country(){ Name = "Birleşik Krallık" }
        };
  }

  public int CountryCount => Countries.Count;
  public async Task<List<Country>> GetCountries() => Countries;
}