namespace Ammy.BackendCommon
{
    public class AmmyFile
    {
        string Filename { get; }
        string Xaml { get; }

        public AmmyFile(string filename, string xaml)
        {
            Filename = filename;
            Xaml = xaml;
        }
    }
}