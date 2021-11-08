using System;
using System.Collections.Generic;
class Program
{
  static void Main()
  {
    // ArrayList list = new ArrayList();
    List<Employee> list = new  List<Employee>();
    char ch ='y';
    while(ch=='y')
    {
       Console.WriteLine("Enter Details of employee" );
       Employee employee = new  Employee();
       employee.GetDetails();
       list.Add(employee);
       Console.WriteLine("Want tp add other record");
       ch = Convert.ToChar(Console.ReadLine());
    }
    // list.Add(1); THIS IS THE PROBLEM
    Console.WriteLine("Employee List");
    foreach (Employee temp in list)
    {
      temp.DisplayDetails();
    }
  }
}