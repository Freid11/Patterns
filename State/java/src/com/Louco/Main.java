package com.Louco;

public class Main {

    public static void main(String[] args) {
        ContextRadioState.getContextState();
        System.out.println();
        DinamicState.getDinamicContext();
    }
}

class ContextRadioState{
    public static void getContextState(){
        State state = new FMNashe();
        Radio radio = new Radio();
        radio.setRadio(state);

        for (int i = 0; i < 5; i++){
            radio.Play();
            radio.NextWave();
        }
    }
}

class DinamicState{
    public static void getDinamicContext(){
        Human human =new Human();
        human.setActivity(new Jamp());

        for (int i = 0; i < 5; i++) {
            human.doState();
        }
    }
}