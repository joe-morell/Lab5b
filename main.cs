using System;

class MainClass {
  public static void Main (string[] args) {
    int i = 1;
    double totalSpeed = 0;

    Console.WriteLine("Enter the number of cars");
    int numOfCars = Convert.ToInt32(Console.ReadLine());

    while (i <= numOfCars) {
    Console.WriteLine("Enter the distance covered by Car #" + i);
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the time taken by Car #" + i);
    double time = Convert.ToDouble(Console.ReadLine());
    
    double speed = distance / time;
    Console.WriteLine("The speed of this car is " + speed + " miles per hour\n");

    totalSpeed += speed;
    i++;
    }
    
    double averageSpeed = totalSpeed / 7;
    Console.WriteLine("The average speed of the cars is  " + averageSpeed + " miles per hour");
  }
}