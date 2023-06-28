using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
    }
}

class Shape {
    private string _color;

    public Shape(string color){
        _color = color;
    }

    public string GetColor (){
        return _color;
    } 

    public void SetColor (string new_color){
        _color = new_color;
    }

    public virtual double GetArea (){
        return 0;
    }

class Square: Shape {
    double _side;

    public Square (string color, double side): base (color){
        _side = side;
    }
}
class Rectangle: Shape{
    double _length;
    double _width;

    public Rectangle(string color, double length, double width):base (color){
        _length = length;
        _width = width;
    }
}
class Circle{
    double _radius;

}
}