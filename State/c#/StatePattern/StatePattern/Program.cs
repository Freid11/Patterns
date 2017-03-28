using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new FmNahe();
            Radio radio = new Radio();
            radio.setStation(station);

            for (int i = 0; i < 10; i++)   
            {
                radio.Play();
                radio.NewWave();
            }
            //-------------------------------
            Human human = new Human();
            human.setActivity(new Run());

            for (int i = 0; i < 10;  i++)
            {
                human.DoState();
            }
            
            Console.Read();
        }
    }
}

interface Activity {
    void DoState(Human context);
}
class Human {
    private Activity actuvity;
    public void setActivity(Activity act) { actuvity = act; }

    public void DoState() {
        actuvity.DoState(this);
    }
}

class Jump : Activity {
    public void DoState(Human context) {
        Console.WriteLine("Прыжек");
        context.setActivity(new Run());
    }
}

class Run : Activity
{
    public void DoState(Human context)
    {
        Console.WriteLine("бег");
        context.setActivity(new Jump());
    }
}

//-----------------------------------------------------------
interface Station {
    void Play();
}

class FmNahe : Station {
    public void Play() {
        Console.WriteLine("Наше радио");
    }
}

class FMMaximum : Station {
    public void Play() {
        Console.WriteLine("Радио максимум");
    }
}

class FMVolna : Station {
    public void Play() {
        Console.WriteLine("Волна FM");
    }
}

class Radio {
    private Station station;

    public void setStation(Station stat) { station = stat; }

    public void NewWave() {
        if (station is FmNahe)
        {
            setStation(new FMMaximum());
        }
        else if (station is FMMaximum)
        {
            setStation(new FMVolna());
        }
        else if (station is FMVolna) {
            setStation(new FmNahe());
        }
    }
    
    public void Play() {
        station.Play();
    }
}