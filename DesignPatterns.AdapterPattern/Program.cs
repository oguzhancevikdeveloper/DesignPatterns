﻿









JsonDataProvider jsonDataProvider = new JsonDataProvider();
IXmlDataProvider xmlDataProvider = new JsonToXmlAdapter(jsonDataProvider);

Console.WriteLine(xmlDataProvider.GetXmlData());


public interface IXmlDataProvider
{
  string GetXmlData();
}

public class JsonDataProvider
{
  public string GetJsonData()
  {
    return "{ \"data\": \"Bu JSON formatında bir veri.\" }";
  }
}



public class JsonToXmlAdapter : IXmlDataProvider
{
  private readonly JsonDataProvider _jsonDataProvider;

  public JsonToXmlAdapter(JsonDataProvider jsonDataProvider)
  {
    _jsonDataProvider = jsonDataProvider;
  }

  public string GetXmlData()
  {
    // JSON verisini XML'e dönüştürüyoruz.
    var jsonData = _jsonDataProvider.GetJsonData();
    // Basit bir dönüşüm simülasyonu (normalde JSON-to-XML dönüşüm kütüphanesi kullanılabilir).
    return "<data>Bu JSON verisinin XML formatına dönüştürülmüş hali.</data>";
  }
}

















// Adapter Design Pattern - Structural Category //

//var trans = new TransferTransaction() { Amount = 10, FromIBAN = "1", ToIBAN = "2" };

//var adapter = new JsonBankApiAdapter();
//var result = adapter.ExecuteTransaction(trans);

//Console.WriteLine("Result: {0}", result);

//Console.ReadLine();


//interface IBankApi
//{
//  bool ExecuteTransaction(TransferTransaction transaction);
//}
//class XmlBankApiAdapter : IBankApi
//{
//  private readonly XmlBankApi xmlBankApi;

//  public XmlBankApiAdapter()
//  {
//    xmlBankApi = new();
//  }

//  public bool ExecuteTransaction(TransferTransaction transaction)
//  {
//    // voltajı düşür
//    return xmlBankApi.ExecuteTransaction(transaction);
//  }
//}
//class JsonBankApiAdapter : IBankApi
//{
//  private readonly JsonBankApi jsonBankApi;

//  public JsonBankApiAdapter()
//  {
//    jsonBankApi = new();
//  }

//  public bool ExecuteTransaction(TransferTransaction transaction)
//  {
//    // voltajı kontrol et
//    return jsonBankApi.ExecuteTransaction(transaction);
//  }
//}
//class JsonBankApi : IBankApi
//{
//  public bool ExecuteTransaction(TransferTransaction transaction)
//  {
//    var json = $$""""
//                      {
//                        ""FromIBAN"": ""{{transaction.FromIBAN}}"",
//                        ""ToIBAN"":   ""{{transaction.ToIBAN}}"",
//                        ""Amount"":   ""{{transaction.Amount:C2}}""
//                      }
//                     """";

//    // Call bank api with JSON
//    Console.WriteLine($"{GetType().Name} worked with;");
//    Console.WriteLine(json);
//    return true;
//  }
//}
//class XmlBankApi : IBankApi
//{
//  public bool ExecuteTransaction(TransferTransaction transaction)
//  {
//    var xml = $"""
//                    <TransferTransaction>
//                        <FromIBAN>{transaction.FromIBAN}</FromIBAN>
//                        <ToIBAN>{transaction.ToIBAN}</ToIBAN>
//                        <Amount>{transaction.Amount:C2}</Amount>
//                    </TransferTransaction>
//                  """;

//    // Call bank api with XML
//    Console.WriteLine($"{GetType().Name} worked with;");
//    Console.WriteLine(xml);
//    return true;
//  }
//}
//class TransferTransaction
//{
//  public string FromIBAN { get; set; }

//  public string ToIBAN { get; set; }

//  public decimal Amount { get; set; }
//}