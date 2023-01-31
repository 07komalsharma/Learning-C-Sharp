// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler


using System;
class Algebra
  {
    static void Main(string[] args)
    {
        
        Console.WriteLine("enter first number : ");
        double num1=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("enter second number : ");
        double num2=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("enter any operator ( + , - , * , / ) :  ");
        string op =Console.ReadLine();
        double ans;
        
        switch(op){
            case "+":
               ans=num1+num2;
               break;
               
            case "-":
               ans=num1-num2;
               break;
              
            case "*":
               ans=num1*num2;
               break;
               
            case "/":
               ans=num1/num2;
               break;
               
            default:
              Console.WriteLine("Invalid Operator");
              Console.ReadLine();
              return;
        }
        Console.WriteLine("Result : "+ans);
        }
    }
