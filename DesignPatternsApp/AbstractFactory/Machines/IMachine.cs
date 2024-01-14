namespace AbstractFactory.Machines
{
    public interface IMachine
    {
        void Start();
        string ProduceItems(int count);
        void Stop();
    }
}
