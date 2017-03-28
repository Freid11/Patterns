using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.getInstans();
            Singleton.getInstans();
            Singleton.getInstans();
            Console.ReadLine();
        }
    }
}

class Singleton {
    private static Singleton Instans;
    private Singleton(){
        Console.WriteLine("Singletone");
    }

    public static Singleton getInstans() {
        if (Instans == null) {
            Instans = new Singleton();
        }
        return Instans;
    }

}