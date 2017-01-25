namespace Ammy.BackendCommon
{
    public class CompilationResult
    {
        public string ProjectName { get; }
        public bool IsSuccess { get; }
        public CompilerMessage[] CompilerMessages { get; }
        public AmmyFile[] Files { get; }

        public CompilationResult(string projectName, bool isSuccess, CompilerMessage[] compilerMessages, AmmyFile[] files)
        {
            ProjectName = projectName;
            IsSuccess = isSuccess;
            CompilerMessages = compilerMessages;
            Files = files;
        }
    }
}