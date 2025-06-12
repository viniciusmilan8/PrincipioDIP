// Exemplo - DIP(Legado)

enum State { On, Off }

class Lamp
{
    State State;

    public Lamp(State State)
    {
        this.State = State;
    }

    public void Operate()
    {
        State = State == State.On ? State.Off : State.On;
        Console.WriteLine("Luz " + (State == State.On ? "Ligada" : "Desligada"));
    }
}

class Switch
{
    private Lamp lamp;

    public Switch(Lamp device)
    {
        this.lamp = device;
    }

    public void Press()
    {
        lamp.Operate();
    }
}