using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            List<Shape> shapes = new List<Shape>();
            shapes.Add(shapeFactory.getShape("Круг"));
            shapes.Add(shapeFactory.getShape("Квадрат"));
            shapes.Add(shapeFactory.getShape("Круг"));
            shapes.Add(shapeFactory.getShape("Круг"));
            shapes.Add(shapeFactory.getShape("Точка"));
            shapes.Add(shapeFactory.getShape("Точка"));
            shapes.Add(shapeFactory.getShape("Квадрат"));

            foreach (Shape shape in shapes){
                int x = 1;
                int y = 2;
                shape.Draw(x,y);
            }
            Console.ReadLine();
        }
    }
}

interface Shape {
    void Draw(int x, int y);
}


class Point : Shape {
    public void Draw(int x, int y) {
        Console.WriteLine("Точка");
    }
}

class Circle : Shape {
    int r = 10;
    public void Draw(int x, int y)
    {
        Console.WriteLine("Круг");
    }
}

class Square : Shape { 
    int a = 10;
    public void Draw(int x, int y)
    {
        Console.WriteLine("Квадрат");
    }
}

class ShapeFactory {
    private static SortedDictionary<string , Shape> shapes = new  SortedDictionary<string, Shape>();

    public Shape getShape(string NameShape) { 
        Shape shape;
        shapes.TryGetValue(NameShape , out shape);
        if (shape == null) {
            switch (NameShape) { 
                case "Точка":
                    shape = new Point();
                    break;
                case "Круг":
                    shape = new Circle();
                    break;
                case "Квадрат":
                    shape = new Square();
                    break;
            }
            shapes.Add(NameShape,shape);
        }
        return shape;
    }



}
