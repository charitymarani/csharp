// Window applications
// Web applications
// Distributed applications
// Web service applications
// Database applications etc.

// Hello world
// Simple Example
using System;
namespace ConsoleApp1{
  public class Program{
    
    
    public static void Main(string[] args){
      try{
        int a=10;
        int b= 0;
        int sum = a/b;
      }
      catch(NullReferenceException e){Console.WriteLine(e);}
      finally{
        Console.WriteLine("finally here");
      }
      
      
  }

}
}


