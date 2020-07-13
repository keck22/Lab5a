using System;
class Employee {

//Fields
 private string f_name;
 private string l_name;
 private string id;
 private int age;
 //private string address;
 //private string phonenumber;
 //private string title;
 private double yearlysalary;
 private double yearlysalaryincrease;
 private string employmentstatus;

  //Properties
 public string F_name {get; set;}
 public string L_name {get; set;}
 public string Id {get; set;}
 public int Age {
   get{ return age; }
   set{
     if (value>=18)
     age = value;
     else
     {
       age = 18;
     }
     
   }
 }
 //public string Address {get; set;}
 //public string Phonenumber {get; set;}
 //public string Title{get; set;}
 public double Yearlysalary{
   get{ return yearlysalary; }
   set{
     if (value>=1000)
      yearlysalary = value;
     else
     {
       yearlysalary = 1000;
       Console.WriteLine("Yearly Salary cannot be less than $1000 so it is set to $1000");
     }
   }
 }
 public double Yearlysalaryincrease{
   get{ return yearlysalaryincrease; }
   set{
     if (value>=0)
     yearlysalaryincrease=value;
     else
     {
       yearlysalaryincrease = 0;
       Console.WriteLine("Yearly Salary Increase cannot be less than 0, Invalid input.");
     }
   }
 }
 public string Employmentstatus{
   get {return "active" ;} 
   set{
     if ("active")
     employmentstatus=
   
   


public Employee()

  f_name="Unknown";
  l_name="Unknown";
  id="Unknown";
  Age=0;
  Console.WriteLine("A new employee has been created ");
}
public Employee(string employeef_name, string employeel_name, string employeeid, int employeeage, double employeeyearlysalary)
{
  f_name = employeef_name;
  l_name = employeel_name;
  id = employeeid;
  Age = employeeage;
  Yearlysalary = employeeyearlysalary;
 
}
public void Intro()
{
  Console.WriteLine("First name: " + f_name);
  Console.WriteLine("Last name: " + l_name);
  Console.WriteLine("Id: " + id);
  Console.WriteLine("Age: " + Age);
  Console.WriteLine("Yearly Salary: " + Yearlysalary);
  
}
public Employee(string employeef_name, string employeel_name, string employeeid, int employeeage, double employeeyearlysalary, double employeeyearlysalaryincrease)
{
  f_name = employeef_name;
  l_name = employeel_name;
  id = employeeid;
  Age = employeeage;
  Yearlysalary = employeeyearlysalary;
  Yearlysalaryincrease = employeeyearlysalaryincrease;

 
}
public void IncreaseSalary()
{
  Console.WriteLine("First name: " + f_name);
  Console.WriteLine("Last name: " + l_name);
  Console.WriteLine("Id: " + id);
  Console.WriteLine("Age: " + Age);
  Console.WriteLine("Yearly Salary: " + Yearlysalary);
  Console.WriteLine("Yearly Salary Increase:" + Yearlysalaryincrease);
  Console.WriteLine("Updated Salary is: " + (Yearlysalary + (Yearlysalary*Yearlysalaryincrease)));

}


}