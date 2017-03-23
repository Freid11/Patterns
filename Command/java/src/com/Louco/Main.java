package com.Louco;

import jdk.nashorn.internal.runtime.Debug;

import java.io.Console;

public class Main {

    public static void main(String[] args) {
        EventClick eventClick = new EventClick();
        PressButton pressButton = new PressButton(new ClickCommand(eventClick));
        pressButton.PressButton1();
        pressButton.PressButton2();
    }
}

