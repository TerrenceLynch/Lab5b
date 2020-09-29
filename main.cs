using System;

class MainClass {
  public static void Main (string[] args) {
    double total = 0;
    Console.WriteLine("What is the total number of cars?");
    double cars = Convert.ToDouble(Console.ReadLine());
    cars = cars + 1;
    for(int counter = 1; counter < cars; counter++)
    {
    Console.WriteLine ("What is the distance, in miles covered by Car#" + counter  );
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is the time, in hours take by Car#" + counter);
    double time = Convert.ToDouble(Console.ReadLine());
    double speed = distance/time;
    Console.WriteLine("The speed of Car#" + counter + " is " + speed + " Miles per hour.");
    total = total + speed;
    }
    double average = total/cars;
    Console.WriteLine("The average speed is " + average + " mph.");
  }
}