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
        Apple oapple = new Apple();
        Console.WriteLine(oapple.GetColor());
        
        oapple = new Orange();
        Console.WriteLine(oapple.GetColor());
    }
}


class Apple{
  public virtual string GetColor()
  {
    return "This is Apple color red";
  }
}

class Orange: Apple
{
  public override string GetColor(){
    return "The Orange color is Yellow";
  }
}
