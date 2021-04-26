using System.IO;
using System;

//Parent Class
class Vehicle
{
  public string Brand ="Ford";
  public void honk()
  {
      Console.WriteLine("Tuut, tuut !");
  }
}
  //Child class
class Car: Vehicle //Parent : Child
{
    Car(string _model)
    { 
        modelName = _model;
    }
    public string modelName {get; set;}
    static void Main()
    {
       Car mycar = new Car("Mustang");
       mycar.honk();
       Console.WriteLine(mycar.Brand+ " " + mycar.modelName);
       Console.ReadLine();
    }
}