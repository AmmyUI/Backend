namespace Ammy.BackendCommon
{
    public class CompilationRequest
    {
        public string ProjectDir { get; set; }
        public string[] ReferenceAssemblyPaths { get; set; }
        public Source[] Sources { get; set; }
        public bool NeedTypeReloading { get; set; }
    }
}