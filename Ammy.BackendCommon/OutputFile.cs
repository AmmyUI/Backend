namespace Ammy.BackendCommon
{
    public class OutputFile
    {
        public string Filename { get; }
        public string Xaml { get; }

        public OutputFile(string filename, string xaml)
        {
            Filename = filename;
            Xaml = xaml;
        }
    }
}