namespace Ammy.BackendCommon
{
    public class CompilationRequest
    {
        public string ProjectDir { get; }
        public string[] ReferenceAssemblyPaths { get; }
        public Source[] Sources { get; }
        public bool NeedTypeReloading { get; }

        public CompilationRequest(Source[] sources, bool needTypeReloading = false, string projectDir = "", string[] referenceAssemblyPaths = null)
        {
            NeedTypeReloading = needTypeReloading;
            ProjectDir = projectDir;
            ReferenceAssemblyPaths = referenceAssemblyPaths ?? new string[0];
            Sources = sources;
        }
    }
}