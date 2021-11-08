using System;

class Employee
{
  int id;
  string name;
  string department;
  int salary;
  public void GetDetails()
  {
    Console.WriteLine("Enter ID");
    id= Convert.ToByte(Console.ReadLine());
    Console.WriteLine("Enter Name");
    name = Console.ReadLine();
    Console.WriteLine("Enter Department");
    department = Console.ReadLine();
    Console.WriteLine("Enter Salary");
    salary = Int32.Parse(Console.ReadLine());
  }
  public void DisplayDetails()
  {
    Console.WriteLine("ID is " + id);
    Console.WriteLine("Name is " + name);
    Console.WriteLine("Department is " + department);
    Console.WriteLine("Salary is " + salary);
  }
}