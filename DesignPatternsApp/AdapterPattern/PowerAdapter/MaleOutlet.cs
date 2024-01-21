namespace AdapterPattern.PowerAdapter
{
    public class MaleOutlet : IOutlet
    {
        public int MaleConnectorCount { get; set; }
        public List<int> Sizes { get; set; }

        public int GetAvailableFemaleConnectorCount()
        {
            return MaleConnectorCount / 2;
        }

        public int GetFemaleConnectorSize()
        {
            int sum = 0;
            foreach (int size in Sizes)
            {
                if (size % 2 == 0) sum += size;
            }

            return sum;
        }
    }
}