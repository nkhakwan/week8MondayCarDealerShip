using System;
using System.Collections.Generic;

public class ShowRoom
{
  public string Make;
  public int Mileage;
  public int Price;
  public string Color;

  public ShowRoom (string make, int mileage, int price, string color)
  { 
    Make = make;
    Mileage = mileage;
    Price = price;
    Color = color;
  }
  
  public bool WithinBudget(int budget)
  {
    return (budget> Price);
  }
}

public class Program
{

  public static void Main()
  {
    ShowRoom suzuki = new ShowRoom ("alto",56000, 1902, "grey");
    ShowRoom hyndai = new ShowRoom ("Santro", 50000, 5000, "light grey");
    ShowRoom gm     = new ShowRoom ("prizm", 81000, 4200,  "white" );
    ShowRoom honda  = new ShowRoom ("Accord", 47000, 8300,  "green");

    List<ShowRoom> MyCarsList = new List<ShowRoom> {suzuki, hyndai, gm, honda};

    Console.WriteLine ("what is your budget?");
    string Answer = Console.ReadLine();
    int Budget = int.Parse(Answer);

    List<ShowRoom> UnderBudgetCars = new List<ShowRoom>(0);

    foreach (ShowRoom auto in MyCarsList)
    {
      if (auto.WithinBudget(Budget))
      {
        UnderBudgetCars.Add(auto);
      }
    }

    foreach (ShowRoom auto in UnderBudgetCars)
    {
      Console.WriteLine(auto.Price);

    }



  }



}






