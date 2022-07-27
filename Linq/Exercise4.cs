using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Exercise4
    {
        //Student[] arr = {
    //new Student() {firstName = "Ivan", lastName = "Ivanov", age = 21 },
    //new Student() { firstName = "Georgi", lastName = "Georgiev", age = 25 },
    //new Student() { firstName = "Mario", lastName = "Metushev", age = 24 },
//}; 
        
        var youngStud =
            from stud in arr
            where stud.age >= 21 && stud.age <= 24
            select stud;
        Console.WriteLine("Students between 21 and 24 years");
        
           foreach (var stud in youngStud)
{  
    Console.WriteLine(stud.firstName + stud.lastName + stud.age);
    }
        
  }
}    

