# -*- coding: utf8 -*-
from abc import ABCMeta, abstractmethod


class Observed:
    __metaclass__ = ABCMeta
    
    @abstractmethod
    def addclient(self, other):
        pass
    
    @abstractmethod
    def reservClient(self, other):
        pass
    
    @abstractmethod
    def NotifyClient(self):
        pass


class Stantion(Observed):
    def __init__(self):
        self.Temperature = None
        self.Davlenie = None
        self.ListClient = []
    
    def SetParam(self, temperature, davlenie):
        self.Temperature = temperature
        self.Davlenie = davlenie
        self.NotifyClient()
    
    def addclient(self, other):
        self.ListClient.append(other)
    
    def reservClient(self, other):
        self.ListClient.remove(other)
    
    def NotifyClient(self):
        for Client in self.ListClient:
            Client.Event(self.Temperature, self.Davlenie)


class Obsever:
    __metaclass__ = ABCMeta
    @abstractmethod
    def Event(self, temperature, davlenie):
        pass


class ClientOne(Obsever):
    def Event(self, temperature, davlenie):
        print str(temperature) +" ClientOne " + str(davlenie)
        
if __name__ == '__main__':
    st = Stantion()
    
    st.addclient(ClientOne())
    
    st.SetParam(1, 5)