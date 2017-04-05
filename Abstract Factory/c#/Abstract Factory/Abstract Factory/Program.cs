using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            DeviseFactory devObj = getDevise("EN");
            Mouse mouse = devObj.getMouse();
            Clava clava = devObj.getClava();
            Touch touch = devObj.getTouch();

            mouse.OnClick();
            clava.PressOn();
            touch.touch();
            Console.Read();
        }

        private static DeviseFactory getDevise(String country) {

            switch (country) { 
                case "RU":
                    return new RuDeviseFactory();
                case "EN":
                    return new EnDeviseFactory();
                default:
                    throw new RankException();
            }
        }
    }
}

interface Mouse {
    void OnClick();
}
interface Clava {
    void PressOn();
    void PressOff();
}
interface Touch {
    void touch();
}
interface DeviseFactory {
    Mouse getMouse();
    Clava getClava();
    Touch getTouch();
}

class MouseRu : Mouse {
    public void OnClick()
    {
        Console.WriteLine("Мышь клик");
    }
}
class MouseEn : Mouse {
    public void OnClick()
    {
        Console.WriteLine("Mouse Click");
    }
}

class ClavaRu : Clava {
    public void PressOn()
    {
        Console.WriteLine("Клава нажание");
    }

    public void PressOff()
    {
        Console.WriteLine("Клава Отжатие");
    }
}
class ClavaEn : Clava
{
    public void PressOn()
    {
        Console.WriteLine("Clava pressOn");
    }

    public void PressOff()
    {
        Console.WriteLine("Clava PressOff");
    }
}

class TouchRu : Touch {

    public void touch()
    {
        Console.WriteLine("Тачь");
    }
}
class TouchEn : Touch
{

    public void touch()
    {
        Console.WriteLine("Touch");
    }
}

class RuDeviseFactory : DeviseFactory
{
    public Mouse getMouse()
    {
        return new MouseRu();
    }

    public Clava getClava()
    {
        return new ClavaRu();
    }

    public Touch getTouch()
    {
        return new TouchRu();
    }
}
class EnDeviseFactory : DeviseFactory
{
    public Mouse getMouse()
    {
        return new MouseEn();
    }

    public Clava getClava()
    {
        return new ClavaEn();
    }

    public Touch getTouch()
    {
        return new TouchEn();
    }
}