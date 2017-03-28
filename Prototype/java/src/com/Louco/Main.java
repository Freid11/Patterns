package com.Louco;

import java.util.*;

public class Main {

    public static void main(String[] args) {
        Human humanOriginal = new Human("Михаил", 24);
        System.out.println(humanOriginal.GetString());

        Human copyHuman = (Human) humanOriginal.Copy();
        System.out.println(copyHuman.GetString());

        HumanFactory humanFactory = new HumanFactory(copyHuman);
        Human h1 = humanFactory.CopyHuman();
        System.out.println(h1.GetString());
    }
}

interface Copybl{
    Object Copy();
}

class Human implements Copybl{
    String name;
    int Age;
    public Human(String  nameIn, int AgeIn ) {
        name = nameIn;
        Age = AgeIn;
    }

    public String GetString(){
        return "Name = "+ name + ", Age = "+Age;
    }

    public Object Copy() {
        Object copy = new Human(name , Age);
        return copy;
    }
}

class HumanFactory{
    Human human;

    public HumanFactory(Human human) {
        SetNewHuman(human);
    }

    public void SetNewHuman(Human human) {
        this.human = human;
    }

    Human CopyHuman(){
        return (Human) human.Copy();
    }

}