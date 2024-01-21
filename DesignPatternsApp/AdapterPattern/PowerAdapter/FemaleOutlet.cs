namespace AdapterPattern.PowerAdapter
{
    public class FemaleOutlet
    {
        public int FemaleConnectorCount { get; set; }
        public int Size { get; set; }
        public IOutlet Outlet { get; set; }

        public bool Fit()
        {
            return Outlet.GetAvailableFemaleConnectorCount() == FemaleConnectorCount && Size == Outlet.GetFemaleConnectorSize();
        }
    }
}
