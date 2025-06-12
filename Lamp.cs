using System;

namespace PrincipioDIP
{
    public class Lamp : IDevice
    {
        private State State;

        public Lamp(State initialState)
        {
            State = initialState;
        }

        public void Operate()
        {
            State = State == State.On ? State.Off : State.On;
            Console.WriteLine("Luz " + (State == State.On ? "Ligada" : "Desligada"));
        }
    }
}