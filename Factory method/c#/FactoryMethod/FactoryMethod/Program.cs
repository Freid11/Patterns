using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            WatchMaker Maker = new RomeWatchMaker();
            Watch watch = Maker.WatchCreate();
            watch.create();
            Console.Read();
        }
    }
}

interface Watch {
    void create();
}

class DigitalWatch : Watch
{
    public void create()
    {
        Console.WriteLine("Электрика");
    }
}

class RomeWatch : Watch 
{
    public void create()
    {
        Console.WriteLine("Римские");
    }
}

interface WatchMaker {
    Watch WatchCreate();
}

class DigitalWatchMaker : WatchMaker {
    public Watch WatchCreate()
    {
        return new DigitalWatch();
    }
}

class RomeWatchMaker : WatchMaker {
    public Watch WatchCreate()
    {
        return new RomeWatch();
    }
}
