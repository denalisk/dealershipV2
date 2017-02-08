using System.Collections.Generic

namespace Dealership.Objects
{
  public static List<Car> Inventory = new List<Car> {};
  public class Car
  {
    private string _make;
    private string _model;
    private int _year;
    private int _price;
    private int _mileage;

    public Car(string make, string model, int year, int price = 0, int mileage = 0)
    {
      SetMake(make);
      SetModel(model);
      SetYear(year);
      SetPrice(price);
      SetMileage(mileage);
    }

    public string GetMake()
    {
      return _make;
    }
    public void SetMake(newMake)
    {
      _make = newMake;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetModel(newModel)
    {
      _model = newModel;
    }
    public int GetYear()
    {
      return _year;
    }
    public void SetYear(newYear)
    {
      _year = newYear;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(newPrice)
    {
      _price = newPrice;
    }public int GetMileage()
    {
      return _mileage;
    }
    public void SetMileage(newMileage)
    {
      _mileage = newMileage;
    }

  }
  public class Dealership
  {
    public static void PrintCar(List<Car> inventory)
    {
      foreach (Car item in inventory)
      {
        string carMake = item.GetMake();
        string carModel = item.GetModel();
        string carYear = item.GetYear().ToString();
        Console.WriteLine("Make: " + carMake + "  Model: " + carModel + "  Year: " + carYear);
      }
    }
  }
}
