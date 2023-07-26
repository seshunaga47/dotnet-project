// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

/* Online C# Compiler and Editor */
using System.IO;
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        var objRectrangle = new Rectangle();
        objRectrangle.Width = 41;
        objRectrangle.Height = 9;
        
        var objSquare = new Square();
        objSquare.Side = 8;
        
        
        object[] shapes = new Object[2];
        shapes[0] = objRectrangle;
        shapes[1] = objSquare;
        
        
        foreach(var objShape in shapes){
            if(objShape is Rectangle){
                var ubRectangle = (Rectangle)objShape;
                ubRectangle.GetArea();
            }
            else if(objShape is Square){
                var ubSquare = (Square)objShape;
                ubSquare.GetArea();
            }
        }
        
    }
}

public abstract class Shape{
  public abstract void GetArea();
}


class Rectangle : Shape{
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
    
    public override void GetArea(){
      var areaShape = _height*_width;
      Console.WriteLine(string.Format("Area of Rectangle of width-{0} and height-{1} is :{2}", this._width, this._height, areaShape));
    }
    
}

class Square : Shape{
    int _side = 0;
    public int Side{
        get {return _side;}
        set { _side = value; }
    }
    
    public override void GetArea(){
      var areaSqShape = _side * _side;
      Console.WriteLine(string.Format("Area of Square of Side-{0} is :{1}", this._side, areaSqShape));
    }
}
