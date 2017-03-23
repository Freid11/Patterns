# -*- coding: utf8 -*-
from abc import ABCMeta, abstractmethod


class Command():
    __metaclass__ = ABCMeta
    @abstractmethod
    def execute(self):
        pass
    
    @abstractmethod
    def Uond(self):
        pass

class EventClick:
    def EventOn(self):
        print "On"
        
    def EventOff(self):
        print "Off"

class EventCommand(Command):
    def __init__(self, var):
        self.EventClick = var
    
    def execute(self):
        self.EventClick.EventOn()

    def Uond(self):
        self.EventClick.EventOff()

class ClickButton:
    def __init__(self, var):
        self.Command = var
    def pressButton1(self):
        self.Command.execute()
    def pressButton2(self):
        self.Command.Uond()
        
if __name__ == '__main__':
    EvCl = EventClick()
    EvCom = EventCommand(EvCl)
    ClBut = ClickButton(EvCom)
    ClBut.pressButton1()
    ClBut.pressButton2()