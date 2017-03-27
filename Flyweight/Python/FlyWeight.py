# -*- coding: utf8 -*-
from abc import ABCMeta, abstractmethod

class Shap:
    __metaclass__ = ABCMeta
    @abstractmethod
    def Draw(self,x,y):
        pass

class Point(Shap):
    def Draw(self,x,y):
        print "Точка"

class Circle(Shap):
    r = 10
    def Draw(self,x,y):
        print "Круг"

class Square(Shap):
    a = 5
    def Draw(self,x,y):
        print "Квадрат"

class ShapeFactory:
    def __init__(self):
        self.shapes = {}

    def getShape(self, NameShape):
        ShapOne = None
        if (NameShape in self.shapes):
            ShapOne = self.shapes[NameShape]
        else:
            if(NameShape == "Точка"):
                ShapOne = Point()
            elif(NameShape == "Круг"):
                ShapOne = Circle()
            elif(NameShape == "Квадрат"):
                ShapOne = Square()
            self.shapes[NameShape] = ShapOne
        return ShapOne

if __name__ == '__main__':
    Shape = ShapeFactory()
    listShape =[]

    listShape.append(Shape.getShape("Круг"))
    listShape.append(Shape.getShape("Квадрат"))
    listShape.append(Shape.getShape("Точка"))
    listShape.append(Shape.getShape("Круг"))
    listShape.append(Shape.getShape("Квадрат"))
    listShape.append(Shape.getShape("Круг"))
    listShape.append(Shape.getShape("Точка"))

    for ShapeIttem in listShape:
        ShapeIttem.Draw(1,1)