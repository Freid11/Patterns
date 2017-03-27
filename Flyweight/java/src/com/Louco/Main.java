package com.Louco;

import java.util.*;

public class Main {

    public static void main(String[] args) {
        ShapeFactory shapeFactory = new ShapeFactory();
        List<Shape> shapes = new ArrayList<>();
        shapes.add(shapeFactory.gerShape("Круг"));
        shapes.add(shapeFactory.gerShape("Точка"));
        shapes.add(shapeFactory.gerShape("Точка"));
        shapes.add(shapeFactory.gerShape("Квадрат"));
        shapes.add(shapeFactory.gerShape("Точка"));
        shapes.add(shapeFactory.gerShape("Круг"));

        Random ran = new Random();
        for (Shape shape: shapes){
            int x = ran.nextInt(100);
            int y = ran.nextInt(100);
            shape.draw(x,y);
        }
    }
}

interface Shape{
    void draw(int x, int y);
}

class Point implements Shape{
    public void draw(int x, int y){
        System.out.println("Точка");
    }
}

class Circle implements Shape{
    int r = 5;
    public void draw(int x, int y){
        System.out.println("Круг");
    }
}

class Square implements Shape{
    int a = 5;
    public void draw(int x, int y){
        System.out.println("Квадрат");
    }
}

class ShapeFactory{
    private static final Map<String, Shape> shapes = new HashMap<>();
    public Shape gerShape(String shapename){
        Shape shape = shapes.get(shapename);
        if(shape == null){
            switch (shapename){
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
            shapes.put(shapename, shape);
        }
        return shape;
    }
}


