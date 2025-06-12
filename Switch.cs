namespace PrincipioDIP
{
    public class Switch
    {
        private readonly IDevice device;

        public Switch(IDevice device)
        {
            this.device = device;
        }

        public void Press()
        {
            device.Operate();
        }
    }
}