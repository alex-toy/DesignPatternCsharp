using BuilderOk.Options;

namespace BuilderOk
{
    public class Car
    {
        public string Model { get; set; }
        public List<Option> Options { get; set; } = new List<Option>();

        public void AddOption(Option option)
        {
            Options.Add(option);
        }

        public string ToString()
        {
            return $"Name : {Model} - Price : {string.Join(", ", Options.Select(o => o.Price).Sum())} - Options : {string.Join(", ", Options.Select(o => o.Name))}";
        }
    }
}
