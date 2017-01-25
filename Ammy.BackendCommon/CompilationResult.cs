namespace Ammy.BackendCommon
{
    public class CompilationResult
    {
        string ProjectName { get; }
        bool IsSuccess { get; }
        CompilerMessage[] CompilerMessages { get; }
        AmmyFile[] Files { get; }

        public CompilationResult(string projectName, bool isSuccess, CompilerMessage[] compilerMessages, AmmyFile[] files)
        {
            ProjectName = projectName;
            IsSuccess = isSuccess;
            CompilerMessages = compilerMessages;
            Files = files;
        }
    }
}