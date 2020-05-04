using System;
using System.collections.Generic;


  public class Car
  {
    public string Make;
    public int Price;
    public int Year;
    public string Color;
    public int Mileage;

    public Car(sting make, int price, int year, string color, int mileage)
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

  Public class Program
  {

    public static void Main()
    {
      Car suzuki = new Car ("alto", 1902, 1992, "grey", 56000);
      Car hyndai = new Car ("Santro", 5000, 2003, "light grey", 50000);
      Car gm     = new Car ("prizm", 4200, 1994, "white", 81000 );
      Car honda  = new Car ("Accord", 8300, 1994, "green", 47000);

      List<Car> myList = new List(){suzuki, hyndai, gm, honda};

      Console.WriteLine ("What is your budget? :");
      sting customerBudget = Console.ReadLine();
      int theBudget = int.Parse(customerBudget);

      List<Car> myOutput = new List(0);



    }
  }

