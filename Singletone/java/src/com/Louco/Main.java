package com.Louco;

public class Main {

    public static void main(String[] args) {
        Singleton.getInstans();
        Singleton.getInstans();
    }
}

class Singleton{
    private static Singleton Instans;
    private Singleton(){
        System.out.println("Singletone");
    }

    public static Singleton getInstans(){
        if(Instans == null){
            Instans = new Singleton();
        }
        return Instans;
    }


}