using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternobserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Stanshion stan = new Stanshion();

            stan.addClient(new ClientOne());

            stan.setParam(1,11);
            Console.ReadLine();
        }
    }
}

interface Observed {
    void addClient(Observer o);
    void reservClient(Observer o);
    void NotifyClient();
}

class Stanshion : Observed
{
    int Temperature;
    int Davlenie;

    public void setParam(int temperature, int davlenie) {
        Temperature = temperature;
        Davlenie = davlenie;
        NotifyClient();
    }

    List<Observer> listClient = new List<Observer>();

    public void addClient(Observer o)
    {
        listClient.Add(o);
    }

    public void NotifyClient()
    {
        foreach (Observer obs in listClient)
        {
            obs.Event(Temperature, Davlenie);
        }
    }

    public void reservClient(Observer o)
    {
        listClient.Remove(o);
    }
}

interface Observer {
    void Event(int x, int y);
}


class ClientOne : Observer
{
    public void Event(int x, int y)
    {
        Console.WriteLine(x + " ClientOne " + y);
    }
}