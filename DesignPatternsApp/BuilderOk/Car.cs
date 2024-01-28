using BuilderOk.Options;

namespace BuilderOk
{
    public class Car
    {
        public string Model { get; set; }
        public List<Option> Options { get; set; }

        public void AddOption(Option option)
        {
            Options.Add(option);
        }

        public void ToString(Option option)
        {
            Console.WriteLine($"Name : {Model} - Options : {string.Join(", ", Options.Select(o => o.Name))}");
        }
    }
}
