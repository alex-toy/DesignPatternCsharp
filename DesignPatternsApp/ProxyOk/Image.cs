namespace ProxyOk
{
    public class Image : IImage
    {
        public readonly string fileName;
        private byte[] data;

        public Image(string fileName)
        {
            this.fileName = fileName;
            Thread.Sleep(1000);
        }

        public void DisplayImage()
        {
            Console.WriteLine($"Affichage de l'image");
        }
    }
}
