class Singleton:
    _singleton = None
    def __new__(cls):
        if not cls._singleton:
            cls._singleton = super(Singleton,cls).__new__(cls)
        return cls._singleton

    def __init__(self):
        if self._singleton != None:
            print "da"

if __name__ == '__main__':
    print Singleton()
    print Singleton()
