using System;
using System.Collections.Generic;

public class ShowRoom
{
  string Make;
  int Mileage;
  int Price;
  string Color;

  public ShowRoom(string make, int mileage, int price, string color);
  { Make = make;
    Mileage = mileage;
    Price = price;
    Color = color;
  }
  
  public bool WithinBudget(int budget)
  {
    return (budget> Price);
  }
}






