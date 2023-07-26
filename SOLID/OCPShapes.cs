// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

/* Online C# Compiler and Editor */
using System.IO;
using System;

class Program
{
    static void Main()
    {
        var objRectrangle = new Rectangle();
        objRectrangle.Width = 4;
        objRectrangle.Height = 9;
        
        var objSquare = new Square();
        objSquare.Side = 8;
        
        object[] shapes = new Object[2];
        shapes[0] = objRectrangle;
        shapes[1] = objSquare;
        
        
        foreach(var objShape in shapes){
            if(objShape is Rectangle){
                var ubRectangle = (Rectangle)objShape;
                var areaShape = ubRectangle.Width * ubRectangle.Height;
                Console.WriteLine(string.Format("Area of Rectangle of width-{0} and height-{1} is :{2}", ubRectangle.Width, ubRectangle.Height, areaShape));
            }
            else if(objShape is Square){
                var ubSquare = (Square)objShape;
                var areaSqShape = ubSquare.Side * ubSquare.Side;
                Console.WriteLine(string.Format("Area of Square of Side-{0} is :{1}", ubSquare.Side, areaSqShape));
            }
        }
        
    }
}



class Rectangle{
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
}

class Square{
    int _side = 0;
    public int Side{
        get {return _side;}
        set { _side = value; }
    }
}

