// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

/* Online C# Compiler and Editor */
using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello world");
        IFruit oapple = new Apple();
        Console.WriteLine(oapple.GetColor());
        
        oapple = new Orange();
        Console.WriteLine(oapple.GetColor());
    }
}

interface IFruit{
  string GetColor();
}

class Apple: IFruit{
  public string GetColor()
  {
    return "This is Apple color red";
  }
}

class Orange: IFruit
{
  public string GetColor(){
    return "The Orange color is Yellow";
  }
}


