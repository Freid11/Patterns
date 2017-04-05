package com.Louco;

import java.util.Date;

public class Main {

    public static void main(String[] args) {
        WatchMaker maker = new DigitalWatchMaker();
        Wacth watch = maker.WatchCreate();
        watch.create();
    }
}

interface Wacth{
    void create();
}
class DigitalWatch implements Wacth{
    public void create() {
        System.out.println(new Date());
    }
}
class RomeWatch implements Wacth{
    public void create() {
        System.out.println("VI-XV-IX");
    }
}

interface WatchMaker{
    Wacth WatchCreate();
}

class DigitalWatchMaker implements WatchMaker{
    public Wacth WatchCreate() {
        return new DigitalWatch();
    }
}
class RomeWatchMaker implements WatchMaker{
    public Wacth WatchCreate() {
        return new RomeWatch();
    }
}