package com.Louco;

/**
 * Created by pc on 23.03.2017.
 */
public class PressButton {
    Command command;
    public PressButton(Command com){
        command = com;
    }

    public void PressButton1(){
        command.execute();
    }
    public void PressButton2(){
        command.Uond();
    }

}
