package com.Louco;

interface State {
    void Play();
}

class FMNashe implements State{
    public void Play() {
        System.out.println("Наше радио");
    }
}

class FMMaximum implements State{
    public void Play() {
        System.out.println("Максимум FM");
    }
}

class FMVolna implements State {
    public void Play() {
        System.out.println("Волна FM");
    }
}

class Radio{
    private State radio;
    public void setRadio(State radio){this.radio = radio;}

    public void NextWave(){
        if(radio instanceof FMNashe){
            setRadio(new FMMaximum());
        }else if(radio instanceof FMMaximum){
            setRadio(new FMVolna());
        }else if(radio instanceof FMVolna){
            setRadio(new FMNashe());
        }
    }

    public void Play(){
        radio.Play();
    }

}