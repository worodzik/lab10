using System;

class Employee{

  string id;
  int age;
  string adress;
  string PhoneNum;
  string title;
  double yearlySal;
  string employmentStatus;

  public Employee(){
    FirstName = "Unknown";
    LastName = "Unknown";
    Id = "Unknown";
    Age = 0;
    EmploymentStatus = "active";

    Console.WriteLine(" A new Employee object has been created");
  }

  public Employee( string first, string last, string empid, int empage){
    FirstName = first;
    LastName = last;
    Id = empid;
    Age = empage;
    EmploymentStatus = "active";
    Console.WriteLine(" A new Employee object has been created");
  }
  public string FirstName{get; set;}

  public string LastName{get; set;}

  public int Age{
    get {return age;}
    set{
      if (value < 18){
        age = 18;
        
    }
     else{
        age = value;
        
        } 
      
    }
  }

   public double YearlySal{
    get {return yearlySal;}
    set{
      if (value < 1000){
        yearlySal = 1000;
        Console.WriteLine("yearly Salary cannot be less than 1000!");
        }
     else{
        yearlySal = value;
        
        } 
      
    }
  }

  public string Id{get; set;}

  public string EmploymentStatus{get;set;}
  
  public void Intro(){
    Console.WriteLine(" First name :  " + FirstName);
    Console.WriteLine(" Last name: " + LastName);
    Console.WriteLine(" Age: " + Age);
    Console.WriteLine(" Id : " + Id);
    Console.WriteLine(" Employment Status : " + EmploymentStatus);
    Console.WriteLine("Yearly salary: " + YearlySal);


  }

  public void  IncreaseSalary(double percent){
    if (percent < 0){
      Console.WriteLine("invalid input. Yearly Salary not updated");
    }
    else{
      double inc = YearlySal * percent;
      YearlySal = YearlySal + inc;
      Console.WriteLine("Yearly salary updated to " + YearlySal);
    }
  } 

  public void RemoveEmployee(){
    if (EmploymentStatus == "active"){
      EmploymentStatus = "inactive";
      Console.WriteLine("Employee removed");
    }
    else 
    Console.WriteLine("Employee already inactive");
  }


}