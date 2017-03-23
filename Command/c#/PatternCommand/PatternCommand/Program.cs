using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            EventClick click = new EventClick();
            ClickButton Button = new ClickButton(new ClickCommand(click));
            Button.PressButton1();
            Button.PressButton2();
            Console.Read();
        }
    }
}

interface Command
{
    void Exemple();
    void Uond();
}

class EventClick
{
    public void clickOn() {
        Console.WriteLine("ON");
    }
    public void clickOff() {
        Console.WriteLine("Off");
    }
}

class ClickCommand : Command
{
    EventClick eventClick;
    public ClickCommand(EventClick ev) {
        eventClick = ev;
    }

    public void Exemple() {
        eventClick.clickOn();
    }

    public void Uond() {
        eventClick.clickOff();
    }
}

class ClickButton {
    Command com;
    public ClickButton(Command co) {
        com = co;
    }

    public void PressButton1() {
        com.Exemple();
    }

    public void PressButton2() {
        com.Uond();
    }

}




