from abc import ABCMeta, abstractmethod

class Activity:
    __metaclass__ = ABCMeta
    @abstractmethod
    def OnState(self, activ):
        pass

class Human:
    def __init__(self):
        self.Activity = None
    def setActivity(self,activ):
        self.Activity = activ
    def OnState(self):
        self.Activity.OnState(self)

class Jump(Activity):
    def OnState(self,activ):
        print "Jump"
        activ.setActivity(Run())

class Run(Activity):
    def OnState(self, activ):
        print "Run"
        activ.setActivity(Jump())

if __name__ == '__main__':
    h1 = Human()
    h1.setActivity(Jump())
    for x in range(10):
        h1.OnState()