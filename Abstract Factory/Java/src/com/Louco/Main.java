package com.Louco;

public class Main {

    public static void main(String[] args) {
        DeviseFactory devFac = getDevise("EN");
        Mouse mouse = devFac.getMouse();
        Claviature clava = devFac.getClava();
        Touch touch = devFac.getTouch();

        mouse.OnClick();
        clava.Print();
        touch.dravMouse();
    }

    public static DeviseFactory getDevise(String country){
        switch (country){
            case "RU":
                return new RuDeviseFactory();
            case "EN":
                return new EnDeviseFactory();
            default:
                throw new RuntimeException();
        }
    }
}

interface Mouse{
    void OnClick();
}

interface Claviature{
    void Print();
    void PrintLn();
}

interface Touch{
    void dravMouse();
}

interface DeviseFactory{
    Mouse getMouse();
    Claviature getClava();
    Touch getTouch();
}

class MouseRu implements Mouse{
    public void OnClick(){
        System.out.println("Мышь клик");
    }
}
class clavaRu implements Claviature{
    public void Print() {
        System.out.println("Клава принт");
    }

    public void PrintLn() {
        System.out.println("Клава принтЛН");
    }
}
class  TouchRu implements Touch{
    public void dravMouse() {
        System.out.println("клик тачь");
    }
}

class MouseEn implements Mouse{
    public void OnClick(){
        System.out.println("mouse touch");
    }
}
class clavaEn implements Claviature{
    public void Print() {
        System.out.println("Clava Print");
    }

    public void PrintLn() {
        System.out.println("Clava PrintLn");
    }
}
class  TouchEn implements Touch{
    public void dravMouse() {
        System.out.println("Click Touch");
    }
}

class RuDeviseFactory implements DeviseFactory{
    public Mouse getMouse() {
        return new MouseRu();
    }
    public Claviature getClava() {
        return new clavaRu();
    }
    public Touch getTouch() {
        return new TouchRu();
    }
}

class EnDeviseFactory implements DeviseFactory{
    public Mouse getMouse() {
        return new MouseEn();
    }
    public Claviature getClava() {
        return new clavaEn();
    }
    public Touch getTouch() {
        return new TouchEn();
    }
}
