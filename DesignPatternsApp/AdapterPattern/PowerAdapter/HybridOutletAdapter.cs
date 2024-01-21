namespace AdapterPattern.PowerAdapter
{
    public class HybridOutletAdapter : IOutlet
    {
        public HybridOutlet HybridOutlet { get; set; }

        public int GetAvailableFemaleConnectorCount()
        {
            return HybridOutlet.MaleConnectorCount / 2;
        }

        public int GetFemaleConnectorSize()
        {
            return HybridOutlet.Size + HybridOutlet.FemaleConnectorCount;
        }
    }
}
