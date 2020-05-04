using System;
using System.Collections.Generic;


  public class Car
  {
    public string Make;
    public int Price;
    public int Year;
    public string Color;
    public int Mileage;

    public Car(string make, int price, int year, string color, int mileage)
    {
      Make = make;
      Price = price;
      Year = year;
      Color = color;
      Mileage = mileage;
    }

    public bool InBudget(int myBudget)
    {
      return (Price<myBudget);
    }

    public bool DesiredColor(string myColor)
    {
      return(myColor == Color);
    }
  }

  public class Program
  {

    public static void Main()
    {
      Car suzuki = new Car ("alto", 1902, 1992, "grey", 56000);
      Car hyndai = new Car ("Santro", 5000, 2003, "light grey", 50000);
      Car gm     = new Car ("prizm", 4200, 1994, "white", 81000 );
      Car honda  = new Car ("Accord", 8300, 1994, "green", 47000);

      List<Car> myList = new List<Car>() {suzuki, hyndai, gm, honda};
     // List<Car> Cars = new List<Car>(){ volkswagen, yugo, ford, amc };

      Console.WriteLine ("What is your budget? :");
      string customerBudget = Console.ReadLine();
      int theBudget = int.Parse(customerBudget);

      List<Car> myOutput = new List<Car>(0);
      //List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car auto in myList )
      {
        if (auto.InBudget(theBudget))
        {
          myOutput.Add(auto);
        }
      }
      foreach ( Car auto in myOutput)
      {
        Console.WriteLine(auto.Make);
        Console.WriteLine(auto.Price);
        Console.WriteLine(auto.Color);
        Console.WriteLine(auto.Mileage);
      }


    }
  }

