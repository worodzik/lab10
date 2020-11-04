using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Employee");
    Employee em1 = new Employee();
    em1.Intro();

    Employee em2 = new Employee("Robert", "downey", "12321", 12);
    em2.YearlySal = 100;
    em2.Intro();

    Employee em3 = new Employee("John", "Smith", "S0089", 38 );
    em3.YearlySal = 50000;
    em3.Intro();
    em3.IncreaseSalary(-0.02);
    em3.RemoveEmployee();

    Employee em4 = new Employee("Maria", "Lambert", "S0100", 26);
    em4.YearlySal = 80000;
    em4.Intro();
    em4.IncreaseSalary(0.07);
    em4.RemoveEmployee();
    em4.RemoveEmployee();
  }
}