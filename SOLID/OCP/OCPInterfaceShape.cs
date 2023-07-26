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
        IShape objRectrangle = new Rectangle();
        objRectrangle.Width = 41;
        objRectrangle.Height = 9;
        
        IShape objSquare = new Square();
        objSquare.Width = 8;
        
        List<IShape> shapes = new List<IShape>();
        shapes.Add(objRectrangle);
        shapes.Add(objSquare);
        
        foreach(var objShape in shapes){
            objShape.GetArea();
        }
        
    }
}

interface IShape{
  int Width{
    get; set;
  }
  int Height{
    get; set;
  }
  
  void GetArea();
}


class Rectangle : IShape{
    int _width =0;
    int _height = 0;
    
    public Rectangle(){
        
    }
    
    public int Width{
        get {return _width;}
        set {this._width = value;}
    }
    
    public int Height{
        get {return _height;}
        set {this._height = value;}
    }
    
    public void GetArea(){
      var areaShape = _height*_width;
      Console.WriteLine(string.Format("Area of Rectangle of width-{0} and height-{1} is :{2}", this._width, this._height, areaShape));
    }
    
}

class Square : IShape{
    int _side = 0;
    public int Width{
        get {return _side;}
        set { _side = value; }
    }
    
    public int Height{
        get {return _side;}
        set {this._side = value;}
    }
    
    public void GetArea(){
      var areaSqShape = _side * _side;
      Console.WriteLine(string.Format("Area of Square of Side-{0} is :{1}", this._side, areaSqShape));
    }
}

