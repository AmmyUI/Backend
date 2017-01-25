namespace Ammy.BackendCommon
{
    public class AmmyFile
    {
        public string Filename { get; }
        public string Xaml { get; }

        public AmmyFile(string filename, string xaml)
        {
            Filename = filename;
            Xaml = xaml;
        }
    }
}