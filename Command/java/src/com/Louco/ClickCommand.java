package com.Louco;

/**
 * Created by pc on 23.03.2017.
 */
public class ClickCommand implements Command {
    EventClick EvCl;
    public ClickCommand(EventClick click){
        EvCl = click;
    }
    @Override
    public void execute() {
        EvCl.clickOn();
    }

    @Override
    public void Uond() {
        EvCl.clickOff();
    }
}
