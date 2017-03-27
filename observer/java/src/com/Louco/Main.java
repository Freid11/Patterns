package com.Louco;

import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {
        Station station = new Station();
        station.addclient(new ClienOne());
        clienttwelw cl = new clienttwelw();
        station.addclient(cl);
        station.removeclient(cl);

        station.setparam(2,45);
    }
}

interface observed{
  void  addclient(observer o);
  void removeclient(observer o);
  void notifyclient();
}

class Station implements observed{
    int temperature;
    int Davlenie;

    public void setparam(int temperature, int davlenie) {
        this.temperature = temperature;
        Davlenie = davlenie;
        notifyclient();
    }

    List<observer> listclient = new ArrayList<>();

    public void addclient(observer o) {
        listclient.add(o);
    }

    public void removeclient(observer o) {
        listclient.remove(o);
    }

    public void notifyclient() {
        for (observer o: listclient ) {
            o.handleIvent(temperature , Davlenie);
        }
    }
}

interface observer {
    void handleIvent(int x, int y);
}

class ClienOne implements observer{

    public void handleIvent(int x, int y) {
        System.out.println(x +" ClienOne "+ y);
    }
}

class clienttwelw implements observer{

    public void handleIvent(int x, int y) {
        System.out.println(x +" clienttwelw "+ y);
    }
}