using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Object Oriented Programming - Employee");

    Employee unknown = new Employee();
    unknown.Intro();

    Employee Robert = new Employee("Robert", "Downey", "12321", 12, 100);
    Robert.Intro();

    Employee John = new Employee ("John","Smith", "S0089", 38, 50000, -.02);
    //John.Intro();
    John.IncreaseSalary();

    Employee Maria = new Employee ("Maria","Lambert", "S0100", 26, 80000,.07);
    Maria.IncreaseSalary();
  }
}