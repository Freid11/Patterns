using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortotypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Louco", 24);
            Console.WriteLine(human.getString());

            Human copyhuman = (Human) human.Copy();
            Console.WriteLine(copyhuman.getString());

            HumanFactory factory = new HumanFactory(copyhuman);
            Human h1 = factory.CopyHums();
            Console.WriteLine(h1.getString());

            Console.ReadLine();

        }
    }
}


interface Pototype {
    Object Copy();
}


class Human : Pototype {
    String Name;
    int Age;

    public Human(String name, int age) { 
        Name = name;
        Age = age;
    }

    public String getString() {
        return "Name = " + Name + ", Age="+ Age.ToString();
    }


    public object Copy()
    {
        return new Human(Name, Age);
    }
}

class HumanFactory{
    Human human;
    public HumanFactory(Human humanin){
        SetNewHuman(humanin);
    }

    public void SetNewHuman(Human human) {
        this.human = human;
    }

    public Human CopyHums() {
        return (Human) human.Copy();
    }
}