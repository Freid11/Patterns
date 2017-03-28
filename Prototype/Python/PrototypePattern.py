# -*- coding: utf8 -*-
from abc import ABCMeta, abstractmethod

class Prototype:
    __metaclass__ = ABCMeta
    @abstractmethod
    def Copy(self):
        pass

class Human(Prototype):
    def __init__(self, name , age):
        self.Name = name;
        self.Age = age;

    def getString(self):
        print "name = "+ self.Name +", Age = "+ str(self.Age)

    def Copy(self):
        return Human(self.Name, self.Age)

class Factory:
    def __init__(self, Human):
        self.human = Human
    def setHuman(self, Human):
        self.human = Human
    def CopyHum(self):
        return self.human.Copy()


if __name__ == '__main__':
    h1 = Human("Louco" , 24)
    h1.getString()

    h2 = h1.Copy()
    h2.getString()

    factory = Factory(h2)
    h3 = factory.CopyHum()
    h3.getString()