package com.Louco;

/**
 * Created by pc on 28.03.2017.
 */
public interface Activity {
    void doState(Human context);
}

class Human{
    private Activity activity;

    public void setActivity(Activity act){activity = act;}

    public void doState() {
        activity.doState(this);
    }
}
class Jamp implements Activity{

    public void doState(Human context) {
        System.out.println("Прыжок");
        context.setActivity(new Run());
    }
}
class Run implements Activity{
    public void doState(Human context) {
        System.out.println("Бегу");
        context.setActivity(new Jamp());
    }
}