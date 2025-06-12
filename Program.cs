using System;

namespace PrincipioDIP
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice lamp = new Lamp(State.Off);
            Switch interruptor = new Switch(lamp);

            interruptor.Press(); // Luz Ligada
            interruptor.Press(); // Luz Desligada

            Console.ReadLine();
        }
    }
}